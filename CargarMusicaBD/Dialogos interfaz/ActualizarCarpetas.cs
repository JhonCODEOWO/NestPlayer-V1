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
    public partial class ActualizarCarpetas : Form
    {
        Metodos metodos = new Metodos();

        public ActualizarCarpetas()
        {
            InitializeComponent();
        }

        private void ActualizarCarpetas_Load(object sender, EventArgs e)
        {
            dgvCarpetas.DataSource = metodos.obtenerDirectoriosGurdados();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string datoSeleccionado = dgvCarpetas.Rows[dgvCarpetas.CurrentRow.Index].Cells[0].Value.ToString();
            Console.WriteLine(datoSeleccionado);
            metodos.eliminarCarpeta(datoSeleccionado);
            dgvCarpetas.DataSource = null;
            dgvCarpetas.DataSource = metodos.obtenerDirectoriosGurdados();
        }
    }
}
