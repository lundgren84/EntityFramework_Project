using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityFramework_Project.CRUDS;

namespace HemmaKväll.Pages
{
    public partial class RemoveMovie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var movies = CRUD_AddRemoveMovies.GetAllMovies();

                /*movieDropDown.DataSource = from i in movies
                                           select new ListItem
                                      (
                                          i.Titel,
                                          i.Movie_ID.ToString()
                                      );
                movieDropDown.DataBind();*/

                foreach (var movie in movies)
                {
                    movieDropDown.Items.Add(new ListItem(movie.Titel, movie.Movie_ID.ToString()));
                }
            }
        }

        protected void RemoveBtn_OnClick(object sender, EventArgs e)
        {
            CRUD_AddRemoveMovies.RemoveMovie(int.Parse(movieDropDown.SelectedValue));
            Response.Redirect("../Default.aspx");
        }
    }
}