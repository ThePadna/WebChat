var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

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

function listenForMessage(usr) {
    let input = document.getElementById('input_box');
    input.onkeypress = function (ev) {
        if (ev.which === 13) {
            if(usr === null) {
                let li = document.createElement("li");
                li.textContent = "You must be logged in to send a chat message!";
                document.getElementById("messages").appendChild(li);
                return;
            }
            console.log(usr);
            connection.invoke("SendMessage", usr.textContent, input.value);
            input.value = '';
        }
    }
}
