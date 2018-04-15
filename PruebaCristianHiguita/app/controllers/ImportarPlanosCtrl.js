
edaControllers.controller('ImportarPlanosCtrl', ['$scope', 'ImportarPlanosService', function ($scope,  ImportarPlanosService) {
    $scope.editar = false;
    $scope.$emit('setTitle', 'Inventario Pesebrera');

    $scope.order = {
        orderProp: 'name',
        reverse: true,
        arrange: function (prop) {
            if ($scope.order.orderProp == prop)
                $scope.order.reverse = !$scope.order.reverse;
            $scope.order.orderProp = prop;
        }
    };

    $scope.GenerarPlanos = function () {
        var parametros = $scope.ANIMALES;
        ImportarPlanosService.GenerarPlanos.list(parametros).$promise.then(function (d) {
            $scope.RESPUESTA = d;


        }, function () {
            console.log('Error')
        });
    };




    $scope.Importar = function () {

        ImportarPlanosService.ImportarPlanos.list().$promise.then(function (d) {
            $scope.ANIMALES = d.AnimalesTO;
            $scope.RESPUESTA = d.RespError;

        }, function () {
            console.log('Error')
        });
    };

    $scope.expand = function (u, action) {
        if (action == 'U') {
            $scope.consult = false;
        } else {
            $scope.consult = true;
        };

        if (($scope.ID == u.ID && action == $scope.action && $scope.action != 'I') || $scope.ID == null) {
            $scope.showing = !$scope.showing;
            document.getElementById(u.ID).style.background = '#F2F2F2';
        } else {
            document.getElementById($scope.ID).style.removeProperty("background-color");
            document.getElementById(u.ID).style.background = '#F2F2F2';
        }

        $scope.action = action;


        if ($scope.showing == false) {
            document.getElementById($scope.ID).style.removeProperty("background-color");
            $scope.ID = null;
        };

    }

}]);

