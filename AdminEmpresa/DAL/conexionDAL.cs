using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AdminEmpresa.DAL
{
    class conexionDAL
    {
        private string CadenaConexion= "Data Source=DESKTOP-QKGGBPT; Initial Catalog=dbSistema; Integrated Security=True";

        SqlConnection Conexion;
        public SqlConnection EstablecerConexion()
        {
            this.Conexion = new SqlConnection(this.CadenaConexion);
            return this.Conexion;
        }


        public bool Pruebaconectar(string strComando)
        { 
         try {
               // SqlConnection Conexion = new SqlConnection();
                SqlCommand Comando = new SqlCommand();
                Comando.CommandText = strComando;
                Comando.Connection =this.EstablecerConexion();
                Conexion.Open();
                Comando.ExecuteNonQuery();
                Conexion.Close();
                return true;
            }
            catch {
                return false;
            }
        }
    }
}
