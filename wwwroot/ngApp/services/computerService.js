class ComputerService {
    constructor($resource) {
        this.computerResource = $resource("/api/Computers/:id");
        
    }
    getComputers(){
        return this.computerResource.query();
    }
    getComputerDetails(id){
        return this.computerResource.get({id: id});
    }
}