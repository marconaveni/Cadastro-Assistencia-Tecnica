using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Cadastro_Assistencia_Tecnica.Model;


namespace pc1_dao.Persistence
{
    class ConnectionFactory
    {
        private SqlConnection conn;

        public SqlConnection getConnection()
        {
            try
            {
               conn = new SqlConnection(@"Data Source=.\Workgroup;Initial Catalog=Assistencia;Persist Security Info=True;User ID=Marco;Password=210317111911");
              //conn = new SqlConnection(@"Data Source=.\WORKGROUP;Initial Catalog=Assistencia;User ID=sa;Password=Wran2103");
              //conn = new SqlConnection(@"Data Source=.\Workgroup;Initial Catalog=Assistencia;Integrated Security=True");
                conn.Open();
                return conn;
            }
            catch (SqlException ex)
            {
                throw new DataBaseNotFoundException(ex.Message);
            }
        }
    }
}
