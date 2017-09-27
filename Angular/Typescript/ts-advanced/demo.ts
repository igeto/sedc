export class Demo {}

let delay = (timeout:number = 1000) => {
    return new Promise((resolve, reject) => {
        setTimeout(function() {
            timeout < 2000 ?
            resolve() : 
            reject();
        }, timeout);
    });
}

delay(1000).then(() => {
    console.log("worked");
}).catch(() => {
    console.log("didnt work");
});