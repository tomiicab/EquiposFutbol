
namespace Presentacion
{
    partial class FrmAltaJugador
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombreCom = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblFechaNaac = new System.Windows.Forms.Label();
            this.lblPosicion = new System.Windows.Forms.Label();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.txtBoxNombreJugador = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNumeroCamiseta = new System.Windows.Forms.TextBox();
            this.cboNumPosicion = new System.Windows.Forms.ComboBox();
            this.cboEquipo = new System.Windows.Forms.ComboBox();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.gbDatosJugadores = new System.Windows.Forms.GroupBox();
            this.gbDatosJugadores.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(117, 259);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(132, 49);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero Camiseta";
            // 
            // lblNombreCom
            // 
            this.lblNombreCom.AutoSize = true;
            this.lblNombreCom.Location = new System.Drawing.Point(6, 35);
            this.lblNombreCom.Name = "lblNombreCom";
            this.lblNombreCom.Size = new System.Drawing.Size(91, 13);
            this.lblNombreCom.TabIndex = 2;
            this.lblNombreCom.Text = "Nombre Completo";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(6, 65);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(23, 13);
            this.lblDni.TabIndex = 3;
            this.lblDni.Text = "Dni";
            // 
            // lblFechaNaac
            // 
            this.lblFechaNaac.AutoSize = true;
            this.lblFechaNaac.Location = new System.Drawing.Point(6, 101);
            this.lblFechaNaac.Name = "lblFechaNaac";
            this.lblFechaNaac.Size = new System.Drawing.Size(93, 13);
            this.lblFechaNaac.TabIndex = 4;
            this.lblFechaNaac.Text = "Fecha Nacimiento";
            // 
            // lblPosicion
            // 
            this.lblPosicion.AutoSize = true;
            this.lblPosicion.Location = new System.Drawing.Point(6, 160);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(72, 13);
            this.lblPosicion.TabIndex = 5;
            this.lblPosicion.Text = "Num Posicion";
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.Location = new System.Drawing.Point(6, 197);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(40, 13);
            this.lblEquipo.TabIndex = 6;
            this.lblEquipo.Text = "Equipo";
            // 
            // txtBoxNombreJugador
            // 
            this.txtBoxNombreJugador.Location = new System.Drawing.Point(123, 35);
            this.txtBoxNombreJugador.Name = "txtBoxNombreJugador";
            this.txtBoxNombreJugador.Size = new System.Drawing.Size(225, 20);
            this.txtBoxNombreJugador.TabIndex = 7;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(123, 65);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(225, 20);
            this.txtDni.TabIndex = 8;
            // 
            // txtNumeroCamiseta
            // 
            this.txtNumeroCamiseta.Location = new System.Drawing.Point(123, 128);
            this.txtNumeroCamiseta.Name = "txtNumeroCamiseta";
            this.txtNumeroCamiseta.Size = new System.Drawing.Size(225, 20);
            this.txtNumeroCamiseta.TabIndex = 9;
            // 
            // cboNumPosicion
            // 
            this.cboNumPosicion.FormattingEnabled = true;
            this.cboNumPosicion.Location = new System.Drawing.Point(123, 160);
            this.cboNumPosicion.Name = "cboNumPosicion";
            this.cboNumPosicion.Size = new System.Drawing.Size(225, 21);
            this.cboNumPosicion.TabIndex = 10;
            // 
            // cboEquipo
            // 
            this.cboEquipo.FormattingEnabled = true;
            this.cboEquipo.Location = new System.Drawing.Point(123, 197);
            this.cboEquipo.Name = "cboEquipo";
            this.cboEquipo.Size = new System.Drawing.Size(225, 21);
            this.cboEquipo.TabIndex = 11;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(123, 101);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(225, 20);
            this.dtpFechaNac.TabIndex = 12;
            // 
            // gbDatosJugadores
            // 
            this.gbDatosJugadores.Controls.Add(this.lblEquipo);
            this.gbDatosJugadores.Controls.Add(this.dtpFechaNac);
            this.gbDatosJugadores.Controls.Add(this.label1);
            this.gbDatosJugadores.Controls.Add(this.cboEquipo);
            this.gbDatosJugadores.Controls.Add(this.lblNombreCom);
            this.gbDatosJugadores.Controls.Add(this.cboNumPosicion);
            this.gbDatosJugadores.Controls.Add(this.lblDni);
            this.gbDatosJugadores.Controls.Add(this.txtNumeroCamiseta);
            this.gbDatosJugadores.Controls.Add(this.lblFechaNaac);
            this.gbDatosJugadores.Controls.Add(this.txtDni);
            this.gbDatosJugadores.Controls.Add(this.lblPosicion);
            this.gbDatosJugadores.Controls.Add(this.txtBoxNombreJugador);
            this.gbDatosJugadores.Location = new System.Drawing.Point(12, 12);
            this.gbDatosJugadores.Name = "gbDatosJugadores";
            this.gbDatosJugadores.Size = new System.Drawing.Size(373, 241);
            this.gbDatosJugadores.TabIndex = 13;
            this.gbDatosJugadores.TabStop = false;
            this.gbDatosJugadores.Text = "Datos";
            // 
            // FrmAltaJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 336);
            this.Controls.Add(this.gbDatosJugadores);
            this.Controls.Add(this.btnGuardar);
            this.Name = "FrmAltaJugador";
            this.Text = "AltaJugador";
            this.gbDatosJugadores.ResumeLayout(false);
            this.gbDatosJugadores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombreCom;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblFechaNaac;
        private System.Windows.Forms.Label lblPosicion;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.TextBox txtBoxNombreJugador;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNumeroCamiseta;
        private System.Windows.Forms.ComboBox cboNumPosicion;
        private System.Windows.Forms.ComboBox cboEquipo;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.GroupBox gbDatosJugadores;
    }
}