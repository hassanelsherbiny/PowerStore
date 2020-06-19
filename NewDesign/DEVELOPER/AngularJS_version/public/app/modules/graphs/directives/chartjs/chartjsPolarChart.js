define(['modules/graphs/module', 'chartjs'], function (module) {

    'use strict';

    return module.registerDirective('chartjsPolarChart', function () {
        return {
            restrict: 'A',
            link: function (scope, element, attributes) {
                var polarOptions = {
                    //Boolean - Show a backdrop to the scale label
                    scaleShowLabelBackdrop : true,
                    //String - The colour of the label backdrop
                    scaleBackdropColor : "rgba(255,255,255,0.75)",
                    // Boolean - Whether the scale should begin at zero
                    scaleBeginAtZero : true,
                    //Number - The backdrop padding above & below the label in pixels
                    scaleBackdropPaddingY : 2,
                    //Number - The backdrop padding to the side of the label in pixels
                    scaleBackdropPaddingX : 2,
                    //Boolean - Show line for each value in the scale
                    scaleShowLine : true,
                    //Boolean - Stroke a line around each segment in the chart
                    segmentShowStroke : true,
                    //String - The colour of the stroke on each segement.
                    segmentStrokeColor : "#fff",
                    //Number - The width of the stroke value in pixels
                    segmentStrokeWidth : 2,
                    //Number - Amount of animation steps
                    animationSteps : 100,
                    //String - Animation easing effect.
                    animationEasing : "easeOutBounce",
                    //Boolean - Whether to animate the rotation of the chart
                    animateRotate : true,
                    //Boolean - Whether to animate scaling the chart from the centre
                    animateScale : false,
                    //Boolean - Re-draw chart on page resize
                    responsive: true,
                    //String - A legend template
                    legendTemplate : "<ul class=\"<%=name.toLowerCase()%>-legend\"><% for (var i=0; i<segments.length; i++){%><li><span style=\"background-color:<%=segments[i].fillColor%>\"></span><%if(segments[i].label){%><%=segments[i].label%><%}%></li><%}%></ul>"
                };

                var polarData = [
                    {
                        value: 300,
                        color:"rgba(220,220,220,0.8)",
                        highlight: "rgba(220,220,220,0.7)",
                        label: "Grey"
                    },
                    {
                        value: 50,
                        color: "rgba(151,187,205,1)",
                        highlight: "rgba(151,187,205,0.8)",
                        label: "Blue"
                    },
                    {
                        value: 100,
                        color: "rgba(169, 3, 41, 0.7)",
                        highlight: "rgba(169, 3, 41, 0.7)",
                        label: "Red"
                    },
                    {
                        value: 40,
                        color: "#949FB1",
                        highlight: "#A8B3C5",
                        label: "Grey"
                    },
                    {
                        value: 120,
                        color: "#4D5360",
                        highlight: "#616774",
                        label: "Dark Grey"
                    }
                ];

                // render chart
                var ctx = element[0].getContext("2d");
                new Chart(ctx).PolarArea(polarData, polarOptions);
            }}
    });
});
