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
        public void Inserir(string nome, string cpf, string rg, DateTime datanascimento, string email, string telefone, string celular, string rua, string turno, string funcao,
                            string status, int numero, string bairro, string cidade, string cep, string uf   )
        {
            DBBase bd = new DBBase();
            string strQuery = "INSERT INTO Funcionario VALUES ('" + nome +  "' , '" + cpf + "', '" + rg + "', '" + datanascimento + "' , '" + email + "' , '" + telefone + "' , " +
                " '" + celular + "' , '" + rua + "' , '" + turno + "' , '" + funcao + "' , '" + status + "' , " + numero + " , '" + bairro + "' , '" + cidade + "' , '" + cep + "' , '" + uf + "')";
            bd.ExecuteInstrucoesNaBase(strQuery);


        }

        public void Consultar(string nome)
        {
            DBBase banco = new DBBase();
            string Query = "SELECT id_Funcionario,nome, cpf FROM Funcionario WHERE nome = '"+ nome + "'";

            banco.ExecuteInstrucoesNaBase(Query);
        }

        public void InserirVeiculos(string categoria, string marca, string modelo, string placa, int anoModelo, int anoFabricacao
                                   , string propriedade, string status, string cor, string renavan,  int km)
        {
            DBBase bd = new DBBase();
            var strQuery = "";
            strQuery += "INSERT INTO Veiculo (categoria, marca, modelo,placa, ano_modelo, ano_fabricacao, propriedade, status, cor, renavam, km)";
            strQuery += "VALUES ('" + categoria + "' , '" + marca + "', '" + modelo + "', '" + placa + "' , " + anoModelo + " , " + anoFabricacao + " , " +
                " '" + propriedade + "' , '" + status + "' , '" + cor + "' , '" + renavan + "' , " + km + ")";
            bd.ExecuteInstrucoesNaBase(strQuery);

        }

        public void AlteraStatusFuncioanrio(int codigo, string status)
        {
            DBBase bd = new DBBase();
            var strQuery = "";
            strQuery += "UPDATE Funcionario SET status = '" + status + "'  WHERE codigoId = " + codigo;
            bd.ExecuteInstrucoesNaBase(strQuery);
        } 
    }
}
