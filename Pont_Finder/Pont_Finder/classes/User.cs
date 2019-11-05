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
        private string nome;
        private string email;
        private string senha;
        private long cpf;
        private bool ativo;

        //atributos opcionais
        private string endereco;
        private DateTime dataNascimento;

        public User()
        {
            dataNascimento = DateTime.Parse("01/01/0001");
            endereco = null;
        }

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

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }

    }
}
