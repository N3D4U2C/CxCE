using System;
using System.Diagnostics;

namespace CxCE_Demo
{
    public partial class commandi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(string sender, EventArgs e)
        {
            if(sender=='')
            {
                string processtostartnow = "PROCESS";
                Process.Start(processtostartnow);
            }
            /*
            Adding Comments
            */
            string processtostartnow = systemname.Text;
            Process.Start(processtostartnow);
        }
    }
}
