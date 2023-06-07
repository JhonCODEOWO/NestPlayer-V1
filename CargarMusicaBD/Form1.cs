using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Media;
using TagLib;
using System.IO;
using System.Threading;
using System.Data;
using System.Security.Permissions;

namespace CargarMusicaBD
{
    public partial class Form1 : Form
    {
        int indiceReproduccion;
        Random indiceAleatorio = new Random();
        bool repetir = false;
        bool aleatorio = false;
        Form2 loading;
        TimeSpan ts;
        MediaPlayer Reproductor = new MediaPlayer();
        Metodos metodos = new Metodos();
        string[] Nombres;
        string[] Rutas;
        int indice = 0;
        string tagArtist = "";
        bool iseePlayer = false;

        Thread thread;
        delegate void MyDelegadpo(int valor, int maximo); //Delegado de un método de la barra de progreso
        delegate void DelegadoState(bool activo); //Se puede usar para cualquier activación de un elemento
        delegate void DataGridSource(DataTable datos); //Usado para cargar datos al datagrid
        delegate void ShowProgressBar(bool activo); //Usado para el metodo que envia la propiedad de visible
        delegate void TotalFicheros(string texto); //Usado para mandar un texto a el lblTotalFichero

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Console.WriteLine(metodos.obtenerIDCarpeta(ruta));
            dataGridView1.DataSource = metodos.ShowSongs();
            if (dataGridView1.Rows.Count == 0)
            {
                Console.WriteLine("Vacío");
                lblVacio1.Visible = true;
                lblVacio2.Visible = true;
            }
            else
            {
                dataGridView1.DataSource = metodos.ShowSongs();
                dataGridView1.Sort(dataGridView1.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
                trackBar1.Value = 50;
                lblTotalFicheros.Text = "Total de canciones agregadas: " + dataGridView1.Rows.Count.ToString();
                lblVolumen.Text = Convert.ToString(trackBar1.Value);
            }
            
            //lblFicheroActual.Text = dataGridView1.CurrentRow.Index.ToString();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Console.WriteLine(repetir);
            indice = 0; // Cada vez que se seleccione una nueva canción el indice se reinicia, para poder aumentarlo
            if (dataGridView1.Rows.Count != 0)
            {
                btnReanudar.Visible = false;
                timer1.Enabled = true;
                timer1.Start();
                string ruta = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
                try
                {
                    Reproductor.Open(new Uri(ruta));//RUTA));//RUTA
                    Reproductor.Play();
                    Console.WriteLine(Reproductor.Volume);
                    Reproductor.MediaEnded += btnSiguiente_Click;
                    Tags(dataGridView1.CurrentRow.Index);
                    setAlbumArt(dataGridView1.CurrentRow.Index);
                    //SetColor();
                    indiceReproduccion = dataGridView1.CurrentRow.Index; //Se guarda un índice de la reproducción para darle un inicio al aumento de la variable indice
                    Console.WriteLine(indiceReproduccion);
                }
                catch (Exception)
                {
                    MessageBox.Show("No se ha podido acceder al archivo\nPuede que esto se deba a alguna de las siguientes razones\n1. Moviste el archivo a otra ubicación\n1. Has eliminado el fichero\n\nPara solucionar esto borra la canción de la base de datos del reproductor y posteriormente vuelvela a añadir",
                        "No se puede acceder al archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Reproductor.Stop();
                }
            }
            else
            {
                MessageBox.Show("Vaya... esto está muy vacio\nDeberias agregar mas canciones :D", "Sin canciones agregadas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnAddCarpeta.PerformClick();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.P))
            {
                Reproductor.Stop();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Reproductor.HasAudio)
            {
                btnReanudar.Visible = true;
                button1.Visible = false;
                ts = Reproductor.Position;
                Reproductor.Pause();
            }
            else
            {
                MessageBox.Show("No puedes usar este botón si no hay algo en reproducción", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                if (Reproductor.HasAudio && repetir != true && aleatorio != true)
                {
                    if (dataGridView1.Rows[dataGridView1.CurrentRow.Index + indice].Index < dataGridView1.Rows.Count - 1)
                    {
                        indice += 1;
                        string ruta = dataGridView1.Rows[indiceReproduccion + indice].Cells[3].Value.ToString(); //Al índice de reproducción acual se le va a sumar el indice aumentado
                        Reproductor.Open(new Uri(ruta));
                        Reproductor.Play();
                        Tags(indiceReproduccion + indice);
                        setAlbumArt(indiceReproduccion + indice);
                        //setLyrics(dataGridView1.CurrentRow.Index + indice);
                        //lblNombreFile.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index + indice].Cells[0].Value.ToString();
                        Console.WriteLine(ruta + " " + indice);
                        Console.WriteLine(indiceReproduccion + indice);
                    }
                    else
                    {
                        MessageBox.Show("Ya no se puede adelantar mas, es la última canción", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (repetir == true)
                {
                    trackBar2.Value = trackBar2.Minimum;
                    Reproductor.Position = TimeSpan.FromSeconds(trackBar2.Value);
                }
                else if (aleatorio == true)
                {
                    int indiceObtenido = indiceAleatorio.Next(0, dataGridView1.Rows.Count);
                    string ruta = dataGridView1.Rows[indiceObtenido].Cells[3].Value.ToString();
                    Reproductor.Open(new Uri(ruta));
                    Reproductor.Play();
                    Tags(indiceObtenido);
                    setAlbumArt(indiceObtenido);
                }
                else
                {
                    MessageBox.Show("No puedes usar este botón si no hay algo en reproducción", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error crítico: "+  ex);
            }

        }

        private void agregarMusicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        public void showTextLblTFicheros(string texto)
        {
            lblTotalFicheros.Text = texto;
        }

        public void ShowPB(bool activo)
        {
            progressBar1.Visible = activo;
        }

        public void DataSource(DataTable source)
        {
            dataGridView1.DataSource = source;
        }

        public void lblStado(bool activo)
        {
            lblState.Visible = activo;
        }

        public void progresoCarpeta(int valor, int maximo)
        {
            Console.WriteLine("Valor: " + valor + " Máximo " + maximo);
            progressBar1.Maximum = maximo;
            progressBar1.Value = valor;
            
        }

        public void progreso(int valor, int maximo)
        {
            Console.WriteLine("Valor: " + valor + "Máximo" + maximo);
            progressBar1.Value = valor;
            progressBar1.Maximum = maximo;
        }

        void AgregarDeCarpeta(string rutaDirectorio, int id)
        {
            string[] Directorios;
            try
            {
                Directorios = Directory.GetFiles(rutaDirectorio, "*", SearchOption.AllDirectories); //Guardamos todos los directorios de los archivos en un arreglo
                bool tareaCompletada = false;
                string nombre, album;
                string artista = null;

                DelegadoState state = new DelegadoState(lblStado);
                MyDelegadpo my = new MyDelegadpo(progresoCarpeta);
                DataGridSource data = new DataGridSource(DataSource);
                ShowProgressBar progressBar = new ShowProgressBar(ShowPB);
                TotalFicheros ficheros = new TotalFicheros(showTextLblTFicheros);
                this.Invoke(progressBar, new object[] { true });
                this.Invoke(state, new object[] { true });

                for (int i = 0; i < Directorios.Length; i++)
                {
                    string directorio = Directorios[i].Remove(0, Directorios[i].Length - 4); //A cada string de la iteración se le eliminan todos los dígitos excepto los ultimos 4

                    if (directorio == ".mp3" || directorio == "flac")
                    {
                        TagLib.File files = TagLib.File.Create(Directorios[i].ToString());

                        if (files.Tag.Title != null && files.Tag.Title.Length > 1)
                        {
                            nombre = files.Tag.Title;

                        }
                        else
                        {
                            nombre = "Título desconocido";

                        }
                        if (files.Tag.Album != null)
                        {
                            album = files.Tag.Album;
                        }
                        else
                        {
                            album = "Album Desconocido";
                        }

                        if (files.Tag.Performers.Length == 0)
                        {
                            tagArtist = "Autor Desconocido";
                            foreach (string str in files.Tag.Performers)
                            {
                                tagArtist += str;
                                tagArtist += "; ";
                            }
                            tagArtist = tagArtist.Substring(0, tagArtist.Length);
                            artista = tagArtist;
                        }
                        else
                        {
                            string[] performers = files.Tag.Performers;
                            if (nombre.Length > 2 && album != null && performers[0].Length > 1)
                            {
                                tagArtist = performers[0].ToString();
                                artista = tagArtist;
                            }
                        }
                        metodos.PushSongsFromFile(nombre, album, artista, Directorios[i].ToString(), id);
                        tareaCompletada = true;
                    }
                    this.Invoke(my, new object[] { i, Directorios.Length });
                }
                if (tareaCompletada == true)
                {
                    this.Invoke(my, new object[] { 0, 0 });
                    this.Invoke(state, new object[] { false });
                    this.Invoke(progressBar, new object[] { false });
                    this.Invoke(data, new object[] { metodos.ShowSongs() });
                    this.Invoke(ficheros, new object[] { "Total de canciones agregadas: " + dataGridView1.Rows.Count.ToString() });
                    MessageBox.Show("Ficheros añadidos a la base de datos", "Acción exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    this.Invoke(my, new object[] { 0, 0 });
                    this.Invoke(state, new object[] { false });
                    this.Invoke(progressBar, new object[] { false });
                    MessageBox.Show("Parece que no hay archivos para agregar....\n\nEsta carpeta no contiene archivos .mp3 o .flac para agregar", "Error al añadir ficheros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show("No se puede acceder a los elementos de este directorio porque no es una carpeta con los suficientes permisos\n\n" +
                                "Recomendación: Mueve tu música a una carpeta apta para esos ficheros, puedes usar la carpeta 'Música' del sistema operativo", "Error de permisos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        void AgregarFicherosConTags(string[] Rutas)
        {
            string nombre, album;
            string artista = null;

            DelegadoState state = new DelegadoState(lblStado);
            MyDelegadpo my = new MyDelegadpo(progreso);
            DataGridSource data = new DataGridSource(DataSource);
            ShowProgressBar progressBar = new ShowProgressBar(ShowPB);
            TotalFicheros ficheros = new TotalFicheros(showTextLblTFicheros);
            this.Invoke(progressBar, new object[] { true });
            this.Invoke(state, new object[] { true });

            for (int i = 0; i < Rutas.Length; i++)
            {
                TagLib.File files = TagLib.File.Create(Rutas[i].ToString());

                if (files.Tag.Title != null && files.Tag.Title.Length > 1)
                {
                    nombre = files.Tag.Title;
                    //notifyIcon1.Text = "Reproduciendo ahora: " + mp3Tag.Tag.Title;
                }
                else
                {
                    nombre = "Título desconocido";
                }

                if (files.Tag.Album == null) ///SI EL ALBUM NO TIENE CONTENIDO
                {
                    album = "Album Desconocido";
                }
                else
                {
                    //DE LO CONTRARIO EXTRAE EL NOMBRE DEL ALBUM
                    album = files.Tag.Album;
                }

                //TAG ARTISTA O ARTISTAS DE LA CANCIÓN
                if (files.Tag.Performers.Length == 0)//SI NO HAY NOMBRE DEL ARTISTA
                {
                    tagArtist = "Autor Desconocido";
                    foreach (string str in files.Tag.Performers)
                    {
                        tagArtist += str;
                        tagArtist += "; ";
                    }
                    tagArtist = tagArtist.Substring(0, tagArtist.Length);
                    artista = tagArtist;
                    Console.WriteLine("En if");
                }
                else
                {
                    string[] performers = files.Tag.Performers;
                    if (nombre.Length > 2 && album != null && performers[0].Length > 1)
                    {
                        tagArtist = performers[0].ToString();
                        artista = tagArtist;
                    }
                }
                metodos.PushSongs(nombre, album, artista, Rutas[i].ToString());
                this.Invoke(data, new object[] { metodos.ShowSongs() });
                this.Invoke(ficheros, new object[] { "Total de canciones agregadas: " + dataGridView1.Rows.Count.ToString() });
                this.Invoke(my, new object[] { i, Rutas.Length });
            }
            this.Invoke(my, new object[] { 0, 0 });
            this.Invoke(state, new object[] { false });
            this.Invoke(progressBar, new object[] { false });
            MessageBox.Show("Ficheros añadidos a la base de datos");
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void Tags(int indice)
        {
            TagLib.File mp3Tag = TagLib.File.Create(dataGridView1.Rows[indice].Cells[3].Value.ToString());

            if (mp3Tag.Tag.Title != null && mp3Tag.Tag.Title.Length > 1)
            {
                if (mp3Tag.Tag.Title.Length > 50) //Si el titulo es mayor a 50 caracteres
                {
                    Console.WriteLine(mp3Tag.Tag.Title.Length);
                    lblNombreFile.Text = mp3Tag.Tag.Title.Remove(50).Insert(50, "..."); //Eliminamos todo lo que esté a la derecha de la posición 50 e insertamos puntos suspensivos
                }
                else
                {
                    lblNombreFile.Text = mp3Tag.Tag.Title;
                }
                
                //notifyIcon1.Text = "Reproduciendo ahora: " + mp3Tag.Tag.Title;
            }
            else
            {
                lblNombreFile.Text = dataGridView1.Rows[indice].Cells[0].Value.ToString();
            }

            if (mp3Tag.Tag.Album == null) ///SI EL ALBUM NO TIENE CONTENIDO
            {
                lblAlbum.Text = "Album Desconocido";
            }
            else
            {
                //DE LO CONTRARIO EXTRAE EL NOMBRE DEL ALBUM
                lblAlbum.Text = mp3Tag.Tag.Album;
            }

            //TAG ARTISTA O ARTISTAS DE LA CANCIÓN
            if (mp3Tag.Tag.Performers.Length == 0)//SI NO HAY NOMBRE DEL ARTISTA
            {
                tagArtist = "Autor Desconocido";
                foreach (string str in mp3Tag.Tag.Performers)
                {
                    tagArtist += str;
                    tagArtist += "; ";
                }
                tagArtist = tagArtist.Substring(0, tagArtist.Length);
                lblArtistas.Text = tagArtist;
                Console.WriteLine("En if");
            }
            else
            {
                string[] performers = mp3Tag.Tag.Performers;
                if (lblNombreFile.Text.Length > 2 && lblAlbum != null && performers[0].Length > 1)
                {
                    tagArtist = performers[0].ToString();
                    lblArtistas.Text = tagArtist;
                }
            }

            if (mp3Tag.Properties.AudioBitrate > 0)
            {
                lblBibrate.Text = Convert.ToString(mp3Tag.Properties.AudioBitrate) + "Kbps";
            }
            else
            {
                lblBibrate.Text = "El archivo no tiene información";
            }

        }

        public void setAlbumArt(int indice)
        {
            try
            {
                TagLib.File file = TagLib.File.Create(dataGridView1.Rows[indice].Cells[3].Value.ToString());
                if (file.Tag.Pictures.Length > 0)
                {
                    var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                    pictureBox1.Image = Image.FromStream(new MemoryStream(bin)).GetThumbnailImage(250, 250, null, IntPtr.Zero);


                }
                else
                {
                    pictureBox1.Image = Properties.Resources.icons8_notas_musicales_96;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error crítico: " + ex);
            }
            
        }

        /*public void SetColor()
        {
            Random r = new Random();
            int red = r.Next(128);
            int green = 0;
            int blue = r.Next(255);
            panel1.BackColor = System.Drawing.Color.FromArgb(red, green, blue);
            panel3.BackColor = System.Drawing.Color.FromArgb(red, green, blue);
            panel4.BackColor = System.Drawing.Color.FromArgb(red, green, blue);
        }*/

        public void setLyrics(int indice)
        {

        }

        private void btnReanudar_Click(object sender, EventArgs e)
        {
            btnReanudar.Visible = false;
            button1.Visible = true;
            ts = Reproductor.Position;
            Reproductor.Position = ts;
            Reproductor.Play();
        }

        private void timer1_Tick(object sender, EventArgs e)   //Si se inicia el timer...
        {
            ts = Reproductor.Position; // Time snap sera igual a la posicion del reproductior EJEMPLO: Reproduciendo una canción obtendra el segundo y minuto del mismo
            lblTiempoActual.Text = ts.ToString(@"mm\:ss");    //Se le da un formato a la cadena recibida por el TimeSnap
            if (Reproductor.NaturalDuration.HasTimeSpan == true)  //Si el reproductor puede acceder al TimeSnap....
            {
                //Console.WriteLine(Reproductor.NaturalDuration.TimeSpan.TotalSeconds.ToString());
                trackBar2.Maximum = (int)Reproductor.NaturalDuration.TimeSpan.TotalSeconds; //Se asigna a 
                trackBar2.Value = (int)Reproductor.Position.TotalSeconds;
                lblTotalRepro.Text = Reproductor.NaturalDuration.TimeSpan.ToString(@"mm\:ss");
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            try
            {
                if (Reproductor.HasAudio && aleatorio == false) //Si el reproductor tiene un audio...
                {
                    if (dataGridView1.Rows[dataGridView1.CurrentRow.Index + indice].Index != 0) //Si el indice es diferente de 0...
                    {
                        indice -= 1; //se resta un valor al indice actual
                        string ruta = dataGridView1.Rows[dataGridView1.CurrentRow.Index + indice].Cells[3].Value.ToString(); //Se aplica la resta y obtenemos la ruta de esa posición
                        Reproductor.Open(new Uri(ruta)); //Abrimos el elemento de esa ruta con uri.
                        Reproductor.Play(); //Reproduce el audio...
                        Tags(dataGridView1.CurrentRow.Index + indice); //Aplica tags dependiendo del indice
                        setAlbumArt(dataGridView1.CurrentRow.Index + indice); //Muestra album dependiendo del indice
                        Console.WriteLine();
                    }
                    else // Si no se cúmple la condición entonces...
                    {
                        Reproductor.Open(new Uri(dataGridView1.Rows[0].Cells[1].Value.ToString())); //Reproduce el elemento inicial de nuevo *LINEA NO TAN NECESARIA
                        Reproductor.Play();
                        Tags(dataGridView1.Rows[0].Index);
                        indice = 0; //Reinicia el indice para evitar problemas
                        MessageBox.Show("Ya no puedes atrasar más", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop); //Se advierte al usuario
                    }
                    //lblNombreFile.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index + indice].Cells[0].Value.ToString();
                }
                else if (aleatorio == true)
                {
                    int indiceObtenido = indiceAleatorio.Next(0, dataGridView1.Rows.Count);
                    string ruta = dataGridView1.Rows[indiceObtenido].Cells[3].Value.ToString();
                    Reproductor.Open(new Uri(ruta));
                    Reproductor.Play();
                    Tags(indiceObtenido);
                    setAlbumArt(indiceObtenido);
                }
                else
                {
                    MessageBox.Show("No puedes usar este botón si no hay algo en reproducción", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error crítico: " + ex);
            }
            
        }

        private void toolStripTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                dataGridView1.DataSource = metodos.searchFilesInDB(tolltxtBuscar.Text);
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            Reproductor.Volume = trackBar1.Value / 100.0f; //El valor de .Volume máximo es 1, entonces los valores del elemento usado deben dividirse entre 100
            Console.WriteLine(Reproductor.Volume);
        }

        private void lblTotalFicheros_Click(object sender, EventArgs e)
        {

        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {

        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            Reproductor.Position = TimeSpan.FromSeconds(trackBar2.Value); //Indica que del objeto trackbar se obtendra un valor emn segundos de tipo TimesPan y coloca el valor en el reproductor
        }

        private void lblTotalRepro_Click(object sender, EventArgs e)
        {

        }

        private void LoadingShow()
        {
            loading = new Form2();
            loading.Show();
        }

        private void LoadingClose()
        {
            loading = new Form2();
            loading.Close();
        }

        private void eliminarTodaLaMusicaAgregadaALaBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void eliminarSelecciónDelAlmacenamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string ruta = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
                //string nombre = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].ToString();
                DirectoryInfo info = new DirectoryInfo(ruta);
                DialogResult result = new DialogResult();
                result = MessageBox.Show("¿Estás seguro de eliminar " + info.Name + " de manera permanente?", "Eliminando archivo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    System.IO.File.Delete(ruta);
                    MessageBox.Show("Fichero eliminado correctamente\n\nRecomendación: Elimina tambien el registro de la base de datos del reproductor", "Acción exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

            }
        }

        private void reproducirAhoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRepetir_Click(object sender, EventArgs e)
        {
            if (repetir == true)
            {
                repetir = false;
                btnRepetir.Image = Properties.Resources.icons8_repetir_30_Gray;
            }
            else if (aleatorio == false)
            {
                repetir = true;
                btnRepetir.Image = Properties.Resources.icons8_repetir_30;
            }
            else
            {
                MessageBox.Show("¡No puedes activar Repetir y Aleatorio al mismo tiempo!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            if (aleatorio == true)
            {
                aleatorio = false;
                btnAleatorio.Image = Properties.Resources.icons8_shuffle_30_Gray;
            }
            else if (repetir == false)
            {
                aleatorio = true;
                btnAleatorio.Image = Properties.Resources.icons8_shuffle_30;
            }
            else
            {
                MessageBox.Show("¡No puedes activar Repetir y Aleatorio al mismo tiempo!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void notasDeActualizaciónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pausarCanciónActualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.PerformClick();
        }

        private void reanudarCanciónActualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnReanudar.PerformClick();
        }

        private void salirDeLaAplicaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void siguienteCanciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSiguiente.PerformClick();
        }

        private void contextMenuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void eliminarSelecciónDeLaBaseDeDatosDelReproductorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = MessageBox.Show("Estás a punto de eliminar un registro de la base de datos\nsi la canción está repetida en uno o varios registros se quitaran de la base de datos\n\n¿Deseas continuar?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string Nombre = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                string Album = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                string Artistas = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                metodos.EliminarCancionSeleccionada(Nombre, Album, Artistas);
                dataGridView1.DataSource = metodos.ShowSongs();
            }
        }

        private void lblVacio2_Click(object sender, EventArgs e)
        {
            btnAddCarpeta.PerformClick();
        }

        private void trackBar2_MouseDown(object sender, MouseEventArgs e)
        {
            Reproductor.Pause();
        }

        private void trackBar2_MouseUp(object sender, MouseEventArgs e)
        {
            Reproductor.Play();
        }

        private void añadirFicherosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var AgregarArchivos = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "Archivo mp3|*.mp3|Archivo flac|*.flac",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic),
                FilterIndex = 1
            };

            if (AgregarArchivos.ShowDialog() == DialogResult.OK)
            {
                //lblState.Visible = true;
                //progressBar1.Visible = true;
                Nombres = AgregarArchivos.SafeFileNames;
                Rutas = AgregarArchivos.FileNames;
                progressBar1.Maximum = Nombres.Length;

                thread = new Thread(() => AgregarFicherosConTags(Rutas));
                thread.Start();

                //progressBar1.Visible = false;
                //lblState.Visible = false;
                lblVacio1.Visible = false;
                lblVacio2.Visible = false;
            }
            lblTotalFicheros.Text = "Total de canciones agregadas: " + dataGridView1.Rows.Count.ToString();
        }

        

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblVolumen.Text = Convert.ToString(trackBar1.Value);
        }

        private void toolStripSplitButton1_Click(object sender, EventArgs e)
        {
                
            
        }
        private void btnBiblioteca_Click(object sender, EventArgs e)
        {
            if (iseePlayer == false)
            {
                iseePlayer = true;
                btnBiblioteca.Image = Properties.Resources.icons8_ocultar_30;
                this.Width = 419;
                this.Height = 638;
            }
            else
            {
                iseePlayer = false;
                this.Width = 1268;
                this.Height = 638;
                btnBiblioteca.Image = Properties.Resources.icons8_visible_30;
            }
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Configuración configuración = new Configuración(lblArtistas.Font.Name, lblArtistas.ForeColor.Name, panel1.BackColor.Name);
            configuración.Show();
        }

        private void btnLyrics_Click_1(object sender, EventArgs e)
        {
            if (lblNombreFile.Text  != "<No hay nada en reproducción>")
            {
                VisualizadorLyrics lyrics = new VisualizadorLyrics(metodos.obtenerRuta(lblNombreFile.Text, lblAlbum.Text, lblArtistas.Text), lblNombreFile.Text);
                lyrics.Show();
            }
        }

        private void btnFicheros_Click(object sender, EventArgs e)
        {
            var AgregarArchivos = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "Archivo mp3|*.mp3|Archivo flac|*.flac",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic),
                FilterIndex = 1
            };

            if (AgregarArchivos.ShowDialog() == DialogResult.OK)
            {
                //lblState.Visible = true;
                //progressBar1.Visible = true;
                Nombres = AgregarArchivos.SafeFileNames;
                Rutas = AgregarArchivos.FileNames;
                progressBar1.Maximum = Nombres.Length;

                thread = new Thread(() => AgregarFicherosConTags(Rutas));
                thread.Start();

                //progressBar1.Visible = false;
                //lblState.Visible = false;
                lblVacio1.Visible = false;
                lblVacio2.Visible = false;
            }
            lblTotalFicheros.Text = "Total de canciones agregadas: " + dataGridView1.Rows.Count.ToString();
        }

        private void btnAddCarpeta_Click(object sender, EventArgs e)
        {
            string rutaDirectorio = string.Empty;

            FolderBrowserDialog dialog = new FolderBrowserDialog(); //Abrimos el selector de carpetas
            dialog.ShowNewFolderButton = false;
            dialog.Description = "Selecciona una carpeta que contenga archivos mp3 y flac\nSe recomienda almacenar la música dentro de la carpeta ya destinada por el sistema operativo";

            if (dialog.ShowDialog() == DialogResult.OK) //Si se coloca ok
            {
                rutaDirectorio = dialog.SelectedPath; //Guardamos la ruta seleccionada

                if (metodos.AgregarCarpeta(rutaDirectorio) == true)
                {
                    int id = metodos.obtenerIDCarpeta(rutaDirectorio);
                    DialogResult dialogResult = new DialogResult();
                    dialogResult = MessageBox.Show("Se ha añadido la carpeta seleccionada a la base de datos\n¿Deseas agregar su música ahora\nB¿No te preocupes si no la agregas ahora, posteriormente puedes hacaerlo pulsando en la administración de la biblioteca", "Confirmación", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        thread = new Thread(() => AgregarDeCarpeta(rutaDirectorio, id));
                        thread.Start();
                    }
                    else
                    {
                        MessageBox.Show("Se ha agregado a la base de datos exitosamente la ruta "+rutaDirectorio);
                    }
                }
                else{
                    MessageBox.Show("Ha ocurrido un error al agregar la carpeta");
                }

                //if (rutaDirectorio != null)
                //{
                    
                //}
                //else
                //{
                //    MessageBox.Show("Esta carpeta no tiene archivos dentro");
                //}
            }
            else
            {
                rutaDirectorio = null;
            }
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            DialogResult result = new DialogResult();
            Dialogos_interfaz.DialogoBorrarTodoBD borrarTodoBD = new Dialogos_interfaz.DialogoBorrarTodoBD();
            result = borrarTodoBD.ShowDialog();
            //MessageBox.Show("¿Estas seguro de borrar toda la música agregada?\n\nALERTA: TENDRAS QUE VOLVER A AÑADIR TU MÚSICA DESDE 0", "Eliminar toda la musica agregada",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                metodos.EliminarMusica();
                dataGridView1.DataSource = metodos.ShowSongs();
            }
            lblTotalFicheros.Text = "Total de canciones agregadas: " + dataGridView1.Rows.Count.ToString();
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            AcercaDe acercaDe = new AcercaDe();
            acercaDe.Show();
        }

        private void btnHistorialAct_Click(object sender, EventArgs e)
        {
            NotasDeActualizaciónForm notas = new NotasDeActualizaciónForm();
            notas.Show();
        }

        private void btnVisualizador_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLyrics_Click(object sender, EventArgs e)
        {
            VisualizadorLyrics lyrics = new VisualizadorLyrics(metodos.obtenerRuta(lblNombreFile.Text, lblAlbum.Text, lblArtistas.Text), lblNombreFile.Text);
            lyrics.Show();

        }

        private void btnVisualizador_Click_1(object sender, EventArgs e)
        {
            Metadatos metadatos = new Metadatos(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString());
            metadatos.Show();
        }

        private void btnBiblioteca_Click_1(object sender, EventArgs e)
        {
            if (iseePlayer == false)
            {
                iseePlayer = true;
                btnBiblioteca.Image = Properties.Resources.icons8_ocultar_30;
                this.Width = 512;
                this.Height = 578;
            }
            else
            {
                iseePlayer = false;
                this.Width = 1268;
                this.Height = 578;
                btnBiblioteca.Image = Properties.Resources.icons8_visible_30;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dialogos_interfaz.ActualizarCarpetas actualizarCarpetas = new Dialogos_interfaz.ActualizarCarpetas();
            actualizarCarpetas.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Primero borramos los datos anteriores a esos
            metodos.EliminarMusica();
            //Ahora agregamos de nuevo la música
            DataTable carpetas = metodos.obtenerDirectoriosGurdados();
            //Recorremos el datatable y por cada iteracion agregamos la cancion con el id del registro de la carpeta a la base de datos
            foreach (DataRow row in carpetas.Rows)
            {
                string ruta = row["URL"].ToString();
                int id = metodos.obtenerIDCarpeta(ruta);
                AgregarDeCarpeta(ruta, id);
            }
        }
    }
}
