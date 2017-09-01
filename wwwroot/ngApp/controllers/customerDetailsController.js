class CustomerDetailsController {
    constructor($customerService, $stateParams) {
        let id = $stateParams["id"];
        this.customer = $customerService.getCustomerDetails(id);
    }
}