$(document).ready(function() {
	$("#movie-list > img").on("click", function(){
		var $img = $(this).clone();
		$img.on("click", function(){
			$(this).hide();
		});
		$("#favorites-container").append($img);
	});
});