(function () {
    app.controller("Topics", function ($scope, $http) {

        const getdata = () => {
            let url = "";
            url = $scope.searchText == undefined ? '/Topics/GetTopics' : `/Topics/GetTopics?searchText=${$scope.searchText}`;
            $http.get(url).then(function (d) {
                $scope.data = d.data;
            });
        }

        getdata();
        $scope.searchText = '';

        $scope.search = function () {
            getdata();
        }

        $scope.sort = function (sortId) {
            $scope.sortParam = sortId;
            if ($scope.IsReverse) {
                $scope.IsReverse = false;
            }
            else {
                $scope.IsReverse = true;
            }

        }; 
        
    });
}).call(angular);