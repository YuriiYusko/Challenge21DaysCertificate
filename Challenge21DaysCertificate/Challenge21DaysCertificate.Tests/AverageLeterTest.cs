namespace Challenge21DaysCertificate.Tests
{
    public class AverageLeterTest
    {
        [Test]
        public void AuthorAndTitel()
        {
            MyBookInMemory book = new MyBookInMemory("It","King");
            Assert.AreEqual("It", book.TitleBook);
            Assert.AreEqual("King", book.Author);
        }

        [Test]
        public void SumaMaxMin()
        {
            MyBookInMemory book = new MyBookInMemory("It", "King");
            book.AddRating(9);
            book.AddRating(5);
            book.AddRating(6);
            book.AddRating(3);
            book.AddRating(10);
            Assert.AreEqual(33, book.GetRatingStatistics().Suma);
            Assert.AreEqual(3, book.GetRatingStatistics().Min);
            Assert.AreEqual(10, book.GetRatingStatistics().Max);
        }
        [Test]
        public void AveragaAndAverageLeter()
        {
            MyBookInMemory book = new MyBookInMemory("It", "King");
            book.AddRating(9);
            book.AddRating(5);
            book.AddRating(6);
            book.AddRating(5);
            book.AddRating(10);
            var rating = book.GetRatingStatistics();
            Assert.AreEqual(7, rating.Average);
            Assert.AreEqual('B', rating.AverageLeter);
        }
    }
}