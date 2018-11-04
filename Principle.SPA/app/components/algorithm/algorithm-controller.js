(function () {

    angular
        .module("dpDesign")
        .controller("AlgorithmController", AlgorithmController);

    AlgorithmController.$inject = ["$location"];

    function AlgorithmController($location) {

        var that = this;
        that.title = "Levenshtein Distance Algorithm";
    }
})();
