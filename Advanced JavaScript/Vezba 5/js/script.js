// let name = "Wekoslaw";

// function sayHi() {
//     console.log(`Hi, ${name}`);
// }
// let count = 0;

// function fibbonaci(number) {
//     count++;
//     if ((number === 1) || (number === 2)) {
//         return 1
//     }
//     return fibbonaci(number - 1) + fibbonaci(number - 2);
// }
// let file = function(author, title, awards) {
//     this.author = author;
//     this.title = title;
//     this.awards = awards;
// }
	// let result = [];
	// $(".awardslisting").each(function() {
	//     let title = $(this).find(".title").text();
	//     let author = $(this).find("img").attr("alt");
	//     let img = $(this).find("img").attr("src");
	//     if (title) {
	//         result.push({
	//             title,
	//             author,
	//             img
	//         });
	//     }
	// });

// let xhr = new XMLHttpRequest();
// xhr.open('GET', 'https://raw.githubusercontent.com/sedc-codecademy/sedc5-ajs/master/group-2/books/books2.json', true)
// xhr.send(null);

// xhr.onreadystatechange = function() {
//     if (xhr.readyState == XMLHttpRequest.DONE) {
//         console.log(xhr.responseText);
//         let bookList = JSON.parse(xhr.responseText);
//         console.log(bookList);
//     }
// }
let pageSize = 20;
let pageNumber = 1;
let booksContainer = $("tbody");
let removeRows = function(booksContainer) {
	booksContainer.html("");
}
let addBookToTable = function(book, booksContainer) {
    booksContainer.append(`<tr>
				<td>${book.author}</td>
				<td>${book.title}</td>
				<td>${book.awards}</td>
				<td><img src="https://www.worldswithoutend.com/${book.img}"></td></tr>`);
};
let displayPage = (pageNumber, pageSize, books) => {
	let startIndex = (pageNumber - 1) * pageSize;
	let endIndex = pageNumber * pageSize;
	let displayBooks = books.slice(startIndex, endIndex);
	displayBooks.forEach(b => addBookToTable(b, booksContainer));
};
$(() => {
    let xhr = new XMLHttpRequest();
    xhr.open('GET', 'https://raw.githubusercontent.com/sedc-codecademy/sedc5-ajs/master/group-2/books/books2.json', true)
    xhr.send(null);

    xhr.onreadystatechange = function() {
        if (xhr.readyState == XMLHttpRequest.DONE) {
            console.log(xhr.responseText);
            let bookList = JSON.parse(xhr.responseText);
            displayPage(pageNumber, pageSize, bookList, booksContainer);
        }
    };
});

