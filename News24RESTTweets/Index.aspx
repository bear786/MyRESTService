<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="News24RESTTweets.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>News24 Tweets</title>
    <link href="Content/Custom.css" rel="stylesheet" />

    <script src="Scripts/jquery-1.10.2.min.js"></script>
    <script src="Scripts/modernizr-2.6.2.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container"></div>
    </form>
</body>

<script>
    $(document).ready(function () {
        $.ajax(
            {
                dataType: 'json',
                headers: {
                    Accept: "application/json",
                    "Access-Control-Allow-Origin": "*"
                },
                type: 'GET',
                url: 'http://localhost:9480/News24RESTService.svc/GetTweets/',
                success: function (data) {
                    $.each(data, function (i, item) {
                        var htmlText = '';

                        htmlText += '<div class="item"><div class="head"><div class="name">';
                        htmlText += '<img src=' + item["Icon"] + ' />';
                        htmlText += '<span class="user">' + item["ScreenName"] + '</span>';
                        htmlText += '</div><div class="time">'+ item["RelativeTime"] +'</div></div><div class="tweet-wrapper">';
                        htmlText += '<span class="text">'+ item["Text"] +'</span></div></div>';

                        $(".container").append(htmlText);
                    });
                },
                error: function (data) {
                    alert("error");
                }
            });
    });
</script>

</html>
