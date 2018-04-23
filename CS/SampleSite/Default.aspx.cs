using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page {
    protected void Page_Init(object sender, EventArgs e) {
        CustomGridView1.DataSource = GetDataTable();
        CustomGridView1.DataBind();
    }

    protected void Page_Load(object sender, EventArgs e) {

    }

    private object GetDataTable() {
        DataTable table = new DataTable();
        table.Columns.Add("ID", typeof(int));
        table.Columns.Add("ItemName", typeof(string));
        for(int i = 1; i <= 10; i++) {
            table.Rows.Add(i, "Item " + i.ToString());
        }
        return table;
    }
}