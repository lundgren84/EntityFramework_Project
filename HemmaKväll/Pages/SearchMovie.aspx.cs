using EntityFramework_Project;
using EntityFramework_Project.CRUDS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HemmaKväll.Pages
{
    public partial class SearchMovie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PanelSearch.Visible = false;
            fillAllMovies();
            fillDroppdown();
        }

        private void fillDroppdown()
        {
            ListItem Default = new ListItem("Default", "0");
            ListItem MovieID = new ListItem("Movie ID", "1");
            ListItem Titel = new ListItem("Titel", "2");
            DropDownList1.Items.Add(Default);
            DropDownList1.Items.Add(MovieID);
            DropDownList1.Items.Add(Titel);

            var GenreList = GetEnumList<Genre>();
            DropDownList2.Items.Add(new ListItem("Defualt","0"));
            foreach (var item in GenreList)
            {
                DropDownList2.Items.Add(new ListItem($"{item.ToString()}", $"{(int)item}"));
            }
     
        }

        private List<T> GetEnumList<T>()
        {
            var enumList = Enum.GetValues(typeof(T))
             .Cast<T>().ToList();
            return enumList;
        }

        private void fillAllMovies()
        {
            List<tbl_Movie> MovieList = CRUD_Add_Search_Member.GetAllMovies();
            StringBuilder sb = new StringBuilder();
            foreach (var item in MovieList)
            {
                if (item.Movie_Status == MovieStatus.InStore)
                {
                    sb.Append($@"    
            <div class='row'>
                <div class='col-xs-2'>ID: {item.Movie_ID}</div>
                <div class='col-xs-2'>{item.Titel}</div>
                <div class='col-xs-2'>{item.Movie_Status}</div>              
                <hr/>
            </div>");
                }
                else
                {
                    sb.Append($@"     
           <div class='row'>
                <div class='col-xs-2'> ID: {item.Movie_ID}</div>
                <div class='col-xs-2'>{item.Titel}</div>
                <div class='col-xs-2'>{item.Movie_Status}</div>
                <div class='col-xs-2'>{item.tbl_Member.LastName}. {item.tbl_Member.LastName}</div>
                <div class='col-xs-2'>{item.Return_Date}</div>
                <hr/>
            </div>");
                }

            }



            AllMovies.InnerHtml = sb.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var o = DropDownList2.SelectedValue;
            var SearchList = CRUD_Add_Search_Member.SearchOnMovies(DropDownList1.SelectedValue, DropDownList2.SelectedValue, TextBox1.Text.ToLower());
            if (SearchList != null)
            {
                PanelSearch.Visible = true;
                FillAllMovieSearchValues(SearchList);
            }
            else
            {
                PanelSearch.Visible = false;
            }
        }
        private void FillAllMovieSearchValues(List<tbl_Movie> SearchList)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in SearchList)
            {
                if (item.Movie_Status == MovieStatus.InStore)
                {
                    sb.Append($@"    
            <div class='row'>
                <div class='col-xs-2'>ID: {item.Movie_ID}</div>
                <div class='col-xs-2'>{item.Titel}</div>
                <div class='col-xs-2'>{item.Movie_Status}</div>              
                <hr/>
            </div>");
                }
                else
                {
                    sb.Append($@"     
           <div class='row'>
                <div class='col-xs-2'> ID: {item.Movie_ID}</div>
                <div class='col-xs-2'>{item.Titel}</div>
                <div class='col-xs-2'>{item.Movie_Status}</div>
                <div class='col-xs-2'>{item.tbl_Member.LastName}. {item.tbl_Member.LastName}</div>
                <div class='col-xs-2'>{item.Return_Date}</div>
                <hr/>
            </div>");
                }

            }
            SearchMovies.InnerHtml = sb.ToString();
        }
    }
}