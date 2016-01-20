namespace Library.Controllers {

    export class BookListController {

        public books;

        constructor(private $http: ng.IHttpService) {
            
            $http.get('/api/books')
            //lamba syntax is used to bind this to the window object
                .then((response) => {
                    this.books = response.data;
                });
        }
    }
}