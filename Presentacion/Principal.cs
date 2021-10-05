using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Presentacion
{
    public partial class Principal : Form
    {

        public Principal()
        {
            InitializeComponent();

        }

        private void btnAltaJugador_Click(object sender, EventArgs e)
        {
            FrmAltaJugador altaJugador = new FrmAltaJugador();
            altaJugador.ShowDialog();
        }

        private void btnAltaEquipo_Click(object sender, EventArgs e)
        {
            FrmAltaEquipo altaEquipo = new FrmAltaEquipo();
            altaEquipo.ShowDialog();
        }

        private void btnConsultarEquipos_Click(object sender, EventArgs e)
        {
            FrmConsultarEquipos consultarEquipos = new FrmConsultarEquipos();
            consultarEquipos.ShowDialog();
        }
    }




}
