class DogDetailsController {
    constructor($stateParams, $dogService) {
        this.message = "hello from dog details";
        let id = $stateParams["id"];
        this.dog = $dogService.getDog(id);
    }
}