namespace Pont_Finder
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Sair = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_salvar = new System.Windows.Forms.Button();
            this.bt_FazerLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_CriarConta = new System.Windows.Forms.Button();
            this.panelHome = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.bt_Sair);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_salvar);
            this.panel1.Controls.Add(this.bt_FazerLogin);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.bt_CriarConta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 45);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bt_Sair
            // 
            this.bt_Sair.BackColor = System.Drawing.Color.Transparent;
            this.bt_Sair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_Sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.bt_Sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.bt_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Sair.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Sair.ForeColor = System.Drawing.Color.White;
            this.bt_Sair.Location = new System.Drawing.Point(785, 10);
            this.bt_Sair.Name = "bt_Sair";
            this.bt_Sair.Size = new System.Drawing.Size(95, 25);
            this.bt_Sair.TabIndex = 7;
            this.bt_Sair.Text = "Sair";
            this.bt_Sair.UseVisualStyleBackColor = false;
            this.bt_Sair.Click += new System.EventHandler(this.Bt_Sair_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(910, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 25);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cadastro Empresa";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1083, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // button_salvar
            // 
            this.button_salvar.BackColor = System.Drawing.Color.Transparent;
            this.button_salvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_salvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button_salvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_salvar.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_salvar.ForeColor = System.Drawing.Color.White;
            this.button_salvar.Location = new System.Drawing.Point(1262, 10);
            this.button_salvar.Name = "button_salvar";
            this.button_salvar.Size = new System.Drawing.Size(75, 25);
            this.button_salvar.TabIndex = 3;
            this.button_salvar.Text = "Salvar";
            this.button_salvar.UseVisualStyleBackColor = false;
            this.button_salvar.Click += new System.EventHandler(this.Button_salvar_Click);
            // 
            // bt_FazerLogin
            // 
            this.bt_FazerLogin.BackColor = System.Drawing.Color.Transparent;
            this.bt_FazerLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_FazerLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.bt_FazerLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.bt_FazerLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_FazerLogin.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_FazerLogin.ForeColor = System.Drawing.Color.White;
            this.bt_FazerLogin.Location = new System.Drawing.Point(1048, 10);
            this.bt_FazerLogin.Name = "bt_FazerLogin";
            this.bt_FazerLogin.Size = new System.Drawing.Size(95, 25);
            this.bt_FazerLogin.TabIndex = 1;
            this.bt_FazerLogin.Text = "Fazer Login";
            this.bt_FazerLogin.UseVisualStyleBackColor = false;
            this.bt_FazerLogin.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(90, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // bt_CriarConta
            // 
            this.bt_CriarConta.BackColor = System.Drawing.Color.White;
            this.bt_CriarConta.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_CriarConta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.bt_CriarConta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.bt_CriarConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_CriarConta.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_CriarConta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_CriarConta.Location = new System.Drawing.Point(1155, 10);
            this.bt_CriarConta.Name = "bt_CriarConta";
            this.bt_CriarConta.Size = new System.Drawing.Size(95, 25);
            this.bt_CriarConta.TabIndex = 2;
            this.bt_CriarConta.Text = "Criar Conta";
            this.bt_CriarConta.UseVisualStyleBackColor = false;
            this.bt_CriarConta.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelHome
            // 
            this.panelHome.Location = new System.Drawing.Point(42, 45);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(1282, 675);
            this.panelHome.TabIndex = 3;
            this.panelHome.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHome_Paint);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 720);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelHome);
            this.MaximumSize = new System.Drawing.Size(1382, 759);
            this.MinimumSize = new System.Drawing.Size(1364, 726);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Point Finder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_FazerLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_CriarConta;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Button button_salvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_Sair;
    }
}

