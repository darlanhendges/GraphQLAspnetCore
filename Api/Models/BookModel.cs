namespace Api.Models
{
    public class BookModel : BaseModel
    {
        public string Title { get; set; } = null!;

        public AuthorModel Author { get; set; } = null!;
    }

}
