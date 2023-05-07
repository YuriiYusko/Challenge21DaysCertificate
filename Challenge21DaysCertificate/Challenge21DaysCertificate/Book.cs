namespace Challenge21DaysCertificate
{
    public class Book
    {
        public virtual string TitleBook { get; set; }
        public virtual string Author { get; set; }

        public Book(string titleBook, string author)
        {
            this.TitleBook = titleBook;
            this.Author = author;
        }
    }
}
