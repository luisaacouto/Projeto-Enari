using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder.servicos.classes
{
    class PostList
    {
        private static List<Post> posts = new List<Post>();
        public static void Add(Post post)
        {
            Post p = new Post();
            p.Id = post.Id;
            p.Titulo = post.Titulo;
            p.Valor = post.Valor;
            p.Detalhes = post.Detalhes;
            p.Descricao = post.Descricao;         
            p.Image = post.Image;
            posts.Add(p);
        }

        private int id;
        private string titulo;
        private double valor;
        private string detalhes;
        private string descricao;

        private bool ativo;
        private string image;
        private long cpf;
        private long cnpj;
        private DateTime data;
        private List<long[]> likes;



        public static List<Post> selectAll()
        {
            List<Post> lista = new List<Post>();
            foreach (var post in posts)
            {
                Post p = new Post();
                p.Id = post.Id;
                p.Titulo = post.Titulo;
                p.Valor = post.Valor;
                p.Detalhes = post.Detalhes;
                p.Descricao = post.Descricao;
                p.Ativo = post.Ativo;
                p.Image = post.Image;
                p.Cpf = post.Cpf;
                p.Cnpj = post.Cnpj;
                p.Data = post.Data;
                p.LikesList = post.LikesList;
                lista.Add(p);
            }
            return lista;
        }

        public static int Tam
        {
            get { return posts.Count; }
        }

    }
}
