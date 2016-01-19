using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StebraDesign2016MVC.Models;
using Microsoft.Azure;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Table;

namespace StebraDesign2016MVC
{
    public class AzureManager
    {
        //Config
        private const string tableName = "stebraNyhetslist";
        private const string partitionKey = "Nyhet";

        //Connection to Azure Storage
        private static CloudStorageAccount StorageAccount = CloudStorageAccount.Parse(
                CloudConfigurationManager.GetSetting("StorageConnectionString"));

        //get Table -client  
        public static CloudTableClient tableClient = StorageAccount.CreateCloudTableClient();

        public static List<StebraEntity> LoadNews()
        {

            CloudTable table = SelectValidTable();

            //Query all entities where "PartitionKey" is "News"
            var allNewsQuery = new TableQuery<StebraEntity>()
                .Where(TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.Equal, partitionKey));//partitionKey is "Nyhet"

            //Entities to List
            var news = table.ExecuteQuery(allNewsQuery).ToList();

            if (LinkManager.globalNews == null)
            {
                LinkManager.globalNews = news;

            }

            //Return List
            return news;


        }


        public static CloudTable SelectValidTable()
        {
            CloudTable tempTable = null;

            for (int id = 0; id < 10; id++)
            {
                tempTable = tableClient.GetTableReference(tableName + id.ToString());
                if (tempTable.Exists()) break;
            }
            //check this tables

            return tempTable;
        }
    }

}