using System.Diagnostics;

namespace Challenge21DaysCertificate
{
    public class MyBookInFile : MyBook, IBook
    {
        public MyBookInFile(string titleBook, string author) : base(titleBook, author)
        {
            File.WriteAllText($"{TitleBook}_{Author}.txt", string.Empty);
        }

        public override void AddRating(float rating)
        {
            using (var writer = File.AppendText($"{TitleBook}_{Author}.txt"))
            {
                writer.WriteLine(rating);
            }
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

            if (File.Exists($"{TitleBook}_{Author}.txt"))
            {
                using (var reader = File.OpenText($"{TitleBook}_{Author}.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        ratings.AddRating(float.Parse(line));
                    }
                }
            }
            return ratings;
        }
    }
}
