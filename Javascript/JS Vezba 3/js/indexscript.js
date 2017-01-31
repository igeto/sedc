function willLevelUp(currentExp, neededExp, winExp) {
	return currentExp + winExp >= neededExp;
}

function alertUser(shouldAlert, message) {
	if (shouldAlert) {
		alert(message);
		return true;
	} else
		return false;
}

 // var hasSucceeded = alertUser(willLevelUp(125, 160, 40), "You have leveled up!");
 // alert(hasSucceeded);

 if(!alertUser(willLevelUp(125, 260, 40), "You have leveled up!")) {
 	alertUser(!willLevelUp(125, 260, 40), "You have not leveled up!");
 } else
 	alertUser(willLevelUp(125, 260, 40), "You have leveled up!");