using EntityFramework_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityFramework_Project.CRUDS;


namespace HemmaKväll.Pages
{
    public partial class RemoveMember : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                   FillTheDropdown();
        }
        protected void FillTheDropdown()
        {
            var memberlist = CRUD_Add_Search_Member.GetAllMembers();

            DropDownList1.DataSource = from i in memberlist
                                       select new ListItem
                                       (
                                           (i.FirstName + " " + i.LastName),
                                           i.Member_ID.ToString()
                                       );
            DropDownList1.DataBind();
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

         
        }

        protected void remove_button_Click(object sender, EventArgs e)
        {
            string temp = DropDownList1.SelectedValue;;

            TextBox1.Text = CRUD_RemoveMember.RemoveMember(temp);
            
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}