import React from 'react';
import ReactDOM from 'react-dom';
// import App from './App';
import './index.css';

/*
let element = <div className="demo"> JSX syntax </div>;

//stateless component
let Input = function(props){
  return(
    <p>
      <label htmlFor={props.id}>{props.label}</label>
      <input type={props.type} id={props.id}/>
    </p>
   
  );
}

// let NameInput = function(){
//   return(
//     <p>
//       <label htmlFor='firstName'>First Name</label>
//       <input type='text' id='firstName'/>

//       <label htmlFor='lastName'>Last Name</label>
//       <input type='text' id='lasttName'/>
//     </p>
//   );
// }

ReactDOM.render(
  /*<div>
    <EmailInput/>
    <EmailInput/>
  </div>,*/

  /*<div>
    <NameInput/>
    <EmailInput/>
  </div>,

  <div>
    <Input label="First Name" type="text" id="firstName"/>
    <Input label="Last Name" type="text" id="lastName"/>
    <Input label="Email" type="email" id="email"/>
  </div>,
  document.getElementById('root')
);
*/

//// stateful component
// class Timer extends React.Component {
//   render() {
//     return (
//       <div onClick={this.props.handdleClickFunction} className="timer">{this.props.startValue}</div>
//     );
//   }
// }

// class App extends React.Component{
//   constructor(props){
//     super(props);
//     this.state = {startValue: props.startValue}
//     setInterval(() => {
//         this.setState({startValue: this.state.startValue - 1}); 
//      }, 1000);
//   }
//   handleClick = (e) => {
//     this.setState({startValue: this.props.startValue});
//   }
//   render(){
//     return(
//       <div>
//         <Timer handdleClickFunction={this.handleClick} startValue={this.state.startValue} />
//         <button onClick={this.handleClick}>Restart Timer</button>      
//       </div>
//     )
//   }
// }

// ReactDOM.render(
//   <App startValue="2040"/>,
//   document.getElementById('root')
// );

let books = [
  {
    title: "Book1",
    author: "Author1"
  },
  {
    title: "Book2",
    author: "Author2"
  },
  {
    title: "Book3",
    author: "Author3"
  },
  {
    title: "Book4",
    author: "Author4"
  },
  {
    title: "Book5",
    author: "Author5"
  }
];

class Book extends React.Component{   
  render(){
    return(
      <li>{this.props.title} -- {this.props.author}</li>
    );
  }
}

class BookList extends React.Component{
  constructor(props){
    super(props);
    this.state = {books: this.props.books}
  }
  render(){
    return(
      <ul>
      {this.state.books.map((book, i)=>{
        return <Book key={i} title={book.title} author={book.author} />
      })}
      </ul>
    );
  }
}

ReactDOM.render(
   <BookList books={books} />,
   document.getElementById('root')
);