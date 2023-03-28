using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargarMusicaBD.Dialogos_interfaz
{
    public partial class DialogoBorrarTodoBD : Form
    {
        public DialogoBorrarTodoBD()
        {
            InitializeComponent();
        }

        private void DialogoBorrarTodoBD_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
    }
}
