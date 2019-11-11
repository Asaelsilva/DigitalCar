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
        public void Inserir(string nome, string cpf, string rg, DateTime datanascimento, string email, string turno, string funcao,
                            string  status, decimal telefone, decimal celular, int cep, string uf, string cidade, string rua, int numero, string bairro)
        {
            DBBase bd = new DBBase();
            string Query = "INSERT INTO Funcionario(Nome, cpf, rg )VALUES('" + nome +  "' , " + cpf + ", '" + rg + "', '" + datanascimento + "' , '" + email + "' , '" + turno + "' , " +
                " '" + funcao + "' , '" + status + "' , " + telefone + " , " + celular + " , " + cep + " , '" + uf + "' , '" + cidade + "' , '" + rua + "' , " + numero + " , " + bairro + "')";
            bd.ExecuteInstrucoesNaBase(Query);
        }

        public void Consultar()
        {

        }
    }
}
