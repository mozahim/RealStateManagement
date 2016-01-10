(function () {
    'use strict';
    var app = angular.module('realState', ['LocalStorageModule', 'ngMaterial', 'ngAnimate', 'ngAria', 'ngRoute', 'realState.controllers', 'realState.services']);
    app.run(function ($rootScope) {
        $rootScope.viewTitle = 'Dashboard';
        $rootScope.currentUser = '';
        $rootScope.access_token = '';
        $rootScope.serverUrl = 'http://localhost:39262/';
       

    });
    app.config(function ($mdIconProvider) {
        $mdIconProvider
          .iconSet('flaticon', 'Images/icons/sets/active5.svg', 24)

          .defaultIconSet('Images/icons/sets/active5.svg', 24);
    });

    app.config(function ($routeProvider, $locationProvider) {
        $routeProvider.when('/', { templateUrl: '/index.html', controller: 'HomeCtrl' });
        $routeProvider.when('/login', { templateUrl: '/Templates/login.html', controller: 'loginCtrl' });
        //$routeProvider.when('/customer/detail', { templateUrl: '/Templates/CustomerDetail.html', controller: 'customerDetailViewModel' });
        $routeProvider.otherwise({ redirectTo: '/' });
        $locationProvider.html5Mode(true);
    });

    app.config(function ($httpProvider) {
        $httpProvider.interceptors.push('authInterceptorService');
    });
})();
