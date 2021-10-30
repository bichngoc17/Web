using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace database
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        String cnn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\web\buoi4\database\database\App_Data\Database1.mdf;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;//load lại trang khi chưa được load
            String q1 = "select * from LoaiHang";
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(q1, cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.DropDownList1.DataSource = dt;
                this.DropDownList1.DataTextField = "TenLoai";
                this.DropDownList1.DataValueField = "MaLoai";
                this.DropDownList1.DataBind();


            }
            catch(SqlException ex)
            {
                Response.Write(ex.Message);
            }
       

            
        }
    }
}