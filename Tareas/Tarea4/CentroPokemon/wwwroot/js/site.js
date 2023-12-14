// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$(document).ready(function () {
    $("#random_team_button").click(function () {
        $("#random_team_battlel").toggleClass("d-none");
    });
    $("#my_team_button").click(function () {
        $("#my_team_battlel").toggleClass("d-none");
    });
});


