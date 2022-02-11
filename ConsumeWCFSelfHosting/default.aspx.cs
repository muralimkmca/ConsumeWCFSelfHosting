using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConsumeWCFSelfHosting
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(TextBox1.Text);
            int b = Convert.ToInt32(TextBox2.Text);
            calService.CalcServiceClient service = new calService.CalcServiceClient("BasicHttpBinding_ICalcService");
            Response.Write(service.ConcatIntValue(a, b));

        }

        protected void btnConcat_Click(object sender, EventArgs e)
        {
            calService.CalcServiceClient service = new calService.CalcServiceClient("BasicHttpBinding_ICalcService");
            Response.Write(service.ConcatStringValue(TextBox1.Text,TextBox2.Text));
        }
    }
}