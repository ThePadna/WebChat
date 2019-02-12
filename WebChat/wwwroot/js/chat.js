var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

connection.on("ReceiveMessage", function (user, message) {
    var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    var encodedMsg = user + " says " + msg;
    var li = document.createElement("li");
    li.textContent = encodedMsg;
    document.getElementById("messages").appendChild(li);
});

connection.start().then(function () {
    let input = document.getElementById('input_box');
    input.onkeypress = function (ev) {
        if (ev.which === 13) {
            connection.invoke("SendMessage", "rdmUser", input.value);
            input.value = '';
        }
    }
}).catch(function (err) {
    return console.error(err.toString());
    });
