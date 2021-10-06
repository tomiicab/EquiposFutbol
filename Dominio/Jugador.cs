using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Jugador : Persona
    {
        private int numCamiseta;
        public int NumCamiseta { get => numCamiseta; set => numCamiseta = value; }
        public Posicion Posicion { get; set; }
        private Equipo Equipo = null;
        

        public Jugador(string nom, string dni, DateTime fecha, int camiseta, int equipo, int posicion) : base(nom,dni,fecha)
        {
            Equipo = new Equipo();
            Posicion = new Posicion();
            Equipo.NombreEquipo = equipo;
            Posicion = (Posicion)posicion;
            
            Dni = dni;
            NombreCompleto = nom;
            FechaNac = fecha;
            NumCamiseta = camiseta;
        }

        public Jugador()
        {
            numCamiseta = 0;
        }

        private int ProximoJugador()
        {
            int salida = 0;
            SqlConnection cnn = new SqlConnection(@"Data Source=PC-TOMI\SQLEXPRESS;Initial Catalog=EquipoFutbol;Integrated Security=True");

            cnn.Open();

            SqlCommand cmd = new SqlCommand("SP_PROXIMO_ID_PERSONA", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parameter = new SqlParameter("@proximo", SqlDbType.Int);
            parameter.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(parameter);
            cmd.ExecuteNonQuery();
            salida = Convert.ToInt32(parameter.Value);
            cnn.Close();
            return salida;
        }

        public bool ConfirmarJugador()
        {
            SqlTransaction transaccion = null;
            int aux = ProximoJugador();
            bool resultado = true;
            SqlConnection cnn = null;

            try
            {
                cnn = new SqlConnection(@"Data Source=PC-TOMI\SQLEXPRESS;Initial Catalog=EquipoFutbol;Integrated Security=True");
                
                cnn.Open();
                transaccion = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand("INSERTAR_JUGADOR", cnn,transaccion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", NombreCompleto);
                cmd.Parameters.AddWithValue("@dni", Convert.ToInt32(Dni));
                cmd.Parameters.AddWithValue("@fecha_nac", FechaNac);
                cmd.Parameters.AddWithValue("@num_cami", NumCamiseta);
                cmd.Parameters.AddWithValue("@id_posicion", (int)Posicion);
                cmd.Parameters.AddWithValue("@id_equipo", Equipo.NombreEquipo);
                cmd.ExecuteNonQuery();
                transaccion.Commit();
            }
            catch (Exception)
            {
                resultado = false;
                transaccion.Rollback();
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }

            return resultado;

        }


    }
}
