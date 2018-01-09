using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DashboardDemo
{
    public partial class Custom : System.Web.UI.Page
    {
        static CustomDashboardStorage dashboardStorage = new CustomDashboardStorage();
        protected void Page_Load(object sender, EventArgs e)
        {
            ASPxDashboard1.SetDashboardStorage(dashboardStorage);
        }
    }
}