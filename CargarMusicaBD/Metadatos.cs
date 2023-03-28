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
    public partial class Metadatos : Form
    {
        public Metadatos(string ruta)
        {
            string generos = null; ;
            InitializeComponent();
            TagLib.File file = TagLib.File.Create(ruta);
            lblTitulo.Text = file.Tag.Title;
            lblAlbum.Text = file.Tag.Album;
            
            lblAño.Text = file.Tag.Year.ToString();
            for (int i = 0; i < file.Tag.Genres.Length; i++)
            {
                generos += file.Tag.Genres[i];
                generos += ", ";
            }
            lblGenero.Text = generos;
            lblBPM.Text = file.Tag.BeatsPerMinute.ToString();
        }

        private void Metadatos_Load(object sender, EventArgs e)
        {
           
        }
    }
}
