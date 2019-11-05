using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pont_Finder.avalie
{
    class XmlListAvalie
    {
        private string caminhoPost = "..\\..\\data\\postagens.xml";

        public void AdicionarPost(string desc, string tipoProblema, string localiza, string tempohor, string email,string modulo)
        {

            XElement usu =
                new XElement("avalie",
                new XElement("usuario", email),
                new XElement("modulo", modulo),
                new XElement("DataHora", tempohor),
                new XElement("TipoProblema", tipoProblema),
                new XElement("Localizacao", localiza),
                new XElement("Descricao", desc));

            XDocument doc = XDocument.Load(caminhoPost);
            doc.Root.Add(usu);
            doc.Save(caminhoPost);

            //usado para adicionar um usuario ao xml
            /*
            xmlli.Add(11, "jhon", "jhon@gmail", "19374", 32859734);
            */

        }


        public List<string[]> select()
        {

            List<string[]> poster = new List<string[]>();

            XDocument doc = XDocument.Load(caminhoPost);

            foreach (var item in doc.Descendants("avalie"))
            {
                string usuario = item.Element("Usuario").Value;
                string modulo = item.Element("modulo").Value;
                string datahora = item.Element("DataHora").Value;
                string tipoproblema = item.Element("TipoProblema").Value;
                string localizacao = item.Element("Localizacao").Value;
                string descricao = item.Element("Descricao").Value;

                string[] v = { usuario,modulo,datahora,tipoproblema,localizacao,descricao };

                poster.Add(v);

            }
            return poster;



        }
    }
}
