using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace db
{
    public partial class Default : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataAdapter ada = new SqlDataAdapter("select * from Navn", conn);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            Repeater_navn.DataSource = dt;
            Repeater_navn.DataBind();
        }
    }
}