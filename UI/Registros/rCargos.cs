using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rosario_Registry.BLL;
using Rosario_Registry.Entidades;

namespace Rosario_Registry.UI.Registros
{
    public partial class rCargos : Form
    {
        public rCargos()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
            MyErrorProvider.Clear();

        }
        private Cargos LlenaClase()
        {
            Cargos cargos = new Cargos();
            cargos.CargoID = Convert.ToInt32(IDnumericUpDown.Value);
            cargos.Descripcion = DescripciontextBox.Text;
            
            return cargos;
        }

        private void LlenaCampo(Cargos cargos)
        {
            IDnumericUpDown.Value = cargos.CargoID;
            DescripciontextBox.Text = cargos.Descripcion;
            
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Cargos cargos = CargosBLL.Buscar((int)IDnumericUpDown.Value);

            return (cargos != null);
        }

        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (DescripciontextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(DescripciontextBox, "El Campo Descripcion no puede estar vacio.");
                DescripciontextBox.Focus();
                paso = false;
            }

            
            return paso;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            Cargos cargos = new Cargos();
            int.TryParse(IDnumericUpDown.Text, out id);

            Limpiar();

            cargos = CargosBLL.Buscar(id);

            if (cargos != null)
            {
                MessageBox.Show("Usuario Encontrado.");
                LlenaCampo(cargos);
            }
            else
            {
                MessageBox.Show("Usuario no encontrado.");
            }
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Cargos cargos;
            bool paso = false;
            if (!Validar())
                return;

            cargos = LlenaClase();


            if (IDnumericUpDown.Value == 0)
                paso = CargosBLL.Guardar(cargos);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede guardar uno que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = CargosBLL.Modificar(cargos);
            }

            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Limpiar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();

            int id;
            int.TryParse(IDnumericUpDown.Text, out id);

            Limpiar();

            if (CargosBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MyErrorProvider.SetError(IDnumericUpDown, "No se puede eliminar uno que no existe.");

        }
    }
}
