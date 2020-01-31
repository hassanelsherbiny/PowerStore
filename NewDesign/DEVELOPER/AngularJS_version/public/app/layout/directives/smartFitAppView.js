define(['layout/module', 'lodash'], function (module, _) {

    'use strict';

    module.registerDirective('smartFitAppView', function ($rootScope, SmartCss) {
        return {
            restrict: 'A',
            compile: function (element, attributes) {
                element.removeAttr('smart-fit-app-view data-smart-fit-app-view leading-y data-leading-y');

                var leadingY = attributes.leadingY ? parseInt(attributes.leadingY) : 0;

                var selector = attributes.smartFitAppView;

                if(SmartCss.appViewSize && SmartCss.appViewSize.height){
                    var height =  SmartCss.appViewSize.height - leadingY < 252 ? 252 :  SmartCss.appViewSize.height - leadingY;
                    SmartCss.add(selector, 'height', height+'px');
                }

                var listenerDestroy = $rootScope.$on('$smartContentResize', function (event, data) {
                    var height = data.height - leadingY < 252 ? 252 : data.height - leadingY;
                    SmartCss.add(selector, 'height', height+'px');
                });

                element.on('$destroy', function () {
                    listenerDestroy();
                    SmartCss.remove(selector, 'height');
                });


            }
        }
    });
});
