$(document).ready(function () {
    $('#sideBar').on('mouseenter', function () {
        $(this).animate({ 'left': '0px' }, 'fast');
    });
    $('#sideBar').on('mouseleave', function () {
        $(this).animate({ 'left': '-100px' }, 'fast');
    });
});
