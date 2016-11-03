using EntityFramework_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HemmaKväll.Pages
{
    public partial class RentAndReturn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TextBox1.Text = "3";
                TextBox3.Text = "2";
            }
            
        }

        protected void rent_Movie_Click(object sender, EventArgs e)
        {
            ActuallyRentTheFuckingMovie();
            TextBox1.Text = "";
            TextBox2.Text = "";
        }

        protected void return_Movie_Click(object sender, EventArgs e)
        {

        }
        protected void ActuallyRentTheFuckingMovie()
        {
            using (var ctx = new HemmakvällEntities())
            {
                tbl_Member member = ctx.tbl_Member.Where(x => x.CSN == TextBox2.Text).FirstOrDefault();
                if (member != null)
                {
                    tbl_Movie movie = ctx.tbl_Movie.Where(x => x.Movie_ID == int.Parse(TextBox1.Text)).FirstOrDefault();
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
                    }

                }




            }
        }
        protected void ReturnTheFuckingMovie()
        {
            using (var ctx = new HemmakvällEntities())
            {
                var movie = ctx.tbl_Movie.Where(x => x.Movie_ID == int.Parse(TextBox3.Text)).FirstOrDefault();
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