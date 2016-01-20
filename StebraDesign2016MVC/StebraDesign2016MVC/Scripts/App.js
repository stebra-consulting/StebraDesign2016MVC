'use strict';


//  TEMPORÄR LÖSNING FÖR ATT FÖRMINSKA ALLA IMG TAGGAR I item.Body  //
$(document).ready(
    function () {
        $('img').each(
            function () {
                $(this).addClass('thumbnail img-responsive');
            }
        );
    }
);