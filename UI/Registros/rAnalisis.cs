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
    public partial class rAnalisis : Form
    {
        public List<AnalisisDetalle> Detalle { get; set; }
        public rAnalisis()
        {
            InitializeComponent();
            this.Detalle = new List<AnalisisDetalle>();
        }



        private void TipoAnalisisbutton_Click(object sender, EventArgs e)
        {
            rTipoAnalisis rta = new rTipoAnalisis();
            rta.Show();
        }
        private void Limpiar()
        {
            MyErrorProvider.Clear();

            IDnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            ResultadotextBox.Text = string.Empty;
            this.Detalle = new List<AnalisisDetalle>();
            CargarGrid();
        }

        private Analisis LlenaClase()
        {
            Analisis analisis = new Analisis();
            analisis.AnalisisId = Convert.ToInt32(IDnumericUpDown.Value);
            analisis.Fecha = FechadateTimePicker.Value;
            analisis.UsuarioId = Convert.ToInt32(UsuariocomboBox.Text);
            analisis.Resultado = this.Detalle;
            return analisis;
        }
        private void LlenaCampo(Analisis analisis)
        {
            IDnumericUpDown.Value = analisis.AnalisisId;
            FechadateTimePicker.Value = analisis.Fecha;
            UsuariocomboBox.Text = analisis.UsuarioId.ToString();

            this.Detalle = analisis.Resultado;
            CargarGrid();
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            Analisis analisis = AnalisisBLL.Buscar((int)IDnumericUpDown.Value);

            return (analisis != null);
        }

        private void CargarGrid()
        {
            ResultadodataGridView.DataSource = null;
            ResultadodataGridView.DataSource = Detalle;
        }
        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            Analisis analisis = new Analisis();
            int.TryParse(IDnumericUpDown.Text, out id);

            Limpiar();

            analisis = AnalisisBLL.Buscar(id);

            if (analisis != null)
            {
                LlenaCampo(analisis);
            }
            else
            {
                MessageBox.Show("Analisis no encontrado.");
            }
        }

        private void Removerbutton_Click(object sender, EventArgs e)
        {
            if(ResultadodataGridView.Rows.Count > 0 && ResultadodataGridView.CurrentRow != null)
            {
                Detalle.RemoveAt(ResultadodataGridView.CurrentRow.Index);
            }
        }
        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (ResultadotextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(ResultadotextBox, "El Campo no puede estar vacio.");
                ResultadotextBox.Focus();
                paso = false;
            }
            if (TipocomboBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(TipocomboBox, "El Campo no puede estar vacio.");
                TipocomboBox.Focus();
                paso = false;
            }
            if (UsuariocomboBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(UsuariocomboBox, "El Campo no puede estar vacio.");
                UsuariocomboBox.Focus();
                paso = false;
            }


            return paso;
        }
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Analisis analisis;
            bool paso = false;

            if (!Validar())
                return;

            analisis = LlenaClase();


            if (IDnumericUpDown.Value == 0)
                paso = AnalisisBLL.Guardar(analisis);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = AnalisisBLL.Modificar(analisis);
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

            if (AnalisisBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MyErrorProvider.SetError(IDnumericUpDown, "No se puede eliminar");
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            if (ResultadodataGridView.DataSource != null)
                this.Detalle = (List<AnalisisDetalle>)ResultadodataGridView.DataSource;

            this.Detalle.Add(
                new AnalisisDetalle(
                    analisisid: (int)IDnumericUpDown.Value,
                    tipoid: 0,
                    resultado: ResultadotextBox.Text
                    )
                );
            CargarGrid();
        }
    }
}
