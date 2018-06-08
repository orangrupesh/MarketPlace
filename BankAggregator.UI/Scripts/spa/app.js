var app = angular.module("BankAggregator", ["ngRoute"])
    
app.config(function($routeProvider, $locationProvider){
    $routeProvider.when("/", {
        templateUrl: "Pages/Login.html",
        controller:"loginCtrl"
    })
    .when("/home/:username", {
        templateUrl: "Pages/Home.html",
        controller: "homeCtrl"
    })
     .when("/account/:accountNumber", {
        templateUrl: "Pages/AccountInfo.html",
        controller: "accountCtrl"
    })
    .when("/mortgage", {
        templateUrl: "Pages/Mortgage.html",
        //controller: "accountCtrl"
    })

    $locationProvider.hashPrefix('');
});

   