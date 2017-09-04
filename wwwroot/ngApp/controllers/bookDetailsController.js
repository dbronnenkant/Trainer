class BookDetailsController {
    constructor($bookService, $stateParams) {
        this.message = "hello from book details";
        let frog = $stateParams["jet"];
        this.bookDetails = $bookService.getBookDetails(frog);
    }
}