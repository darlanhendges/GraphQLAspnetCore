using Api.Models;

namespace Api.Interfaces.Repositories
{
    public interface IBookRepository
    {
        IEnumerable<BookModel> GetBooks();
        IEnumerable<BookModel> GetBookByName(string name);
        BookModel? GetBookById(string id);
    }
}
