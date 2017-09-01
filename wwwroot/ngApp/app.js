var myApp = angular.module("myApp", [ "ui.router", "ngResource" ]);
myApp.controller("MainController", MainController);
myApp.controller("DogsController", DogsController);
myApp.controller("DogDetailsController", DogDetailsController);

myApp.service("$productService", ProductService);
myApp.service("$dogService", DogService);

myApp.config(function ($stateProvider, $urlRouterProvider, $locationProvider) {
    $stateProvider
        .state("home", {
            url: "/",
            templateUrl: "/ngApp/views/main.html",
            controller: MainController,
            controllerAs: "controller"
        }).state("dogs", {
            url: "/dogs",
            templateUrl: "/ngApp/views/dogs.html",
            controller: DogsController,
            controllerAs: "controller"
        }).state("dogDetails", {
            url: "/dogDetails/:id",
            templateUrl: "/ngApp/views/dogDetails.html",
            controller: DogDetailsController,
            controllerAs: "controller"
        });

    // Handle request for non-existent route
    $urlRouterProvider.otherwise("/notFound");

    // Enable HTML5 navigation
    $locationProvider.html5Mode(true);
});