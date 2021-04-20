define(['layout/module', 'lodash'], function (module, _) {

    'use strict';

    module.registerFactory('SmartCss', function ($rootScope, $timeout) {

        var sheet = (function () {
            // Create the <style> tag
            var style = document.createElement("style");

            // Add a media (and/or media query) here if you'd like!
            // style.setAttribute("media", "screen")
            // style.setAttribute("media", "@media only screen and (max-width : 1024px)")

            // WebKit hack :(
            style.appendChild(document.createTextNode(""));

            // Add the <style> element to the page
            document.head.appendChild(style);

            return style.sheet;
        })();

        var _styles = {};


        var SmartCss = {
            writeRule: function(selector){
                SmartCss.deleteRuleFor(selector);
                if(_.has(_styles, selector)){
                    var css = selector + '{ ' + _.map(_styles[selector], function(v, k){
                        return  k + ':' +  v + ';'
                    }).join(' ') +'}';
                    sheet.insertRule(css)
                }
            },
            add: function (selector, property, value, delay) {
                if(!_.has(_styles, selector))
                    _styles[selector] = {};

                if(value == undefined || value == null || value == '')
                    delete _styles[selector][property];
                else
                    _styles[selector][property] = value;


                if(_.keys(_styles[selector]).length == 0)
                    delete _styles[selector];

                if(!delay)
                    delay = 0;
                $timeout(function(){
                    SmartCss.writeRule(selector);
                }, delay);

            },
            remove: function(selector, property, delay){
                SmartCss.add(selector, property, null, delay);
            },
            deleteRuleFor: function (selector) {
                _(sheet.rules).forEach(function (rule, idx) {
                    if (rule.selectorText == selector) {
                        sheet.deleteRule(idx);
                    }
                });
            },
            appViewSize: null
        };

        $rootScope.$on('$smartContentResize', function (event, data) {
            SmartCss.appViewSize = data;
        });

        return SmartCss;

    });
});



