using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder.servicos.classes
{
    class ServiceList
    {
        private static List<Service> services = new List<Service>();

        public static void Add(Service service)
        {
            Service s = new Service();
            s.Id = service.Id;
            s.Tipo = service.Tipo;
            s.Valor = service.Valor;
            s.Detalhes = service.Detalhes;
            s.Sugestoes = s.Sugestoes;
            s.Visualizacoes = service.Visualizacoes;
            s.Like = service.Like;
            s.Avaliacao = service.Avaliacao;
            s.Ativo = service.Ativo;
            s.Image = service.Image;
            services.Add(s);
        }

        public static List<Service> selectAll()
        {
            List<Service> lista = new List<Service>();
            foreach (var item in services)
            {
                Service tmp = new Service();
                tmp.Id = item.Id;
                tmp.Tipo = item.Tipo;
                tmp.Valor = item.Valor;
                tmp.Detalhes = item.Detalhes;
                tmp.Sugestoes = item.Sugestoes;
                tmp.Visualizacoes = item.Visualizacoes;
                tmp.Like = item.Like;
                tmp.Avaliacao = item.Avaliacao;
                tmp.Ativo = item.Ativo;
                tmp.Image = item.Image;
                lista.Add(tmp);
            }
            return lista;
        }

        public static int Tam
        {
            get { return services.Count; }
        }
    }
}
