using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EquiposWeb
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Asignar contenido al control Literal
                //contentLiteral.Text = "Este es un ejemplo de contenido <b>HTML</b> en un Literal.";
            }
            messageBox.Visible = false;
        }

        protected void chkBox_CheckedChanged(object sender, EventArgs e)
        {

        }


        protected void ShowMessageBox(string message)
        {
            ltMessage.Text = message;
            messageBox.Visible = true;
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            // Código para manejar el clic en el botón OK
            messageBox.Visible = false;
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            // Código para manejar el clic en el botón Cancel
            messageBox.Visible = false;
        }
    }
}