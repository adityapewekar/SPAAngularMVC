angular.module('SPA').factory('CommentFactory', ['$http', function ($http) {

    var commentFactory = {}
    commentFactory.GetComments = function () {
        return $http({
            url: '/Comment/GetAllComments',
            method: 'GET'
        });
    };
  
    return commentFactory;
}])