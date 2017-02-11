let simplejs = document.getElementById('simplejs');
let reactjs = document.getElementById('reactjs');

function render(){

    simplejs.innerHTML = 
    `<div class='demo'> 
        Hello from JS 
        <input type='text'>
            <p> ${new Date().toString()}</p>
    </div>`;


    ReactDOM.render(
        React.createElement(
            'div', {className: 'demo'}, 'Hello form ReactJS',
            React.createElement(
                'input', {type: 'text'}
            ),
            React.createElement(
                'p', 
                null, //or {}
                new Date().toString()
            )
        ),
        reactjs
    );
}

setInterval(render, 1000);