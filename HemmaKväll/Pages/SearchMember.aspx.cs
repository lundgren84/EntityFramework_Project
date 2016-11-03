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
            fillDroppdown();
        }

        private void fillDroppdown()
        {
           //DropDownList1.DataSource
        }

        private void fillAllMembers()
        {
            List<tbl_Member> MembersList = CRUD_Add_Search_Member.GetAllMembers();
            StringBuilder sb = new StringBuilder();
            foreach (var item in MembersList)
            {
                sb.Append($@"     <div class='row'>
                <div class='col-xs-2'>ID: {item.Member_ID}</div>
                <div class='col-xs-2'>{item.LastName}. {item.FirstName}</div>
                <div class='col-xs-2'>SSN: {item.CSN}</div>
                <div class='col-xs-2'>Phone: {item.PhoneNumber}</div>
                <hr/>
            </div>");
            }

        

            AllMembers.InnerHtml = sb.ToString();
        }
    }
}