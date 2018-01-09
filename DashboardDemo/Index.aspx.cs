using DevExpress.DashboardCommon;
using DevExpress.DashboardWeb;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DashboardDemo
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //DashboardFileStorage dashboardFileStorage = new DashboardFileStorage("~/App_Data");
            //ASPxDashboard1.SetDashboardStorage(dashboardFileStorage);

            DashboardFileStorage dashboard = new DashboardFileStorage(GetVirtualPath(Server.MapPath("~/Dashboards")));
            ASPxDashboard1.SetDashboardStorage(dashboard);

        }

        protected void ASPxDashboard1_DashboardSaving(object sender, DashboardSavingWebEventArgs e)
        {
            
        }
         
        public string GetVirtualPath(string physicalPath)
        {
            if (!physicalPath.StartsWith(HttpContext.Current.Request.PhysicalApplicationPath))
            {
                throw new InvalidOperationException("Physical path is not within the application root");
            }

            return "~/" + physicalPath.Substring(HttpContext.Current.Request.PhysicalApplicationPath.Length)
                  .Replace("\\", "/");
        }
    }
}