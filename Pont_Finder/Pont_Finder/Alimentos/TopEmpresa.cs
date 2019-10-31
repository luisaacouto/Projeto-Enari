using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder
{    
    public partial class UserControl1 : UserControl
    {
        private string avaliacao;
        public UserControl1(string Ava)
        {
            avaliacao = Ava;
            InitializeComponent();
        }

        private void TopEmp_Paint(object sender, PaintEventArgs e)
        {
            NomeTopEmp.Text = avaliacao.ToString();
        }
    }
}
