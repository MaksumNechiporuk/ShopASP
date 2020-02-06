const indicator = document.querySelector('.nav-indicator');
const items = document.querySelectorAll('.nav-item');

function dxSimpleSlider(element = '#dx-slider', auto = false, pause) {

    var $this = $(element);

    var slidesCont = $this.children('.slides-container');
    var slides = slidesCont.children('.slide');

    var pager = $this.children('.pager');

    var arrowsCont = $this.children('.arrows');
    var prevSlide = arrowsCont.children('.prev');
    var nextSlide = arrowsCont.children('.next');

    var slidesCount = slides.length;

    var currentSlide = slides.first();
    var currentSlideIndex = 1;

    var autoPlay = null;

    slides.not(':first').css('display', 'none');
    currentSlide.addClass('active');

    function fadeNext() {
        currentSlide.removeClass('active').fadeOut(700);

        if (currentSlideIndex == slidesCount) {
            currentSlide = slides.first();
            currentSlide.delay(500).addClass('active').fadeIn(700);
            currentSlideIndex = 1;
        } else {
            currentSlideIndex++;
            currentSlide = currentSlide.next();
            currentSlide.delay(500).addClass('active').fadeIn(700);
        }
        pager.text(currentSlideIndex + ' / ' + slidesCount);
    }
    //function fadePrev() {
    //    currentSlide.removeClass('active').fadeOut(700);

    //    if (currentSlideIndex == 1) {
    //        currentSlide = slides.last();
    //        currentSlide.delay(500).addClass('active').fadeIn();
    //        currentSlideIndex = slidesCount;
    //    } else {
    //        currentSlideIndex--;
    //        currentSlide = currentSlide.prev();
    //        currentSlide.delay(500).addClass('active').fadeIn(700);
    //    }

    //    pager.text(currentSlideIndex + ' / ' + slidesCount);
    //}
    function AutoPlay() {
        clearInterval(autoPlay);

        if (auto == true)
            autoPlay = setInterval(function () { fadeNext() }, pause);
    }
    $(nextSlide).click(function (e) {
        e.preventDefault();
        fadeNext();
        AutoPlay();
    });
    $(prevSlide).click(function (e) {
        e.preventDefault();
        fadePrev();
        AutoPlay();
    });
    AutoPlay();
}

$(function () {
    dxSimpleSlider('#slider', true, 5000);
});

fillSelect();
function fillSelect() {

  

    let devices = [
        {
            Name: "Phone",
            value: "Phone"
        },
        {
            Name: "CPU",
            value: "CPU"
        },
        {
            Name: "GPU",
            value: "GPU"
        },
        {
            Name: "SSD",
            value: "SSD"
        },
        {
            Name: "RAM",
            value: "RAM"
        },
        {
            Name: "Mather board",
            value: "MB"
        }
    ];
    let select = document.querySelector(".select");
    
    devices.map(devices => {
        let item = document.createElement("a");
        $(item).addClass("dropdown-item");
        item.innerHTML = devices.Name;
        item.value = devices.value;
        item.setAttribute("href", `http://localhost:8080/${item.value}/List`) ;
        select.appendChild(item);
    });
    select.addEventListener("change", changeURL);
}
function changeURL()
{

}
$(document).on("scroll", function () {
    if ($(document).scrollTop() > 86) {
        $("#banner").addClass("shrink");
    } else {
        $("#banner").removeClass("shrink");
    }
});
$(".dropdown-toggle").on("click", function () {
    if ($(".dropdown-menu").hasClass("show")) {
        $(".dropdown-menu").removeClass("show");
    } else {
        $(".dropdown-menu").addClass("show");

    }
});
$(".dropdown-item").on("click", function () { 
    $(".dropdown-menu").removeClass("show");
    let dev = document.querySelector(".devices");
    console.log(dev);
});