$(function () {
    $(document).on('click', 'a', function (e) {
        linkClick(e, $(this));
    });});

//Globally detecting anchor (link) clicks and calling custom function
function linkClick(e, link) {
    if (e.isDefaultPrevented()) {
        return;
    }
    var action = link.attr('href');
    // '/#' is breadcrumb - left menu navigation
    if (action == null || action[0] != '/' || action.startsWith('/#')) {
        return;
    }
    e.preventDefault();
    var image = "<img id='centeredImage' style='margin: calc(50vh - 30px)  auto 0 auto; height: 70px; width: 70px; display:block;' src='../Content/Images/quorum-loader.gif' />"
    $('#spa-content').html(image);


    spaLoad(action, "GET");
};

function spaLoad(action, type, data) {
    $.ajax({
        url: action,
        type: type,
        dataType: 'html',
        data: data
    }).done(function (response, status, xhr) {
        renderPage(xhr);
    });
}

function renderPage(xhr) {
    var location = xhr.getResponseHeader('Location');
    history.pushState('', '', location);

    $('#spa-content').html(xhr.responseText);

    // set page title
    var titleDiv = $('#title-div', '#spa-content');
    document.title = titleDiv.text();
}