class BookDetailsController {
    constructor($stateParams,$bookService) {
        this.message = "hello from main";
        let id = $stateParams["id"];
        this.book = $bookService.getBookDetails(id);
    }
}