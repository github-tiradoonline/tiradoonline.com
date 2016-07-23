tiradoonlineNamespace.controller
(
	'languagesController', function ($scope, $http, $location) {
	    $scope.languages = [];

	    var $url = $location.protocol() + "://" + $location.host() + "/Languages/Get";

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
            $scope.languages = data;
        })
	    .error(function (data, status) {
	        alert('ERROR - ' + $url);
	    });
	}
);