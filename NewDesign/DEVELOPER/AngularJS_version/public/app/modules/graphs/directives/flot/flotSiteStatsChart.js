define(['modules/graphs/module', 'modules/graphs/directives/flot/FlotConfig',
    'flot',
    'flot-resize',
    'flot-fillbetween',
    'flot-orderBar',
    'flot-pie',
    'flot-time',
    'flot-tooltip'
], function(module, config){
    "use strict";

    return module.registerDirective('flotSiteStatsChart', function(){
        return {
            restrict: 'E',
            replace: true,
            template: '<div class="chart"></div>',
            scope: {
                data: '='
            },
            link: function(scope, element){

                $.plot(element, scope.data, {
                    series : {
                        lines : {
                            show : true,
                            lineWidth : 1,
                            fill : true,
                            fillColor : {
                                colors : [{
                                    opacity : 0.1
                                }, {
                                    opacity : 0.15
                                }]
                            }
                        },
                        points : {
                            show : true
                        },
                        shadowSize : 0
                    },

                    yaxes : [{
                        min : 20,
                        tickLength : 5
                    }],
                    grid : {
                        hoverable : true,
                        clickable : true,
                        tickColor : config.chartBorderColor,
                        borderWidth : 0,
                        borderColor : config.chartBorderColor
                    },
                    tooltip : true,
                    tooltipOpts : {
                        content : "%s for <b>%x:00 hrs</b> was %y",
                        dateFormat : "%y-%0m-%0d",
                        defaultTheme : false
                    },
                    colors : [config.charMain, config.chartSecond],
                    xaxis : {
                        mode : "time",
                        tickLength : 10,
                        ticks : 15,
                        tickDecimals : 2
                    },
                    yaxis : {
                        ticks : 15,
                        tickDecimals : 0
                    }
                });

            }
        }
    })
});
