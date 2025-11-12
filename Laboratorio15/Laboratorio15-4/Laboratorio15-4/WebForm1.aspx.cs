using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio15_4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string texto1 = TextBox1.Text;
            string texto2 = TextBox2.Text;

            int num1 = int.Parse(texto1);
            int num2 = int.Parse(texto2);

            int resultado = num1 + num2;

            Label3.Text = "Resultado: " + resultado.ToString();


        }
    }
}