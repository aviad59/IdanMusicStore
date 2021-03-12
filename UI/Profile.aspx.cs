﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["User"] == null)
            {
                Response.Write("<script>alert('You cannot view you profile, \n please try login in first!')</script>");
                Response.Redirect("HomePage.aspx");
            }
            
        }
    }
}