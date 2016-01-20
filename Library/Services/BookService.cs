using Library.Domain.Models;
using Library.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Services {
    public class BookService {

        private BookRepository _bookRepo;

        public BookService(BookRepository bookRepo) {
            _bookRepo = bookRepo;
        }

        //convert books to bookDTO

        private BookDTO Map(Book dbBook) {
            return new BookDTO() {
                Id = dbBook.Id,
                Title = dbBook.Title,
                //so there will not be a null reference exception
                Author =
                        dbBook.Author != null
                        ? //dbBook has an author
                        new AuthorDTO() {
                            Id = dbBook.Author.Id,
                            Name = dbBook.Author.Name
                        } 
                        : //dbBook does NOT have an author
                        null,
                Isbn = dbBook.Isbn
            };
        }
        public IList<BookDTO> ListBooks() {

            return (from b in _bookRepo.List()
                    select Map(b)).ToList();
        }
    }
}