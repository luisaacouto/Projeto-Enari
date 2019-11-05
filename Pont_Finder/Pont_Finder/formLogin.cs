﻿using System;
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
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void ChecarLogin()
        {
            string Login_email = textB_email.Text;
            string Login_senha = textB_senha.Text;
            int indexer = UserList.checkLogin(Login_email, Login_senha);

            if (indexer != -1)
            {
                UserList.sessionStart(indexer);
                //MessageBox.Show("Logado\n"+Session.Nome);
                this.Close();
            }
            else
            {
                MessageBox.Show("Não Logado");

            }
        }

        private void button_CriarC_Click(object sender, EventArgs e)
        {
            formCriarConta fCC = new formCriarConta();
            this.Close();
            fCC.ShowDialog();
            

        }

        private void buttonCriarC_Click(object sender, EventArgs e)
        {
            formCriarConta fCC = new formCriarConta();
            fCC.ShowDialog();
            fCC.Dispose();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            ChecarLogin();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void TextB_senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextB_senha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                ChecarLogin();
        }

        private void FormLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
          
                
        }

        private void TextB_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                ChecarLogin();           
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
