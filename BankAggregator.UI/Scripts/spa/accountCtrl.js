app.controller('accountCtrl', function ($scope, $http,$routeParams) {
    $scope.pageClass = 'page-movies';
    $scope.loadingAccount = true;

    $scope.Accounts = [];
    $scope.Transactions = [];

    $http.get('http://localhost:8075/api/accountinfo/bank/' + $routeParams.accountNumber)
    .then(function (response) {
        $scope.resp = response;
        $scope.loadingAccount = false;
        $scope.Accounts = response.data.Accounts
        $scope.Transactions = response.data.Transactions
    })

    $http.get('http://localhost:8075/api/offer/' + $routeParams.accountNumber)
   .then(function (response) {
       $scope.offers = response.data;
   })
})