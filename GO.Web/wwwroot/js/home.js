var home = {} || home;

home.showPost = function () {
    $.ajax({
        url: 'https://localhost:44345/api/post/gets',
        method: 'GET',
        contentType: 'JSON',
        success: function (data) {
            $.each(data, function (i, v) {
                $('#post').append(`
                    <div class="blog-thumb">
                        <img src="${v.image}" alt="">
                    </div>
                    <div class="blog-text text-box text-white">
                        <div class="top-meta">11.11.18  /  in <a href="">Games</a></div>
                        <h3>${v.title}</h3>
                        <p>${v.description}</p>
                        <a href="#" class="read-more">Read More  <img src="~/img/icons/double-arrow.png" alt="#" /></a>
                    </div>
                `);
            })

        }
    });
}


home.initCategory = function () {
    $.ajax({
        url: 'https://localhost:44398/api/category/gets',
        method: 'GET',
        contentType: 'JSON',
        success: function (data) {
            $.each(data, function (i, v) {
                $('#cat').append(`<option value="${v.categoryId}">${v.categoryName}</option>`);
            })

        }
    });
}

home.tbCategory = function () {
    $.ajax({
        url: 'https://localhost:44398/api/category/gets',
        method: 'GET',
        contentType: 'JSON',
        success: function (data) {
            $.each(data, function (i, v) {
                $('#tbCat>tbody').append(`<tr>
                                            <td>${v.categoryId}</td>
                                            <td>${v.categoryName}</td>
                                            <td></td>
                                        </tr>`);
            })

        }
    });
}

home.initNav = function () {
    $.ajax({
        url: 'https://localhost:44398/api/category/gets',
        method: 'GET',
        contentType: 'JSON',
        success: function (data) {
            $.each(data, function (i, v) {
                $('#subNav ul').append(`<li class="nav-item">
                                            <a class="nav-link" href="#">${v.categoryName}</a>
                                        </li>`);
            })

        }
    });
}

home.init = function () {
    home.showCategory();
    home.initCategory();
    home.tbCategory();
    home.initNav();
}

$(document).ready(function () {
    home.init();
});