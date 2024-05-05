$(document).ready(function () {
    SliderPosition();
    $("#PowerStoreCarousel .carousel-indicators:first, #PowerStoreCarousel .carousel-inner .carousel-item:first").addClass("active");
    $("#PowerStoreCarousel .carousel-indicators li").each(function () {
        var car_ind = $(this).index();
        $(this).attr("data-slide-to", car_ind);
    });
});
$(window).resize(function () {
    SliderPosition();
});
$("#next").click(function () {
    $('#PowerStoreCarousel').carousel('next');
});

$("#prev").click(function () {
    $('#PowerStoreCarousel').carousel('prev');
});

$(".carousel").on("touchstart", function (event) {
    var xClick = event.originalEvent.touches[0].pageX;
    $(this).one("touchmove", function (event) {
        var xMove = event.originalEvent.touches[0].pageX;
        if (Math.floor(xClick - xMove) > 5) {
            $(".carousel").carousel('next');
        }
        else if (Math.floor(xClick - xMove) < -5) {
            $(".carousel").carousel('prev');
        }
    });
    $(".carousel").on("touchend", function () {
        $(this).off("touchmove");
    });
});

function SliderPosition() {
    var FixSliderPos = $('.custom-container').position().left + 'px';
    $('#PowerStoreCarousel').css('right', '-' + FixSliderPos);
}