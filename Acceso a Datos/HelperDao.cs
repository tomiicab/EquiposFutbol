using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Acceso_a_Datos
{
    public class HelperDao
    {
        private static HelperDao instancia;
        private string connectionString;

        private HelperDao()
        {
            connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=EquipoFutbol;Integrated Security=True";
            //connectionString = Resources.StringConexion;
        }

        public static HelperDao ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new HelperDao();
            }
            return instancia;
        }

        public static string Connection()
        {
            return HelperDao.ObtenerInstancia().connectionString;
        }


        public static void CloseConnection(SqlConnection cnn)
        {
            if (cnn != null && cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
        }

    }
}
