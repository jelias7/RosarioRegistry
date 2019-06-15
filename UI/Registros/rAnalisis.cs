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
        public rAnalisis()
        {
            InitializeComponent();
        }



        private void TipoAnalisisbutton_Click(object sender, EventArgs e)
        {
            rTipoAnalisis rta = new rTipoAnalisis();
            rta.Show();
        }
    }
}
