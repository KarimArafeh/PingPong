namespace PingPong
{
    partial class Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelJugador = new System.Windows.Forms.Panel();
            this.buResultado = new System.Windows.Forms.Button();
            this.tbPuntosJugador2 = new System.Windows.Forms.TextBox();
            this.labPuntos2 = new System.Windows.Forms.Label();
            this.btAplicar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.tbPuntosJugador1 = new System.Windows.Forms.TextBox();
            this.labelPuntos1 = new System.Windows.Forms.Label();
            this.btModificar = new System.Windows.Forms.Button();
            this.bempezarLiga = new System.Windows.Forms.Button();
            this.bMostrarJ = new System.Windows.Forms.Button();
            this.tBapellido = new System.Windows.Forms.TextBox();
            this.Lapellido = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.LabNomJugador = new System.Windows.Forms.Label();
            this.tBnomJugador = new System.Windows.Forms.TextBox();
            this.listResultado = new System.Windows.Forms.ListView();
            this.listMostrarJugador = new System.Windows.Forms.ListView();
            this.listLiga = new System.Windows.Forms.ListView();
            this.columGanador = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columPuntos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelJugador.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelJugador);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listResultado);
            this.splitContainer1.Panel2.Controls.Add(this.listMostrarJugador);
            this.splitContainer1.Panel2.Controls.Add(this.listLiga);
            this.splitContainer1.Size = new System.Drawing.Size(1432, 615);
            this.splitContainer1.SplitterDistance = 315;
            this.splitContainer1.TabIndex = 0;
            // 
            // panelJugador
            // 
            this.panelJugador.Controls.Add(this.buResultado);
            this.panelJugador.Controls.Add(this.tbPuntosJugador2);
            this.panelJugador.Controls.Add(this.labPuntos2);
            this.panelJugador.Controls.Add(this.btAplicar);
            this.panelJugador.Controls.Add(this.btEliminar);
            this.panelJugador.Controls.Add(this.tbPuntosJugador1);
            this.panelJugador.Controls.Add(this.labelPuntos1);
            this.panelJugador.Controls.Add(this.btModificar);
            this.panelJugador.Controls.Add(this.bempezarLiga);
            this.panelJugador.Controls.Add(this.bMostrarJ);
            this.panelJugador.Controls.Add(this.tBapellido);
            this.panelJugador.Controls.Add(this.Lapellido);
            this.panelJugador.Controls.Add(this.btSave);
            this.panelJugador.Controls.Add(this.LabNomJugador);
            this.panelJugador.Controls.Add(this.tBnomJugador);
            this.panelJugador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelJugador.Location = new System.Drawing.Point(0, 0);
            this.panelJugador.Name = "panelJugador";
            this.panelJugador.Size = new System.Drawing.Size(1432, 315);
            this.panelJugador.TabIndex = 3;
            // 
            // buResultado
            // 
            this.buResultado.Enabled = false;
            this.buResultado.Location = new System.Drawing.Point(434, 176);
            this.buResultado.Name = "buResultado";
            this.buResultado.Size = new System.Drawing.Size(151, 82);
            this.buResultado.TabIndex = 18;
            this.buResultado.Text = "Resultado";
            this.buResultado.UseVisualStyleBackColor = true;
            this.buResultado.Click += new System.EventHandler(this.bResultado_Click);
            // 
            // tbPuntosJugador2
            // 
            this.tbPuntosJugador2.Enabled = false;
            this.tbPuntosJugador2.Location = new System.Drawing.Point(121, 242);
            this.tbPuntosJugador2.Name = "tbPuntosJugador2";
            this.tbPuntosJugador2.Size = new System.Drawing.Size(100, 20);
            this.tbPuntosJugador2.TabIndex = 17;
            // 
            // labPuntos2
            // 
            this.labPuntos2.AutoSize = true;
            this.labPuntos2.Enabled = false;
            this.labPuntos2.Location = new System.Drawing.Point(31, 245);
            this.labPuntos2.Name = "labPuntos2";
            this.labPuntos2.Size = new System.Drawing.Size(87, 13);
            this.labPuntos2.TabIndex = 16;
            this.labPuntos2.Text = "Puntos Jugador2";
            // 
            // btAplicar
            // 
            this.btAplicar.Enabled = false;
            this.btAplicar.Location = new System.Drawing.Point(262, 150);
            this.btAplicar.Name = "btAplicar";
            this.btAplicar.Size = new System.Drawing.Size(75, 112);
            this.btAplicar.TabIndex = 15;
            this.btAplicar.Text = "Aplicar";
            this.btAplicar.UseVisualStyleBackColor = true;
            this.btAplicar.Click += new System.EventHandler(this.btAplicar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Enabled = false;
            this.btEliminar.Location = new System.Drawing.Point(262, 59);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(75, 23);
            this.btEliminar.TabIndex = 14;
            this.btEliminar.Text = "Eliminar Jugador Seleccionado";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // tbPuntosJugador1
            // 
            this.tbPuntosJugador1.Enabled = false;
            this.tbPuntosJugador1.Location = new System.Drawing.Point(121, 216);
            this.tbPuntosJugador1.Name = "tbPuntosJugador1";
            this.tbPuntosJugador1.Size = new System.Drawing.Size(100, 20);
            this.tbPuntosJugador1.TabIndex = 13;
            // 
            // labelPuntos1
            // 
            this.labelPuntos1.AutoSize = true;
            this.labelPuntos1.Enabled = false;
            this.labelPuntos1.Location = new System.Drawing.Point(31, 219);
            this.labelPuntos1.Name = "labelPuntos1";
            this.labelPuntos1.Size = new System.Drawing.Size(87, 13);
            this.labelPuntos1.TabIndex = 12;
            this.labelPuntos1.Text = "Puntos Jugador1";
            // 
            // btModificar
            // 
            this.btModificar.Enabled = false;
            this.btModificar.Location = new System.Drawing.Point(262, 102);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(75, 24);
            this.btModificar.TabIndex = 8;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // bempezarLiga
            // 
            this.bempezarLiga.Location = new System.Drawing.Point(434, 112);
            this.bempezarLiga.Name = "bempezarLiga";
            this.bempezarLiga.Size = new System.Drawing.Size(151, 23);
            this.bempezarLiga.TabIndex = 7;
            this.bempezarLiga.Text = "Empezar Liga";
            this.bempezarLiga.UseVisualStyleBackColor = true;
            this.bempezarLiga.Visible = false;
            this.bempezarLiga.Click += new System.EventHandler(this.bempezarLiga_Click);
            // 
            // bMostrarJ
            // 
            this.bMostrarJ.Enabled = false;
            this.bMostrarJ.Location = new System.Drawing.Point(434, 52);
            this.bMostrarJ.Name = "bMostrarJ";
            this.bMostrarJ.Size = new System.Drawing.Size(151, 23);
            this.bMostrarJ.TabIndex = 6;
            this.bMostrarJ.Text = "Mostrar Jugadores";
            this.bMostrarJ.UseVisualStyleBackColor = true;
            this.bMostrarJ.Click += new System.EventHandler(this.bMostrarJ_Click);
            // 
            // tBapellido
            // 
            this.tBapellido.Location = new System.Drawing.Point(121, 64);
            this.tBapellido.Name = "tBapellido";
            this.tBapellido.Size = new System.Drawing.Size(100, 20);
            this.tBapellido.TabIndex = 5;
            // 
            // Lapellido
            // 
            this.Lapellido.AutoSize = true;
            this.Lapellido.Location = new System.Drawing.Point(45, 64);
            this.Lapellido.Name = "Lapellido";
            this.Lapellido.Size = new System.Drawing.Size(44, 13);
            this.Lapellido.TabIndex = 4;
            this.Lapellido.Text = "Apellido";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(262, 26);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 3;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // LabNomJugador
            // 
            this.LabNomJugador.AutoSize = true;
            this.LabNomJugador.Location = new System.Drawing.Point(45, 36);
            this.LabNomJugador.Name = "LabNomJugador";
            this.LabNomJugador.Size = new System.Drawing.Size(70, 13);
            this.LabNomJugador.TabIndex = 2;
            this.LabNomJugador.Text = "Nom Jugador";
            // 
            // tBnomJugador
            // 
            this.tBnomJugador.Location = new System.Drawing.Point(121, 33);
            this.tBnomJugador.Name = "tBnomJugador";
            this.tBnomJugador.Size = new System.Drawing.Size(100, 20);
            this.tBnomJugador.TabIndex = 0;
            // 
            // listResultado
            // 
            this.listResultado.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columGanador,
            this.columPuntos});
            this.listResultado.Location = new System.Drawing.Point(1064, 0);
            this.listResultado.Name = "listResultado";
            this.listResultado.Size = new System.Drawing.Size(365, 293);
            this.listResultado.TabIndex = 2;
            this.listResultado.UseCompatibleStateImageBehavior = false;
            this.listResultado.View = System.Windows.Forms.View.Details;
            // 
            // listMostrarJugador
            // 
            this.listMostrarJugador.Location = new System.Drawing.Point(0, 0);
            this.listMostrarJugador.Name = "listMostrarJugador";
            this.listMostrarJugador.Size = new System.Drawing.Size(461, 296);
            this.listMostrarJugador.TabIndex = 0;
            this.listMostrarJugador.UseCompatibleStateImageBehavior = false;
            this.listMostrarJugador.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListMostrarJugador_MouseClick);
            // 
            // listLiga
            // 
            this.listLiga.Location = new System.Drawing.Point(0, 0);
            this.listLiga.Name = "listLiga";
            this.listLiga.Size = new System.Drawing.Size(1046, 296);
            this.listLiga.TabIndex = 1;
            this.listLiga.UseCompatibleStateImageBehavior = false;
            this.listLiga.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListLiga_MouseClick);
            // 
            // columGanador
            // 
            this.columGanador.Text = "Ganador";
            // 
            // columPuntos
            // 
            this.columPuntos.Text = "Puntos";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 615);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form";
            this.Text = "PingPong";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelJugador.ResumeLayout(false);
            this.panelJugador.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panelJugador;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label LabNomJugador;
        private System.Windows.Forms.TextBox tBnomJugador;
        private System.Windows.Forms.TextBox tBapellido;
        private System.Windows.Forms.Label Lapellido;
        private System.Windows.Forms.Button bMostrarJ;
        private System.Windows.Forms.Button bempezarLiga;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.TextBox tbPuntosJugador1;
        private System.Windows.Forms.Label labelPuntos1;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btAplicar;
        private System.Windows.Forms.ListView listMostrarJugador;
        private System.Windows.Forms.ListView listLiga;
        private System.Windows.Forms.TextBox tbPuntosJugador2;
        private System.Windows.Forms.Label labPuntos2;
        private System.Windows.Forms.ListView listResultado;
        private System.Windows.Forms.Button buResultado;
        private System.Windows.Forms.ColumnHeader columGanador;
        private System.Windows.Forms.ColumnHeader columPuntos;
    }
}