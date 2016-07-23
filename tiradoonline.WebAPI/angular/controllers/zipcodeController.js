tiradoonlineNamespace.controller
(
	'zipcodeController', function ($scope, $http, $location) {
	    var $zipCode = "10461";
	    $scope.grid = [];
	    $scope.zipcode = $zipCode;


	    //window.navigator.geolocation.getCurrentPosition(function (pos) {
	    //    alert(pos.coords.coords.latitude);
	    //});

	    $scope.getZipCode = function () {
            var $url = $location.protocol() + "://" + $location.host() + "/ZipCode/Get";

            $http({
                method: 'POST',
                url: $url,
                crossDomain: true,
                data: { ZipCode: $scope.zipcode },
                headers: {
                    'Content-Type': 'application/json',
                    'Access-Control-Allow-Origin': '*'
                }
            })
            .success(function (data, status) {
                //alert('SUCCESS - ' + data);
                $scope.grid = data;
            })
	        .error(function (data, status) {
	            alert('ERROR - ' + $url);
	        });
        }

	    // INITIALIZE GRID
        $scope.getZipCode();
	}
);