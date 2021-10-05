
namespace Presentacion
{
    partial class FrmAltaEquipo
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
            this.gbDatosJugadores = new System.Windows.Forms.GroupBox();
            this.lblNombreEquipo = new System.Windows.Forms.Label();
            this.lblDirectorTecnico = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbDatosJugadores.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatosJugadores
            // 
            this.gbDatosJugadores.Controls.Add(this.lblNombreEquipo);
            this.gbDatosJugadores.Controls.Add(this.lblDirectorTecnico);
            this.gbDatosJugadores.Controls.Add(this.textBox2);
            this.gbDatosJugadores.Controls.Add(this.textBox1);
            this.gbDatosJugadores.Location = new System.Drawing.Point(12, 12);
            this.gbDatosJugadores.Name = "gbDatosJugadores";
            this.gbDatosJugadores.Size = new System.Drawing.Size(480, 119);
            this.gbDatosJugadores.TabIndex = 15;
            this.gbDatosJugadores.TabStop = false;
            this.gbDatosJugadores.Text = "Datos";
            // 
            // lblNombreEquipo
            // 
            this.lblNombreEquipo.AutoSize = true;
            this.lblNombreEquipo.Location = new System.Drawing.Point(6, 35);
            this.lblNombreEquipo.Name = "lblNombreEquipo";
            this.lblNombreEquipo.Size = new System.Drawing.Size(80, 13);
            this.lblNombreEquipo.TabIndex = 2;
            this.lblNombreEquipo.Text = "Nombre Equipo";
            // 
            // lblDirectorTecnico
            // 
            this.lblDirectorTecnico.AutoSize = true;
            this.lblDirectorTecnico.Location = new System.Drawing.Point(6, 65);
            this.lblDirectorTecnico.Name = "lblDirectorTecnico";
            this.lblDirectorTecnico.Size = new System.Drawing.Size(86, 13);
            this.lblDirectorTecnico.TabIndex = 3;
            this.lblDirectorTecnico.Text = "Director Tecnico";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(123, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(225, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 20);
            this.textBox1.TabIndex = 7;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(154, 137);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(132, 49);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // FrmAltaEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 200);
            this.Controls.Add(this.gbDatosJugadores);
            this.Controls.Add(this.btnGuardar);
            this.Name = "FrmAltaEquipo";
            this.Text = "FrmAltaEquipo";
            this.gbDatosJugadores.ResumeLayout(false);
            this.gbDatosJugadores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatosJugadores;
        private System.Windows.Forms.Label lblNombreEquipo;
        private System.Windows.Forms.Label lblDirectorTecnico;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGuardar;
    }
}