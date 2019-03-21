var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();
var input = document.getElementById('input_box'), messages = document.getElementById("messages");

connection.on("ReceiveMessage", function (user, message) {
    var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    var encodedMsg = user + ": " + msg;
    var li = document.createElement("li");
    li.textContent = encodedMsg;
    document.getElementById("messages").appendChild(li);
});

connection.start().then(() => {
   
}).catch(function (err) {
    return console.error(err.toString());
    });

function listenForMessage(user) {
    input.onkeypress = function (ev) {
        if (ev.which === 13) {
            if(user === null) {
                let li = document.createElement("li");
                li.textContent = "You must be logged in to send a chat message!";
                messages.appendChild(li);
                return;
            }
            connection.invoke("SendMessage", user.textContent, input.value);
            input.value = '';
        }
    }
}

function fillChat(messageList) {
    for (var i = 0; i <= messages.length; i++) {
        let li = document.createElement("li");
        li.textContent = messages[i];
        messages.appendChild(li);
    }
}
