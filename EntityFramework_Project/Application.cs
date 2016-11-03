using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EntityFramework_Project
{
    public class Application
    {
        public void Menu()
        {
            while (true)
            {
                Console.WriteLine(@"Hemmakväll
1. Add new movie
2. Register new member
3. OutRent movie
4. Mark move reseved
");
                ConsoleKeyInfo key;
                key = Console.ReadKey(true);
                switch (key.KeyChar)
                {
                    case '1':
                        AddMovie();
                        break;
                    case '2':
                        AddMember();
                        break;
                    case '3':
                        OutRentMovie();
                        break;
                    case '4':
                        ReceveMovie();
                        break;
                    default:
                        break;
                }
                Console.Clear();
            }
        }

        private void ReceveMovie()
        {
            Console.WriteLine("Enter Movie ID");
            int movieID = int.Parse(Console.ReadLine());
            CRUD.ReturnedMovie(movieID);
        }

        private void OutRentMovie()
        {
            Console.WriteLine("Enter members SSN");
            string ssn = Console.ReadLine();
            Console.WriteLine("Enter Movie ID");
            int movieID = int.Parse(Console.ReadLine());
            var DateToReturn = CRUD.OutRentMovie(ssn, movieID);
            if (DateToReturn.Year == DateTime.Now.Year)
            {
                Console.WriteLine("Inform member to return movie before " + DateToReturn.ToString());
                Console.WriteLine("Press a key. . .");Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Something whent wrong!");
                Console.WriteLine("Press a key. . ."); Console.ReadKey();
            }

        }

        private void AddMember()
        {
            tbl_Member member = new tbl_Member();
            Console.WriteLine("Enter Firstname");
            member.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Lastname");
            member.LastName = Console.ReadLine();
            Console.WriteLine("Enter phone number");
            int number;
            int.TryParse(Console.ReadLine(), out number);
            member.PhoneNumber = number.ToString();
            Console.WriteLine("Enter social security number(10 numbers)");
            member.CSN = Console.ReadLine();
            member.Status = MemberStatus.Open;
            CRUD.NewMember(member);
        }

        private void AddMovie()
        {
            tbl_Movie movie = new tbl_Movie();
            Console.WriteLine("Enter titel");
            movie.Titel = Console.ReadLine();
            Console.WriteLine("");
            movie.Genre = GetGenre();
            Console.WriteLine("Enter movie length in minutes");
            int length;
            int.TryParse(Console.ReadLine(), out length);
            movie.Length = length.ToString();
            movie.Movie_Status = MovieStatus.InStore;
            CRUD.NewMovie(movie);
        }

        private Genre? GetGenre()
        {
            Genre genre = new Genre();
            Console.WriteLine("Choice Genre and Press Enter");
            var enums = GetEnumList<Genre>();
            foreach (var item in enums)
            {
                Console.WriteLine((int)item + ". " + item);
            }

            int nr;
            int.TryParse(Console.ReadLine(), out nr);
            foreach (var item in enums)
            {
                if ((nr == (int)item))
                {
                    genre = item;
                    break;
                }
            }
            return genre;

        }
        private static List<T> GetEnumList<T>()
        {
            var enumList = Enum.GetValues(typeof(T))
                .Cast<T>().ToList();
            return enumList;
        }
    }
}
