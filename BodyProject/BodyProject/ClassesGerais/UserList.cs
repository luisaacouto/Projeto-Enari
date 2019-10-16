using System;
using System.Collections.Generic;
using System.Text;

namespace BodyProject
{
    class UserList
    {
        private List<User> users = new List<User>();

        public void userAdd(User user)
        {
            User u = new User();
            u.Nome = user.Nome;
            u.Email = user.Email;
            u.Senha = user.Senha;
            u.Cpf = user.Cpf;
            u.Ativo = user.Ativo;
            users.Add(u);
        }

        public object[] select(int index)
        {
            string nome = users[index].Nome;
            string email = users[index].Email;
            string senha = users[index].Senha;
            long cpf = users[index].Cpf;
            bool ativo = users[index].Ativo;

            object[] vetor = { nome, email, senha, cpf, ativo };
            return vetor;
        }

        public void userDel(int index)
        {
            users[index].Ativo = false;
        }

        public int Tam
        {
            get { return users.Count; }
        }

        public void alter(int index, User u)
        {
            users[index].Nome = u.Nome;
            users[index].Email = u.Email;
            users[index].Senha = u.Senha;
            users[index].Cpf = u.Cpf;
            users[index].Ativo = u.Ativo;
        }

        public List<User> selectAll()
        {
            List<User> lista = new List<User>();
            foreach (var item in users)
            {
                User u = new User();
                u.Nome = item.Nome;
                u.Email = item.Email;
                u.Senha = item.Senha;
                u.Cpf = item.Cpf;
                u.Ativo = item.Ativo;
                lista.Add(u);
            }
            return lista;
        }
    }
}
