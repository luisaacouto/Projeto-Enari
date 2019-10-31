using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Pont_Finder
{
    class XmlLi
    {
        //instanciando
        /*
         XmlLi xmlli = new XmlLi();
        */

        private string caminho = "..\\..\\data\\usuarios.xml";


        public XElement Full
        {
            get { return XElement.Load(caminho); }
            //retorna o xml
            /*
             Console.WriteLine(xmlli.Full);
            */
        }

        public void Add(int id, string nome, string email, string senha, long cpf, bool ativo)
        {
  
            XElement usu = 
                new XElement("User",
                new XElement("id", id),
                new XElement("nome", nome),
                new XElement("email", email),
                new XElement("senha", senha),
                new XElement("cpf", cpf),
                new XElement("ativo", ativo));

            XDocument doc = XDocument.Load(caminho);
            doc.Root.Add(usu);
            doc.Save(caminho);

            //usado para adicionar um usuario ao xml
            /*
            xmlli.Add(11, "jhon", "jhon@gmail", "19374", 32859734);
            */

        }

        public void Edit(int id, string nome, string email, string senha)
        {
            var doc = XDocument.Load(caminho);
            var node = doc.Descendants("usuario").FirstOrDefault(usuario => usuario.Element("id").Value == id+"");

            node.SetElementValue("nome", nome);
            node.SetElementValue("email", email);
            node.SetElementValue("senha", senha);

            doc.Save(caminho);

            //editar um usuario por id
            /*
             xmlli.Edit(11, "jhonn", "jho@gmail", "a17");
            */
        }

        public List<string[]> select()
        {

            List<string[]> users = new List<string[]>();

            XDocument doc = XDocument.Load(caminho);

            foreach (var item in doc.Descendants("User"))
            {          
                    string id = item.Element("id").Value;
                    string nome = item.Element("nome").Value;
                    string email = item.Element("email").Value;
                    string senha = item.Element("senha").Value;
                    string cpf = item.Element("cpf").Value;
                    string ativo = item.Element("ativo").Value;

                    string[] v = { id, nome, email, senha, cpf, ativo };

                    users.Add(v);
                
            }
            return users;


            //retorna todos os usuarios em string
            /*
              foreach (var item in xmlli.select())
            {
                foreach (var item2 in item)
                {
                    Console.WriteLine(item2);
                }
                Console.WriteLine("---------------");
            }
            */
        }

        public void Drop()
        {

            

            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(caminho);
           
            XDocument xdoc = XDocument.Load(caminho);

            foreach (var item in xdoc.Descendants("User"))
            {
                XmlNode node = xmldoc.SelectSingleNode("/UserList/User");
                node.ParentNode.RemoveChild(node);
            }
          
            xmldoc.Save(caminho);

        }

    }
}
