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
    public partial class VisualizadorLyrics : Form
    {
        public VisualizadorLyrics(string Lyrics, string NombreCancion)
        {
            InitializeComponent();
            if (Lyrics == null)
            {
                
                rTBLyrics.Text = "Sin letras disponibles para esta canción";
            }
            else
            {
                rTBLyrics.Text = Lyrics;
            }
            this.Text = "Letras de: "+NombreCancion;
        }

        private void VisualizadorLyrics_Load(object sender, EventArgs e)
        {

        }
    }
}
