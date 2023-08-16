using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using EquiposClassLib;

namespace EquiposWeb
{
    public partial class ListarEquipos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                Contenedor contenedor = Session["contenedor"] as Contenedor;
                if (contenedor == null)
                {
                    contenedor = new Contenedor();
                    Session["contenedor"] = contenedor;
                }

                ltvListado.DataSource = contenedor.Listar();
                ltvListado.DataBind();
            }
        }
    }
}