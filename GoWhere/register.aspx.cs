using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Register_Click(object sender, EventArgs e)
    {
        int row = 0; String sql="";
        OleDbConnection con = new OleDbConnection();
        // establish connection  
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("/GoWhere/App_Data/Database.mdb");
        con.Open(); // connection open
        
        sql = "SELECT COUNT(*) from Tourist WHERE user='" + registerUser.Text + "'";
        OleDbCommand cmd = new OleDbCommand(sql, con);
        row = (int)cmd.ExecuteScalar(); // cast into integer and ExecuteScalar() get single value from database.
        if (row > 0)
        {
            Label2.Text = "Username already in use.";
        }

        else {
            cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO Tourist ([user], [pass], [last_name], [first_name], [email], [country]) VALUES(@user, @pass, @lName, @fName, @email, @country);";
            cmd.Parameters.AddWithValue("@user", registerUser.Text);
            cmd.Parameters.AddWithValue("@pass", registerPwd.Text);
            cmd.Parameters.AddWithValue("@lName", registerLName.Text);
            cmd.Parameters.AddWithValue("@fName", registerFName.Text);
            cmd.Parameters.AddWithValue("@email", registerEmail.Text);
            cmd.Parameters.AddWithValue("@country", registerCountry.Text);
            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO Tour_Guide ([user], [pass], [last_name], [first_name], [email], [country]) VALUES(@user, @pass, @lName, @fName, @email, @country);";
            cmd.Parameters.AddWithValue("@user", registerUser.Text);
            cmd.Parameters.AddWithValue("@pass", registerPwd.Text);
            cmd.Parameters.AddWithValue("@lName", registerLName.Text);
            cmd.Parameters.AddWithValue("@fName", registerFName.Text);
            cmd.Parameters.AddWithValue("@email", registerEmail.Text);
            cmd.Parameters.AddWithValue("@country", registerCountry.Text);
            cmd.ExecuteNonQuery();

            Response.Redirect("regSubmit.aspx");
        }
    }
}