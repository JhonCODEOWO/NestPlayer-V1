using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargarMusicaBD
{
    public partial class Configuración : Form
    {
        public Configuración(string Fuente, string ColorFont, string ColorPaneles)
        {
            InitializeComponent();
            lblFuenteActual.Text = Fuente;
            lblColor.Text = ColorFont;
            lblColorInterfaz.Text = ColorPaneles;
            panelCFuente.BackColor = System.Drawing.Color.FromName(ColorFont);
            panelCInterfaz.BackColor = System.Drawing.Color.FromName(ColorPaneles);
        }

        private void Configuración_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selecciónFuente.ShowDialog() == DialogResult.OK)
            {
                lblFuenteActual.Text = selecciónFuente.Font.Name;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Color color = new Color();
            if (elegirColor.ShowDialog() == DialogResult.OK)
            {
                lblColor.Text = elegirColor.Color.Name;
                color = elegirColor.Color;
                panelCFuente.BackColor = color;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Color color = new Color();
            if (elegirColor.ShowDialog() == DialogResult.OK)
            {
                lblColorInterfaz.Text = elegirColor.Color.Name;
                color = elegirColor.Color;
                panelCInterfaz.BackColor = color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
