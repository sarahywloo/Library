var Library;
(function (Library) {
    angular.module("Library", ['ngRoute'])
        .config(function ($routeProvider) {
        $routeProvider
            .when('/', {
            templateUrl: '/Presentation/ngApp/views/booklist.html',
            controller: Library.Controllers.BookListController,
            controllerAs: 'controller'
        });
    });
})(Library || (Library = {}));
//# sourceMappingURL=app.js.map