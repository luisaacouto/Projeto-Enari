using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder.hospedagem
{
    class Empresa
    {
        //Atributo da Empresa

        private string nomeempresa, nomefantasia, endereco, email, descricao, ambiente, foto;
        private int cep, tel;
        private bool ativo;
        private long cnpj;



        //Get e Sets
        //Get e Sets Strings

        public string Nomeempresa
        {
            get { return nomeempresa; }
            set { nomeempresa = value; }
        }
        public string Nomefantasia
        {
            get { return nomefantasia; }
            set { nomefantasia = value; }
        }
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        public string Ambiente
        {
            get { return ambiente; }
            set { ambiente = value; }
        }
        public string Foto
        {
            get { return foto; }
            set { foto = value; }
        }


        //Get e Set Long

        public long CNPJ
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        //Gets e Sets Ints

        public int Telefone
        {
            get { return tel; }
            set { tel = value; }
        }
        public int Cep
        {
            get { return cep; }
            set { cep = value; }
        }
        public bool Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }


    }
}
