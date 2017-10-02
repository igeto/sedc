let path = require('path');

let express = require('express');
let bodyParser = require('body-parser');

let mongo = require('./mongo.js');
let app = express();
let appRoot = path.resolve(__dirname);

app.use(bodyParser.urlencoded({ extended: false }));
app.use(express.static('public'));

app.get('/getList', (req, res) => {
    res.sendFile(appRoot + '/public/list.html');
});

app.get('/getNewForm', (req, res) => {
    res.sendFile(appRoot + '/public/form.html');
});

app.get('/getContactList', (req, res) => {
    mongo.loadData('contacts').then(result => {
        console.log(result);
        res.send(result);
    });
});

app.post('/postNewContact', (req, res) => {
    console.log(req.body)
    mongo.insertData(req.body, 'contacts').then(
        result => {
            res.send(result);
        },
        error => {
            res.status(412);
            res.send(error);
        }
    );
});

app.post('/deleteContact', (req, res) => {
    // console.log(req.body)
    mongo.deleteData(req.body, 'contacts').then(
        result => {
            res.send(result);
        },
        error => {
            res.status(412);
            res.send(error);
        }
    );
});

app.listen(3000, () => {
    // mongo.createCollection(['contacts', 'phones']);
    console.log('App running');
});

