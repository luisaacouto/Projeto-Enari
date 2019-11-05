using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.hospedagem
{
    public partial class Hosp_Home : Form
    {
        public Hosp_Home()
        {
            InitializeComponent();
        }

        private void Hosp_Home_Load(object sender, EventArgs e)
        {
            
        }

        private void Bt_Cad_Empresa_Click(object sender, EventArgs e)
        {
            hospedagem.Cadastro_Empresa cadEmpre = new Cadastro_Empresa();
            FormPrincipal.MudarForm("hospedagem", cadEmpre);
        }

        private void btn_salvar_empresa_Click(object sender, EventArgs e)
        {
            XML xmlli = new XML();
            //final do programa salvando...
            int cont = 0;
            foreach (var item in hostList.selectAll())
            {
                xmlli.Add(cont, item.Nomeempresa, item.Nomefantasia, item.CNPJ, item.Endereco, item.Cep, item.Telefone, item.Foto, item.Descricao);
                cont++;
            }

            MessageBox.Show("Dados Salvos");
        }
    }
}
