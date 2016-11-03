using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Project
{
    public class CRUD
    {
        internal static void NewMovie(tbl_Movie movie)
        {
            using (var ctx = new HemmakvällEntities())
            {
                movie.tbl_HemmaKväll = ctx.tbl_HemmaKväll.Where(x => x.Hemmakväll_ID == 1).FirstOrDefault();
                ctx.tbl_Movie.Add(movie);

                ctx.SaveChanges();
            }
        }

        internal static void NewMember(tbl_Member member)
        {
            using (var ctx = new HemmakvällEntities())
            {
                member.tbl_HemmaKväll = ctx.tbl_HemmaKväll.Where(x => x.Hemmakväll_ID == 1).FirstOrDefault();
                ctx.tbl_Member.Add(member);
                ctx.SaveChanges();
            }
        }

        internal static DateTime OutRentMovie(string ssn, int movieID)
        {
            using (var ctx = new HemmakvällEntities())
            {
                tbl_Member member = ctx.tbl_Member.Where(x => x.CSN == ssn).FirstOrDefault();
                if (member != null)
                {
                    tbl_Movie movie = ctx.tbl_Movie.Where(x => x.Movie_ID == movieID).FirstOrDefault();
                    if (movie.Movie_Status == MovieStatus.InStore)
                    {
                        int year = DateTime.Now.Year;
                        int mounth = DateTime.Now.Month;
                        int day = DateTime.Now.Day;
                        DateTime date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 7, 18, 0, 0);
                        movie.Return_Date = date;

                        movie.tbl_Member = member;
                        movie.Movie_Status = MovieStatus.Rented;
                        ctx.SaveChanges();
                        return (DateTime)movie.Return_Date;
                    }

                }
              
                    return new DateTime();
                

            }
        }

        internal static void ReturnedMovie(int movieID)
        {
            using (var ctx = new HemmakvällEntities())
            {
                var movie = ctx.tbl_Movie.Where(x => x.Movie_ID == movieID).FirstOrDefault();
                if (movie != null)
                {
                    movie.tbl_Member = null;
                    movie.Movie_Status = MovieStatus.InStore;
                    ctx.SaveChanges();
                }
            }
        }
    }
}
