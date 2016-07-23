tiradoonlineNamespace.controller
(
	'countriesController', function ($scope, $http, $location) {
	    $scope.countries = [];

	    var $url = $location.protocol() + "://" + $location.host() + "/Countries/Get";

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
            $scope.countries = data;
        })
	    .error(function (data, status) {
	        alert('ERROR - ' + $url);
	    });
	}
);