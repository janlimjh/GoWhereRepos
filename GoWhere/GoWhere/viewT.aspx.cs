using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class viewT : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string sql = "";
        //DateTime today = DateTime.Today;
        OleDbConnection con = new OleDbConnection();

        // establish connection  
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("/GoWhere/App_Data/Database.mdb");
        con.Open(); // connection open 

        sql = "SELECT Tour.* FROM Tour WHERE date_start >= DATE()";

        OleDbCommand cmd = new OleDbCommand(sql, con);
        OleDbDataReader reader = cmd.ExecuteReader();

        // create new row for adding table heading
        TableRow tableHeading = new TableRow();

        // create and add cells 
        TableHeaderCell dateHeading = new TableHeaderCell();
        dateHeading.Text = "Date Start";
        dateHeading.HorizontalAlign = HorizontalAlign.Left;
        tableHeading.Cells.Add(dateHeading);

        TableHeaderCell descHeading = new TableHeaderCell();
        descHeading.Text = "Tour Type";
        descHeading.HorizontalAlign = HorizontalAlign.Left;
        tableHeading.Cells.Add(descHeading);

        TableHeaderCell cityHeading = new TableHeaderCell();
        cityHeading.Text = "City/Country";
        cityHeading.HorizontalAlign = HorizontalAlign.Left;
        tableHeading.Cells.Add(cityHeading);

        TableHeaderCell statusHeading = new TableHeaderCell();
        statusHeading.Text = "Status";
        statusHeading.HorizontalAlign = HorizontalAlign.Left;
        tableHeading.Cells.Add(statusHeading);

        DisplayTable.Rows.Add(tableHeading);

        // add details to table
        while (reader.Read())
        {
            TableRow detailsRow = new TableRow();
            TableCell dateCell = new TableCell();
            dateCell.Text = (reader["date_start"].ToString()).Substring(0, 10);
            detailsRow.Cells.Add(dateCell);

            TableCell descCell = new TableCell();
            descCell.Text = reader["tour_type"].ToString();
            detailsRow.Cells.Add(descCell);

            TableCell cityCell = new TableCell();
            cityCell.Text = reader["city_country"].ToString();
            detailsRow.Cells.Add(cityCell);

            TableCell statusCell = new TableCell();
            statusCell.Text = reader["tour_status"].ToString();
            detailsRow.Cells.Add(statusCell);

            DisplayTable.Rows.Add(detailsRow);

        }
        reader.Close();
        con.Close();
    }
}