var myApp = angular.module("myApp", [ "ui.router", "ngResource" ]);
myApp.controller("MainController", MainController);
myApp.controller("BooksController", BooksController);
myApp.controller("BookDetailsController", BookDetailsController);
myApp.service("$productService", ProductService);
myApp.service("$bookService", BookService);

myApp.config(function ($stateProvider, $urlRouterProvider, $locationProvider) {
    $stateProvider
        .state("home", {
            url: "/",
            templateUrl: "/ngApp/views/main.html",
            controller: MainController,
            controllerAs: "controller"
        }).state("books", {
            url: "/books",
            templateUrl: "/ngApp/views/books.html",
            controller: BooksController,
            controllerAs: "controller"
        }).state("bookDetails", {
            url: "/bookDetails/:jet",
            templateUrl: "/ngApp/views/bookDetails.html",
            controller: BookDetailsController,
            controllerAs: "controller"
        });

    // Handle request for non-existent route
    $urlRouterProvider.otherwise("/notFound");

    // Enable HTML5 navigation
    $locationProvider.html5Mode(true);
});