using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class GoWhere_login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Label2.Visible = false;
        if (!IsPostBack)
            username.Focus(); // blink cursor in TextBox1 
    }

    protected void Login_Click(object sender, EventArgs e)
    {
        String user = loginType.SelectedValue;
        string sql = ""; int row = 0;
        OleDbConnection con = new OleDbConnection();

        // establish connection  
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("/GoWhere/App_Data/Database.mdb");
        con.Open(); // connection open 

        if (user.Equals("UA"))
        {
            sql = "SELECT COUNT(*) FROM User_Admin WHERE user='" + loginUser.Text + "' AND pass='" + loginPwd.Text + "'";
            OleDbCommand cmd = new OleDbCommand(sql, con);
            row = (int)cmd.ExecuteScalar(); // cast into integer and ExecuteScalar() get single value from database.
            if (row > 0)
                Response.Redirect("homeUA.aspx");
            else
                Label2.Text = "Username or Password is invalid...";
        }

        else if (user.Equals("TG"))
        {
            sql = "SELECT COUNT(*) FROM Tour_Guide WHERE user='" + loginUser.Text + "' AND pass='" + loginPwd.Text + "' AND suspended=0";
            OleDbCommand cmd = new OleDbCommand(sql, con);
            row = (int)cmd.ExecuteScalar(); // cast into integer and ExecuteScalar() get single value from database.
            if (row > 0)
                Response.Redirect("homeTG.aspx");
            else
                Label2.Text = "Username or Password is invalid...";
        }

        else if (user.Equals("TR"))
        {
            sql = "SELECT COUNT(*) FROM Tourist WHERE user='" + loginUser.Text + "' AND pass='" + loginPwd.Text + "' AND suspended=0";
            OleDbCommand cmd = new OleDbCommand(sql, con);
            row = (int)cmd.ExecuteScalar(); // cast into integer and ExecuteScalar() get single value from database.
            if (row > 0)
                Response.Redirect("homeTR.aspx");
            else
                Label2.Text = "Username or Password is invalid...";
        }

        con.Close(); // connection close  
    }
}