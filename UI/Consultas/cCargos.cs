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
    public partial class cCargos : Form
    {
        public cCargos()
        {
            InitializeComponent();
        }

        private bool Validar()
        {
            bool paso = false;

            if (FiltrarcomboBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(FiltrarcomboBox, "Este campo no puede estar vacio.");
                FiltrarcomboBox.Focus();
                paso = true;
            }

            return paso;
        }

        private void Consultabutton_Click(object sender, EventArgs e)
        {
            var listado = new List<Cargos>();
            if (Validar())
                return;

            if (CriteriotextBox.Text.Trim().Length > 0)
            {
                switch (FiltrarcomboBox.Text)
                {
                    case "Todo":
                        listado = CargosBLL.GetList(p => true);
                        break;

                    case "ID":
                        int id = Convert.ToInt32(CriteriotextBox.Text);
                        listado = CargosBLL.GetList(p => p.CargoID == id);
                        break;

                    case "Descripcion":
                        listado = CargosBLL.GetList(p => p.Descripcion.Contains(CriteriotextBox.Text));
                        break;

                }

            }
            else
            {
                listado = CargosBLL.GetList(p => true);
            }

            ConsultadataGridView.DataSource = null;
            ConsultadataGridView.DataSource = listado;
        }
    }
}
