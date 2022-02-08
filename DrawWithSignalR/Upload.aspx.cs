using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DrawWithSignalR
{
    public partial class Upload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpPostedFile file = HttpContext.Current.Request.Files[0];

            string path = Server.MapPath("images");
            file.SaveAs(path+"/"+file.FileName);

            Response.Clear();
            Response.Write("/images/" + file.FileName);
            Response.Flush();
            Response.End();
        }
    }
}