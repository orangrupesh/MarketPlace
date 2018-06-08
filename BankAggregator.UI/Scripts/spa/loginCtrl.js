/// <reference path="../../vendors/angular.js" />

app.controller('loginCtrl', function ($scope, $location) {
    $scope.Login = function () {
        $location.path('/home/' + $scope.username)
    }
})