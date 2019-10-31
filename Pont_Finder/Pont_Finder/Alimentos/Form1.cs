using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Pont_Finder;
using Pont_Finder.classes;
using Pont_Finder.Alimentos;
using BodyProject;

namespace ModuloAlimentacao
{
    public partial class Form1 : Form
    {
        private int local, local1;
        private List<Company> lista = new List<Company>();
        private CompanyList comp = new CompanyList();
        private ProfileList prof = new ProfileList();
        public Form1()
        {
            local1 = 0;
            local = 46;
            InitializeComponent();
            Listar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Company> listaBusca = new List<Company>();
            listaBusca = comp.SearchName(PesquisaRest.Text);
            Restaurantes.Controls.Clear();
            local = 46;
            foreach (var item in listaBusca)
            {
                ExibirEmpresa exbEmp = new ExibirEmpresa(item.Nome, listaBusca.IndexOf(item));
                exbEmp.Location = new Point(0, local);
                local = local + exbEmp.Height + 5;
                Restaurantes.Controls.Add(exbEmp);
            }
            List<ProfileCompany> BuscaPerfis = prof.profileList(listaBusca);
            local1 = 0;
            Top5.Controls.Clear();
            foreach (var busca in prof.TopList(BuscaPerfis))
            {
                if (busca.NotaApurada != 0 )
                {
                    foreach (var teste2 in comp.selectAll())
                    {
                        if (busca.CodigoCompany == comp.selectAll().IndexOf(teste2))
                        {
                            UserControl1 te = new UserControl1(teste2.NomeFantasia);
                            te.Location = new Point(0, local1);
                            local1 = local1 + te.Height + 5;
                            Top5.Controls.Add(te);
                        }
                    }
                }                
            }
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
                foreach (var teste2 in comp.selectAll()) {
                    if (teste.CodigoCompany == comp.selectAll().IndexOf(teste2))
                    {
                        UserControl1 te = new UserControl1(teste2.NomeFantasia);
                        te.Location = new Point(0, local1);
                        local1 = local1 + te.Height + 5;
                        Top5.Controls.Add(te);
                    }
                }
            }
            /*foreach (var ava in prof.selectEvaluation())
            {
                foreach (var itemEmp in comp.selectAll()) {
                    if (ava.IndexEmp == comp.selectAll().IndexOf(itemEmp)) {                        
                        UserControl1 te = new UserControl1(ava.Nota);
                        te.Location = new Point(0, local1);
                        local1 = local1 + te.Height + 5;
                        Top5.Controls.Add(te);
                    }
                }
            }*/

            lista = comp.selectAll();
            foreach (var item in lista)
            {
                ExibirEmpresa exbEmp = new ExibirEmpresa(item.Nome, lista.IndexOf(item));
                exbEmp.Location = new Point(0, local);
                local = local + exbEmp.Height + 5;
                Restaurantes.Controls.Add(exbEmp);
            }
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            /*int index = 0;
            string itemSelecionado = listBox1.SelectedItem.ToString();
            foreach (var item in lista)
            {
                if (itemSelecionado.Equals(item.Nome))
                {
                    index = lista.IndexOf(item);
                }
            }            
            Details_Rest.Visible = true;
            Details_Rest.BringToFront();            
            label9.Text = lista[index].Nome.ToString();
            label10.Text = lista[index].NomeFantasia.ToString();
            label11.Text = lista[index].Email.ToString();
            label12.Text = lista[index].Senha.ToString();
            label13.Text = lista[index].TipoServico.ToString();
            label14.Text = lista[index].Senha.ToString();
            label15.Text = lista[index].Rua.ToString();
            label16.Text = lista[index].Bairro.ToString();
            label17.Text = lista[index].Cnpj.ToString();
            label8.Text = lista[index].Numero.ToString();
            label18.Text = lista[index].Cep.ToString();*/
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
     
    }
}
