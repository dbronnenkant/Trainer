class CatDetailsController {
    constructor($stateParams, $catService) {
        this.message = "hello from main";
        let id = $stateParams["id"];
        this.cat = $catService.getCatDetails(id);
        }
}