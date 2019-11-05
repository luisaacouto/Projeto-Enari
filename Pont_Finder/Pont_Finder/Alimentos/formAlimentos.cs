using Pont_Finder.alimentos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder
{
    public partial class formAlimentos : Form
    {
        private int local, local1;
        private List<Company> lista = new List<Company>();
        private CompanyList comp = new CompanyList();
        private ProfileList prof = new ProfileList();
        public formAlimentos()
        {
            local1 = 0;
            local = 0;
            InitializeComponent();
            Listar();
        }
        public void Listar()
        {
            Company emp = new Company();
            for (int cont = 0; cont < 10; cont++)
            {
                emp.Nome = "Empresa" + cont;
                emp.NomeFantasia = "Fantasia" + cont;
                emp.Email = "email" + cont + "@mail.com";
                emp.TipoServico = "Alimento";
                emp.Senha = "senha" + cont;
                emp.Rua = "rua" + cont;
                emp.Bairro = "bairro" + cont;
                emp.Cnpj = long.Parse("" + cont + "" + cont + "" + cont + "" + cont + "" + cont);
                emp.Numero = int.Parse("" + cont + "" + cont);
                emp.Cep = int.Parse("" + cont + "" + cont + "" + cont + "" + cont + "" + cont + "" + cont);
                comp.CompAdd(emp);
            }
            int count = 0;
            foreach (var item in comp.selectAll())
            {

                ProfileCompany profComp = new ProfileCompany();
                profComp.Especialidade = "Especialidade" + count;
                profComp.Contato = "Contato" + count;
                profComp.HoraInicio = DateTime.Now;
                profComp.HoraFim = DateTime.Now;
                profComp.Telefone = int.Parse("" + count + "" + count + "" + count + "" + count + "" + count);
                profComp.Cep = emp.Cep;
                profComp.Cel = int.Parse("" + count + "" + count + "" + count + "" + count + "" + count);
                profComp.CodigoCompany = comp.selectAll().IndexOf(item);
                prof.ProfileAdd(profComp);
                count++;

                prof.AddAvaliacao(count, profComp.CodigoCompany, count);
                prof.AddAvaliacao(10, profComp.CodigoCompany, count);
                prof.ApuraAvaliacao(profComp.CodigoCompany);
            }
            foreach (var teste in prof.TopList(prof.selectAll()))
            {
                foreach (var teste2 in comp.selectAll())
                {
                    if (teste.CodigoCompany == comp.selectAll().IndexOf(teste2))
                    {
                        TopEmpresa te = new TopEmpresa(teste2.Nome);
                        te.Location = new Point(0, local1);
                        local1 = local1 + te.Height + 5;
                        Top5.Controls.Add(te);
                    }
                }
            }

            lista = comp.selectAll();
            foreach (var item in lista)
            {
                ExibirEmpresa exbEmp = new ExibirEmpresa(item.Nome, lista.IndexOf(item));
                exbEmp.Location = new Point(0, local);
                local = local + exbEmp.Height + 5;
                ListarEmpresas.Controls.Add(exbEmp);
            }
        }

        private void FormAlimentos_Load(object sender, EventArgs e)
        {

        }

        private void Pesquisar_Click(object sender, EventArgs e)
        {
            List<Company> listaBusca = new List<Company>();
            listaBusca = comp.SearchName(PesquisaBox.Text);
            ListarEmpresas.Controls.Clear();
            local = 0;
            foreach (var item in listaBusca)
            {
                ExibirEmpresa exbEmp = new ExibirEmpresa(item.Nome, listaBusca.IndexOf(item));
                exbEmp.Location = new Point(0, local);
                local = local + exbEmp.Height + 5;
                ListarEmpresas.Controls.Add(exbEmp);
            }
            List<ProfileCompany> BuscaPerfis = prof.profileList(listaBusca);
            local1 = 0;
            Top5.Controls.Clear();
            foreach (var busca in prof.TopList(BuscaPerfis))
            {
                if (busca.NotaApurada != 0)
                {
                    foreach (var teste2 in comp.selectAll())
                    {
                        if (busca.CodigoCompany == comp.selectAll().IndexOf(teste2))
                        {
                            TopEmpresa te = new TopEmpresa(teste2.NomeFantasia);
                            te.Location = new Point(0, local1);
                            local1 = local1 + te.Height + 5;
                            Top5.Controls.Add(te);
                        }
                    }
                }
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            alimentos.Cadastro_Restaurante cadastrarestabele = new alimentos.Cadastro_Restaurante();
            FormPrincipal.MudarForm("alimentos", cadastrarestabele);

        }
    }
}
