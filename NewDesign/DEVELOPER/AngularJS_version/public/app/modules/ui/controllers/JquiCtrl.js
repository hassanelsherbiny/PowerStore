define(['modules/ui/module'], function (module) {

    "use strict";


    module.registerController('JquiCtrl', function ($scope) {
        $scope.demoAutocompleteWords = [
            "ActionScript",
            "AppleScript",
            "Asp",
            "BASIC",
            "C",
            "C++",
            "Clojure",
            "COBOL",
            "ColdFusion",
            "Erlang",
            "Fortran",
            "Groovy",
            "Haskell",
            "Java",
            "JavaScript",
            "Lisp",
            "Perl",
            "PHP",
            "Python",
            "Ruby",
            "Scala",
            "Scheme"];


        $scope.demoAjaxAutocomplete = '';


        $scope.modalDemo1 = function(){
            console.log('modalDemo1');
        }

        $scope.modalDemo2 = function(){
            console.log('modalDemo2');
        }


    })
});