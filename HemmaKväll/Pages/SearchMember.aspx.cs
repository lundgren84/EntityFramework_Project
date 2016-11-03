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
            if(!IsPostBack)
            {
                PanelSearch.Visible = false;
                fillAllMembers();
                fillDroppdown();
            }
    
        }

        private void fillDroppdown()
        {
            ListItem FistName = new ListItem("FistName", "1");
            ListItem LastName = new ListItem("LastName", "2");
            ListItem ID = new ListItem("ID", "3");
            ListItem SSN = new ListItem("SSN", "4");
            ListItem Phone = new ListItem("Phone", "5");


            DropDownList1.Items.Add(FistName);
            DropDownList1.Items.Add(LastName);
            DropDownList1.Items.Add(ID);
            DropDownList1.Items.Add(SSN);
            DropDownList1.Items.Add(Phone);

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

        protected void Button1_Click(object sender, EventArgs e)
        {
          var SearchList =  CRUD_Add_Search_Member.SearchOnMember(DropDownList1.SelectedValue,TextBox1.Text.ToLower());
            if(SearchList != null)
            {
                PanelSearch.Visible = true;
                FillAllMembersSearchValues(SearchList);
            }
            else
            {
                PanelSearch.Visible = false;
            }
        }

        private void FillAllMembersSearchValues(List<tbl_Member> SearchList)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in SearchList)
            {
                sb.Append($@"     <div class='row'>
                <div class='col-xs-2'>ID: {item.Member_ID}</div>
                <div class='col-xs-2'>{item.LastName}. {item.FirstName}</div>
                <div class='col-xs-2'>SSN: {item.CSN}</div>
                <div class='col-xs-2'>Phone: {item.PhoneNumber}</div>
                <hr/>
            </div>");
            }
            SearchMembers.InnerHtml = sb.ToString();
        }
    }
}