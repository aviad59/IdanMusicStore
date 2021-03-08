using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MusicStoreBL;

namespace UI
{
    public partial class Products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductsDL.DataSource = Product.getListAll();
            ProductsDL.DataBind();
        }
    }
}