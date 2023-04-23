using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge21DaysCertificate
{
    internal class MyBookInMemory : MyBook, IBook
    {
        //Variables
        private List<float> ratings;

        public MyBookInMemory(string titleBook, string author) : base(titleBook, author)
        {
            ratings = new List<float>();
        }

        public override void AddRating(float rating)
        {
            if (Validation1to10(rating))
            {
                this.ratings.Add(rating);
                OnAssignRating(new EventArgs());
            }
        }

        public override void AddRating(string rating)
        {
            if (float.TryParse(rating, out float result))
            {
                if (Validation1to10(result)) { AddRating(rating); }
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
