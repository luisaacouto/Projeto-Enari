﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BodyProject
{
    class ProfileCompany
    {
        //Classe de Perfil Empresa Formal e Informal. Atributos Adicionais
        //Atributos
        private string especialidade, contato;
        private DateTime horaInicio, horaFim;
        private int telefone, cep, cel, codigoCompany;

        //Métodos
        public string Especialidade
        {
            get { return especialidade; }
            set { especialidade = value; }
        }
        public string Contato
        {
            get { return contato; }
            set { contato = value; }
        }
        public DateTime HoraInicio
        {
            get { return horaInicio; }
            set { horaInicio = value; }
        }            
        public DateTime HoraFim
        {
            get { return horaFim; }
            set { horaFim = value; }
        }
        public int Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public int Cep
        {
            get { return cep; }
            set { cep = value; }
        }
        public int Cel
        {
            get { return cel; }
            set { cel = value; }
        }
        public int CodigoCompany
        {
            get { return codigoCompany; }
            set { codigoCompany = value }
        }
    }
}
