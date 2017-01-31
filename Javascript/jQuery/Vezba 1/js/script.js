$(document).ready(function() {
	
	$(".inputField").on("focus", function(event) {
		$(this).css("outline-color", "orange");
	});
	$("#button").on("click", function(event) {
		var fields = $(".inputField");
		for (var i = 0; i < fields.length; i++) {
			if (fields[i].value === "") {
				$(fields[i]).css("border-color", "red");
				$(fields[i]).css("border-shadow", " none");
			}
			else
				$(fields[i]).css("border-color", "green");

		
		}
		
	});




		// var pTag = $("p");
		// var firstPTag = $("p:first");
		// pTag.addClass("red");
		// pTag.css("color", "green");
		// console.log(firstPTag);
		// // pTag.on("click", function(event) {
		// // 	$(this).hide(500, function() {
		// // 		$(this).show(700, function() {});
		// // 	});
		// // })
		// firstPTag.on("click", function(event) {
		// 	$(this).animate({height: "0px", opacity: 0}, 500, function(){});
		// })
		// $("p:not(:first)").on("click", function(event) {
		// 	firstPTag.animate({height: "16px", opacity: 1}, 500, function() {});
		// });
});