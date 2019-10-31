using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.Alimentos
{
    
    public partial class ExibirEmpresa : UserControl
    {
        private string nome;
        private int idEmpresa;
        public ExibirEmpresa(string nomeComp, int idComp)
        {
            nome = nomeComp;
            idEmpresa = idComp;
            InitializeComponent();
        }

        private void Panel5_Paint(object sender, PaintEventArgs e)
        {
            Nome.Text = nome;
        }
    }
}
