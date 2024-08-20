$("a[avthref]").click(function (index) {
    var AvtHref = $(this).attr("avthref");
    window.frames["bodyFrame"].location = AvtHref;
});