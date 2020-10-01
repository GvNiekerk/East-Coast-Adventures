using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace EastCoastAdventures
{
    public partial class HomePage : System.Web.UI.Page
    {
        int amount;
        string name, surname, adventure, time, cellnr;
        DateTime date;
        float price;
        SqlConnection cnn;
        const float quad = 200;
        const float horse = 250;
        const float jet = 300;
        const float kite = 400;
        const float scuba = 600;
        const float shark = 800;
        const float snorkle = 150;
        const float boat = 200;

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            rbHorse.Checked = false;
            rbJet.Checked = false;
            rbKite.Checked = false;
            rbScuba.Checked = false;
            rbShark.Checked = false;
            rbSnorkle.Checked = false;
            rbBoat.Checked = false;

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("LoginPage");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gerhard\Desktop\EastCoastAdventures\EastCoastAdventures\App_Data\bookings.mdf;Integrated Security=True");
        }


        protected void Button2_Click(object sender, EventArgs e)
        {
            name = txtName.Text;
            surname = txtSurname.Text;
            cellnr = txtCell.Text;
            amount = Convert.ToInt32(DropDownList1.SelectedValue);
            date = Calendar1.SelectedDate;
            time = DropDownList2.SelectedValue;

            if (rbBoat.Checked)
            {
                adventure = rbBoat.Text;
                price = amount * boat;
            }
            if (rbHorse.Checked)
            {
                adventure = rbHorse.Text;
                price = amount * horse;
            }
            if (rbJet.Checked)
            {
                adventure = rbJet.Text;
                price = amount * jet;
            }
            if (rbKite.Checked)
            {
                adventure = rbKite.Text;
                price = amount * kite;
            }
            if (rbQuad.Checked)
            {
                adventure = rbQuad.Text;
                price = amount * quad;
            }
            if (rbScuba.Checked)
            {
                adventure = rbScuba.Text;
                price = amount * scuba;
            }
            if (rbShark.Checked)
            {
                adventure = rbShark.Text;
                price = amount * shark;
            }
            if (rbSnorkle.Checked)
            {
                adventure = rbSnorkle.Text;
                price = amount * snorkle;
            }

            if (amount >= 5)
                price = price * 0.7f;

            Label12.Visible = true;
            cnn.Open();
            string sql = "INSERT INTO Bookings VALUES('"+name+ "','" + surname + "','" + cellnr + "','" + adventure + "'," + amount + ",'" + date.ToShortDateString() + "','" + time + "'," + price + ")";
            SqlCommand cmd = new SqlCommand(sql, cnn);

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.InsertCommand = cmd;
            adapter.InsertCommand.ExecuteNonQuery();

            cnn.Close();
            ListBox1.Items.Clear();
            txtName.Text = "";
            txtSurname.Text = "";
            txtCell.Text = "";

            rbQuad.Checked = false;
            rbHorse.Checked = false;
            rbJet.Checked = false;
            rbKite.Checked = false;
            rbScuba.Checked = false;
            rbShark.Checked = false;
            rbSnorkle.Checked = false;
            rbBoat.Checked = false;

            Button2.Visible = false;
            Label11.Visible = false;
            ListBox1.Visible = false;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text))
            {
                Response.Write("<script>alert('Please enter your name');</script>");
                return;
            }
            if (String.IsNullOrEmpty(txtSurname.Text))
            {
                Response.Write("<script>alert('Please enter your surname');</script>");
                return;
            }
            if (String.IsNullOrEmpty(txtCell.Text))
            {
                Response.Write("<script>alert('Please enter your Cellphone Number');</script>");
                return;
            }

            Label12.Visible = false;
            Label11.Visible = true;
            cellnr = txtCell.Text;
            name = txtName.Text;
            surname = txtSurname.Text;
            amount = Convert.ToInt32(DropDownList1.SelectedValue);

            if (rbBoat.Checked)
            {
                adventure = rbBoat.Text;
                price = amount * boat;
            }
            if (rbHorse.Checked)
            {
                adventure = rbHorse.Text;
                price = amount * horse;
            }
            if (rbJet.Checked)
            {
                adventure = rbJet.Text;
                price = amount * jet;
            }
            if (rbKite.Checked)
            {
                adventure = rbKite.Text;
                price = amount * kite;
            }
            if (rbQuad.Checked)
            {
                adventure = rbQuad.Text;
                price = amount * quad;
            }
            if (rbScuba.Checked)
            {
                adventure = rbScuba.Text;
                price = amount * scuba;
            }
            if (rbShark.Checked)
            {
                adventure = rbShark.Text;
                price = amount * shark;
            }
            if (rbSnorkle.Checked)
            {
                adventure = rbSnorkle.Text;
                price = amount * snorkle;
            }

            if (amount >= 5)
                price = price * 0.7f;

            date = Calendar1.SelectedDate;
            time = DropDownList2.SelectedItem.ToString();

            ListBox1.Items.Add("Thanks for your booking " + name + " " + surname);
            ListBox1.Items.Add("You have booked a "+ adventure +" adventure for "+ amount + " People");
            ListBox1.Items.Add("Date and time for adventure: " + date.ToShortDateString() + " " + time);
            ListBox1.Items.Add("Total Price: R"+ price);


            ListBox1.Visible = true;
            Button2.Visible = true;
        }
    }
}