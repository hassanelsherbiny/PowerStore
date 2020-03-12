define(['modules/maps/module'], function (module) {

    'use strict';

    var _mapsCounter = 0;

    module.registerDirective('smartMapInstance', function ($q, uiGmapGoogleMapApi, uiGmapIsReady, SmartMapInstances) {
        return {
            restrict: 'A',
            compile: function (tElement, tAttributes) {
                _mapsCounter++;
                tElement.removeAttr('smart-map-instance data-smart-map-instance').addClass('smart-map-instance');

                var scope = tElement.scope();

                var mapId = tAttributes.smartMapInstance;
                var dfd = $q.defer();
                SmartMapInstances.add(mapId, dfd.promise);

                tElement.data('smart.map.dfd', dfd);


                uiGmapIsReady.promise(_mapsCounter).then(function () {
                    $('.smart-map-instance').each(function(){
                        var element = $(this);
                        var map = element.children('.angular-google-map').scope().map;
                        element.data('smart.map.dfd').resolve(map)
                    });
                });


                tElement.on('$destroy', function () {
                    SmartMapInstances.remove(mapId);
                });


                dfd.promise.then(function (map) {
                    scope.$on('$smartContentResize', function () {
                        google.maps.event.trigger(map, 'resize');
                    });
                });
            }

        }
    });
});
