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
    public partial class Listas_quartos : Form
    {
        public Listas_quartos()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hospedagem.Cad_Quarto cadQuarto = new Cad_Quarto();
            cadQuarto.ShowDialog();
        }

        private void Listas_quartos_Load(object sender, EventArgs e)
        {

        }
    }
}
