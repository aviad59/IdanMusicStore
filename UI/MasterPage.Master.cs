using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LogoImgBtn_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        protected void HomeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        protected void ProductsBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Products.aspx");
        }

        protected void ProfileBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Profile.aspx");
        }

        protected void CartBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cart.aspx");
        }

    }
}