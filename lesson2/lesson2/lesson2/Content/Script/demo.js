$(document).ready(function () {

    $.ajax({
        type: "post",
        url: "service/DataHandler.ashx",
        data: {},
        success: function (result) {
            //var json = JSON.parse(data);
            alert(result);
        }
    });
});