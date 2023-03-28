
namespace CargarMusicaBD
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.reproducirAhoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarSelecciónDelAlmacenamientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarSelecciónDeLaBaseDeDatosDelReproductorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblVolumen = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lblBibrate = new System.Windows.Forms.Label();
            this.lblArtistas = new System.Windows.Forms.Label();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.lblNombreFile = new System.Windows.Forms.Label();
            this.lblTotalRepro = new System.Windows.Forms.Label();
            this.lblTiempoActual = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tolltxtBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.siguienteCanciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pausarCanciónActualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reanudarCanciónActualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirDeLaAplicaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTotalFicheros = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblState = new System.Windows.Forms.Label();
            this.btnRepetir = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnAleatorio = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnReanudar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblVacio1 = new System.Windows.Forms.Label();
            this.lblVacio2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnHistorialAct = new System.Windows.Forms.Button();
            this.btnAcercaDe = new System.Windows.Forms.Button();
            this.btnBorrarTodo = new System.Windows.Forms.Button();
            this.btnAddCarpeta = new System.Windows.Forms.Button();
            this.btnFicheros = new System.Windows.Forms.Button();
            this.btnVisualizador = new System.Windows.Forms.Button();
            this.btnLyrics = new System.Windows.Forms.Button();
            this.btnBiblioteca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(496, 86);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(756, 412);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.BackColor = System.Drawing.Color.White;
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reproducirAhoraToolStripMenuItem,
            this.eliminarSelecciónDelAlmacenamientoToolStripMenuItem,
            this.eliminarSelecciónDeLaBaseDeDatosDelReproductorToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(358, 70);
            // 
            // reproducirAhoraToolStripMenuItem
            // 
            this.reproducirAhoraToolStripMenuItem.Image = global::CargarMusicaBD.Properties.Resources.icons8_play_30;
            this.reproducirAhoraToolStripMenuItem.Name = "reproducirAhoraToolStripMenuItem";
            this.reproducirAhoraToolStripMenuItem.Size = new System.Drawing.Size(357, 22);
            this.reproducirAhoraToolStripMenuItem.Text = "Reproducir ahora";
            this.reproducirAhoraToolStripMenuItem.Click += new System.EventHandler(this.reproducirAhoraToolStripMenuItem_Click);
            // 
            // eliminarSelecciónDelAlmacenamientoToolStripMenuItem
            // 
            this.eliminarSelecciónDelAlmacenamientoToolStripMenuItem.Image = global::CargarMusicaBD.Properties.Resources.icons8_eliminar_30;
            this.eliminarSelecciónDelAlmacenamientoToolStripMenuItem.Name = "eliminarSelecciónDelAlmacenamientoToolStripMenuItem";
            this.eliminarSelecciónDelAlmacenamientoToolStripMenuItem.Size = new System.Drawing.Size(357, 22);
            this.eliminarSelecciónDelAlmacenamientoToolStripMenuItem.Text = "Eliminar selección del almacenamiento";
            this.eliminarSelecciónDelAlmacenamientoToolStripMenuItem.Click += new System.EventHandler(this.eliminarSelecciónDelAlmacenamientoToolStripMenuItem_Click);
            // 
            // eliminarSelecciónDeLaBaseDeDatosDelReproductorToolStripMenuItem
            // 
            this.eliminarSelecciónDeLaBaseDeDatosDelReproductorToolStripMenuItem.Image = global::CargarMusicaBD.Properties.Resources.icons8_eliminar_base_de_datos_30;
            this.eliminarSelecciónDeLaBaseDeDatosDelReproductorToolStripMenuItem.Name = "eliminarSelecciónDeLaBaseDeDatosDelReproductorToolStripMenuItem";
            this.eliminarSelecciónDeLaBaseDeDatosDelReproductorToolStripMenuItem.Size = new System.Drawing.Size(357, 22);
            this.eliminarSelecciónDeLaBaseDeDatosDelReproductorToolStripMenuItem.Text = "Eliminar selección de la base de datos del reproductor";
            this.eliminarSelecciónDeLaBaseDeDatosDelReproductorToolStripMenuItem.Click += new System.EventHandler(this.eliminarSelecciónDeLaBaseDeDatosDelReproductorToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panel1.Controls.Add(this.btnBiblioteca);
            this.panel1.Controls.Add(this.btnVisualizador);
            this.panel1.Controls.Add(this.btnAleatorio);
            this.panel1.Controls.Add(this.btnAnterior);
            this.panel1.Controls.Add(this.btnSiguiente);
            this.panel1.Controls.Add(this.btnRepetir);
            this.panel1.Controls.Add(this.lblBibrate);
            this.panel1.Controls.Add(this.lblArtistas);
            this.panel1.Controls.Add(this.lblVolumen);
            this.panel1.Controls.Add(this.lblTotalRepro);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblTiempoActual);
            this.panel1.Controls.Add(this.lblAlbum);
            this.panel1.Controls.Add(this.lblNombreFile);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.trackBar2);
            this.panel1.Controls.Add(this.btnLyrics);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnReanudar);
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 498);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblVolumen
            // 
            this.lblVolumen.AutoSize = true;
            this.lblVolumen.ForeColor = System.Drawing.Color.White;
            this.lblVolumen.Location = new System.Drawing.Point(24, 195);
            this.lblVolumen.Name = "lblVolumen";
            this.lblVolumen.Size = new System.Drawing.Size(25, 13);
            this.lblVolumen.TabIndex = 20;
            this.lblVolumen.Text = "100";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.Image = global::CargarMusicaBD.Properties.Resources.icons8_notas_musicales_96;
            this.pictureBox1.Location = new System.Drawing.Point(116, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Image = global::CargarMusicaBD.Properties.Resources.icons8_volumen_medio_32;
            this.label1.Location = new System.Drawing.Point(24, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 29);
            this.label1.TabIndex = 5;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(27, 69);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(23, 80);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // lblBibrate
            // 
            this.lblBibrate.AutoSize = true;
            this.lblBibrate.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBibrate.ForeColor = System.Drawing.Color.White;
            this.lblBibrate.Location = new System.Drawing.Point(229, 466);
            this.lblBibrate.Name = "lblBibrate";
            this.lblBibrate.Size = new System.Drawing.Size(53, 19);
            this.lblBibrate.TabIndex = 16;
            this.lblBibrate.Text = "0 Kbps";
            // 
            // lblArtistas
            // 
            this.lblArtistas.AutoSize = true;
            this.lblArtistas.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtistas.ForeColor = System.Drawing.Color.White;
            this.lblArtistas.Location = new System.Drawing.Point(13, 308);
            this.lblArtistas.Name = "lblArtistas";
            this.lblArtistas.Size = new System.Drawing.Size(206, 19);
            this.lblArtistas.TabIndex = 6;
            this.lblArtistas.Text = "<No hay nada en reproducción>";
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlbum.ForeColor = System.Drawing.Color.White;
            this.lblAlbum.Location = new System.Drawing.Point(13, 343);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(206, 19);
            this.lblAlbum.TabIndex = 5;
            this.lblAlbum.Text = "<No hay nada en reproducción>";
            // 
            // lblNombreFile
            // 
            this.lblNombreFile.AutoSize = true;
            this.lblNombreFile.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreFile.ForeColor = System.Drawing.Color.White;
            this.lblNombreFile.Location = new System.Drawing.Point(12, 266);
            this.lblNombreFile.Name = "lblNombreFile";
            this.lblNombreFile.Size = new System.Drawing.Size(303, 25);
            this.lblNombreFile.TabIndex = 1;
            this.lblNombreFile.Text = "<No hay nada en reproducción>";
            // 
            // lblTotalRepro
            // 
            this.lblTotalRepro.AutoSize = true;
            this.lblTotalRepro.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalRepro.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRepro.ForeColor = System.Drawing.Color.White;
            this.lblTotalRepro.Location = new System.Drawing.Point(391, 428);
            this.lblTotalRepro.Name = "lblTotalRepro";
            this.lblTotalRepro.Size = new System.Drawing.Size(79, 37);
            this.lblTotalRepro.TabIndex = 10;
            this.lblTotalRepro.Text = "00:00";
            this.lblTotalRepro.Click += new System.EventHandler(this.lblTotalRepro_Click);
            // 
            // lblTiempoActual
            // 
            this.lblTiempoActual.AutoSize = true;
            this.lblTiempoActual.BackColor = System.Drawing.Color.Transparent;
            this.lblTiempoActual.Font = new System.Drawing.Font("Segoe UI Light", 20.25F);
            this.lblTiempoActual.ForeColor = System.Drawing.Color.White;
            this.lblTiempoActual.Location = new System.Drawing.Point(20, 426);
            this.lblTiempoActual.Name = "lblTiempoActual";
            this.lblTiempoActual.Size = new System.Drawing.Size(79, 37);
            this.lblTiempoActual.TabIndex = 9;
            this.lblTiempoActual.Text = "00:00";
            // 
            // trackBar2
            // 
            this.trackBar2.AutoSize = false;
            this.trackBar2.Location = new System.Drawing.Point(81, 437);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(313, 23);
            this.trackBar2.TabIndex = 13;
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            this.trackBar2.ValueChanged += new System.EventHandler(this.trackBar2_ValueChanged);
            this.trackBar2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackBar2_MouseDown);
            this.trackBar2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar2_MouseUp);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tolltxtBuscar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1252, 44);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackColor = System.Drawing.Color.White;
            this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel1.Image = global::CargarMusicaBD.Properties.Resources.icons8_búsqueda_25;
            this.toolStripLabel1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(25, 41);
            // 
            // tolltxtBuscar
            // 
            this.tolltxtBuscar.AutoSize = false;
            this.tolltxtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tolltxtBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tolltxtBuscar.ForeColor = System.Drawing.Color.White;
            this.tolltxtBuscar.Name = "tolltxtBuscar";
            this.tolltxtBuscar.Size = new System.Drawing.Size(100, 41);
            this.tolltxtBuscar.ToolTipText = "Escribe un nombre de una canción o artista";
            this.tolltxtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBox1_KeyPress);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Reproduciendo";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siguienteCanciónToolStripMenuItem,
            this.pausarCanciónActualToolStripMenuItem,
            this.reanudarCanciónActualToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirDeLaAplicaciónToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(180, 98);
            this.contextMenuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.contextMenuStrip1_MouseMove);
            // 
            // siguienteCanciónToolStripMenuItem
            // 
            this.siguienteCanciónToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.siguienteCanciónToolStripMenuItem.Name = "siguienteCanciónToolStripMenuItem";
            this.siguienteCanciónToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.siguienteCanciónToolStripMenuItem.Text = "Siguiente canción...";
            this.siguienteCanciónToolStripMenuItem.Click += new System.EventHandler(this.siguienteCanciónToolStripMenuItem_Click);
            // 
            // pausarCanciónActualToolStripMenuItem
            // 
            this.pausarCanciónActualToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.pausarCanciónActualToolStripMenuItem.Name = "pausarCanciónActualToolStripMenuItem";
            this.pausarCanciónActualToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.pausarCanciónActualToolStripMenuItem.Text = "Pausar canción actual";
            this.pausarCanciónActualToolStripMenuItem.Click += new System.EventHandler(this.pausarCanciónActualToolStripMenuItem_Click);
            // 
            // reanudarCanciónActualToolStripMenuItem
            // 
            this.reanudarCanciónActualToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.reanudarCanciónActualToolStripMenuItem.Name = "reanudarCanciónActualToolStripMenuItem";
            this.reanudarCanciónActualToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.reanudarCanciónActualToolStripMenuItem.Text = "Reanudar canción actual";
            this.reanudarCanciónActualToolStripMenuItem.Click += new System.EventHandler(this.reanudarCanciónActualToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(176, 6);
            // 
            // salirDeLaAplicaciónToolStripMenuItem
            // 
            this.salirDeLaAplicaciónToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.salirDeLaAplicaciónToolStripMenuItem.Name = "salirDeLaAplicaciónToolStripMenuItem";
            this.salirDeLaAplicaciónToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.salirDeLaAplicaciónToolStripMenuItem.Text = "Salir de la aplicación";
            this.salirDeLaAplicaciónToolStripMenuItem.Click += new System.EventHandler(this.salirDeLaAplicaciónToolStripMenuItem_Click);
            // 
            // lblTotalFicheros
            // 
            this.lblTotalFicheros.AutoSize = true;
            this.lblTotalFicheros.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFicheros.ForeColor = System.Drawing.Color.White;
            this.lblTotalFicheros.Location = new System.Drawing.Point(6, 8);
            this.lblTotalFicheros.Name = "lblTotalFicheros";
            this.lblTotalFicheros.Size = new System.Drawing.Size(231, 23);
            this.lblTotalFicheros.TabIndex = 14;
            this.lblTotalFicheros.Text = "Total de canciones agregadas:";
            this.lblTotalFicheros.Click += new System.EventHandler(this.lblTotalFicheros_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.lblState);
            this.panel2.Controls.Add(this.lblTotalFicheros);
            this.panel2.Location = new System.Drawing.Point(496, 498);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 40);
            this.panel2.TabIndex = 7;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(554, 16);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(190, 10);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 16;
            this.progressBar1.Visible = false;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.Color.White;
            this.lblState.Location = new System.Drawing.Point(321, 8);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(211, 23);
            this.lblState.TabIndex = 15;
            this.lblState.Text = "Analizando y añadiendo música";
            this.lblState.Visible = false;
            // 
            // btnRepetir
            // 
            this.btnRepetir.BackColor = System.Drawing.Color.Transparent;
            this.btnRepetir.FlatAppearance.BorderSize = 0;
            this.btnRepetir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnRepetir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepetir.Image = global::CargarMusicaBD.Properties.Resources.icons8_repetir_30_Gray;
            this.btnRepetir.Location = new System.Drawing.Point(81, 373);
            this.btnRepetir.Name = "btnRepetir";
            this.btnRepetir.Size = new System.Drawing.Size(51, 52);
            this.btnRepetir.TabIndex = 18;
            this.btnRepetir.UseVisualStyleBackColor = false;
            this.btnRepetir.Click += new System.EventHandler(this.btnRepetir_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.Transparent;
            this.btnAnterior.FlatAppearance.BorderSize = 0;
            this.btnAnterior.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Image = global::CargarMusicaBD.Properties.Resources.icons8_rebobinar_30;
            this.btnAnterior.Location = new System.Drawing.Point(138, 373);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(51, 52);
            this.btnAnterior.TabIndex = 3;
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnAleatorio
            // 
            this.btnAleatorio.BackColor = System.Drawing.Color.Transparent;
            this.btnAleatorio.FlatAppearance.BorderSize = 0;
            this.btnAleatorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnAleatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAleatorio.Image = global::CargarMusicaBD.Properties.Resources.icons8_shuffle_30_Gray;
            this.btnAleatorio.Location = new System.Drawing.Point(362, 373);
            this.btnAleatorio.Name = "btnAleatorio";
            this.btnAleatorio.Size = new System.Drawing.Size(51, 52);
            this.btnAleatorio.TabIndex = 17;
            this.btnAleatorio.UseVisualStyleBackColor = false;
            this.btnAleatorio.Click += new System.EventHandler(this.btnAleatorio_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.Transparent;
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Image = global::CargarMusicaBD.Properties.Resources.icons8_avance_rápido_30;
            this.btnSiguiente.Location = new System.Drawing.Point(294, 373);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(51, 52);
            this.btnSiguiente.TabIndex = 4;
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnReanudar
            // 
            this.btnReanudar.BackColor = System.Drawing.Color.Transparent;
            this.btnReanudar.FlatAppearance.BorderSize = 0;
            this.btnReanudar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReanudar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReanudar.Image = global::CargarMusicaBD.Properties.Resources.icons8_play_64;
            this.btnReanudar.Location = new System.Drawing.Point(207, 366);
            this.btnReanudar.Name = "btnReanudar";
            this.btnReanudar.Size = new System.Drawing.Size(75, 66);
            this.btnReanudar.TabIndex = 8;
            this.btnReanudar.UseVisualStyleBackColor = false;
            this.btnReanudar.Visible = false;
            this.btnReanudar.Click += new System.EventHandler(this.btnReanudar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::CargarMusicaBD.Properties.Resources.icons8_pausa_50;
            this.button1.Location = new System.Drawing.Point(211, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 52);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblVacio1
            // 
            this.lblVacio1.AutoSize = true;
            this.lblVacio1.BackColor = System.Drawing.Color.Black;
            this.lblVacio1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVacio1.ForeColor = System.Drawing.Color.White;
            this.lblVacio1.Location = new System.Drawing.Point(762, 299);
            this.lblVacio1.Name = "lblVacio1";
            this.lblVacio1.Size = new System.Drawing.Size(214, 29);
            this.lblVacio1.TabIndex = 17;
            this.lblVacio1.Text = "Esto esta muy vacio...";
            this.lblVacio1.Visible = false;
            // 
            // lblVacio2
            // 
            this.lblVacio2.AutoSize = true;
            this.lblVacio2.BackColor = System.Drawing.Color.Black;
            this.lblVacio2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVacio2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVacio2.ForeColor = System.Drawing.Color.White;
            this.lblVacio2.Location = new System.Drawing.Point(639, 392);
            this.lblVacio2.Name = "lblVacio2";
            this.lblVacio2.Size = new System.Drawing.Size(460, 29);
            this.lblVacio2.TabIndex = 18;
            this.lblVacio2.Text = "Pulsa aquí para empezar a analizar una carpeta";
            this.lblVacio2.Visible = false;
            this.lblVacio2.Click += new System.EventHandler(this.lblVacio2_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(496, 41);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(756, 45);
            this.panel6.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(342, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 33);
            this.label2.TabIndex = 17;
            this.label2.Text = "Biblioteca";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 200;
            this.toolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolTip1.ForeColor = System.Drawing.Color.White;
            // 
            // btnHistorialAct
            // 
            this.btnHistorialAct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnHistorialAct.FlatAppearance.BorderSize = 0;
            this.btnHistorialAct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorialAct.Image = global::CargarMusicaBD.Properties.Resources.icons8_historia_de_la_actividad_25;
            this.btnHistorialAct.Location = new System.Drawing.Point(1165, 1);
            this.btnHistorialAct.Name = "btnHistorialAct";
            this.btnHistorialAct.Size = new System.Drawing.Size(35, 38);
            this.btnHistorialAct.TabIndex = 25;
            this.toolTip1.SetToolTip(this.btnHistorialAct, "Visualiza el historial de actualizaciones");
            this.btnHistorialAct.UseVisualStyleBackColor = false;
            this.btnHistorialAct.Click += new System.EventHandler(this.btnHistorialAct_Click);
            // 
            // btnAcercaDe
            // 
            this.btnAcercaDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnAcercaDe.FlatAppearance.BorderSize = 0;
            this.btnAcercaDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcercaDe.Image = global::CargarMusicaBD.Properties.Resources.icons8_información_25;
            this.btnAcercaDe.Location = new System.Drawing.Point(1208, 1);
            this.btnAcercaDe.Name = "btnAcercaDe";
            this.btnAcercaDe.Size = new System.Drawing.Size(35, 38);
            this.btnAcercaDe.TabIndex = 24;
            this.toolTip1.SetToolTip(this.btnAcercaDe, "Acerca de");
            this.btnAcercaDe.UseVisualStyleBackColor = false;
            this.btnAcercaDe.Click += new System.EventHandler(this.btnAcercaDe_Click);
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnBorrarTodo.FlatAppearance.BorderSize = 0;
            this.btnBorrarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarTodo.Image = global::CargarMusicaBD.Properties.Resources.icons8_borrar_para_siempre_25;
            this.btnBorrarTodo.Location = new System.Drawing.Point(212, 0);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(35, 38);
            this.btnBorrarTodo.TabIndex = 23;
            this.toolTip1.SetToolTip(this.btnBorrarTodo, "Eliminar toda la biblioteca (No borra archivos físicos)");
            this.btnBorrarTodo.UseVisualStyleBackColor = false;
            this.btnBorrarTodo.Click += new System.EventHandler(this.btnBorrarTodo_Click);
            // 
            // btnAddCarpeta
            // 
            this.btnAddCarpeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnAddCarpeta.FlatAppearance.BorderSize = 0;
            this.btnAddCarpeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCarpeta.Image = global::CargarMusicaBD.Properties.Resources.icons8_agregar_carpeta_25;
            this.btnAddCarpeta.Location = new System.Drawing.Point(171, 0);
            this.btnAddCarpeta.Name = "btnAddCarpeta";
            this.btnAddCarpeta.Size = new System.Drawing.Size(35, 38);
            this.btnAddCarpeta.TabIndex = 22;
            this.toolTip1.SetToolTip(this.btnAddCarpeta, "Añadir música en base a un directorio...");
            this.btnAddCarpeta.UseVisualStyleBackColor = false;
            this.btnAddCarpeta.Click += new System.EventHandler(this.btnAddCarpeta_Click);
            // 
            // btnFicheros
            // 
            this.btnFicheros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnFicheros.FlatAppearance.BorderSize = 0;
            this.btnFicheros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFicheros.Image = global::CargarMusicaBD.Properties.Resources.icons8_agregar_archivo_25;
            this.btnFicheros.Location = new System.Drawing.Point(133, 1);
            this.btnFicheros.Name = "btnFicheros";
            this.btnFicheros.Size = new System.Drawing.Size(35, 38);
            this.btnFicheros.TabIndex = 21;
            this.toolTip1.SetToolTip(this.btnFicheros, "Añadir a la base de datos por ficheros...");
            this.btnFicheros.UseVisualStyleBackColor = false;
            this.btnFicheros.Click += new System.EventHandler(this.btnFicheros_Click);
            // 
            // btnVisualizador
            // 
            this.btnVisualizador.BackColor = System.Drawing.Color.Transparent;
            this.btnVisualizador.FlatAppearance.BorderSize = 0;
            this.btnVisualizador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVisualizador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizador.Image = global::CargarMusicaBD.Properties.Resources.icons8_visible_30;
            this.btnVisualizador.Location = new System.Drawing.Point(440, 110);
            this.btnVisualizador.Name = "btnVisualizador";
            this.btnVisualizador.Size = new System.Drawing.Size(51, 39);
            this.btnVisualizador.TabIndex = 25;
            this.toolTip1.SetToolTip(this.btnVisualizador, "Muestra u oculta la biblioteca");
            this.btnVisualizador.UseVisualStyleBackColor = false;
            this.btnVisualizador.Click += new System.EventHandler(this.btnVisualizador_Click_1);
            // 
            // btnLyrics
            // 
            this.btnLyrics.BackColor = System.Drawing.Color.Transparent;
            this.btnLyrics.FlatAppearance.BorderSize = 0;
            this.btnLyrics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLyrics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLyrics.Image = global::CargarMusicaBD.Properties.Resources.icons8_micrófono_2_30;
            this.btnLyrics.Location = new System.Drawing.Point(440, 54);
            this.btnLyrics.Name = "btnLyrics";
            this.btnLyrics.Size = new System.Drawing.Size(51, 39);
            this.btnLyrics.TabIndex = 24;
            this.toolTip1.SetToolTip(this.btnLyrics, "Visualizar letra");
            this.btnLyrics.UseVisualStyleBackColor = false;
            this.btnLyrics.Click += new System.EventHandler(this.btnLyrics_Click);
            // 
            // btnBiblioteca
            // 
            this.btnBiblioteca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnBiblioteca.FlatAppearance.BorderSize = 0;
            this.btnBiblioteca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBiblioteca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBiblioteca.Image = global::CargarMusicaBD.Properties.Resources.icons8_visible_30;
            this.btnBiblioteca.Location = new System.Drawing.Point(440, 9);
            this.btnBiblioteca.Name = "btnBiblioteca";
            this.btnBiblioteca.Size = new System.Drawing.Size(51, 39);
            this.btnBiblioteca.TabIndex = 23;
            this.toolTip1.SetToolTip(this.btnBiblioteca, "Muestra u oculta la biblioteca");
            this.btnBiblioteca.UseVisualStyleBackColor = false;
            this.btnBiblioteca.Click += new System.EventHandler(this.btnBiblioteca_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1252, 539);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnHistorialAct);
            this.Controls.Add(this.btnAcercaDe);
            this.Controls.Add(this.btnBorrarTodo);
            this.Controls.Add(this.btnAddCarpeta);
            this.Controls.Add(this.btnFicheros);
            this.Controls.Add(this.lblVacio2);
            this.Controls.Add(this.lblVacio1);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NestPlayer Beta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblNombreFile;
        public System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.Button btnSiguiente;
        public System.Windows.Forms.Button btnAnterior;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.ToolStripLabel toolStripLabel1;
        public System.Windows.Forms.ToolStripTextBox tolltxtBuscar;
        public System.Windows.Forms.Label lblAlbum;
        public System.Windows.Forms.Label lblArtistas;
        public System.Windows.Forms.Button btnReanudar;
        public System.Windows.Forms.Label lblTiempoActual;
        public System.Windows.Forms.Label lblTotalRepro;
        public System.Windows.Forms.NotifyIcon notifyIcon1;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.TrackBar trackBar1;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TrackBar trackBar2;
        public System.Windows.Forms.Label lblTotalFicheros;
        public System.Windows.Forms.Label lblBibrate;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lblState;
        public System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        public System.Windows.Forms.ToolStripMenuItem eliminarSelecciónDelAlmacenamientoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem reproducirAhoraToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem eliminarSelecciónDeLaBaseDeDatosDelReproductorToolStripMenuItem;
        public System.Windows.Forms.Button btnAleatorio;
        public System.Windows.Forms.Button btnRepetir;
        public System.Windows.Forms.ToolStripMenuItem pausarCanciónActualToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem reanudarCanciónActualToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem salirDeLaAplicaciónToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem siguienteCanciónToolStripMenuItem;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.Label lblVacio1;
        public System.Windows.Forms.Label lblVacio2;
        public System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.Label lblVolumen;
        private System.Windows.Forms.Button btnFicheros;
        private System.Windows.Forms.Button btnAddCarpeta;
        private System.Windows.Forms.Button btnBorrarTodo;
        private System.Windows.Forms.Button btnAcercaDe;
        private System.Windows.Forms.Button btnHistorialAct;
        public System.Windows.Forms.Button btnVisualizador;
        public System.Windows.Forms.Button btnLyrics;
        public System.Windows.Forms.Button btnBiblioteca;
    }
}

