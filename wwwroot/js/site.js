﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$(document).ready(function () {
    $('#table-funcionario').DataTable();
    $('#table-empresa').DataTable();
    $('#table-usuarios').DataTable();



    setTimeout(function () {
        $(".alert").fadeOut("slow", function ()
        {
            $(this).alert('close');
            
        }, 3000)
    })
});