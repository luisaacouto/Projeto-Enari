using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder.servicos
{
    class Service
    {
        private int id;
        private string tipo;
        private double valor;
        private string detalhes;
        private int sugestoes;
        private int visualizacoes;
        private int like;
        private short avaliacao;
        private bool ativo;
        private long cpf;
        private string image;
        private DateTime data;
        private List<long[]> likes;

        public Service()
        {
            cpf = Session.Cpf;
            data = DateTime.Now;
        }



        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
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

        public int Sugestoes
        {
            get { return sugestoes; }
            set { sugestoes = value; }
        }

        public int Visualizacoes
        {
            get { return visualizacoes; }
            set { visualizacoes = value; }
        }

        public int Like
        {
            get { return like; }
            set { like = value; }
        }

        public short Avaliacao
        {
            get { return avaliacao; }
            set { avaliacao = value; }
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


     
        public long[] Likes
        {
            set
            {
                long[] v = new long[2];
                v[0] = cpf;
                v[1] = like;
                likes.Add(v); }
            get
            {
                long[] v = new long[2];
                v[0] = cpf;
                v[1] = like;

                return v; }
        }

          


        public long[] getLikes()
        {
            long[] v = likes[id];

            return v;
        }
    }
}
