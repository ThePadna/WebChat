var _connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();
var $_input = $('#input_box'), $_messages = $('#messages');

_connection.on("ReceiveMessage", function (user, message) {
    let msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;"), encodedMsg = user + ": " + msg, li = $('<li></li>');
    li.text(encodedMsg);
    $_messages.append(li);
});

_connection.start().then(() => {
}).catch(function (err) {
    return console.error(err.toString());
});

function listenForMessage(user) {
    $_input.keypress(function (ev) {
        if (ev.which === 13) {
            if (user === null) {
                let li = $('<li></li>');
                li.text("You must be logged in to send a chat message!");
                $_messages.append(li);
                scrollBottom();
                return;
            }
            _connection.invoke("SendMessage", user.textContent, $_input.val());
            scrollBottom();
        }
    });
}

function scrollBottom() {
    let $chatBox = $('#chat_box');
    $chatBox.scrollTop($chatBox[0].scrollHeight)
}
