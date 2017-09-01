class ComputerDetailsController {
    constructor($computerService, $stateParams) {
        this.message = "hello from main";
        let id = $stateParams["id"];
        this.computer = $computerService.getComputerDetails(id);
    }
}