
// To run this code, edit file index.html or index.jade and change
// html data-ng-app attribute from angle to myAppName
// ----------------------------------------------------------------------

(function() {
    'use strict';
    angular.module('app.produto').controller('ProdutoController', [
	'$scope',
	'$interval',
	'$stateParams',
	'$location',
	'DTOptionsBuilder',
	'DTColumnDefBuilder',
	'SweetAlert',
    '$uibModal',
    '$http',
	function ($scope,
		$interval,
		$stateParams,
		$location,
		DTOptionsBuilder,
		DTColumnDefBuilder,
		SweetAlert,
        $uibModal,
        $http) {

	    $scope.xCross = true;
	    $scope.tempoExpiracao = 0;
	    $scope.buscaProduto = '/Produto/IndexFilter';

	    this.dtOptions = DTOptionsBuilder
            .newOptions()
            .withOption('bLengthChange', false)
            .withOption('bInfo', false)
            .withOption('bProcessing', true)
            .withPaginationType('full_numbers');

	    this.dtColumnDefs = [
			DTColumnDefBuilder
				.newColumnDef(0)
				.withOption('bSearchable', false)
				.notVisible()
				.notSortable(),
	        DTColumnDefBuilder
	        	.newColumnDef(1)
	        	.notSortable()
	    ]; 	  	   

	    $scope.buscarProdutos = function (item) {
	        $http({
	            method: 'GET',
	            url: $scope.buscaProduto,
	            headers: {
	                'Token': $scope.token,
	                'xCross': $scope.xCross
	            },
	        }).then(function successCallback(response) {
	            $scope.produtos = response.data;
	        }, function errorCallback(response) {
	            SweetAlert.swal('Erro!', 'token expirado ou inválido', 'error');
	        });
	            
	    }

	    $scope.validarToken = function (item) {
	        $http({
	            method: 'GET',
	            url: 'http://localhost:2627/wcf/AuthenticationTokenService.svc/ValidateToken'
	        }).then(function successCallback(response) {

	        }, function errorCallback(response) {

	        });
	    }

	    $scope.gerarToken = function (item) {
	        $http({
	            method: 'GET',
	            url: 'http://localhost:2627/wcf/AuthenticationTokenService.svc/GenerateToken'
	        }).then(function successCallback(response) {
	            $scope.tempoExpiracao = 60;
	            $scope.token = response.data;
	            $scope.xCross = false;

	            var timer = setInterval(function () {
	                $scope.tempoExpiracao--;
	                $scope.$apply();

	                if ($scope.tempoExpiracao <= 0) {
	                    clearInterval(timer);
	                    $scope.xCross = true;
	                }
	            }, 1000);
	        }, function errorCallback(response) {

	        });	        
	    }

	}]);
})();
