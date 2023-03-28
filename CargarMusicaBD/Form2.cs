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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureLoading.Image = Properties.Resources.Loading_icon;
            //pictureLoading.Location = new Point(this.Width/2 - pictureLoading.Width/2,
                //this.Width / 2 - pictureLoading.Width / 2);
        }
    }
}
