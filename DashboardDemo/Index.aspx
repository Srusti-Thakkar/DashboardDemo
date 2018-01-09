<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="DashboardDemo.Index" %>

<%@ Register Assembly="DevExpress.Dashboard.v17.2.Web, Version=17.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.DashboardWeb" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <dx:ASPxPageControl ID="carTabPage" Width="100%" runat="server" CssClass="dxtcFixed" ActiveTabIndex="0" EnableHierarchyRecreation="True" >
        <TabPages>
            <dx:TabPage Text="Dashboard">
                <ContentCollection>
                    <dx:ContentControl ID="ContentControl1" runat="server">
                        <dx:ASPxDashboard ID="ASPxDashboard1" runat="server" OnDashboardSaving="ASPxDashboard1_DashboardSaving"></dx:ASPxDashboard>
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>           
        </TabPages>
    </dx:ASPxPageControl>

                    

        </div>
    </form>
</body>
</html>
