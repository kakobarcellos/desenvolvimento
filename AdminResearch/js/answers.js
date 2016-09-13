
$(function () {
    initButtons();
})




function initButtons() {


    $("#btn_save").click(function () {
        $.ajax({
            url: "handlers/AnswerHandler.ashx?action=insert",
            type: "POST",
            data: {
                "answers": $('form').serialize()
            },
            success: function (data) {
                $("form_answers").serialize()
            }
        });
    });
}