using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MusicStoreBL;

namespace UI
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] != null)
            {
                Response.Write("<script>alert('Please logout first to create a new user!')</script>");
                Response.Redirect("HomePage.aspx");
            }
        }
        
        protected void EmailExistsValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (MusicStoreBL.User.isExist(EmailInput.Text))
            {
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
            }
        }

        protected void DoPasswordsMatch_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (ConPassword.Text == password.Text)
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            Page.Validate("SignUpValidation");
            if (Page.IsValid && IAgree.Checked)
            {
                Session["User"] = MusicStoreBL.User.createUser(firstname.Text, lastname.Text, password.Text, EmailInput.Text);
                Response.Redirect("HomePage.aspx");
            }
            else
            {
                Page.Validate();
            }
        }
    }
}