using System.Text;
using System.Xml.Linq;

namespace Challenge21DaysCertificate
{
    class Start
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;


            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("------------------Books-Ratings-Console-App-------------------");
                Console.WriteLine("Skończyłeś czytać kolejną książkę ? Teraz czas na twoją ocenę.");
                Console.WriteLine();
                Console.WriteLine("       Chcesz, że by dane były zapisane do pliku .txt ?       ");
                Console.WriteLine("                     Y - Tak  //  N - Nie                     ");
                //WritelineColor(ConsoleColor.Cyan,
                //    "1 - Add student's grades to the program memory and show statistics\n" +
                //    "2 - Add student's grades to the .txt file and show statistics\n" +
                //    "X - Close app\n");

                //WritelineColor(ConsoleColor.Yellow, "What you want to do? \nPress key 1, 2 or X: ");

                var input = Console.ReadLine();

                switch (input)
                {
                    case "N":
                    case "n":
                        InMemory();
                        break;

                    case "Y":
                    case "y":
                        InFile();
                        Console.WriteLine("_Y_");
                        break;

                    case "E":
                    case "e":
                        exit = true;
                        break;
                    default:
                        //WritelineColor(ConsoleColor.Red, "Invalid operation.\n");
                        continue;
                }
            }
        }

        private static void InFile()
        {
            string titleBook = GetIn("Wpisz nazwę książki: ");
            string author = GetIn("Wpisz autora książki: ");
            if (!string.IsNullOrEmpty(titleBook) && !string.IsNullOrEmpty(author))
            {
                Console.WriteLine($"{titleBook} {author}");
            }
        }

        private static void InMemory()
        {
            string titleBook = GetIn("Wpisz nazwę książki: ");
            string author = GetIn("Wpisz autora książki: ");
            if (!string.IsNullOrEmpty(titleBook) && !string.IsNullOrEmpty(author))
            {
                Console.WriteLine($"{titleBook} {author}");
            }
        }

        private static string GetIn(string inp)
        {
            Console.Write(inp);
            return Console.ReadLine();
        }
    }
}

