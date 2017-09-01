class ProductController {
    constructor($productService, $state) {
        this.message = "hello from main";
        this.products = $productService.getProducts(); 
        this.state = $state; 
    }

    click(id){
        this.state.go("productDetails",{ id: id });
        

    }
}