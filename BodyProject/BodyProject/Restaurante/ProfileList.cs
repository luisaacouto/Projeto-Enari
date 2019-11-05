using System;
using System.Collections.Generic;
using System.Text;

namespace BodyProject
{
    class ProfileList
    {
        private List<ProfileCompany> perfil = new List<ProfileCompany>();

        //Adicionando Atribudos adicionais vinculados a empresa
        public void ProfileAdd(int indexCompany, ProfileCompany emp)
        {
            ProfileCompany profComp = new ProfileCompany();
            
            profComp.Especialidade = emp.Especialidade;
            profComp.Contato = emp.Contato;
            profComp.HoraInicio = emp.HoraInicio;
            profComp.HoraFim = emp.HoraFim;
            profComp.Telefone = emp.Telefone;
            profComp.Cep = emp.Cep;
            profComp.Cel = emp.Cel;
            profComp.CodigoCompany = indexCompany;
            perfil.Add(profComp);
        }
        //Teste Pull
    }
}
