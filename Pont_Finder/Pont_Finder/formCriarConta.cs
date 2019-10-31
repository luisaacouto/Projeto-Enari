using Pont_Finder.classes;
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
    public partial class formCriarConta : Form
    {
        public formCriarConta()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button_Cadastrar_Click(object sender, EventArgs e)
        {
            string cad_Name = textB_nome.Text;
            long cad_CPF = long.Parse(textB_cpf.Text);
            string cad_email = textB_email.Text;
            string cad_senha = textB_senha.Text;
            DateTime cad_dataNasci = dateT_dataNasci.Value;
            int cad_Cel = int.Parse(textB_cel.Text);
            string cad_sexo = (comboB_sex.SelectedItem).ToString();

            User user = new User();
            user.Nome = cad_Name;
            user.Email = cad_email;
            user.Senha = cad_senha;
            user.Sexo = cad_sexo;
            user.Cpf = cad_CPF;
            user.Celular = cad_Cel;
            user.DataNascimento = cad_dataNasci;
            user.Ativo = true;
            UserList.userAdd(user);            
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            panelCompany.Visible = false;
            panelUser.Visible = true;
            panelUser.BringToFront();
            
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            panelUser.Visible = false;
            panelCompany.Visible = true;
            panelCompany.BringToFront();
        }

        private void CadEmp_Click(object sender, EventArgs e)
        {
            CompanyList complist = new CompanyList();
            Company comp = new Company();
            comp.Nome = textB_nomeEmp.Text;
            comp.NomeFantasia = textB_fantasia.Text;
            comp.Email = textB_emailEmp.Text;
            comp.TipoServico = textB_Serv.Text;
            comp.Senha = textB_senhaEmp.Text;
            comp.Rua = textB_rua.Text;
            comp.Bairro = textB_bairro.Text;
            comp.Cnpj = long.Parse(textB_cnpj.Text);
            comp.Numero = int.Parse(textB_num.Text);
            comp.Cep = int.Parse(textB_cep.Text);
            complist.CompAdd(comp);
        }
    }
}
