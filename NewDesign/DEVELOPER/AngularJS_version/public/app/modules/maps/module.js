define(['angular',
    'angular-couch-potato',
    'angular-google-maps',
    'angular-ui-router'], function (ng, couchPotato) {

    "use strict";


    var module = ng.module('app.maps', ['ui.router', 'google-maps'.ns()]);


    couchPotato.configureApp(module);

    module.config(function ($stateProvider, $couchPotatoProvider, uiGmapGoogleMapApiProvider) {

        uiGmapGoogleMapApiProvider.configure({
            key: 'AIzaSyD5Ybgnvx6jbYGpq7IncsWFc6rkUNrzUzw',
            v: '3.17'
        });
        $stateProvider
            .state('app.maps', {
                url: '/maps',
                data: {
                    title: 'Maps'
                },
                views: {
                    "content@app": {
                        controller: 'MapsDemoCtrl',
                        templateUrl: 'app/modules/maps/views/maps-demo.html',
                        resolve: {
                            deps: $couchPotatoProvider.resolveDependencies([
                                'layout/directives/smartFitAppView',
                                'modules/maps/controllers/MapsDemoCtrl',
                                'modules/maps/directives/smartMapInstance',
                                'modules/maps/models/SmartMapInstances',
                                'modules/maps/models/SmartMapStyle'
                            ]),
                            api: function(uiGmapGoogleMapApi){
                                return uiGmapGoogleMapApi;
                            }
                        }
                    }
                }
            })
    });

    module.run(function ($couchPotato) {
        module.lazy = $couchPotato;
    });

    return module;

});
