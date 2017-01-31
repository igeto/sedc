let xhr = new XMLHttpRequest();
xhr.open('GET', 'movies/movie-list.json', true);
xhr.send(null);

xhr.onreadystatechange = () => {
    if (xhr.readyState == XMLHttpRequest.DONE) {
        let movieList = JSON.parse(xhr.responseText);
        let filteredMovieList = movieList;

        let $movieTable = $("#movieTable");

        let pageNumber = 1;

        let $setPageSize = $("#setPageSize");
        let $previousBtn = $("#previous");
        let $nextBtn = $("#next");
        let $searchBtn = $("#search");

        let $pageSize = $("#pageSize option").filter(":selected").val();

        let displayPage = (pageNumber, pageSize, filteredMovieList, $movieTable) => {
            let $page = $("#page").text(pageNumber);
            let maxPageNumber = Math.ceil(filteredMovieList.length / $pageSize);
            let $pages = $("#pages").text(maxPageNumber);
            let startIndex = (pageNumber - 1) * $pageSize;
            let endIndex = pageNumber * $pageSize;
            addMovies(filteredMovieList, startIndex, endIndex, $movieTable);
        };

        let removeRows = ($movieTable) => {
            $movieTable.html("");
        };

        let addMovies = (filteredMovieList, startIndex, endIndex, $movieTable) => {
            removeRows($movieTable);
            filteredMovieList.slice(startIndex, endIndex).forEach(m => {
                $movieTable.append(`<tr>
        		<td style="text-align: center">${m.rank}.</td>
        		<td>${m.title}</td>
        		<td style="text-align: center">${m.year}</td>
        		<td style="text-align: center">${m.rating}</td>
        	</tr>`);
            });
        };

        $(() => {
            displayPage(pageNumber, pageSize, filteredMovieList, $movieTable);
            $setPageSize.on("click", () => {
                pageNumber = 1;
                $pageSize = $("#pageSize option").filter(":selected").val();
                displayPage(pageNumber, pageSize, filteredMovieList, $movieTable);
            });

            $previousBtn.on("click", () => {
                if (pageNumber != 1) {
                    pageNumber--;
                    displayPage(pageNumber, pageSize, filteredMovieList, $movieTable);
                }
            });
            $nextBtn.on("click", () => {
                let maxPageNumber = Math.ceil(filteredMovieList.length / $pageSize);
                if (pageNumber < maxPageNumber) {
                    pageNumber++;
                    displayPage(pageNumber, pageSize, filteredMovieList, $movieTable);
                }
            });
            $searchBtn.on("keyup", () => {
                let $searchVal = $("#search").val();
                if (!$searchVal)
                    displayPage(pageNumber, pageSize, filteredMovieList, $movieTable);
                pageNumber = 1;
                $searchVal = $searchVal.toLowerCase();
                filteredMovieList = movieList.filter(m => {
                    if (m.title.toLowerCase().indexOf($searchVal) !== -1)
                        return true;
                    if (m.year.toLowerCase().indexOf($searchVal) !== -1)
                        return true;
                    displayPage(pageNumber, pageSize, filteredMovieList, $movieTable);
                    return false;
                });
                displayPage(pageNumber, pageSize, filteredMovieList, $movieTable);
            });
        });
    }
};
