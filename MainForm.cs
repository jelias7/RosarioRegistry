using Rosario_Registry.UI.Consultas;
using Rosario_Registry.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rosario_Registry
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void rUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rUsuarios ru = new rUsuarios();
            ru.Show();
        }

        private void rCargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rCargos rc = new rCargos();
            rc.Show();
        }

        private void cCargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cCargos cc = new cCargos();
            cc.Show();
        }

        private void CUsuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cUsuarios cu = new cUsuarios();
            cu.Show();
        }
    }
}
