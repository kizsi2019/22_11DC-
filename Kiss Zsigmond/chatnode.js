// Szerver oldali Node.js alkalmazás
const express = require('express');
const app = express();

// A szerver indítása a 3000-es porton
const server = app.listen(3000, function() {
    console.log('A szerver elindult a 3000-es porton!');
});

// Socket.IO inicializálása a szerver oldalon
const io = require('socket.io')(server);

// Az új kapcsolatok kezelése
io.on('connection', function(socket) {
    console.log('Új kapcsolat felépítve!');

    // Az új üzenetek fogadása a kliensektől
    socket.on('chat-message', function(msg) {
        console.log('Üzenet érkezett: ' + msg);

        // Az üzenet továbbítása a többi kliensnek
        io.emit('chat-message', msg);
    });
});
