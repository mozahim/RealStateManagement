﻿(function () {
    var app = angular.module('realState.controllers', []);
    app.controller('HomeCtrl', function ($scope, $location,$rootScope, $mdDialog, authService) {
        $scope.logOut = function () {
            authService.logOut();
            $location.path('/home');
        }

        $scope.authentication = authService.authentication;
        console.log();
        if (!$scope.authentication.isAuth) {
            $location.path('/login');
        }
        $scope.message = 'Alsalam Alaykom';
        $scope.navigateTo = function(to, event) {
            $mdDialog.show(
              $mdDialog.alert()
                .title('Navigating')
                .content('Imagine being taken to ' + to)
                .ariaLabel('Navigation demo')
                .ok('Neat!')
                .targetEvent(event)
            );
        };
    });

    app.controller('registerCtrl', ['$scope', '$location', '$timeout', 'authService', function ($scope, $location, $timeout, authService) {

        $scope.savedSuccessfully = false;
        $scope.message = "";

        $scope.registration = {
            userName: "",
            password: "",
            confirmPassword: ""
        };

        $scope.signUp = function () {

            authService.saveRegistration($scope.registration).then(function (response) {

                $scope.savedSuccessfully = true;
                $scope.message = "User has been registered successfully, you will be redicted to login page in 2 seconds.";
                startTimer();

            },
             function (response) {
                 var errors = [];
                 for (var key in response.data.modelState) {
                     for (var i = 0; i < response.data.modelState[key].length; i++) {
                         errors.push(response.data.modelState[key][i]);
                     }
                 }
                 $scope.message = "Failed to register user due to:" + errors.join(' ');
             });
        };

        var startTimer = function () {
            var timer = $timeout(function () {
                $timeout.cancel(timer);
                $location.path('/login');
            }, 2000);
        }

    }]);

    app.controller('loginCtrl', ['$scope', '$location', 'authService', function ($scope, $location, authService) {

        $scope.loginData = {
            userName: "",
            password: ""
        };

        $scope.message = "";

        $scope.login = function () {
            console.log("Trying to login");
            authService.login($scope.loginData).then(function (response) {

                $location.path('/');

            },
             function (err) {
                 $scope.message = err.error_description;
             });
        };

    }]);
})();
