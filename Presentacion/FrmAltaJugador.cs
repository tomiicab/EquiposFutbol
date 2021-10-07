using Acceso_a_Datos;
using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmAltaJugador : Form
    {
        SqlConnection cnn = new SqlConnection(HelperDao.Connection());
        private SqlCommand cmd = null;

        public FrmAltaJugador()
        {
            InitializeComponent();
            CargarComboNumeroPosicion();
            CargarComboEquipos();
        }

        private void CargarComboNumeroPosicion()
        {
            try
            {
                DataTable table = new DataTable();
                cnn.Open();
                cmd = new SqlCommand("SP_CONSULTAR_POSICIONES", cnn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                table.Load(cmd.ExecuteReader());
                cboNumPosicion.DataSource = table;
                cboNumPosicion.DisplayMember = table.Columns[1].ColumnName; //"n_producto";
                cboNumPosicion.ValueMember = table.Columns[0].ColumnName; //"id_producto";
                cnn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al cargar combo posiciones");
            }

        }

        private void CargarComboEquipos()
        {
            try
            {
                DataTable table = new DataTable();
                cnn.Open();
                cmd = new SqlCommand("SP_CONSULTAR_EQUIPOS", cnn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                table.Load(cmd.ExecuteReader());
                cboEquipo.DataSource = table;
                cboEquipo.DisplayMember = table.Columns[1].ColumnName; //"n_producto";
                cboEquipo.ValueMember = table.Columns[0].ColumnName; //"id_producto";
                cnn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al cargar combo equipos");
            }

        }

        public void GuardarJugador()
        {

            Jugador jugador = new Jugador(txtBoxNombreJugador.Text,txtDni.Text, dtpFechaNac.Value ,
                Convert.ToInt32(txtNumeroCamiseta.Text), Convert.ToInt32(cboEquipo.SelectedValue), Convert.ToInt32(cboNumPosicion.SelectedValue));


            if (jugador.ConfirmarJugador())
            {
                MessageBox.Show("Jugador Registrado Correctamente", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();

            }
            else
            {
                MessageBox.Show("ERROR. Jugador NO registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarJugador();
        }
    }
}
