using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.servicos
{
    public partial class Post : Form
    {
        private bool img = false;
        public Post()
        {
            InitializeComponent();
            pb_icone.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Publicar_Click(object sender, EventArgs e)
        {
            string link = null;
            if (img)
            {
                if (!Directory.Exists("..//..//servicos//data//images//posts"))
                    Directory.CreateDirectory("..//..//servicos//data//images//posts");

                pb_icone.Load();
                pb_icone.Image = Image.FromFile(openIcone.FileName);
              
                Image bmp = new Bitmap(pb_icone.Image);
              
                Image bmp2 = new Bitmap(bmp, pb_icone.Size);

                

                pb_icone.Image = bmp2;
                string nome = textBox1.Text;
                int id = classes.ServiceList.Tam;
                link = "..//..//servicos//data//images//posts//" + id + ".jpg";
                pb_icone.Image.Save(link, ImageFormat.Jpeg);
            }
     

            Service s = new Service();
            s.Id = classes.ServiceList.Tam;
            s.Tipo = textBox3.Text;
            s.Valor = double.Parse(textBox1.Text);
            s.Detalhes = textBox2.Text ;
            s.Sugestoes = 0;
            s.Visualizacoes = 0;
            s.Like = 0;
            s.Avaliacao = 0;
            s.Ativo = true;
            s.Image = link;
        
            classes.ServiceList.Add(s);     
            this.Close();
        }

        private void Bt_icone_Click(object sender, EventArgs e)
        {
            if (openIcone.ShowDialog() == DialogResult.OK)
            {
                pb_icone.ImageLocation = openIcone.FileName;
                pb_icone.Load();
                img = true;            
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OpenIcone_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
