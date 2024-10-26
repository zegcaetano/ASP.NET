using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Areas
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_r_Click(object sender, EventArgs e)
        {
            Response.Redirect("rectangulo.aspx");
        }

        protected void btn_t_Click(object sender, EventArgs e)
        {
            Response.Redirect("triangulo.aspx");
        }

        protected void btn_c_Click(object sender, EventArgs e)
        {
            Response.Redirect("circulo.aspx");
        }

        protected void btn_q_Click(object sender, EventArgs e)
        {
            Response.Redirect("quadrado.aspx");
        }
    }
}