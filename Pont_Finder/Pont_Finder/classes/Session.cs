using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder
{
    class Session
    {
        private static int id;
        private static string nome;
        private static string email;
        private static string senha;
        private static long cpf;

        public static int Id
        {
            get { return Session.id; }
            set { Session.id = value; }
        }
        public static string Nome
        {
            get { return Session.nome; }
            set { Session.nome = value; }
        }
        public static string Email
        {
            get { return Session.email; }
            set { Session.email = value; }
        }
        public static string Senha
        {
            get { return Session.senha; }
            set { Session.senha = value; }
        }
        public static long Cpf
        {
            get { return Session.cpf; }
            set { Session.cpf = value; }
        }



    }
}
