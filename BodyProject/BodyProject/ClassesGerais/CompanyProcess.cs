using System;
using System.Collections.Generic;
using System.Text;

namespace BodyProject
{
    class CompanyProcess:CompanyList
    {
        //Método pega os dados via objeto e retorna armazenado em uma variável Company(Empresa). Vai ser usado no Front
        public Company CaptureDados(object[] dados)
        {
            Company c = new Company();
            //convertendo e cortando os pontos e barras da string de CEP e CNPJ
            int cep = Convert.ToInt32(String.Join("", System.Text.RegularExpressions.Regex.Split(Convert.ToString(dados[7]), @"[^\d]")));
            long cnpj = Convert.ToInt64(String.Join("", System.Text.RegularExpressions.Regex.Split(Convert.ToString(dados[8]), @"[^\d]")));
            c.Nome = Convert.ToString(dados[0]);
            c.NomeFantasia = Convert.ToString(dados[1]);
            c.Email = Convert.ToString(dados[2]);
            c.TipoServico = Convert.ToString(dados[3]);
            c.Senha = Convert.ToString(dados[4]);
            c.Rua = Convert.ToString(dados[5]);
            c.Bairro = Convert.ToString(dados[6]);
            c.Cep = cep;
            c.Cnpj = cnpj;
            c.Numero = Convert.ToInt32(dados[9]);          
            return c;
        }
    }
}
