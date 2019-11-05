using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder.servicos.classes
{
    class Post
    {
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

        public Post()
        {
            ativo = true;
            cpf = Session.Cpf;
            cnpj = -1;
            data = DateTime.Now;
        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public string Detalhes
        {
            get { return detalhes; }
            set { detalhes = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public bool Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }

        public long Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public long Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        public string Image
        {
            get { return image; }
            set { image = value; }
        }

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        public void like(short valor, long cpf)
        {
            int verify = this.vLike(cpf);
            if (verify == -1)
            {
                long[] v = new long[2];
                v[0] = valor;
                v[1] = cpf;
                likes.Add(v);
            }
            else
            {
                likes[verify][0] = valor;
            }      
        }

        public long Likes
        {
            get
            {
                long total = 0;

                foreach (var item in likes)
                {
                    total += item[0];
                }
                return total;
                ;
            }
        }

        public int vLike(long cpf)
        {
            int cont = -1;
            foreach (var item in likes)
            {
                if (item[1] == cpf)
                {
                    cont++;
                    return cont;
                }               
            }
            return cont;
        }

        public List<long[]> LikesList
        {
            get { return likes ; }
            set { likes = value; }
        }



    }

}

