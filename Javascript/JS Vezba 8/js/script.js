$(document).ready(function() {
	function retrieveCityName(url) {
		$.ajax({
			url: url,
			method: "GET",
			success: function(data) {
				var string = "";
				
				for (var i = 0; i < data.geonames.length; i++) {
					var link = "https://";
					link += data.geonames[i].wikipedia
					string = "<a href=" + link + ">" + data.geonames[i].name  + "</a>";  
					$("#display").append(string + "<br />");

				}

			
			},
			fail: function(error) {
				alert("Sorry no data found");
			}
		});
	}
	retrieveCityName("data.json");
});