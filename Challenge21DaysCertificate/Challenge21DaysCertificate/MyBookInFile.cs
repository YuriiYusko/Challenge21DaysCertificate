namespace Challenge21DaysCertificate
{
    public class MyBookInFile : MyBook, IBook
    {
        private List<float> ratings;

        public MyBookInFile(string titleBook, string author) : base(titleBook, author)
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
            SaveInFile();
            return ratings;
        }

        public void SaveInFile()
        {
            using (var writer = File.AppendText($"{TitleBook}_{Author}.txt"))
            {
                writer.WriteLine($"Nazwa - {TitleBook}");
                writer.WriteLine($"Author - {Author}");
                writer.WriteLine($"1.Fabuła         - {ratings[0]}");
                writer.WriteLine($"2.Bohaterowie    - {ratings[1]}");
                writer.WriteLine($"3.Narracja       - {ratings[2]}");
                writer.WriteLine($"4.Emocje         - {ratings[3]}");
                writer.WriteLine($"5.Kreacja świata - {ratings[4]}");
                writer.WriteLine($"{DateTime.UtcNow}");
                writer.WriteLine($"");
            }
        }
    }
}
