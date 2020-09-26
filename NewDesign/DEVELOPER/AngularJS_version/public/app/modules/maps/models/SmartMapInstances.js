define(['modules/maps/module'], function (module) {

    'use strict';

    module.registerFactory('SmartMapInstances', function ($q, $timeout) {

            var _instances = {};

            function add(key, map) {
                _instances[key] = map
            }

            function remove(key) {
                delete  _instances[key];
            }

            function getMap(key) {
                var dfd = $q.defer();

                function resolver(){
                    $timeout(function(){
                        if(_instances[key]){
                            _instances[key].then(function(map){
                                dfd.resolve(map)
                            });
                        } else {
                            resolver();
                        }
                    }, 50)
                }
                resolver();
                return dfd.promise;
            }

            return {
                add: add,
                remove: remove,
                getMap: getMap
            }
        }
    );
});
