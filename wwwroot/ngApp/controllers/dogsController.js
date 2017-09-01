class DogsController {
    constructor($dogService) {
        this.message = "hello from dogs";
        this.dogs = $dogService.getDogs();
        
    }
}