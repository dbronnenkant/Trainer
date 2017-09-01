class ProductDetailsController {
    constructor($stateParams, $productService) {
        this.message = "hello from main";
        let id = $stateParams["id"];
        this.product = $productService.getProduct(id);
    }
}