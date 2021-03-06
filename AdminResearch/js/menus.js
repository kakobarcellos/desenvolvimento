﻿
var table;

$(function () {
    initButtons();
    initGrids();
    initSelects();
});

function initSelects() {
    $.ajax({
        url: "handlers/MenuHandler.ashx?action=menuSelect",
        type: "POST",
        success: function (data) {
            $("#father_menu").html(data);
        }
    })
}

function initButtons() {
    $("#btn_save").click(function () {
        alert("oi");
        $.ajax({
            type: "POST",
            url: "handlers/QuestionHandler.ashx?action=insert",
            data: {
                "description": $("#description").val(),
                "type": $('input[name=type]:checked').val(),
                "status": $('input[name=status]:checked').val()
            },
            success: function (data) {

            }
        });
    });

    $("#btn_update").click(function () {
        $.ajax({
            type: "POST",
            url: "handlers/QuestionHandler.ashx?action=update",
            data: {
                "question_id": $("#question_id").val(),
                "description": $("#description").val(),
                "type": $('input[name=type]:checked').val(),
                "status": $('input[name=status]:checked').val()
            },
            success: function (data) {

            }
        });
    });

    $("#btn_delete").click(function () {
        $.ajax({
            type: "POST",
            url: "handlers/QuestionHandler.ashx?action=delete",
            data: {
                "question_id": $("#question_id").val(),
            },
            success: function (data) {

            }
        });
    });
}


function initGrids() {
    $('#menus-grid').DataTable({
        "ajax": "handlers/QuestionHandler.ashx?action=getQuestions",
        "processing": true,
        "serverSide": true,
        "oLanguage": {
            "oAria": {
                "sSortAscending": ": ativar para classificar coluna ascendente",
                "sSortDescending": ": ativar para classificar coluna descendente"
            },
            "oPaginate": {
                "sFirst": "Primeira",
                "sLast": "Última",
                "sNext": "Próxima",
                "sPrevious": "Anterior"
            },
            "sInfo": "Mostrando _START_ a _END_ de _TOTAL_ registros",
            "sInfoEmpty": "Mostrando 0 de 0 of 0 registros",
            "sInfoFiltered": "(filtrada a partir de _MAX_ entradas totais)",
            "sLengthMenu": 'Mostrar <select>' +
                    '<option value="10">10</option>' +
                    '<option value="20">20</option>' +
                     '<option value="30">30</option>' +
                     '<option value="40">40</option>' +
                     '<option value="50">50</option>' +
                     '<option value="-1">Todos</option>' +
                     '</select> registros',
            "sLoadingRecords": "Carregando...",
            "sProcessing": "Processando",
            "sSearch": "Buscar:",
            "sZeroRecords": "Não há registros correspondentes encontrado"
        }
    });

    $("#menus-grid tbody").on("click", "tr", function (event) {
        question_id = $(this).find("td:first").text();
        showRecord(question_id);
        edit();
    });
}


function showRecord(question_id) {
    $.ajax({
        type: "POST",
        url: "handlers/QuestionHandler.ashx?action=setQuestion",
        dataType: "json",
        data: {
            "question_id": question_id
        },
        success: function (data) {
            $("#question_id").val(data.question_id),
            $("#description").val(data.description),
            setRadio("status", data.status);
            setRadio("type", data.type);
        },
        error: function () {

        },
    });
}


function edit() {
    $("btn_save").hide();
    $("btn_edit").show();
    $("btn_delete").show();
}


function save() {
    $("btn_save").show();
    $("btn_edit").hide();
    $("btn_delete").hide();
}