(function () {

    angular
        .module("dpDesign")
        .controller("DemoController", DemoController);

    DemoController.$inject = ["$location", "dataAccessFactory"];

    function DemoController($location, factory, $http) {

        var that = this;
        that.title = "Playground";
        that.subtitle = "Play";
        that.newEntity = "";
        that.size = { Id: 1, Name: "Small" };
        that.sizes = [{ Id: 1, Name: "Small" }, { Id: 2, Name: "Large" }];
        that.entities = [];
        that.recommendations = [];
        that.add = add;
        that.remove = remove;
        that.getInput = getInput;
        that.getRecommendation = getRecommendation;

        activate();

        function activate() {
            factory
                .getInputCommunicator()
                .query({ type: that.size.Id },
                    function (response) {
                        // success
                        that.entities = response;
                    },
                    function (error) {
                        // fail
                        alert("Error");
                    });
        }

        function add() {
            if (that.newEntity !== "" && that.newEntity !== undefined) {
                that.entities.push({ Name: that.newEntity });
                that.newEntity = "";
            }
        }

        function remove(entity) {
            var index = that.entities.indexOf(entity);
            that.entities.splice(index, 1);
        }

        function getInput() {
            activate();
        }

        function getRecommendation() {
            factory
                .getRecommendationCommunicator()
                .fetch({ type: undefined, collection: that.entities }, // that.size.Id
                    function (response) {
                        // success
                        that.recommendations = response;
                    },
                    function (error) {
                        // fail
                        alert("Error");
                    });
        }

    }
})();
