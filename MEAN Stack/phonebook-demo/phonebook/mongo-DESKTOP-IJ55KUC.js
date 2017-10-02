let mongoClient = require('mongodb');
let url =  'mongodb://localhost:27017/dbcl';
let defer = require('deferred');

let globalDb;

mongoModule = {
    collectionCounter: 0,
    connection: () => {
        let def = defer();

        mongoClient.connect(url, (err, db) => {
            if (err) throw err;
            globalDb = db;
            def.resolve();
        });
        return def.promise();
    },
    createCollection: collectionNameArray => {
        mongoModule.connection().then(() => {
            if (collectionNameArray[mongoModule.collectionCounter]) {
                globalDb.createCollection(collectionNameArray[mongoModule.collectionCounter], (err, res) => {
                    if (err) throw err;
                    console.log('collection created', collectionNameArray[mongoModule.collectionCounter]);
                    globalDb.close();
                    mongoModule.collectionCounter++;
                    mongoModule.createCollection(collectionNameArray);
                });
            }
            else
                globalDb.close();
        });
    },
    insertData: (data, collectionName) => {
        let def = defer();
        mongoModule.connection().then(() => {
            globalDb.collection(collectionName).insertOne(data, (err, res) => {
                if (err) {
                    def.reject(err);
                }
                if(!err)
                console.log('one row inserted into ', collectionName, data);
                globalDb.close();

                def.resolve();
            });           
        });
        return def.promise;
    },
    deleteData: (data, collectionName) => {
        let def = defer();
        mongoModule.connection().then(() => {
            globalDb.collection(collectionName).remove({_id: new mongodb.ObjectID(data) }, (err, res) => {
                if (err) {
                    def.reject(err);
                }
                if(!err)
                console.log('one row deleted from ', collectionName, data);
                globalDb.close();

                def.resolve();
            });           
        });
        return def.promise;
    },
    loadData: (collectionName) => {
        let def = defer();
        mongoModule.connection().then(() => {
            globalDb.collection(collectionName).find({}).toArray((err, res) => {
                if (err) {
                    def.reject(err);
                }
                globalDb.close();

                def.resolve(res);
            });           
        });
        return def.promise;
    }
};

module.exports = mongoModule;