$(document).ready(function() {
	function retrieveCityData(url) {
		$.ajax ({
			url: url,
			method: "GET",
			success: function(data) {
				alert(data.geonames[0].name);
				},
			fail: function(error) {
				alert(error.status.message);
			}
		});



		// $.getJSON(url, function(data) {
		// 	//great success!!
		// 	alert(data.status.message);
		// }, function(error) {
		// 	// uh oh...
		// 	alert(error.status.message);
		// });
	}
	retrieveCityData("http://api.geonames.org/citiesJSON?north=44.1&south=-9.9&east=-22.4&west=55.2&lang=en&username=igeto");
});