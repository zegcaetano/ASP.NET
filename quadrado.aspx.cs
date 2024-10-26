using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Areas
{
    public partial class quadrado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbl_2.Text = "";
        }

        protected void btn_1_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_2.Text = (float.Parse("0" + txtb_1.Text) * (float.Parse("0" + txtb_1.Text))).ToString() + " cm²";

            }
            catch
            {
                lbl_2.Text = "Erro!";
            }
        }

        protected void btn_v_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }
    }
}