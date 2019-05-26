using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rosario_Registry.Entidades;
using Rosario_Registry.BLL;

namespace Rosario_Registry.UI.Consultas
{
    public partial class cUsuarios : Form
    {
        public cUsuarios()
        {
            InitializeComponent();
        }

        private void Consultabutton_Click(object sender, EventArgs e)
        {
            var listado = new List<Usuarios>();

            if (CriteriotextBox.Text.Trim().Length > 0)
            {
                switch (FiltrarcomboBox.Text)
                {
                    case "Todo":
                        listado = UsuariosBLL.GetList(p => true);
                        break;

                    case "ID":
                        int id = Convert.ToInt32(CriteriotextBox.Text);
                        listado = UsuariosBLL.GetList(p => p.UsuarioID == id);
                        break;

                    case "Nombres":
                        listado = UsuariosBLL.GetList(p => p.Nombres.Contains(CriteriotextBox.Text));
                        break;

                    case "Email":
                        listado = UsuariosBLL.GetList(p => p.Email.Contains(CriteriotextBox.Text));
                        break;

                    case "Nivel Usuario":
                        listado = UsuariosBLL.GetList(p => p.NivelUsuario.Contains(CriteriotextBox.Text));
                        break;

                    case "Usuario":
                        listado = UsuariosBLL.GetList(p => p.Usuario.Contains(CriteriotextBox.Text));
                        break;

                    case "Clave":
                        int c = Convert.ToInt32(CriteriotextBox.Text);
                        listado = UsuariosBLL.GetList(p => p.Clave == c);
                        break;

                    default:
                        break;
                }
                
            }
            else
            {
                listado = UsuariosBLL.GetList(p => true);
            }

            ConsultadataGridView.DataSource = null;
            ConsultadataGridView.DataSource = listado;
        }
    }
}
