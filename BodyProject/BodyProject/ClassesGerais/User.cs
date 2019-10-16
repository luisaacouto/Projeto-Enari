using System;
using System.Collections.Generic;
using System.Text;

namespace BodyProject
{
    class User
    {
        private string nome;
        private string email;
        private string senha;
        private long cpf;
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
    }
}
