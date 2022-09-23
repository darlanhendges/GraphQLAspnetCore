using Api.Models;
using RandomNameGenerator;

namespace Api.Configurations
{
    public static class Database
    {
        public static List<AuthorModel> Authors { get; set; } = new();
        public static List<BookModel> Books { get; set; } = new();

        public static void Initialize()
        {
            for (int i = 0; i < 11; i++)
            {
                var author = new AuthorModel() { Name = $"{NameGenerator.Generate(Gender.Male)}" };
                Authors.Add(author);

                for (int j = 0; j < 3; j++)
                {
                    var book = new BookModel() { Author = author, Title = NameGenerator.Generate(Gender.Female) };
                    Books.Add(book);
                }
            }
        }
    }
}
