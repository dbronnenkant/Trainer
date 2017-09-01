class DogService {
    constructor($resource) {
        this.dogResource = $resource("/api/Dogs/:id");

    }
    getDogs() {
        return this.dogResource.query();
    }
    getDog(id) {
        return this.dogResource.get({id: id});
    }
}