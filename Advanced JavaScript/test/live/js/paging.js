let $previousBtn = $("#previous");
let $nextBtn = $("#next");
let $searchBtn = $("#searchBtn");
let tableOrder = 0;
let pageNumber = 1;
let pageSize = 10;
let $list = $('#list');

let removeRows = ($listOfBooks) => {
    $listOfBooks.html("");
};

let displayPage = (pageNumber, books, $listOfBooks) => {
    let $page = $("#page").text(pageNumber);
    let maxPageNumber = Math.ceil(books.length / pageSize);
    let $pages = $("#pages").text(maxPageNumber);
    let startIndex = (pageNumber - 1) * pageSize;
    let endIndex = pageNumber * pageSize;
    addBooks(books, startIndex, endIndex, $listOfBooks);
};

let addBooks = (books, startIndex, endIndex, $listOfBooks) => {
    removeRows($listOfBooks);
    books.slice(startIndex, endIndex).forEach(b => {
    	tableOrder++;
        if (b.title.indexOf('Novel') !== -1)
	        $listOfBooks.append(`
	        	<tr>
		            <th scope="row">${tableOrder}</th>
		            <td>${b.title} (${$('#bookTypeChoice option:selected').val()})</td>
		            <td>${b.author}</td>
		            <td>${b.publisher}</td>
		            <td>${b.year}</td>
		            <td>${b.pageLength}</td>
		            <td>${b.series} (#${b.seriesNumber})</td>
		            <td></td>
		            <td>${b.isbn}</td>
		            <td>${fixReviewText()}</td>
	        	</tr>`
	        );
	    if (b.title.indexOf('Anthology') !== -1)
	    	$listOfBooks.append(`
		    	<tr>
		            <th scope="row">${tableOrder}</th>
		            <td>${b.title} (${$('#bookTypeChoice option:selected').val()})</td>
		            <td>${b.editor}</td>
		            <td>${b.publisher}</td>
		            <td>${b.year}</td>
		            <td>${b.pageLength}</td>
		            <td></td>
		            <td>${storiesOutput()}</td>
		            <td>${b.isbn}</td>
		            <td>${fixReviewText()}</td>
		        </tr>`
        	);
    });
};