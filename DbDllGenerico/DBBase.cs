using DllConfiguracao;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbDllGenerico
{
    public class DBBase
    {
        public void ExecuteInstrucoesNaBase(string QuerySQL)
        {
            Configuracao configuracao = new Configuracao();

            string strConxao = configuracao.StrConfiguracao;
            //@"data source= DESKTOP-O34D68D\SQLEXPRESS; Integrated Security=SSPI; Initial Catalog=dbCrud";
            string Query = QuerySQL;
            SqlConnection con = new SqlConnection(strConxao);
            SqlCommand comando = new SqlCommand(Query, con);

            try
            {
                con.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string erro = ex.Message;
                erro += " !!!";
            }
            finally
            {
                con.Close();
            }
        }
    }
}
