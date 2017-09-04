class BookService {
    constructor($resource) {
        this.bookResource = $resource("/api/Books/:jet");
    }
    getBooks () {
        return this.bookResource.query();
    }
    getBookDetails (bird) {
        return this.bookResource.get({ jet: bird });
    }
}