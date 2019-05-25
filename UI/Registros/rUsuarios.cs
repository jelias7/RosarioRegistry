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
    public partial class rUsuarios : Form
    {
        public rUsuarios()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            NombrestextBox.Text = string.Empty;
            EmailtextBox.Text = string.Empty;
            NivelcomboBox.Text = string.Empty;
            UsuariotextBox.Text = string.Empty;
            IngresodateTimePicker.Value = DateTime.Now;
            ClavenumericUpDown.Value = 0;
            MyErrorProvider.Clear();

        }
        private Usuarios LlenaClase()
        {
            Usuarios usuarios = new Usuarios();
            usuarios.UsuarioID = Convert.ToInt32(IDnumericUpDown.Value);
            usuarios.Nombres = NombrestextBox.Text;
            usuarios.Email = EmailtextBox.Text;
            usuarios.NivelUsuario = NivelcomboBox.Text;
            usuarios.Usuario = UsuariotextBox.Text;
            usuarios.FechaIngreso = IngresodateTimePicker.Value;
            usuarios.Clave = Convert.ToInt32(ClavenumericUpDown.Value);
            return usuarios;
        }

        private void LlenaCampo(Usuarios usuarios)
        {
            IDnumericUpDown.Value = usuarios.UsuarioID;
            NombrestextBox.Text = usuarios.Nombres;
            EmailtextBox.Text = usuarios.Email;
            NivelcomboBox.Text = usuarios.NivelUsuario;
            UsuariotextBox.Text = usuarios.Usuario;
            IngresodateTimePicker.Value = usuarios.FechaIngreso;
            ClavenumericUpDown.Value = usuarios.Clave;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Usuarios usuarios = UsuariosBLL.Buscar((int)IDnumericUpDown.Value);

            return (usuarios != null);
        }

        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (NombrestextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(NombrestextBox, "El Campo Nombres no puede estar vacio.");
                NombrestextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(EmailtextBox.Text))
            {
                MyErrorProvider.SetError(EmailtextBox, "El campo Email no puede estar vacio.");
                EmailtextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(UsuariotextBox.Text))
            {
                MyErrorProvider.SetError(UsuariotextBox, "El campo Usuario no puede estar vacio.");
                UsuariotextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(NivelcomboBox.Text))
            {
                MyErrorProvider.SetError(NivelcomboBox, "El campo Nivel Usuario no puede estar vacio.");
                NivelcomboBox.Focus();
                paso = false;
            }
            return paso;
        }
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            Usuarios usuarios = new Usuarios();
            int.TryParse(IDnumericUpDown.Text, out id);

            Limpiar();

            usuarios = UsuariosBLL.Buscar(id);

            if (usuarios != null)
            {
                MessageBox.Show("Usuario Encontrado.");
                LlenaCampo(usuarios);
            }
            else
            {
                MessageBox.Show("Usuario no encontrado.");
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Usuarios usuarios;
            bool paso = false;
            if (!Validar())
                return;

            usuarios = LlenaClase();
            

            if (IDnumericUpDown.Value == 0)
                paso = UsuariosBLL.Guardar(usuarios);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede guardar un usuario que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = UsuariosBLL.Modificar(usuarios);
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

            if (UsuariosBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MyErrorProvider.SetError(IDnumericUpDown, "No se puede eliminar un usuario que no existe.");
        }
    }
}
