
namespace Challenge21DaysCertificate
{
    internal interface IBook
    {
        string TitleBook { get; set; }
        string Author { get; set; }

        public void AddRating(float grade);
        public void AddRating(string grade);
        public Ratings GetRatingStatistics();
    }
}
