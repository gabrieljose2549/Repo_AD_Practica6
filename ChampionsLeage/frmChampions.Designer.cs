namespace ChampionsLeage
{
    partial class frmChampions
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
            this.pbJugador = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbJugadores = new System.Windows.Forms.ListBox();
            this.lblLista = new System.Windows.Forms.Label();
            this.lblPartido = new System.Windows.Forms.Label();
            this.pbPartido = new System.Windows.Forms.PictureBox();
            this.rbEquipo1 = new System.Windows.Forms.RadioButton();
            this.rbEquipo2 = new System.Windows.Forms.RadioButton();
            this.txtIdJugador = new System.Windows.Forms.TextBox();
            this.txtPuntos = new System.Windows.Forms.TextBox();
            this.txtAsistencias = new System.Windows.Forms.TextBox();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.lblAsistenciasEquipo = new System.Windows.Forms.Label();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lblPresupuesto = new System.Windows.Forms.Label();
            this.btnEquipoGanador = new System.Windows.Forms.Button();
            this.nudEquipo1 = new System.Windows.Forms.NumericUpDown();
            this.nudEquipo2 = new System.Windows.Forms.NumericUpDown();
            this.chkAumentarGoles = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbJugador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPartido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEquipo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEquipo2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbJugador
            // 
            this.pbJugador.Location = new System.Drawing.Point(871, 409);
            this.pbJugador.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.pbJugador.Name = "pbJugador";
            this.pbJugador.Size = new System.Drawing.Size(416, 288);
            this.pbJugador.TabIndex = 0;
            this.pbJugador.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(758, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(648, 1154);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl2.Location = new System.Drawing.Point(865, 830);
            this.lbl2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(176, 26);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "ASISTENCIAS:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl1.Location = new System.Drawing.Point(865, 761);
            this.lbl1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(165, 26);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "ID JUGADOR:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl3.Location = new System.Drawing.Point(919, 896);
            this.lbl3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(116, 26);
            this.lbl3.TabIndex = 6;
            this.lbl3.Text = "PUNTOS:";
            // 
            // lbJugadores
            // 
            this.lbJugadores.FormattingEnabled = true;
            this.lbJugadores.ItemHeight = 32;
            this.lbJugadores.Location = new System.Drawing.Point(871, 135);
            this.lbJugadores.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.lbJugadores.Name = "lbJugadores";
            this.lbJugadores.Size = new System.Drawing.Size(411, 228);
            this.lbJugadores.TabIndex = 7;
            this.lbJugadores.SelectedIndexChanged += new System.EventHandler(this.lbJugadores_SelectedIndexChanged);
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLista.Location = new System.Drawing.Point(912, 71);
            this.lblLista.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(294, 26);
            this.lblLista.TabIndex = 8;
            this.lblLista.Text = "Lista Jugadores en Equipo";
            // 
            // lblPartido
            // 
            this.lblPartido.AutoSize = true;
            this.lblPartido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPartido.Location = new System.Drawing.Point(306, 71);
            this.lblPartido.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPartido.Name = "lblPartido";
            this.lblPartido.Size = new System.Drawing.Size(123, 26);
            this.lblPartido.TabIndex = 9;
            this.lblPartido.Text = "PARTIDO:";
            // 
            // pbPartido
            // 
            this.pbPartido.Image = global::ChampionsLeage.Properties.Resources.Partido;
            this.pbPartido.Location = new System.Drawing.Point(128, 187);
            this.pbPartido.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.pbPartido.Name = "pbPartido";
            this.pbPartido.Size = new System.Drawing.Size(492, 325);
            this.pbPartido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPartido.TabIndex = 10;
            this.pbPartido.TabStop = false;
            // 
            // rbEquipo1
            // 
            this.rbEquipo1.AutoSize = true;
            this.rbEquipo1.Location = new System.Drawing.Point(128, 581);
            this.rbEquipo1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.rbEquipo1.Name = "rbEquipo1";
            this.rbEquipo1.Size = new System.Drawing.Size(132, 36);
            this.rbEquipo1.TabIndex = 11;
            this.rbEquipo1.TabStop = true;
            this.rbEquipo1.Text = "Equipo1";
            this.rbEquipo1.UseVisualStyleBackColor = true;
            this.rbEquipo1.CheckedChanged += new System.EventHandler(this.rbEquipo1_CheckedChanged);
            // 
            // rbEquipo2
            // 
            this.rbEquipo2.AutoSize = true;
            this.rbEquipo2.Location = new System.Drawing.Point(481, 581);
            this.rbEquipo2.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.rbEquipo2.Name = "rbEquipo2";
            this.rbEquipo2.Size = new System.Drawing.Size(132, 36);
            this.rbEquipo2.TabIndex = 12;
            this.rbEquipo2.TabStop = true;
            this.rbEquipo2.Text = "Equipo2";
            this.rbEquipo2.UseVisualStyleBackColor = true;
            this.rbEquipo2.CheckedChanged += new System.EventHandler(this.rbEquipo2_CheckedChanged);
            // 
            // txtIdJugador
            // 
            this.txtIdJugador.Location = new System.Drawing.Point(1066, 753);
            this.txtIdJugador.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtIdJugador.Name = "txtIdJugador";
            this.txtIdJugador.Size = new System.Drawing.Size(212, 39);
            this.txtIdJugador.TabIndex = 13;
            // 
            // txtPuntos
            // 
            this.txtPuntos.Location = new System.Drawing.Point(1066, 889);
            this.txtPuntos.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtPuntos.Name = "txtPuntos";
            this.txtPuntos.Size = new System.Drawing.Size(212, 39);
            this.txtPuntos.TabIndex = 14;
            // 
            // txtAsistencias
            // 
            this.txtAsistencias.Location = new System.Drawing.Point(1066, 825);
            this.txtAsistencias.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtAsistencias.Name = "txtAsistencias";
            this.txtAsistencias.Size = new System.Drawing.Size(212, 39);
            this.txtAsistencias.TabIndex = 15;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(0, 0);
            this.splitter2.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(758, 1154);
            this.splitter2.TabIndex = 16;
            this.splitter2.TabStop = false;
            // 
            // lblAsistenciasEquipo
            // 
            this.lblAsistenciasEquipo.AutoSize = true;
            this.lblAsistenciasEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAsistenciasEquipo.ForeColor = System.Drawing.Color.Red;
            this.lblAsistenciasEquipo.Location = new System.Drawing.Point(154, 970);
            this.lblAsistenciasEquipo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAsistenciasEquipo.Name = "lblAsistenciasEquipo";
            this.lblAsistenciasEquipo.Size = new System.Drawing.Size(322, 26);
            this.lblAsistenciasEquipo.TabIndex = 17;
            this.lblAsistenciasEquipo.Text = "Las Asistencias Totales son: ";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(1066, 970);
            this.txtSueldo.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(212, 39);
            this.txtSueldo.TabIndex = 19;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl4.Location = new System.Drawing.Point(919, 977);
            this.lbl4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(116, 26);
            this.lbl4.TabIndex = 18;
            this.lbl4.Text = "SUELDO:";
            // 
            // lblPresupuesto
            // 
            this.lblPresupuesto.AutoSize = true;
            this.lblPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPresupuesto.ForeColor = System.Drawing.Color.Red;
            this.lblPresupuesto.Location = new System.Drawing.Point(188, 889);
            this.lblPresupuesto.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPresupuesto.Name = "lblPresupuesto";
            this.lblPresupuesto.Size = new System.Drawing.Size(301, 26);
            this.lblPresupuesto.TabIndex = 21;
            this.lblPresupuesto.Text = "El presupuesto máximo es:";
            // 
            // btnEquipoGanador
            // 
            this.btnEquipoGanador.Location = new System.Drawing.Point(1482, 519);
            this.btnEquipoGanador.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnEquipoGanador.Name = "btnEquipoGanador";
            this.btnEquipoGanador.Size = new System.Drawing.Size(162, 103);
            this.btnEquipoGanador.TabIndex = 22;
            this.btnEquipoGanador.Text = "Equipo Ganador";
            this.btnEquipoGanador.UseVisualStyleBackColor = true;
            this.btnEquipoGanador.Click += new System.EventHandler(this.btnEquipoGanador_Click);
            // 
            // nudEquipo1
            // 
            this.nudEquipo1.Enabled = false;
            this.nudEquipo1.Location = new System.Drawing.Point(124, 761);
            this.nudEquipo1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.nudEquipo1.Name = "nudEquipo1";
            this.nudEquipo1.Size = new System.Drawing.Size(143, 39);
            this.nudEquipo1.TabIndex = 23;
            this.nudEquipo1.ValueChanged += new System.EventHandler(this.nudEquipo1_ValueChanged);
            // 
            // nudEquipo2
            // 
            this.nudEquipo2.Enabled = false;
            this.nudEquipo2.Location = new System.Drawing.Point(481, 761);
            this.nudEquipo2.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.nudEquipo2.Name = "nudEquipo2";
            this.nudEquipo2.Size = new System.Drawing.Size(143, 39);
            this.nudEquipo2.TabIndex = 24;
            this.nudEquipo2.ValueChanged += new System.EventHandler(this.nudEquipo2_ValueChanged);
            // 
            // chkAumentarGoles
            // 
            this.chkAumentarGoles.AutoSize = true;
            this.chkAumentarGoles.Location = new System.Drawing.Point(271, 687);
            this.chkAumentarGoles.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.chkAumentarGoles.Name = "chkAumentarGoles";
            this.chkAumentarGoles.Size = new System.Drawing.Size(228, 36);
            this.chkAumentarGoles.TabIndex = 25;
            this.chkAumentarGoles.Text = "Aumentar Goles?";
            this.chkAumentarGoles.UseVisualStyleBackColor = true;
            this.chkAumentarGoles.CheckedChanged += new System.EventHandler(this.chkAumentarGoles_CheckedChanged);
            // 
            // frmChampions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1723, 1154);
            this.Controls.Add(this.chkAumentarGoles);
            this.Controls.Add(this.nudEquipo2);
            this.Controls.Add(this.nudEquipo1);
            this.Controls.Add(this.btnEquipoGanador);
            this.Controls.Add(this.lblPresupuesto);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lblAsistenciasEquipo);
            this.Controls.Add(this.txtAsistencias);
            this.Controls.Add(this.txtPuntos);
            this.Controls.Add(this.txtIdJugador);
            this.Controls.Add(this.rbEquipo2);
            this.Controls.Add(this.rbEquipo1);
            this.Controls.Add(this.pbPartido);
            this.Controls.Add(this.lblPartido);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.lbJugadores);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.pbJugador);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.splitter2);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "frmChampions";
            this.Text = "EQUIPOS Y JUGADORES";
            this.Load += new System.EventHandler(this.frmChampions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbJugador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPartido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEquipo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEquipo2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbJugador;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.ListBox lbJugadores;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.Label lblPartido;
        private System.Windows.Forms.PictureBox pbPartido;
        private System.Windows.Forms.RadioButton rbEquipo1;
        private System.Windows.Forms.RadioButton rbEquipo2;
        private System.Windows.Forms.TextBox txtIdJugador;
        private System.Windows.Forms.TextBox txtPuntos;
        private System.Windows.Forms.TextBox txtAsistencias;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Label lblAsistenciasEquipo;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lblPresupuesto;
        private System.Windows.Forms.Button btnEquipoGanador;
        private System.Windows.Forms.NumericUpDown nudEquipo1;
        private System.Windows.Forms.NumericUpDown nudEquipo2;
        private System.Windows.Forms.CheckBox chkAumentarGoles;
    }
}