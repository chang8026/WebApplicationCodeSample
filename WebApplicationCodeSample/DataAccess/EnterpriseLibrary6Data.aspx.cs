using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationCodeSample.DataAccess
{
	public partial class EnterpriseLibrary6Data : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			DatabaseProviderFactory factory = new DatabaseProviderFactory();

			Database LocalDB = factory.Create("LocalDB");

			DataSet ds = LocalDB.ExecuteDataSet(CommandType.Text, "select * From TestTable");

			GridView1.DataSource = ds;
			GridView1.DataBind();
		}
	}
}