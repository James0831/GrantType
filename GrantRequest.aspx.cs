using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class GrantRequest : System.Web.UI.Page
{
    SearchClass sc = new SearchClass();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userkey"] != null)
        {
            if(!IsPostBack)
            {
                DataTable table = sc.GetGrantType();
                DropDownList1.DataSource = table;
                DropDownList1.DataTextField = "GrantTypeName";
                DropDownList1.DataValueField = "GrantTypeKey";
                DropDownList1.DataBind();
                ListItem item = new ListItem("Select a Grant Type");
                DropDownList1.Items.Insert(0, item);
            }
        }
        else
        {
            Response.Redirect("Default.aspx");
        }
    }

    protected void FillGrid()
    {
        if (!DropDownList1.SelectedItem.Text.Equals("Select a Grant Type"))
        {
            int key = int.Parse(DropDownList1.SelectedValue.ToString());
            DataTable tbl = sc.GetServices(key);
            GridView1.DataSource = tbl;
            GridView1.DataBind();
        }
    }


    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        FillGrid();
    }
}