using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoggingExampleASP.NET
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Generating Custom Exception
            int x = 0;int y = 1;
            int z = y / x;
        }
    }
}