
var hotels = [];
var foundHotels = [];

function Hotel(name, availableRooms, roomPrice) {
	this.name = name;
	this.availableRooms = availableRooms;
	this.roomPrice = roomPrice;
}
function addNewHotel() {
	var theHotel = new Hotel(document.getElementById("hotelName").value, parseInt(document.getElementById("availableRooms").value), parseInt(document.getElementById("price").value));
	hotels.push(theHotel);
	var addedHotel = document.getElementsByName("inputField");
	for (var i = 0; i < addedHotel.length; i++) {
		addedHotel[i].value = "";
	}
} document.getElementById("submit").addEventListener("click", addNewHotel);

function searchForHotel(hotelName, neededRooms, priceRange, days) {
	for (var i = 0; i < hotels.length; i++) {
		if ((hotelName === "" || hotelName === hotels[i].name) && (neededRooms === null || neededRooms <= hotels[i].availableRooms) && (priceRange === null || priceRange <= hotels[i].roomPrice))
			foundHotels.push(hotels[i]);
	}
	var result = document.querySelector("tr");
	for	(var i = 0; i < foundHotels.length; i++) {
		result.innerHTML = ("<td>foundHotels[i]</td>")
	}
} document.getElementById("check").addEventListener("click", function() {
	searchForHotel(document.getElementById("hotelNameSearched").value, document.getElementById("needRooms").value, document.getElementById("priceRange").value, document.getElementById("days").value);

});


