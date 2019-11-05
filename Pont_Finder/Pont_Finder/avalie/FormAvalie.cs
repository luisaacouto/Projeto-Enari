using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pont_Finder.avalie;

namespace Pont_Finder
{
    public partial class FormAvalie : Form
    {
        public FormAvalie()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formPostar fp = new formPostar();
            fp.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string separacaoproblem = "____________________________________________________________________________________________________________________________________________________________________________";
            feed.Items.Clear();

            foreach (var item in PostList.poster)
            {
                feed.Items.Add(item.Tempohora);
                feed.Items.Add("");
                feed.Items.Add("TIPO DE PROBLEMA :");
                feed.Items.Add(item.Tipoproblema);
                feed.Items.Add("");
                feed.Items.Add("LOCALIZAÇÃO :");
                feed.Items.Add(item.Localizao);
                feed.Items.Add("");
                feed.Items.Add("DESCRIÇÃO :");
                feed.Items.Add(item.Desc);

                feed.Items.Add(separacaoproblem);

            }
            PostConstructor post = new PostConstructor();
        }

        public void Att()
        {
            string separacaoproblem = "____________________________________________________________________________________________________________________________________________________________________________";
            feed.Items.Clear();

            foreach (var item in PostList.poster)
            {
                feed.Items.Add(item.Tempohora);
                feed.Items.Add("");
                feed.Items.Add("TIPO DE PROBLEMA :");
                feed.Items.Add(item.Tipoproblema);
                feed.Items.Add("");
                feed.Items.Add("LOCALIZAÇÃO :");
                feed.Items.Add(item.Localizao);
                feed.Items.Add("");
                feed.Items.Add("DESCRIÇÃO :");
                feed.Items.Add(item.Desc);

                feed.Items.Add(separacaoproblem);

            }
            PostConstructor post = new PostConstructor();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
