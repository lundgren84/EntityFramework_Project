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

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

            var memberlist = CRUD_Add_Search_Member.GetAllMembers();

            DropDownList1.DataSource = from i in memberlist
                                       select new ListItem
                                       {
                                           Text = i.FirstName + " " + i.LastName,
                                           Value = i.Member_ID.ToString()
                                       };
            DropDownList1.DataBind();
        }
    }
}