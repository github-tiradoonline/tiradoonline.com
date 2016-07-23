tiradoonlineNamespace.controller
(
	'moviesController', function ($scope, $http, $location) {
	    $scope.movies = [];
	    $scope.movieTitle = "";

	    var $url = $location.protocol() + "://" + $location.host() + "/Media/Movies";

	    $http({
	        method: 'POST',
	        url: $url,
	        crossDomain: true,
	        data: { filter: ".mp4" },
	        headers: {
	            'Content-Type': 'application/json',
	            'Access-Control-Allow-Origin': '*'
	        }
	    })
        .success(function (data, status) {
            //alert('SUCCESS - ' + data);
            $scope.movies = data;
        })
	    .error(function (data, status) {
	        alert('ERROR - ' + $url);
	    });

	    $scope.showModal = function (url) {
	        $("#movieTitle").html(url);
	        var video = document.getElementsByTagName('video')[0];
	        var sources = video.getElementsByTagName('source');

	        sources[0].src = url;
	        video.load();

	        if (video.requestFullScreen) {
	            video.requestFullScreen();
	        } else if (video.webkitRequestFullScreen) {
	            video.webkitRequestFullScreen();
	        } else if (video.mozRequestFullScreen) {
	            video.mozRequestFullScreen();
	        }

	        $("#mediaPlayerModal").modal('show');
	    }



	}
);