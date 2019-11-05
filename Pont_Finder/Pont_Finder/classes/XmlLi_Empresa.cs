using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Pont_Finder
{
    class XmlLi_Empresa
    {
        private string caminho = "..\\..\\data\\empresas.xml";

        public XElement Full
        {
            get { return XElement.Load(caminho); }
            //retorna o xml
            /*
             Console.WriteLine(xmlli.Full);
            */
        }

        public void AddServico(string nome, string nomeFantasia, string email, string telefone, string endereco, long cnpj, long cpf, bool status)
        {
            XElement serv =
                new XElement("servico",
                new XElement("nome", nome),
                new XElement("nomeFantasia", nomeFantasia),
                new XElement("email", email),
                new XElement("telefone", telefone),
                new XElement("endereco", endereco),
                new XElement("cnpj", cnpj),
                new XElement("cpf", cpf),
                new XElement("status", status));
            XDocument doc = XDocument.Load(caminho);
            doc.Root.Add(serv);
            doc.Save(caminho);
        }

        public List<string[]> Select(string modulo)
        {
            List<string[]> serv = new List<string[]>();

            XDocument doc = XDocument.Load(caminho);

            switch (modulo)
            {
                case "servico":
                    foreach (var item in doc.Descendants("servico"))
                    {
                        string nome = item.Element("nome").Value;
                        string nomeFantasia = item.Element("nomeFantasia").Value;
                        string email = item.Element("email").Value;
                        string senha = item.Element("senha").Value;
                        string telefone = item.Element("telefone").Value;
                        string endereco = item.Element("endereco").Value;
                        string cnpj = item.Element("cnpj").Value;
                        string status = item.Element("status").Value;

                        string[] v = { nome, nomeFantasia, email, senha, telefone, endereco, cnpj, status };
                        serv.Add(v);
                    }
                    return serv;
                default:
                    string[] error = { "0" };
                    serv.Add(error);
                    return serv;
            }

        }

        public void Drop()
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(caminho);

            XDocument xdoc = XDocument.Load(caminho);

            foreach (var item in xdoc.Descendants("servico"))
            {
                XmlNode node = xmldoc.SelectSingleNode("/modulos/servico");
                node.ParentNode.RemoveChild(node);
            }

            xmldoc.Save(caminho);

        }

    }
}
