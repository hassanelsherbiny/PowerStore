define(['components/calendar/module'], function (module) {

    "use strict";

    module.registerDirective('dragableEvent', function ($log) {
        return {
            restrict: 'A',
            link: function (scope, element) {

                // $log.log(element.scope());

                var eventObject = element.scope().event;

                element.data('eventObject', eventObject);


                element.draggable({
                    zIndex: 999,
                    revert: true, // will cause the event to go back to its
                    revertDuration: 0 //  original position after the drag
                });


            }
        }
    })

});