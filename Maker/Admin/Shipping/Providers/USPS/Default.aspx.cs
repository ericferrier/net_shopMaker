using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text.RegularExpressions;
using MakerShop.Common;
using MakerShop.Catalog;
using MakerShop.Orders;
using MakerShop.Products;
using MakerShop.Stores;
using MakerShop.Users;
using MakerShop.Utility;
using MakerShop.Reporting;
using System.Collections.Generic;
using MakerShop.Shipping;
using MakerShop.Shipping.Providers.USPS;

public partial class Admin_Shipping_USPS_Default : MakerShop.Web.UI.MakerShopAdminPage
{

    protected void Page_Init(object sender, EventArgs e)
    {
        //DEFAULT PAGE, REDIRECT TO APPROPRIATE LOCATION
        int _ShipGatewayId = AlwaysConvert.ToInt(Request.QueryString["ShipGatewayId"]);
        ShipGateway _ShipGateway = ShipGatewayDataSource.Load(_ShipGatewayId);
        if (_ShipGateway != null) 
        {
            USPS provider = _ShipGateway.GetProviderInstance() as USPS;
            if (provider != null)
            {
                if (provider.UserIdActive) Response.Redirect("Configure.aspx?ShipGatewayId=" + _ShipGatewayId.ToString());
                Response.Redirect("Activate.aspx?ShipGatewayId=" + _ShipGatewayId.ToString());
            }
        }
        Response.Redirect("Register.aspx");
    }

}
