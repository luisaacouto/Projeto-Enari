using Pont_Finder.servicos;
using Pont_Finder.hospedagem;
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
    public partial class FormPrincipal : Form
    {
        static Color barra = Color.FromArgb(64, 64, 64);
        static Panel navbar;
        static Panel painel;

        public FormPrincipal()
        {
            InitializeComponent();
            panel1.BackColor = barra;
            navbar = panel1;
            painel = panelHome;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bt_Sair.Visible = false;
            label1.Text = "";
            formHome fh = new formHome();
            fh.TopLevel = false;
            panelHome.Controls.Add(fh);
            fh.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formCriarConta fCC = new formCriarConta();
            fCC.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formLogin fL = new formLogin();
            fL.ShowDialog();
            if (Session.Id != -1)
            {
                bt_FazerLogin.Visible = false;
                bt_CriarConta.Visible = false;
                label1.Text = Session.Nome;
                bt_Sair.Visible = true;
            }
        }

        private void Button_salvar_Click(object sender, EventArgs e)
        {
            XmlLi xmlli = new XmlLi();
            //final do programa salvando...
            xmlli.Drop();
            int cont = 0;
            foreach (var item in UserList.selectAll())
            {
                xmlli.Add(cont, item.Nome, item.Email, item.Senha, item.Cpf, item.Ativo);
                cont++;
            }


            XmlLi_Empresa xmlli_empresa = new XmlLi_Empresa();
            //final do programa salvando...
            xmlli_empresa.Drop();
            foreach (var item in servicos.classes.ListaEmpresa.selectAll())
            {
                xmlli_empresa.AddServico(item.Nome, item.NomeFantasia, item.Email, item.Telefone, item.Endereco, item.Cnpj, item.Cpf, item.Status);
            }

            MessageBox.Show("Dados Salvos");




           

        }

        private void panelHome_Paint(object sender, PaintEventArgs e)
        {

        }

        public static void Mudar(String x = "")
        {
            painel.Controls.Clear();
            switch (x)
            {
                case "Alimentos":
                    formAlimentos formA = new formAlimentos
                    {
                        TopLevel = false
                    };
                    painel.Controls.Add(formA);
                    formA.Show();
                    navbar.BackColor = Color.Red;
                    break;

                case "Serviços":
                   formservicos form = new formservicos
                   {
                        TopLevel = false
                    };
                    painel.Controls.Add(form);
                    form.Show();
                    navbar.BackColor = Color.FromArgb(0, 120, 215);
                    break;

                case "Hospedagem":
                    hospedagem.Hosp_Home Hosp = new Hosp_Home();
                    {
                        Hosp.TopLevel = false;
                    }
                    painel.Controls.Add(Hosp);
                    Hosp.Show();
                    navbar.BackColor = Color.FromArgb(69,172,20);
                    break;

                case "Eventos":
                    FormEventos fEvent = new FormEventos();
                    {
                        fEvent.TopLevel = false;
                    }
                    painel.Controls.Add(fEvent);
                    fEvent.Show();
                    navbar.BackColor = Color.FromArgb(120, 88, 210);
                    break;
                case "Reclame":
                    FormAvalie formAvalie = new FormAvalie();
                    {
                        formAvalie.TopLevel = false;
                    }
                    painel.Controls.Add(formAvalie);
                    formAvalie.Show();
                    navbar.BackColor = Color.DeepSkyBlue;
                    break;
                default:
                    formHome fh = new formHome
                    {
                        TopLevel = false
                    };
                    painel.Controls.Add(fh);
                    fh.Show();
                    navbar.BackColor = barra;
                    break;

            }
        }

        public static void MudarForm(string modulo, Form formA)
        {
            painel.Controls.Clear();
            formA.TopLevel = false;          
            painel.Controls.Add(formA);
            formA.Show();
          
            switch (modulo.ToLower().Replace("ç", "c"))
            {
                case "alimentos":
                    navbar.BackColor = Color.Red;
                    break;
                case "servicos":
                    navbar.BackColor = Color.FromArgb(0, 120, 215);
                    break;
                case "hospedagem":
                    navbar.BackColor = Color.FromArgb(69, 172, 20);
                    break;
                case "eventos":
                    navbar.BackColor = Color.FromArgb(120, 88, 210);
                    break;
                case "reclame":                
                    navbar.BackColor = Color.DeepSkyBlue;
                    break;
                default:
                    navbar.BackColor = barra;
                    break;
            }
        }

        public static void padrao()
        {
            navbar.BackColor = barra;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Mudar();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Mudar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CadEmpresa cdEmp = new CadEmpresa();
            cdEmp.ShowDialog();
        }

        private void Bt_Sair_Click(object sender, EventArgs e)
        {
            Session.Deslogar();
            bt_Sair.Visible = false;
            bt_FazerLogin.Visible = true;
            bt_CriarConta.Visible = true;
            label1.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
