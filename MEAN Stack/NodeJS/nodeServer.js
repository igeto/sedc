let http = require('http');
let firstModule = require('./firstModule');
let fs = require('fs');


let getFile = (req, res, fileName) => {
    fs.readFile(fileName, (err, data) => {
        if (err) {
            console.log(err);
            res.writeHead(404);
            res.end('Not Found');
            return false;
        }
        res.write(data);
        res.end();
    });
}




http.createServer((req, res) => {
    console.log(req.url);
    res.writeHead(200, {'Content-Type': 'text/html'});
    if (req.url.match('test')) {
        getFile(req, res, 'index.html');
    }
    else if (req.url.match('demo')) {
        res.end('This is demo endpoint');
    }
    else if (req.url.match('function')) {
        res.end(firstModule.randomMethod());
    }
    else if (req.url.match('')) {
        res.end("Hello World!");
    }

    // res.end("Hello World!");
    firstModule.randomMethod();

    console.log("1", "server up");
}).listen(8080);

console.log("2", "server up");