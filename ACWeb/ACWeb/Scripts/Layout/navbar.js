//$(document).scroll(function () {
//    var documentScrollTop = $(document).scrollTop();
//    if (documentScrollTop > $('#header').height()) {
//        $('#navbar').addClass('fixedattop');
//        var shiftContent = $('#navbar').height();
//        $('#content').css('margin-top', shiftContent + 'px');
//    }
//    else if ($('#navbar').hasClass('fixedattop')) {
//        $('#navbar').removeClass('fixedattop');
//        $('#content').css('margin-top', '0px');
//    }
//});
(function ($) {
    "use strict";

    var $navbar = $("#navbar"),
        y_pos = $navbar.offset().top,
        height = $navbar.height();

    $(document).scroll(function () {
        var scrollTop = $(this).scrollTop();

        if (scrollTop > y_pos + height) {
            $navbar.addClass("navbar-fixed").animate({
                top: 0
            });
        } else if (scrollTop <= y_pos) {
            $navbar.removeClass("navbar-fixed").clearQueue().animate({
                top: "-48px"
            }, 0);
        }
    });

})(jQuery, undefined);