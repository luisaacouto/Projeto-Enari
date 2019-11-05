using Pont_Finder.servicos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;








namespace Pont_Finder.avalie
{
    public partial class formPostar : Form
    {

        FormAvalie AvaliePrincipal = new FormAvalie();


        public formPostar()
        {
            InitializeComponent();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (txtLocalizacao.Text == Text)
            {
                if (string.IsNullOrWhiteSpace(txtLocalizacao.Text)) ;

            }
            else
            {

                NavigateToRoute(new string[1] { txtLocalizacao.Text });
            }
        }
        /// <summary>
        /// Navega para uma rota composta por um ou mais pontos geográficos
        /// </summary>
        /// <param name="points">Um array/coleção contendo uma lista de pontos geográficos necessários para se criar a rota. Os pontos deve estar ordenados do inicial para o final!</param>
        public void NavigateToRoute(IEnumerable<string> points)
        {
            string baseAdress = "https://www.google.com.br/maps/dir/";

            StringBuilder url = new StringBuilder(baseAdress);
            foreach (string point in points)
            {
                url.Append(Uri.EscapeDataString(point));
                url.Append("/");
            }

            webBrowser1.Navigate(new Uri(url.ToString()));
        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

            if (e.Url == webBrowser1.Url)
            {
                //progressBar1.Style = ProgressBarStyle.Blocks;
            }
        }

        private void WebBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

            if (e.Url == webBrowser1.Url)
            {
                //progressBar1.Style = ProgressBarStyle.Blocks;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBoxCarregarImagem.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void PictureBoxCarregarImagem_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBoxCarregarImagem.ImageLocation = openFileDialog1.FileName;
            }
        }
        private void BtnPostar_Click(object sender, EventArgs e)
        {
            PostConstructor post = new PostConstructor();
            

            string post_Tempohora = System.DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            string post_problema = comboBox1.SelectedItem.ToString();
            string post_localizao = txtLocalizacao.Text;
            string post_descricao = richTextBox1.Text;


            post.Tempohora = post_Tempohora;
            post.Tipoproblema = post_problema;
            post.Localizao = post_localizao;
            post.Desc = post_descricao;

            PostList.PostAdd(post);

            AvaliePrincipal.Att();
            this.Close();





        }

        private void FormPostar_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
