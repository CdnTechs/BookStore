using CdnTech.BookStore.Models;
using CdnTech.BookStore.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CdnTech.BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }

        //public List<Book> GetAllBooks()
        //{
        //    return _bookRepository.GetAllBooks();
        //}
        public ViewResult GetAllBooks()
        {
            var data= _bookRepository.GetAllBooks();
            return View(data);
        }
        public Book GetBook(int id)
        {
            return _bookRepository.GetBookById(id);
        }

        public List<Book> SearchBooks(string bookName, string authorName)
        {
            return _bookRepository.SearchBooks(bookName, authorName);
        }
    }
}
