using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MusicStoreBL;

namespace UI
{
    public partial class SignIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] != null)
            {
                Response.Write("<script>alert('Please logout first if you intend to login as another user!')</script>");
                Response.Redirect("HomePage.aspx");
            }
        }

        protected void LogInBtn_Click(object sender, EventArgs e)
        {
            Page.Validate();
            if(Page.IsValid)
            {
                Session["User"] = MusicStoreBL.User.createUser(MusicStoreBL.User.getUserByEmail(Email.Text).Tables[0].Rows[0]);
                Response.Redirect("HomePage.aspx");
            }       
        }

        protected void checkCredentials_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = MusicStoreBL.User.isCorrectPassword(Email.Text, Password.Text);
        }
    }
}