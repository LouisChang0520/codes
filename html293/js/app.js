// 網頁載入完成的時候
$(function () {
    // 要做的事 寫在這
    function sayHello(event) {
        // 事件 的 目標 的 id
        var id = event.target.id;
        alert("Hello World" + id);
    }
    $("#btn01").click(sayHello);
    $("title").click(sayHello);
});


$(function () {
            function displayBar(event) {
                $("#scrollbar").slideDown();
            }
            $("#scrollbar").scroll(displayBar);


        };

        $(function () {
            $("#uptop").click(function () {
                jQuery("html,body").animate({
                    scrollTop: 0
                }, 1000);
            });
            $(window).scroll(function () {
                if ($(this).scrollTop() > 300) {
                    $('#uptop').fadeIn("fast");
                } else {
                    $('#uptop').stop().fadeOut("fast");
                }
            });
        });