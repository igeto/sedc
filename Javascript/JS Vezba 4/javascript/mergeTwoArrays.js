function mergeTwoArrays (array1, array2) {
	var mergedArray = array1.concat (array2);
	return mergedArray;
}

var arrayOfNumbers1 = [1, 2, 3, 4, 5];
var arrayOfNumbers2 = [6, 7, 8, 9, 0];


document.write (mergeTwoArrays(arrayOfNumbers1, arrayOfNumbers2));