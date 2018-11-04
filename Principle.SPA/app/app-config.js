angular.module("dpDesign")
       .config(function ($routeProvider) {

           $routeProvider
               .when("/playground", {
                   templateUrl: "app/components/playground/playground.html",
                   controller: "DemoController",
                   controllerAs: 'vm'
               })
               .when("/algorithm", {
                   templateUrl: "app/components/algorithm/algorithm.html",
                   controller: "AlgorithmController",
                   controllerAs: 'vm'
               })
               .when("/engine", {
                   templateUrl: "app/components/engine/engine.html",
                   controller: "EngineController",
                   controllerAs: 'vm'
               })
               .when("/module", {
                   templateUrl: "app/components/module/etl.html",
                   controller: "EtlController",
                   controllerAs: 'vm'
               })
               .otherwise({
                   // default page
                   redirectTo: "/engine"
               })
       });