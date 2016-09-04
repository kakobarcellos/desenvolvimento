
function setRadio(radio_id, value) {
    $("input[name=" + radio_id + "][value=" + value + "]").attr('checked', 'checked');
}