define(['modules/forms/module', 'bootstrap-tagsinput'], function (module) {

    'use strict';

    return module.registerDirective('smartTagsinput', function () {
        return {
            restrict: 'A',
            compile: function (tElement, tAttributes) {
                tElement.removeAttr('smart-tagsinput data-smart-tagsinput');
                tElement.tagsinput();
            }
        }
    });
});
