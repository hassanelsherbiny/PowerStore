define(['app'], function(app){
    "use strict";

	    return app.factory('activityService', function($http,$log) {

		function getActivities(callback){

			$http.get('api/activities/activity.json').success(function(data){

				callback(data);
					
			}).error(function(){

				$log.log('Error');
				callback([]);

			});

		}

		function getActivitiesByType(type, callback){

			$http.get('api/activities/activity-' + type + '.json').success(function(data){

				callback(data);
					
			}).error(function(){

				$log.log('Error');
				callback([]);

			});

		}
		
		return{
			get:function(callback){
				getActivities(callback);
			},
			getbytype:function(type,callback){
				getActivitiesByType(type, callback);
			}
		}
	})
})