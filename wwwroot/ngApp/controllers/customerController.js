class CustomerController {
    constructor($customerService, $state) {
        this.customers = $customerService.getCustomers();
        this.state = $state;
    }
    onclick(customerId){
        this.state.go("customerDetails", {id:customerId} );
    }

}