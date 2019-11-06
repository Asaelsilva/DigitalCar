using DbDllGenerico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bdDllEspecifica
{
    public class DBBaseEspecifica
    {
        public void Inserir(string nome)
        {
            DBBase bd = new DBBase();
            string Query = "INSERT INTO tb01(Nome)VALUES('" + nome + "')";
            bd.ExecuteInstrucoesNaBase(Query);
        }

        public void Consultar()
        {

        }
    }
}
