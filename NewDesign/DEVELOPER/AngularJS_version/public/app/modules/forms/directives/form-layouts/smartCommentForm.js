define(['modules/forms/module', 'modules/forms/common', 'jquery-maskedinput', 'jquery-form', 'jquery-validation'], function (module, formsCommon) {

    'use strict';

    return module.registerDirective('smartCommentForm', function () {
        return {
            restrict: 'E',
            replace: true,
            templateUrl: 'app/modules/forms/directives/form-layouts/smart-comment-form.tpl.html',
            scope: true,
            link: function (scope, form) {

                form.validate(angular.extend({
                    // Rules for form validation
                    rules : {
                        name : {
                            required : true
                        },
                        email : {
                            required : true,
                            email : true
                        },
                        url : {
                            url : true
                        },
                        comment : {
                            required : true
                        }
                    },

                    // Messages for form validation
                    messages : {
                        name : {
                            required : 'Enter your name',
                        },
                        email : {
                            required : 'Enter your email address',
                            email : 'Enter a VALID email'
                        },
                        url : {
                            email : 'Enter a VALID url'
                        },
                        comment : {
                            required : 'Please enter your comment'
                        }
                    },

                    // Ajax form submition
                    submitHandler : function() {
                        form.ajaxSubmit({
                            success : function() {
                                form.addClass('submited');
                            }
                        });
                    }

                }, formsCommon.validateOptions));

            }
        }
    });
});
