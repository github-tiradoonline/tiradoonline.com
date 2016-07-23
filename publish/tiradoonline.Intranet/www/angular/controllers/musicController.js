tiradoonlineNamespace.controller
(
	'musicController', function ($scope, $http, $location) {
	    $scope.songs = [];

	    var $url = $location.protocol() + "://" + $location.host() + "/Media/Music";

	    $http({
	        method: 'POST',
	        url: $url,
	        crossDomain: true,
	        data: { test: ".mp3;.wma" },
	        headers: {
	            'Content-Type': 'application/json',
	            'Access-Control-Allow-Origin': '*'
	        }
	    })
        .success(function (data, status) {
            $scope.songs = data;
        })
	    .error(function (data, status) {
	        alert('ERROR - ' + $url);
	    });
	}
);