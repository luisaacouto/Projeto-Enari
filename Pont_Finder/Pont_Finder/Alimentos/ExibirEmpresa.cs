using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.alimentos
{
    public partial class ExibirEmpresa : UserControl
    {
        private string NomeCompany;
        private int ID;
        public ExibirEmpresa(string nomeEmpresa, int idComp)
        {
            NomeCompany = nomeEmpresa;
            ID = idComp;
            InitializeComponent();
        }

        private void Panel5_Paint(object sender, PaintEventArgs e)
        {
            NomeEmpresa.Text = NomeCompany;
        }
    }
}
