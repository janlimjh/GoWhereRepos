using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class suspendUA : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Suspend_Click(object sender, EventArgs e)
    {
        string sql = ""; int row = 0;
        OleDbConnection con = new OleDbConnection();

        // establish connection  
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("/GoWhere/App_Data/Database.mdb");
        con.Open(); // connection open 

        sql = "SELECT COUNT(*) FROM Tour_Guide WHERE user='" + suspendUser.Text + "'";
        OleDbCommand cmd = new OleDbCommand(sql, con);
        row = (int)cmd.ExecuteScalar(); // cast into integer and ExecuteScalar() get single value from database.
        if (row > 0)
        {
            sql = "UPDATE Tour_Guide SET [suspended]=? WHERE user=?";
            cmd = new OleDbCommand(sql, con);
            cmd.Parameters.AddWithValue("?", true);
            cmd.Parameters.AddWithValue("?", suspendUser.Text);
            cmd.ExecuteNonQuery();

            sql = "UPDATE Tourist SET [suspended]=? WHERE user=?";
            cmd = new OleDbCommand(sql, con);
            cmd.Parameters.AddWithValue("?", true);
            cmd.Parameters.AddWithValue("?", suspendUser.Text);
            cmd.ExecuteNonQuery();

            Label2.Text = suspendUser.Text + " suspended";
        }
        else
            Label2.Text = "User does not exist.";

        con.Close();
    }
}