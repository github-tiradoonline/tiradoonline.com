tiradoonlineNamespace.controller
(
	'eBooksController', function ($scope, $http, $location) {
	    $scope.eBooks = [];

	    var $url = $location.protocol() + "://" + $location.host() + "/Media/eBooks";

	    $http({
	        method: 'POST',
	        url: $url,
	        crossDomain: true,
	        data: { filter: ".pdf" },
	        headers: {
	            'Content-Type': 'application/json',
	            'Access-Control-Allow-Origin': '*'
	        }
	    })
        .success(function (data, status) {
            //alert('SUCCESS - ' + data);
            $scope.eBooks = data;
        })
	    .error(function (data, status) {
	        alert('ERROR - ' + $url);
	    });
	}
);