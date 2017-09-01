class CatsController {
    constructor($catService, $state) {
        this.message = "hello from Cats";
        this.state = $state;
        this.cats = $catService.getCats();
    }

    click(id) {
        this.state.go("catDetails", {id: id})
    }
}