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
        public void Inserir(string nome, string cpf, string rg, DateTime datanascimento, string email, int turno, int funcao,
                            int  status, string telefone, string celular, string cep, string uf, string cidade, string rua, int numero, string bairro)
        {
            DBBase bd = new DBBase();
            string Query = "INSERT INTO Funcionario VALUES ('" + nome +  "' , '" + cpf + "', '" + rg + "', '" + datanascimento + "' , '" + email + "' , '" + turno + "' , " +
                " '" + funcao + "' , '" + status + "' , '" + telefone + "' , '" + celular + "' , '" + cep + "' , '" + uf + "' , '" + cidade + "' , '" + rua + "' , " + numero + " , '" + bairro + "')";
            bd.ExecuteInstrucoesNaBase(Query);
        }

        public void Consultar(string nome)
        {
            DBBase banco = new DBBase();
            string Query = "SELECT id_Funcionario,nome, cpf FROM Funcionario WHERE nome = '"+ nome + "'";

            banco.ExecuteInstrucoesNaBase(Query);
        }
    }
}
