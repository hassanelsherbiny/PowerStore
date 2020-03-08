define(['modules/forms/module'], function(module){
    "use strict";

    return module.registerController('FormLayoutsCtrl', function($scope, $modal, $log){

        $scope.openModal = function () {
            var modalInstance = $modal.open({
                templateUrl: 'formLayoutsDemoModal.html',
                controller: function($scope, $modalInstance){
                    $scope.closeModal = function(){
                        $modalInstance.close();
                    }
                }
            });

            modalInstance.result.then(function () {
                $log.info('Modal closed at: ' + new Date());

            }, function () {
                $log.info('Modal dismissed at: ' + new Date());
            });


        };


    })

});