using ModuloAlimentacao;
using Pont_Finder.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //carregando o xml
            XmlLi xmlli = new XmlLi();      
            User user = new User();
            //salvando os itens na lista
            foreach (var item in xmlli.select())
            {
                user.Nome = item[1];
                user.Email = item[2];
                user.Senha = item[3];
                user.Cpf = long.Parse(item[4]);
                user.Ativo = bool.Parse(item[5]);
                UserList.userAdd(user);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
