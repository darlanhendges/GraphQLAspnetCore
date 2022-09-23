using Api.Configurations;
using Api.Interfaces.Repositories;
using Api.Models;

namespace Api.Repositories
{
    public class BookRepository : IBookRepository
    {
        public IEnumerable<BookModel> GetBooks()
        {
            return Database.Books;
        }

        public IEnumerable<BookModel> GetBookByName(string name)
        {
            return Database.Books.Where(b => b.Title.ToLower().Contains(name.ToLower()));
        }

        public BookModel? GetBookById(string id)
        {
            return Database.Books.FirstOrDefault(b => b.Id.ToString().Equals(id));
        }
    }
}
