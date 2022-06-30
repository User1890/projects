var n = 400;
var mess = "У вас новое уведомление"
$(document).ready(function () {
    $(".avatar").mouseover(function () {
        $(".progres").show(n);
        $(".menu").hide(n);
    });
    $(".avatar").mouseout(function () {
        $(".progres").hide(n);
        $(".menu").show(n);
    });
});

$(document).ready(function () {
  $('.avatar').click(function(){
    window.location="http://localhost/registration/login.php";
    });
});

$(document).ready(function () {
  $('.but').click(function(){
    $(".lineNotif").append('<div class="notification">'+mess+'<button class="close"></button></div>');
    });
});

$(document).on('click', '.close', function (evt) {
    $(this).parent().detach();
});

$(document).ready(function () {
  $('.timetableMenu').click(function(){
    $(".timetable").show(n);
    $(".chat").hide(n);
    $('.timetableMenu').css('opacity' , '1');
    $('.chatMenu').css('opacity' , '0.8');
    });
});

$(document).ready(function () {
  $('.chatMenu').click(function(){
    $(".timetable").hide(n);
    $(".chat").show(n);
    $('.timetableMenu').css('opacity' , '0.8');
    $('.chatMenu').css('opacity' , '1');
    });
});
