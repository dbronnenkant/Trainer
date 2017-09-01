class CustomerService {
    constructor($resource) {
        this.customerResource = $resource("/api/Customers/:id");
    }
    getCustomers(){
        return this.customerResource.query();
    }
    getCustomerDetails(id){
        return this.customerResource.get({ id: id });
    }

}