
namespace Presentacion
{
    partial class Principal
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
            this.btnAltaJugador = new System.Windows.Forms.Button();
            this.btnAltaEquipo = new System.Windows.Forms.Button();
            this.btnConsultarEquipos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAltaJugador
            // 
            this.btnAltaJugador.Location = new System.Drawing.Point(41, 80);
            this.btnAltaJugador.Name = "btnAltaJugador";
            this.btnAltaJugador.Size = new System.Drawing.Size(129, 112);
            this.btnAltaJugador.TabIndex = 0;
            this.btnAltaJugador.Text = "Alta Jugador";
            this.btnAltaJugador.UseVisualStyleBackColor = true;
            this.btnAltaJugador.Click += new System.EventHandler(this.btnAltaJugador_Click);
            // 
            // btnAltaEquipo
            // 
            this.btnAltaEquipo.Location = new System.Drawing.Point(233, 80);
            this.btnAltaEquipo.Name = "btnAltaEquipo";
            this.btnAltaEquipo.Size = new System.Drawing.Size(129, 112);
            this.btnAltaEquipo.TabIndex = 1;
            this.btnAltaEquipo.Text = "Alta Equipo";
            this.btnAltaEquipo.UseVisualStyleBackColor = true;
            this.btnAltaEquipo.Click += new System.EventHandler(this.btnAltaEquipo_Click);
            // 
            // btnConsultarEquipos
            // 
            this.btnConsultarEquipos.Location = new System.Drawing.Point(421, 80);
            this.btnConsultarEquipos.Name = "btnConsultarEquipos";
            this.btnConsultarEquipos.Size = new System.Drawing.Size(129, 112);
            this.btnConsultarEquipos.TabIndex = 2;
            this.btnConsultarEquipos.Text = "Consultar Equipos";
            this.btnConsultarEquipos.UseVisualStyleBackColor = true;
            this.btnConsultarEquipos.Click += new System.EventHandler(this.btnConsultarEquipos_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 281);
            this.Controls.Add(this.btnConsultarEquipos);
            this.Controls.Add(this.btnAltaEquipo);
            this.Controls.Add(this.btnAltaJugador);
            this.Name = "Principal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAltaJugador;
        private System.Windows.Forms.Button btnAltaEquipo;
        private System.Windows.Forms.Button btnConsultarEquipos;
    }
}

