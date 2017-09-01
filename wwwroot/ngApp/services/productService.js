class ProductService {
    constructor($resource) {
        this.productResource=$resource("/api/products/:id");
    }

    getProducts() {
        return this.productResource.query();
    }

    getProduct(id) {
        return this.productResource.get({ id: id });
    }

}