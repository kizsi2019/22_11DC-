//  server.js
const http = require("http");
const port = 3000;

const server = http.createServer();
server.on("request", (request, response) => {
    request.writeHead(200, { "Content-Type": "text/plain; charset=utf-8" });
    response.write("Válasz a szervertől");
    response.end();
});

server.listen(port);