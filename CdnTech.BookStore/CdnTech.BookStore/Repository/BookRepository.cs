using CdnTech.BookStore.Models;
using System.Collections.Generic;
using System.Linq;

namespace CdnTech.BookStore.Repository
{
    public class BookRepository
    {
        public List<Book> GetAllBooks()
        {
            return DataSource();
        }
        public Book GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<Book> SearchBooks(string title, string authorName)
        {
            return DataSource().Where(x => x.Title.Contains( title) || x.Author.Contains( authorName)).ToList();
        }
        private List<Book> DataSource()
        {
            return new List<Book>()
            {
                new Book() { Id=1,Title ="MVC",Author="Nitish"},
                new Book() { Id=2,Title ="C#",Author="Chandan"},
                new Book() { Id=3,Title ="Java",Author="Monika"},
                new Book() { Id=4,Title ="Php",Author="CdnTech"},
                new Book() { Id=5,Title ="JavaScript",Author="CdnTech"}
            };
        }
    }
}
