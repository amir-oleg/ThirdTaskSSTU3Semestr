using System;

namespace ThirdTask
{
    public partial class EditDbForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Insert(object sender, EventArgs e)
        {
            SqlDataSource1.Insert();
        }

        protected void Insert2(object sender, EventArgs e)
        {
            SqlDataSource2.Insert();
        }
    }

}