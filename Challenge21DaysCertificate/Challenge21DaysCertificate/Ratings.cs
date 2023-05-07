namespace Challenge21DaysCertificate
{
    public class Ratings
    {
        private List<float> ratings;
        public float Min { get; private set; }
        public float Max { get; private set; }
        public float Suma { get; private set; }
        public float Count { get; private set; }
        public float Average
        {
            get
            {
                return this.Suma / this.Count;
            }
        }
        public char AverageLeter
        {
            get
            {
                switch (this.Suma)
                {
                    case var average when average >= 40:
                        return 'A';
                    case var average when average >= 30:
                        return 'B';
                    case var average when average >= 20:
                        return 'C';
                    case var average when average >= 10:
                        return 'D';
                    default:
                        return 'E';
                }
            }
        }
        
        public Ratings()
        {
            ratings = new List<float>();
            this.Min = float.MaxValue;
            this.Max = float.MinValue;
            this.Suma = 0;
            this.Count = 0;
        }
        
        public void AddRating(float grade)
        {
            this.Count++;
            this.Suma += grade;
            this.Min = Math.Min(this.Min, grade);
            this.Max = Math.Max(this.Max, grade);
            ratings.Add(grade);
        }

        public void ShowStatistics(MyBook book)
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("+-------------------Books-Ratings-Console-App--------------------+");
            Console.WriteLine("|                                                                |");
            Console.WriteLine("|                                                                |");
            Console.WriteLine("|                                                                |");
            Console.WriteLine("|                                                                |");
            Console.WriteLine("|                                                                |");
            Console.WriteLine("|                                                                |");
            Console.WriteLine("|                                                                |");
            Console.WriteLine("|                                                                |");
            Console.WriteLine("|                                                                |");
            Console.WriteLine("+----------------- Enter - ponownie uruchomić. ------------------+");
            Console.SetCursorPosition(2, 1);
            Console.Write($"Nazwa - {book.TitleBook}");
            Console.SetCursorPosition(2, 2);
            Console.Write($"Author - {book.Author}");
            Console.SetCursorPosition(44, 1);
            Console.Write($"1.Fabuła         - {ratings[0]}");
            Console.SetCursorPosition(44, 3);
            Console.Write($"2.Bohaterowie    - {ratings[1]}");
            Console.SetCursorPosition(44, 5);
            Console.Write($"3.Narracja       - {ratings[2]}");
            Console.SetCursorPosition(44, 7);
            Console.Write($"4.Emocje         - {ratings[3]}");
            Console.SetCursorPosition(44, 9);
            Console.Write($"5.Kreacja świata - {ratings[4]}");
            Console.SetCursorPosition(2, 4);
            Console.Write($"Największa ocena  - {Max}");
            Console.SetCursorPosition(2, 5);
            Console.Write($"Najmniejsza ocena - {Min}");
            Console.SetCursorPosition(2, 6);
            Console.Write($"Średnia ocena  - {Average}");
            Console.SetCursorPosition(2, 8);
            Console.Write($"Twoja ocena to: -= {AverageLeter} =-");
            Console.ReadLine();
        }
    }
}
