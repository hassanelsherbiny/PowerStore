define(['modules/forms/module', 'bootstrap-markdown'], function (module) {

    'use strict';

    module.registerDirective('smartMarkdownEditor', function () {
        return {
            restrict: 'A',
            compile: function (element, attributes) {
                element.removeAttr('smart-markdown-editor data-smart-markdown-editor')

                var options = {
                    autofocus:false,
                    savable:true,
                    fullscreen: {
                        enable: false
                    }
                };

                if(attributes.height){
                    options.height = parseInt(attributes.height);
                }

                element.markdown(options);
            }
        }
    });
});
