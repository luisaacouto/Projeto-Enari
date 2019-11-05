using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder.servicos.classes
{
    class Empresa
    {
        private string
            nome,
            nomeFantasia,
            email,
            telefone,
            endereco;
        //rua, numero, cidade, cep

        private long
            cnpj,
            cpf;
        private bool
            status;

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

        public long Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        public long Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        /*
        public void SetEndereco(string rua, string numero, string cidade, string cep)
        {
            endereco[0] = rua;
            endereco[1] = numero;
            endereco[2] = cidade;
            endereco[3] = cep;
        }
        */
      
        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
    }
}
