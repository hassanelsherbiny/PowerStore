define(['angular',
    'angular-couch-potato',
    'angular-ui-router'], function (ng, couchPotato) {

    "use strict";


    var module = ng.module('app.misc', ['ui.router']);


    couchPotato.configureApp(module);

    module.config(function ($stateProvider, $couchPotatoProvider) {

        $stateProvider
            .state('app.misc', {
                abstract: true,
                data: {
                    title: 'Miscellaneous'
                }
            })

            .state('app.misc.pricingTable', {
                url: '/pricing-table',
                data: {
                    title: 'Pricing Table'
                },
                views: {
                    "content@app": {
                        templateUrl: 'app/modules/misc/views/pricing-table.html'
                    }
                }
            })

            .state('app.misc.invoice', {
                url: '/invoice',
                data: {
                    title: 'Invoice'
                },
                views: {
                    "content@app": {
                        templateUrl: 'app/modules/misc/views/invoice.html'
                    }
                }
            })

            .state('app.misc.error404', {
                url: '/404',
                data: {
                    title: 'Error 404'
                },
                views: {
                    "content@app": {
                        templateUrl: 'app/modules/misc/views/error404.html'
                    }
                }
            })

            .state('app.misc.error500', {
                url: '/500',
                data: {
                    title: 'Error 500'
                },
                views: {
                    "content@app": {
                        templateUrl: 'app/modules/misc/views/error500.html'
                    }
                }
            })

            .state('app.misc.blank', {
                url: '/blank',
                data: {
                    title: 'Blank'
                },
                views: {
                    "content@app": {
                        templateUrl: 'app/modules/misc/views/blank.html'
                    }
                }
            })

            .state('app.misc.emailTemplate', {
                url: '/email-template',
                data: {
                    title: 'Email Template'
                },
                views: {
                    "content@app": {
                        templateUrl: 'app/modules/misc/views/email-template.html'
                    }
                }
            })

            .state('app.misc.search', {
                url: '/search',
                data: {
                    title: 'Search'
                },
                views: {
                    "content@app": {
                        templateUrl: 'app/modules/misc/views/search.html'
                    }
                }
            })

            .state('app.misc.ckeditor', {
                url: '/ckeditor',
                data: {
                    title: 'CK Editor'
                },
                views: {
                    "content@app": {
                        templateUrl: 'app/modules/misc/views/ckeditor.html',
                        resolve:{
                            deps: $couchPotatoProvider.resolveDependencies([
                                'modules/forms/directives/editors/smartCkEditor'
                            ])
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
