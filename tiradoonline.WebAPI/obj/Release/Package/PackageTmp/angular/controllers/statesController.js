tiradoonlineNamespace.controller
(
	'statesController', function ($scope, $http, $location) {
	    $scope.states = [];

	    var $url = $location.protocol() + "://" + $location.host() + "/States/Get";

	    $http({
	        method: 'POST',
	        url: $url,
	        crossDomain: true,
	        data: { test: "teddy" },
	        headers: {
	            'Content-Type': 'application/json',
	            'Access-Control-Allow-Origin': '*'
	        }
	    })
        .success(function (data, status) {
            //alert('SUCCESS - ' + data);
            $scope.states = data;
        })
	    .error(function (data, status) {
          alert('ERROR - ' + $url);
        });
	}
);