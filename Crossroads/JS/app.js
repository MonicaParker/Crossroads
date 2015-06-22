(function () {
    angular.module("C", ['ngRoute', 'ngResource']).config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {
        $routeProvider
        .when('/', {
            templateUrl: '/Templates/Index.html',
            controller: 'HomeController'
        })
        .when('/login', {
            templateUrl: '/Templates/Login.html',
            controller: 'LoginController'
        })
        .when('/profile', {
            templateUrl: '/Templates/Profile.html',
            controller: 'ProfileController'
        })
        .when('/map', {
            templateUrl: '/Templates/Map.html',
            controller: 'MapController'
        })
        .when('/character', {
            templateUrl: '/Templates/Character.html',
            controller: 'CharacterController'
        })
        .when('/journal', {
            templateUrl: '/Templates/Journal.html',
            controller: 'JournalController'
        })
        .when('/search', {
            templateUrl: '/Templates/Search.html',
            controller: 'SearchController'
        })
        .otherwise({
            templateUrl: '/Templates/Missing.html'
        })
        $locationProvider.html5Mode(true);
    }]);
})();