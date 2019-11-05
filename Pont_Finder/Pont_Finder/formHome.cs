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
    public partial class formHome : Form
    {
        public formHome()
        {
            InitializeComponent();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button__Almentos_Click(object sender, EventArgs e)
        {
            FormPrincipal.Mudar(Botao(sender).Text);
        }
        private Button Botao(object sender) => (Button)sender;
    }
}
