let fs = require('fs');

let appendFile = () => {
    fs.appendFile('./index2.txt', 'Data to be stored', (err) => {
        if (err) {
            console.log(err);
            return false;
        }
        console.log('Data stored in index2.txt');
        return true;
    });
}

// appendFile();

let openFile = () => {
    fs.open('./index4.txt', 'r', (err, data) => {
        if (err) {
            console.log('Error', err);
            return false;
        }
        console.log(data.toString());
        return true;
    })
}

// openFile();

let writeFile = () => {
    fs.writeFile('./index4.txt', 'Content to be overwritten', (err) => {
        if (err) {
            console.log('error: ', err);
            return true;
        }
        console.log('its working bitch');
        return true;
    });
}

writeFile();

let deleteFile = () => {
    fs.unlink('./index4.txt', err => {
        if (err) {
            console.log('error: ', err);
            return false;
        }
        console.log('file deleted');
        return true;
    });
}

// deleteFile();

let renameFile = () => {
    fs.rename('./index4.txt', './index3.txt', err => {
        if (err) {
            console.log('rename failed: ', err);
            return false;
        }
        console.log('rename successfull');
        return true;
    });
}

renameFile();