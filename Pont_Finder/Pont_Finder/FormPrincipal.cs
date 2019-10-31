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
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
        }

        private void Button_salvar_Click(object sender, EventArgs e)
        {                   
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
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

            MessageBox.Show("Dados Salvos");
        }
    }
}
