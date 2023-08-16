using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using EquiposClassLib;

namespace WebFormApp
{
  
    public partial class WebForm1 : System.Web.UI.Page
    {
        Contenedor contenedor;

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            contenedor = Session["contenedor"] as Contenedor;
            if (contenedor == null)
            {
                contenedor = new Contenedor();
                Session["contenedor"] = contenedor;
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            string club = tbClub.Text;
            int puntos = Convert.ToInt32(tbPuntos.Text);

            contenedor.RegistrarEquipo(nombre, club, puntos);

            tbNombre.Text = "";
            tbClub.Text = "";
            tbPuntos.Text = "";
        }
    }
}