class BooksController {
    constructor($bookService, $state) {
        this.message = "hello from books";
        this.books = $bookService.getBooks();
        this.state = $state;
    }
    clickDetails(bear) {
        this.state.go("bookDetails", {jet: bear});
    }
}