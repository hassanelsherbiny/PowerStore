define(['modules/graphs/module', 'dygraphs-demo', 'dygraphs'], function (module, demo) {

    'use strict';

    return module.registerDirective('dygraphsNoRollPeriod', function () {
        return {
            restrict: 'A',
            compile: function () {
                return {
                    post: function (scope, element) {
                        new Dygraph(element[0], demo.data_temp, {
                            customBars: true,
                            title: 'Daily Temperatures in New York vs. San Francisco',
                            ylabel: 'Temperature (F)',
                            legend: 'always',
                            labelsDivStyles: {
                                'textAlign': 'right'
                            },
                            showRangeSelector: true
                        });
                    }
                }
            }
        }
    });
});
