(function () {

    angular
        .module("dpDesign")
        .controller("EngineController", EngineController);

    EngineController.$inject = ["$location"];

    function EngineController($location) {

        var that = this;
        that.title = "MatrixSearch Engine";
    }
})();
