function findBiggest(array) {
	var max = array[0];
	for (var i = 0; i < array.length; i++)
		if (max < array[i])
			max = array[i];
	return max;

}

var randomNumbers = [1, 5, 21, 14, 2, 5, 60, 92, 73, 23];

alert(findBiggest(randomNumbers));