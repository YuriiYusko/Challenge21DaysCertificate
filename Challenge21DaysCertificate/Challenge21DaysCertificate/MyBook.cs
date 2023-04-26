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
    }
}
