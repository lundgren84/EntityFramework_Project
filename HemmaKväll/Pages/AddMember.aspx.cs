using EntityFramework_Project;
using EntityFramework_Project.CRUDS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HemmaKväll.Pages
{
    public partial class AddMember : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClearTextBoxes();
            }
        }

        private void ClearTextBoxes()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            tbl_Member member = new tbl_Member();
            member.FirstName = TextBox1.Text;
            member.LastName = TextBox2.Text;
            member.PhoneNumber = TextBox3.Text;
            member.CSN = TextBox4.Text;
            CRUD_Add_Search_Member.NewMember(member);
        }
    }
}