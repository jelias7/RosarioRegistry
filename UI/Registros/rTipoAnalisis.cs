using Rosario_Registry.BLL;
using Rosario_Registry.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rosario_Registry.UI.Registros
{
    public partial class rTipoAnalisis : Form
    {
        public rTipoAnalisis()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            MyErrorProvider.Clear();

            TipoIDnumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;


        }

        private TiposAnalisis LlenaClase()
        {
            TiposAnalisis analisis = new TiposAnalisis();
            analisis.TipoId = Convert.ToInt32(TipoIDnumericUpDown);
            analisis.Descripcion = DescripciontextBox.Text;
            return analisis;
        }
        private void LlenaCampo(TiposAnalisis analisis)
        {
            TipoIDnumericUpDown.Value = analisis.TipoId;
            DescripciontextBox.Text = analisis.Descripcion;

        }
        private bool ExisteEnLaBaseDeDatos()
        {
            TiposAnalisis analisis = TipoAnalisisBLL.Buscar((int)TipoIDnumericUpDown.Value);

            return (analisis != null);
        }
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            TiposAnalisis analisis = new TiposAnalisis();
            int.TryParse(TipoIDnumericUpDown.Text, out id);

            Limpiar();

            analisis = TipoAnalisisBLL.Buscar(id);

            if (analisis != null)
            {
                LlenaCampo(analisis);
            }
            else
            {
                MessageBox.Show("Tipo no encontrado.");
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            TiposAnalisis analisis;
            bool paso = false;


            analisis = LlenaClase();


            if (TipoIDnumericUpDown.Value == 0)
                paso = TipoAnalisisBLL.Guardar(analisis);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = TipoAnalisisBLL.Modificar(analisis);
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
            int.TryParse(TipoIDnumericUpDown.Text, out id);

            Limpiar();

            if (TipoAnalisisBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MyErrorProvider.SetError(TipoIDnumericUpDown, "No se puede eliminar");
        }
    }
}
