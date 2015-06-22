(function () {
    angular.module('C').controller('LoginController', function ($scope, $location) {


        $scope.username = '';
        $scope.password = '';
        //ng-model for username and password

        $scope.login = function () {
            $http({
                url: '/Token',
                method: 'POST',
                contentType: 'application/x-www-form-urlencoded',
                data: 'username=' + $scope.username + '&password=' + $scope.password + '&grant_type=password'
            }).success(function (data) {
                sessionStorage.setItem('token', data.access_token);

            }).error(function () {
                alert("Sorry your information was incorrect.")
            });
        };
        //Browser ==> Resources ==> Session storage to check if token was successfully generated
    });

})();