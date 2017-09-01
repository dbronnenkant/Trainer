class ComputersController {
    constructor($computerService, $state) {
        this.message = "hello from main";
        this.computers = $computerService.getComputers();
        this.state = $state;
        
    }
    clickit(id){
        this.state.go("computerDetails", {id: id});
    }

}