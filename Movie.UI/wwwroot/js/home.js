var searchKey = [];
var model1 = {
    Search: $("#search").val(),
    CurrentPage: 0,
    PageSize: 0
}

BindData(model1);
FillSerch();

function BindData(model1) {
    $.ajax({
        type: "post",
        url: '/Movie/GetMovie',
        data: {
            model: model1
        },
        success: function (result) {
            debugger;
            if (result.data.list != null) {
                $("#movie-fluid").html("");
                $(result.data.list).each(function (index, item) {
                    $("#movie-fluid")
                        .append($("<a>").attr("href", "/Movie/Detail/" + item.id)
                            .append($("<div>").addClass("movie-content")
                        //.append($("<div>").addClass("movie-score").text(item.score))
                        .append(($("<img>").addClass("movie-content-img").attr("src", item.imageUrl)))
                        .append($("<div>").addClass("movie-title").text(item.name))));
                });

                drawPagination(result.data.rowCount, result.data.currentPage);
            }

        }
    });

}

function FillSerch() {
    var search = JSON.parse(localStorage.getItem("arr"));

    search.forEach((ele, index) => {
        $("#searchs").prepend($("<option>").attr("value", search[index]));
    });

}


$('#search, #search-btn').on('keyup', function (event) {
    var searchTxt = $("#search").val();
    searchKey.push(searchTxt);
    localStorage.setItem("arr", JSON.stringify(searchKey));
    
    var itemCount = $("#searchs option").length;
    if (itemCount >= 5) {
        searchKey.shift();
        $("#searchs option:last").remove();
    }

    $("#searchs").prepend($("<option>").attr("value", searchTxt));//listenin ilk optionuna ekliyor

    model1.Search = $("#search").val();
    BindData(model1);
});

$('.pagination').on('click', 'li', function (event) {
    var item = $(event.currentTarget).attr("pag-item");
    model1.CurrentPage = item;
    BindData(model1);
});

$('.pagination').on('click', 'li:not(.prev):not(.next)', function () {
    $('.pagination li').removeClass('active');
    $(this).not('.prev,.next').addClass('active');
});

$('.pagination').on('click', 'li.prev', function () {
    $('li.active').removeClass('active').prev().addClass('active');
});

$('.pagination').on('click', 'li.next', function () {
    $('li.active').removeClass('active').next().addClass('active');
});

function drawPagination(numOfPages, current) {
    $('#pag_nav ul').empty();
    $('#pag_nav ul').append('<li pag-item="0" class=prev><a href=# aria-label=Previous><span aria-hidden=true>&laquo;</span></a></li>');
    for (var i = 1; i <= numOfPages; i++) {
        if (current == i || (current == 0 & 0 == (i - 1))) {
            $('#pag_nav ul').append('<li class="active" pag-item="' + i + '"><a>' + i + '</a></li>');
        } else {
            $('#pag_nav ul').append('<li pag-item="' + i + '"><a>' + i + '</a></li>');

        }
    }
    $('#pag_nav ul').append('<li class=next pag-item="' + (i + 1) + '"><a href=# aria-label=Previous><span aria-hidden=true>&raquo;</span></a></li>');

    pagination = false;

}