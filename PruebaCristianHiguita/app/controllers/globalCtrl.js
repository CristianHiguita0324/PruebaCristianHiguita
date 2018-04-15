edaControllers.controller('globalCtrl', ['$scope', '$timeout', function ($scope, $timeout) {
    $scope.menuopen = false;

    var timer = null;
    $scope.mouseover = function () {
        if (timer)
            $timeout.cancel(timer);
        timer = $timeout(function () {
            $scope.menuopen = true;
        }, 500);
    };

    $scope.mouseleave = function () {
        $timeout.cancel(timer);
        $scope.menuopen = false;
    };

    $scope.global = {
        generalError: 'Ha ocurrido un error, por favor vuelva a intentarlo'
    };
    $scope.showError = function (msg) {
        alert(msg);
    };
    $scope.$on('setTitle', function (event, titulo, atras) {
        $scope.titulo = titulo;
        document.title = titulo;
        $scope.atras = atras;
    });



}]);