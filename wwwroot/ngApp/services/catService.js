class CatService {
    constructor($resource) {
        this.cats = $resource("/api/Cats/:id");
    }

    getCats() {
        return this.cats.query();
    }

    getCatDetails(id) {
        return this.cats.get({id: id});    }
}