using System;
using System.Collections.Generic;
using System.Text;

namespace BodyProject
{
    class Searchs
    {
        private CompanyList comp = new CompanyList();
        private List<Company> companys = new List<Company>();
        private List<Company> lista = new List<Company>();

        public List<Company> SearchName(string name)
        {           
            companys = comp.selectAll();

            foreach (var emps in companys)
            {

                if(emps.NomeFantasia.Contains(name)) { 
                    Company emp = new Company();
                    emp.Nome = emps.Nome;
                    emp.NomeFantasia = emps.NomeFantasia;
                    emp.Email = emps.Email;
                    emp.TipoServico = emps.TipoServico;
                    emp.Senha = emps.Senha;
                    emp.Rua = emps.Rua;
                    emp.Numero = emps.Numero;
                    emp.Bairro = emps.Bairro;
                    emp.Cep = emps.Cep;
                    emp.Cnpj = emps.Cnpj;
                    emp.Status = emps.Status;
                    lista.Add(emp);
                }
            }
            return lista;
        }        
    }
}
