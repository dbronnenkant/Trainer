class BookService {
    constructor($resource) {
        this.booksResource = $resource("/api/Books/:id");



    }
    getBooks(){
        return this.booksResource.query();
    }
    getBookDetails(id){
        return this.booksResource.get({id:id});
    }
}