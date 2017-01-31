function removedElement (parent, theElement) {
	parent.removeChild (theElement);
}
function addElement (parent, theElement) {
	parent.appendChild (theElement);
}
function addElementAtPosition (parent, theElement, position) {
	parent.insertBefore (theElement, parent.children [position]);
}
function createElementByTagName (elementTagName) {
	var element = document.createElement (elementTagName)
}

var theDiv = document.getElementById ("myDiv");
var theParent = document.getElementsByTagName ("body")[0];

removedElement (theParent, theDiv);
// addElement (theParent, theDiv);

addElementAtPosition (theParent, theDiv, 0);
var newElement = ge

function calculate (event) {
	var firstNumber = parseInt(document.getElementById ("1stNumber").value);
	var secondNumber = parseInt(document.getElementById ("2ndNumber").value);

	var result = document.getElementById ("result");
	var sum = firstNumber + secondNumber;
	
	result.innerHTML = sum;
}

var button = document.getElementById ("button");

button.addEventListener ("click", calculate);