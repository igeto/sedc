let forExport = {
    randomMethod: () => {
        console.log('Random method has been called.');
        return "Random method";
    },
    secondMethod: () => {
        return forExport.randomMethod();
    }
};

module.exports = forExport;