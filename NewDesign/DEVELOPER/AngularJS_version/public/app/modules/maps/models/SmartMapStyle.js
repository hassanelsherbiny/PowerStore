define(['modules/maps/module'], function (module) {

    "use strict";


    module.registerFactory('SmartMapStyle', function ($q, $http, uiGmapGoogleMapApi) {

        var styles = {
            'colorful': { name: 'Colorful', url: 'api/maps/colorful.json'},
            'greyscale': { name: 'greyscale', url: 'api/maps/greyscale.json'},
            'metro': { name: 'metro', url: 'api/maps/metro.json'},
            'mono-color': { name: 'mono-color', url: 'api/maps/mono-color.json'},
            'monochrome': { name: 'monochrome', url: 'api/maps/monochrome.json'},
            'nightvision': { name: 'Nightvision', url: 'api/maps/nightvision.json'},
            'nightvision-highlight': { name: 'nightvision-highlight', url: 'api/maps/nightvision-highlight.json'},
            'old-paper': { name: 'Old Paper', url: 'api/maps/old-paper.json'}
        };


        function getMapType(key){
            var keyData = styles[key];

            if(!keyData.cache){
                keyData.cache = createMapType(keyData)
            }

            return keyData.cache;
        }

        function createMapType(keyData){
            var dfd = $q.defer();
            $q.all([uiGmapGoogleMapApi, $http.get(keyData.url)]).then(function(resolves){
                var styleData = resolves[1].data;
                var type = new google.maps.StyledMapType(styleData, {name: keyData.name})
                dfd.resolve(type);
            }, function(reason){
                console.error(reason);
                dfd.reject(reason);
            });

            return dfd.promise;
        }


        return {
            getMapType: getMapType,
            styles: styles
        }



    });

});

