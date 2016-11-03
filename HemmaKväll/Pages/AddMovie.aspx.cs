using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityFramework_Project;
using EntityFramework_Project.CRUDS;

namespace HemmaKväll.Pages
{
    public partial class AddMovie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var genres = Enum.GetValues(typeof (Genre));
                foreach (var genre in genres)
                {
                    genreDropDown.Items.Add(new ListItem(genre.ToString(), ((int)genre).ToString()));
                }
            }
        }

        protected void AddBtn_OnClick(object sender, EventArgs e)
        {
            var movie = new tbl_Movie();
            movie.Titel = titleTxtBox.Text;
            movie.Genre = (Genre?) int.Parse(genreDropDown.Items[genreDropDown.SelectedIndex].Value);
            movie.Length = lengthTxtBox.Text;
            movie.Movie_Status = MovieStatus.InStore;

            CRUD_AddRemoveMovies.AddMovie(movie);

            Response.Redirect("../default.aspx");
        }
    }
}