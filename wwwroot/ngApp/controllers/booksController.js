class BooksController {
    constructor($bookService,$state) {
        this.message = "hello from main";
        this.books = $bookService.getBooks();
        this.state = $state;
        
    }
    click(bookId){
        this.state.go("bookDetails",{id:bookId});
    }
}