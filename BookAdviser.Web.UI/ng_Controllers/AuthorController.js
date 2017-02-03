app.controller('AuthorControl', function ($scope, $http) {

    $scope.getAuthorList = function () {
        $http.get("http://localhost:34266/api/Author")
          .then(function (response) {
              $scope.Authors = response.data;
          });
    };

    $scope.deleteAuthor = function (id) {
        debugger;
        $http.delete("http://localhost:34266/api/Author?id=" + id.toString())
            .then(function (response) {
                $scope.getAuthorList();
            });
    };

    $scope.getAuthor = function (id)
    {
        debugger;
        $http.get("http://localhost:34266/api/Author?id=" + id.toString())
          .then(function (response) {
              $scope.Author = response.data;
          });
    };

    $scope.editAuthor = function () {
        $http.put("http://localhost:34266/api/Author", JSON.stringify($scope.Author))
            .then(function (response) {
                window.location = '/Author'
            });
    };

    $scope.createAuthor = function () {
        $http.post("http://localhost:34266/api/Author", JSON.stringify($scope.Author))
         .then(function (response) {
             window.location = '/Author'
         });
    };


    $scope.getAuthorList();
});