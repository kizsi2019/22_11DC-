// Kapcsolódás a szerverhez
const socket = io.connect('http://localhost:3000');

// Az üzenetek megjelenítése a chat-boxban
function appendMessage(msg) {
	const chatBox = document.getElementById('chat-box');
	const messageElement = document.createElement('div');
	messageElement.innerText = msg;
	chatBox.appendChild(messageElement);
}

// Az üzenet küldése a szervernek
function sendMessage() {
	const message = document.getElementById('chat-input').value;
	socket.emit('chat-message', message);
	document.getElementById('chat-input').value = '';
}

// A küldés gomb eseménykezelője
document.getElementById('chat-send').addEventListener('click', function() {
	sendMessage();
});

// Az Enter lenyomásának eseménykezelője a chat-input mezőben
document.getElementById('chat-input').addEventListener('keydown', function(event) {
	if (KeyBoardEvent.keyCode === 13) {
		sendMessage();
	}
});

// Az új üzenetek fogadása a szerverről
socket.on('chat-message', function(msg) {
	appendMessage(msg);
});
