
var edaApp = angular.module('edaApp', ['edaControllers', 'edaServices', 'ngRoute', 'ngSanitize', 'ngCsv']);
var edaControllers = angular.module('edaControllers', []);
var edaServices = angular.module('edaServices', ['ngResource']);

edaApp.factory('sammInterceptor', ['$q', receiverInterceptor]);

edaApp.config(['$routeProvider', '$httpProvider',
  function ($routeProvider, $httpProvider) {
      $routeProvider.
        when('/menu', {
            templateUrl: '/app/views/menu.html',
            controller: 'menuCtrl'
        }).

        when('/planos', {
            templateUrl: '/app/views/ImportarPlanos.html',
            controller: 'ImportarPlanosCtrl'
        }).

   otherwise({
         redirectTo: '/menu.html'
     })

      $httpProvider.interceptors.push('sammInterceptor');
  }]);
