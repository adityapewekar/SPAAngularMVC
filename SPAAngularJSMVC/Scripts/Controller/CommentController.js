app.controller('CommentController', function ($scope, $location, $window, CommentFactory) {
    $scope.Name = "Aditya";
    $scope.Company = "GeBBS";
    $scope.Role = "Software Engineer";


    $scope.GetComments = function () {
        CommentFactory.GetComments().then(function (response) {
            debugger;
            $scope.Comments =response.data;
        });
    }
});

