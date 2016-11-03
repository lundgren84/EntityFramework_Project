using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Project.CRUDS
{
    class CRUD_UpdateMovieWithRenter
    {
        public static void UpdateMovie(tbl_Movie movie)
        {
            using (var ctx = new HemmakvällEntities())
            {
                movie.tbl_HemmaKväll = ctx.tbl_HemmaKväll.FirstOrDefault(x => x.Hemmakväll_ID == 1);
                ctx.tbl_Movie.Add(movie);

                ctx.SaveChanges();
            }
        }
    }
}
