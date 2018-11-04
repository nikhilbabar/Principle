angular.module("dpFactories")
       .factory("dataAccessFactory", dataAccessFactory);

dataAccessFactory.$inject = ["$resource"];

function dataAccessFactory($resource) {
    var service = {
        get: get,
        post: post,
        put: put,
        remove: remove,
        getMasterCommunicator: getMasterCommunicator,
        getInputCommunicator: getInputCommunicator,
        getRecommendationCommunicator: getRecommendationCommunicator
    };

    var absoluteUrl = "http://localhost:55044/api/";

    return service;

    function get() {
    }

    function post() {
    }

    function put() {
    }

    function remove() {
    }

    function getInputCommunicator() {
        var relativeUrl = "input";
        var path = absoluteUrl + relativeUrl;
        var communicator = $resource(path, {},
                            {
                                get: { method: "GET" },
                                query: { method: "GET", params: { type: "@type" }, isArray: true },
                                update: { method: "POST" },
                                save: { method: "POST" },
                                remove: { method: "DELETE" }
                            });

        return communicator;
    }


    function getMasterCommunicator() {
        var relativeUrl = "home";
        var path = absoluteUrl + relativeUrl;
        var communicator = $resource(path, {},
                            {
                                get: { method: "GET" },
                                query: { method: "GET", isArray: true },
                                update: { method: "POST" },
                                save: { method: "POST" },
                                remove: { method: "DELETE" }
                            });

        return communicator;
    }

    function getRecommendationCommunicator() {
        var relativeUrl = "recommendation/:action";
        var path = absoluteUrl + relativeUrl;
        var communicator = $resource(path, {},
            {
                fetch: { params: { action: "Fetch" }, method: "POST", isArray: true }

            });
        return communicator;
    }

}
