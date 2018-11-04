(function () {

    angular
        .module("dpDesign")
        .controller("EtlController", EtlController);

    EtlController.$inject = ["$location"];

    function EtlController($location) {

        var that = this;
        that.title = "ETL";
    }
})();
