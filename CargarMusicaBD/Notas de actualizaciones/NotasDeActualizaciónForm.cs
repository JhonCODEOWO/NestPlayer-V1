using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargarMusicaBD
{
    public partial class NotasDeActualizaciónForm : Form
    {
        public NotasDeActualizaciónForm()
        {
            InitializeComponent();
        }

        private void NotasDeActualizaciónForm_Load(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("NotasDeActualizaciónParaUsuarios.txt");
            
            string linea = "";
            linea = reader.ReadLine();
            while (linea != null)
            {
                richTextBox1.AppendText(linea + "\n");
                linea = reader.ReadLine();
            }
        }
    }
}
