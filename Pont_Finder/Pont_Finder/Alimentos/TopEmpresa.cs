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
    public partial class TopEmpresa : UserControl
    {
        private string NomeCompany;
        public TopEmpresa(string Nome)
        {
            NomeCompany = Nome;
            InitializeComponent();
        }

        private void TopEmp_Paint(object sender, PaintEventArgs e)
        {
            NomeTopEmp.Text = NomeCompany;
        }
    }
}
