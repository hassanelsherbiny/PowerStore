define(['angular',
    'angular-couch-potato',
    'angular-ui-router'], function (ng, couchPotato) {

    "use strict";


    var module = ng.module('app.smartAdmin', ['ui.router']);


    couchPotato.configureApp(module);

    module.config(function ($stateProvider, $couchPotatoProvider) {

        $stateProvider
            .state('app.smartAdmin', {
                abstract: true,
                data: {
                    title: 'SmartAdmin Intel'
                }
            })

            .state('app.smartAdmin.appLayout', {
                url: '/app-layout',
                data: {
                    title: 'App Layout'
                },
                views: {
                    "content@app": {
                        templateUrl: 'app/modules/smart-admin/views/app-layout.html'
                    }
                }
            })

            .state('app.smartAdmin.diffVer', {
                url: '/different-versions',
                data: {
                    title: 'Different Versions'
                },
                views: {
                    "content@app": {
                        templateUrl: 'app/modules/smart-admin/views/different-versions.html'
                    }
                }
            })
    });

    module.run(function ($couchPotato) {
        module.lazy = $couchPotato;
    });

    return module;

});
