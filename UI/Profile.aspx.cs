using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MusicStoreBL;

namespace UI
{
    public partial class Profile : System.Web.UI.Page
    {
        public bool isAdmin = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null)
            {
                Response.Write("<script>alert('You cannot view you profile, \n please try login in first!')</script>");
                Response.Redirect("HomePage.aspx");
            }
            else {
                FullName.Text = ((User)Session["User"]).FullName;
                isAdmin = ((User)Session["User"]).isAdmin;
                UsersList.DataSource = MusicStoreBL.User.getAllUsers();
                UsersList.DataBind();
            }
        }

        protected void SetAdminBTN_Click(object sender, EventArgs e)
        {
            ((User)Session["User"]).setAdmin(emailSetAdmin.Text, !((User)Session["User"]).isAdmin);
            Response.Redirect("Profile.aspx");
        }
    }
}