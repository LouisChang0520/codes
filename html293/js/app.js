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