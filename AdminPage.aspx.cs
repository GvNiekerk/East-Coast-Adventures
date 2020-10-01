using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace EastCoastAdventures
{
    public partial class AdminPage : System.Web.UI.Page
    {
        SqlConnection cnn;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] != null)
            {
                Label1.Text = "Welcome " + Session["Username"];
            }
            else
            {
                Page.Response.Redirect("LoginPage");
            }
            cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gerhard\Desktop\EastCoastAdventures\EastCoastAdventures\App_Data\bookings.mdf;Integrated Security=True");
            cnn.Open();
            string sql = "SELECT * FROM Bookings";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataAdapter Adapter = new SqlDataAdapter();
            Adapter.SelectCommand = cmd;
            DataSet ds = new DataSet();

            Adapter.Fill(ds);

            GridView1.DataSource = ds;

            GridView1.DataBind();
            cnn.Close();
        }
        
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string searchType = ddSearch.SelectedValue;
            string searchValue = txtSearch.Text;
            string sql;

            if (searchValue.ToLower() == "all")
            {
                sql = "SELECT * FROM Bookings";
            }
            else
            {
                sql = "SELECT * FROM Bookings WHERE " + searchType + " LIKE '%" + searchValue + "%'";
            }

            cnn.Open();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataAdapter Adapter = new SqlDataAdapter();
            Adapter.SelectCommand = cmd;
            DataSet ds = new DataSet();
            Adapter.Fill(ds);


            GridView1.DataSource = ds;
            GridView1.DataBind();

            cnn.Close();
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["Username"] = null;
            Page.Response.Redirect("LoginPage");
        }

        protected void btnThousand_Click(object sender, EventArgs e)
        {
            string searchType = ddSearch.SelectedValue;
            string searchValue = txtSearch.Text;

            cnn.Open();
            string sql = "SELECT * FROM Bookings WHERE Price > 1000";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataAdapter Adapter = new SqlDataAdapter();
            Adapter.SelectCommand = cmd;
            DataSet ds = new DataSet();
            Adapter.Fill(ds);


            GridView1.DataSource = ds;
            GridView1.DataBind();

            cnn.Close();
        }

        protected void btnFive_Click(object sender, EventArgs e)
        {

            cnn.Open();
            string sql = "SELECT * FROM Bookings WHERE Amount > 4";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataAdapter Adapter = new SqlDataAdapter();
            Adapter.SelectCommand = cmd;
            DataSet ds = new DataSet();
            Adapter.Fill(ds);


            GridView1.DataSource = ds;
            GridView1.DataBind();

            cnn.Close();
        }

        protected void btnOnePerson_Click(object sender, EventArgs e)
        {
            cnn.Open();
            string sql = "SELECT * FROM Bookings WHERE Amount = 1";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataAdapter Adapter = new SqlDataAdapter();
            Adapter.SelectCommand = cmd;
            DataSet ds = new DataSet();
            Adapter.Fill(ds);


            GridView1.DataSource = ds;
            GridView1.DataBind();

            cnn.Close();
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            string index = btnDelete.Attributes["data-id"];
            cnn.Open();
            string sql = "UPDATE Bookings SET " + ddField.SelectedValue + " = '" + txtNewValue.Text + "' WHERE id = " + index;
            sql += "SELECT * FROM bookings";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataAdapter Adapter = new SqlDataAdapter();
            Adapter.SelectCommand = cmd;
            DataSet ds = new DataSet();
            Adapter.Fill(ds);

            btnEdit.Visible = false;
            btnDelete.Visible = false;
            ddField.Visible = false;
            txtNewValue.Visible = false;
            GridView1.DataSource = ds;
            GridView1.DataBind();

            cnn.Close();
        }


        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string index = btnDelete.Attributes["data-id"];
            cnn.Open();
            string sql = "DELETE FROM Bookings WHERE id = " + index + " ";
            sql += "SELECT * FROM bookings";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataAdapter Adapter = new SqlDataAdapter();
            Adapter.SelectCommand = cmd;
            DataSet ds = new DataSet();
            Adapter.Fill(ds);

            btnDelete.Visible = false;
            btnEdit.Visible = false;
            ddField.Visible = false;
            txtNewValue.Visible = false;
            GridView1.DataSource = ds;
            GridView1.DataBind();

            cnn.Close();
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(GridView1, "Select$" + e.Row.RowIndex);
                e.Row.ToolTip = "Click to select this row.";
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRowId = "-1";
            foreach (GridViewRow row in GridView1.Rows)
            {
                if (row.RowIndex == GridView1.SelectedIndex)
                {
                    selectedRowId = row.Cells[0].Text;
                    row.BackColor = ColorTranslator.FromHtml("#A1DCF2");
                    row.ToolTip = string.Empty;                                 
                }
                else
                {
                    row.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                    row.ToolTip = "Click to select this row.";
                }
            }
            ddField.Visible = true;
            txtNewValue.Visible = true;
            btnDelete.Visible = true;
            btnDelete.Attributes["data-id"] = selectedRowId;
            btnEdit.Visible = true;
            btnEdit.Attributes["data-id"] = selectedRowId;
        }
    }
}