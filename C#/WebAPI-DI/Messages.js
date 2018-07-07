var uri = 'api/Messages';

$(document).ready(function () {
    // Send an AJAX request
    $.getJSON(uri)
        .done(function (data) {
            // On success, 'data' contains a list of Messages.
            $.each(data, function (key, item) {
                // Add a list item for the Message.
                $('<li>', { text: formatItem(item) }).appendTo($('#Messages'));
            });
        });
});

function formatItem(item) {
    return item.Name;
}
