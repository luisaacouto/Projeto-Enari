using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.servicos
{
    public partial class CadastrarEmpresa : Form
    {
        public CadastrarEmpresa()
        {
            InitializeComponent();
        }

        private void Bt_continuar_Click(object sender, EventArgs e)
        {
            string nome = tb_nome.Text;
            string fatasia = tb_fantasia.Text;
            long cnpj = long.Parse(tb_cep.Text);
            string endereco = tb_endereco.Text;
            string telefone = tb_telefone.Text;
            string email = tb_email.Text;

            classes.Empresa tmp = new classes.Empresa();
            tmp.Nome = nome;
            tmp.NomeFantasia = fatasia;
            tmp.Email = email;
            tmp.Cnpj = cnpj;
            tmp.Endereco = endereco;
            tmp.Telefone = telefone;
            tmp.Cpf = Session.Cpf;
            tmp.Status = true;
            classes.ListaEmpresa.Add(tmp);
            this.Close();
        }

        private void Tb_endereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tb_endereco_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void CadastrarEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Tb_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
