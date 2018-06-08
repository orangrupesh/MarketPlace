/// <reference path="../../vendors/angular.js" />

app.controller('homeCtrl', function ($scope, $http, $location, $routeParams) {

    $scope.pageClass = 'page-movies';
    $scope.loadingAccount = true;

    $scope.Accounts = [];
    $scope.Transactions = [];

    $http.get('http://localhost:8075/api/accountinfo/' + $routeParams.username)
    .then(function (response) {
        $scope.loadingAccount = false;
        $scope.Accounts = response.data.Accounts
    }, function (error) {
        $scope.loadingAccount = false;
        $scope.error = error
    })

    $scope.GetTransaction = function (accountNumber) {
        $location.path('/account/' + accountNumber)
    }
})