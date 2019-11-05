using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class viewUA : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string sql = "";
        OleDbConnection con = new OleDbConnection();

        // establish connection  
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("/GoWhere/App_Data/Database.mdb");
        con.Open(); // connection open 

        sql = "SELECT Tour_Guide.TGID, Tourist.TID, Tourist.user FROM Tour_Guide INNER JOIN Tourist ON(Tour_Guide.suspended = Tourist.suspended) AND(Tour_Guide.pass = Tourist.pass) AND(Tour_Guide.user = Tourist.user);";
        OleDbCommand cmd = new OleDbCommand(sql, con);

        OleDbDataReader reader = cmd.ExecuteReader();

        // create new row for adding table heading
        TableRow tableHeading = new TableRow();

        // create and add cells that contain tourist ID
        TableHeaderCell tidHeading = new TableHeaderCell();
        tidHeading.Text = "Tour Guide ID";
        tidHeading.HorizontalAlign = HorizontalAlign.Left;
        tableHeading.Cells.Add(tidHeading);

        TableHeaderCell tgidHeading = new TableHeaderCell();
        tgidHeading.Text = "Tourist ID";
        tgidHeading.HorizontalAlign = HorizontalAlign.Left;
        tableHeading.Cells.Add(tgidHeading);

        TableHeaderCell userHeading = new TableHeaderCell();
        userHeading.Text = "Username";
        userHeading.HorizontalAlign = HorizontalAlign.Left;
        tableHeading.Cells.Add(userHeading);

        DisplayTable.Rows.Add(tableHeading);

        // add details to table
        while (reader.Read())
        {
            TableRow detailsRow = new TableRow();
            TableCell tgidCell = new TableCell();
            tgidCell.Text = reader["TGID"].ToString();
            detailsRow.Cells.Add(tgidCell);

            TableCell tidCell = new TableCell();
            tidCell.Text = reader["TID"].ToString();
            detailsRow.Cells.Add(tidCell);

            TableCell userCell = new TableCell();
            userCell.Text = reader["user"].ToString();
            detailsRow.Cells.Add(userCell);

            DisplayTable.Rows.Add(detailsRow);

        }
        reader.Close();
        con.Close();
    }
}