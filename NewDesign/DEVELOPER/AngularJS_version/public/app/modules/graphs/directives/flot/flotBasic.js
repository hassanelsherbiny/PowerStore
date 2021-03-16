define(['modules/graphs/module',
    'flot',
    'flot-resize',
    'flot-fillbetween',
    'flot-orderBar',
    'flot-pie',
    'flot-time',
    'flot-tooltip'], function (module) {

    'use strict';

    module.registerDirective('flotBasic', function () {
        return {
            restrict: 'A',
            scope:{
                data:'=flotData',
                options: '=flotOptions'
            },
            link: function (scope, element, attributes) {
                var plot = $.plot(element, scope.data, scope.options);

                scope.$watchCollection('data', function(newData, oldData){
                    if(newData != oldData){
                        plot.setData(newData);
                        plot.draw();
                    }
                });
            }
        }
    });
});
