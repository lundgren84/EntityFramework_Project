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
    public partial class SearchMember : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            fillAllMembers();
        }

        private void fillAllMembers()
        {
            List<tbl_Member> MembersList = CRUD_Add_Search_Member.GetAllMembers();
            StringBuilder sb = new StringBuilder();


            sb.Append($@"     <div class='row'>
                < div class='col-xs-1'></div>
                <div class='col-xs-1'></div>
                <div class='col-xs-1'></div>
            </div>");

            AllMembers.InnerHtml = "";
        }
    }
}