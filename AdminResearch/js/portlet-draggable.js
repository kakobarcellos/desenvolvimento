
$(function () {
    initButtons();
    initCounters();
});


function initButtons() {
    
    $("#save-card").click(function (event) {
        event.preventDefault();
        $.ajax({
            type: "POST",
            url: "handlers/CardHandler.ashx?action=insert",
            data: {
                "description": $("#card-description").val()
            },
            success: function (data) {
                $("#card-modal").close();
            }
        });
    });

    $("#open-card-modal").click(function () {
        $("#card-modal").modal();
    });
}


function initCounters() {
    var backlogCounter = $("#backlogTotal").val();
    var makeCounter = $("#makeTotal").val();
    var finishedCounter = $("#finishedTotal").val();
    var archivedCounter = $("#archivedTotal").val();
}