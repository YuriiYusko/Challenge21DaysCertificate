namespace Challenge21DaysCertificate
{
    public class MyBookInMemory : MyBook, IBook
    {
        private List<float> ratings;

        public MyBookInMemory(string titleBook, string author) : base(titleBook, author)
        {
            ratings = new List<float>();
        }

        public override void AddRating(float rating)
        {
            this.ratings.Add(rating);
            OnAssignRating();
        }

        public override void AddRating(string rating)
        {
            if (float.TryParse(rating, out float result))
            {
                AddRating(result);
            }
        }

        public override Ratings GetRatingStatistics()
        {
            var ratings = new Ratings();
            foreach (var grade in this.ratings)
            {
                ratings.AddRating(grade);
            }
            return ratings;
        }

    }
}
