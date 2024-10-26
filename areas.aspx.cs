using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Areas
{
    public partial class areas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label2.Text = "";
        }

        protected void btn_1_Click(object sender, EventArgs e)
        {
            try
            {
                Label2.Text = (float.Parse("0" + txtb_1.Text) * float.Parse(txtb_2.Text)).ToString();

            }
            catch 
            {
                Label2.Text = "Erro!";
            }
        }
    }
}