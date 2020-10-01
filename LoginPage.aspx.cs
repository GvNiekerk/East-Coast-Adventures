using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EastCoastAdventures
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                HttpCookie _userInfoCookie = Request.Cookies["UserInfo"];
                TextBox1.Text = _userInfoCookie["Username"];
            }
            catch (Exception)
            {
            }
        }
        string username = "Hanno1998";
        string password = "mieliestronk";

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == username && TextBox2.Text == password)
            {
                Session["Username"] = TextBox1.Text;
                HttpCookie _userInfoCookie = new HttpCookie("UserInfo");
                _userInfoCookie["Username"] = TextBox1.Text;
                _userInfoCookie.Expires = DateTime.Now.AddDays(2);
                Response.Cookies.Add(_userInfoCookie);
                Page.Response.Redirect("AdminPage");
                
            }
        }
    }
}