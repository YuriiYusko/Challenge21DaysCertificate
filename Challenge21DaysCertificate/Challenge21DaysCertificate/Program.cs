﻿using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;

namespace Challenge21DaysCertificate
{
    class Start
    {
        private static string titleBook = "";
        private static string author = "";

        private static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;


            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("+-------------------Books-Ratings-Console-App--------------------+");
                Console.WriteLine("| Skończyłeś czytać kolejną książkę ? Teraz czas na twoją ocenę. |");
                Console.WriteLine("|                                                                |");
                Console.WriteLine("|       Chcesz, że by dane były zapisane do pliku .txt ?         |");
                Console.WriteLine("|                   Y/y - Tak       N/n - Nie                    |");
                Console.WriteLine("|                             -   -                              |");
                Console.WriteLine("|                                                                |");
                Console.WriteLine("|                                                                |");
                Console.WriteLine("|                                                                |");
                Console.WriteLine("+----------------------------------------------------------------+");

                Console.SetCursorPosition(32, 5);
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
                        break;

                    case "E":
                    case "e":
                        exit = true;
                        break;
                }
                Console.SetCursorPosition(0, 0);
                Console.Clear();
            }
        }

        private static void InFile()
        {
            GetAuthorAndTitle();
            if (!string.IsNullOrEmpty(titleBook) && !string.IsNullOrEmpty(author))
            {
                Console.WriteLine($"{titleBook} {author}");
            }
        }

        private static void InMemory()
        {
            GetAuthorAndTitle();
            if (!string.IsNullOrEmpty(titleBook) && !string.IsNullOrEmpty(author))
            {
                var MyBookInMemory = new MyBookInMemory(titleBook, author);
                Console.SetCursorPosition(2, 3);
                ColorOutput(ConsoleColor.Green, "          1.Fabuła - nie ma bez niej dobrej powieści          \n");
                Console.WriteLine             ("|                    Twoja ocena od 1 do 10:                     |");
                Console.WriteLine             ("|                                                                |");
                Console.ReadLine();
            }
        }

        private static void GetAuthorAndTitle()
        {
            titleBook = "";
            author = "";
            int caunt = 0;

            Console.SetCursorPosition(2, 3);
            ColorOutput(ConsoleColor.Green, "     Ok. Zaczynamy ocenę, postępuj zgodnie z komunikatami:    \n");
            Console.WriteLine("|                                                                |");
            Console.WriteLine("|                                                                |");
            Console.SetCursorPosition(2, 5);
            Console.Write("Wpisz nazwę książki: ");
            Console.SetCursorPosition(2, 8);
            ColorOutput(ConsoleColor.Yellow, "Dla potwierdzenia naciśnij Enter:");
            bool chaekTitle = true;
            while (chaekTitle)
            {
                Console.SetCursorPosition(23, 5);
                titleBook = Console.ReadLine();
                if (titleBook != "")
                {
                    chaekTitle = false;
                }
                else
                {
                    Console.SetCursorPosition(2, 4);
                    ColorOutput(ConsoleColor.Red, $"       Pole nie może zostać puste. Spróbuj jeszcze raz.       ");
                    Console.SetCursorPosition(23, 5);
                }
            }
            Console.SetCursorPosition(0, 4);
            Console.Write("|                                                                |");
           
            Console.SetCursorPosition(0, 5);
            Console.Write("|                                                                |");
            Console.SetCursorPosition(2, 5);
            Console.Write("Wpisz autora książki: ");

            bool chaekAuthor = true;
            while (chaekAuthor)
            {
                Console.SetCursorPosition(24, 5);
                author = Console.ReadLine();
                if (author != "")
                {
                    chaekAuthor = false;
                }
                else
                {
                    Console.SetCursorPosition(2, 4);
                    ColorOutput(ConsoleColor.Red, $"       Pole nie może zostać puste. Spróbuj jeszcze raz.       ");
                    Console.SetCursorPosition(24, 5);
                }
            }
        }

        private static string GetIn(string inp)
        {
            Console.Write(inp);
            return Console.ReadLine();
        }

        private static void ColorOutput(ConsoleColor color, string text)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ResetColor();

        }
    }
}

