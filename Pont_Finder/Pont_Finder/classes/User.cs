using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder
{
    class User
    {
        //atributos
        private string nome, email, senha, sexo;
        private long cpf;
        int celular;
        DateTime dataNascimento;
        private bool ativo;


        //metodos
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public long Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public bool Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public int Celular
        {
            get { return celular; }
            set { celular = value; }
        }

        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }
    }
}
