namespace Challenge21DaysCertificate
{
    abstract class MyBook : Book, IBook
    {


        public delegate void EAddRating (object sender, EventArgs args);
        public event EAddRating AssignRating;

        public MyBook(string titleBook, string author) : base(titleBook, author)
        {
        }

        public abstract void AddRating(float grade);
        public abstract void AddRating(String grade);
        public abstract Ratings GetRatingStatistics();
        public virtual void OnAssignRating(EventArgs args)
        {
            if (AssignRating != null)
            {
                AssignRating(this, args);
            }
        }
        protected static bool Validation1to10(float grade)
        {
            if (grade >= 1 && grade <= 100)
            {
                return true;
            }
            else
            {
                throw new Exception($"Ocena ma być w granicach od 1 do 10.");
            }
        }

    }
}
