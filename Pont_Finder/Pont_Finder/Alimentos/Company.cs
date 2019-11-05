using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder.alimentos
{
    class Company
    {
        private string nome, nomeFantasia, email, tipoServico, senha, rua, bairro;
        private long cnpj;
        private int numero, cep, ID;
        private bool status;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string NomeFantasia
        {
            get { return nomeFantasia; }
            set { nomeFantasia = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string TipoServico
        {
            get { return tipoServico; }
            set { tipoServico = value; }
        }
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
        public long Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }
        public string Rua
        {
            get { return rua; }
            set { rua = value; }
        }
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }
        public int Cep
        {
            get { return cep; }
            set { cep = value; }
        }
        public bool Status
        {
            get { return status; }
            set { status = value; }
        }
        public int Id
        {
            get { return ID; }
            set { ID = value; }
        }
    }
}
