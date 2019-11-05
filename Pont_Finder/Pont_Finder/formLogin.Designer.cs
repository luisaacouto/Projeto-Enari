namespace Pont_Finder
{
    partial class formLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLogin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textB_senha = new System.Windows.Forms.TextBox();
            this.textB_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCriarC = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(233)))));
            this.buttonLogin.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(241, 443);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(148, 42);
            this.buttonLogin.TabIndex = 23;
            this.buttonLogin.Text = "Fazer Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(168, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 32);
            this.label4.TabIndex = 21;
            this.label4.Text = "Senha:";
            // 
            // textB_senha
            // 
            this.textB_senha.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB_senha.Location = new System.Drawing.Point(165, 317);
            this.textB_senha.Name = "textB_senha";
            this.textB_senha.Size = new System.Drawing.Size(300, 29);
            this.textB_senha.TabIndex = 20;
            this.textB_senha.TextChanged += new System.EventHandler(this.TextB_senha_TextChanged);
            this.textB_senha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextB_senha_KeyPress);
            // 
            // textB_email
            // 
            this.textB_email.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB_email.Location = new System.Drawing.Point(165, 211);
            this.textB_email.Name = "textB_email";
            this.textB_email.Size = new System.Drawing.Size(300, 29);
            this.textB_email.TabIndex = 19;
            this.textB_email.Tag = "";
            this.textB_email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextB_email_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(168, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 32);
            this.label3.TabIndex = 18;
            this.label3.Text = "E-mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(518, 27);
            this.label2.TabIndex = 17;
            this.label2.Text = "Você pode fazer o login usando a sua conta para acessar nossos serviços.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 45);
            this.label1.TabIndex = 16;
            this.label1.Text = "Fazer Login";
            // 
            // buttonCriarC
            // 
            this.buttonCriarC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(158)))), ((int)(((byte)(60)))));
            this.buttonCriarC.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCriarC.ForeColor = System.Drawing.Color.White;
            this.buttonCriarC.Location = new System.Drawing.Point(241, 513);
            this.buttonCriarC.Name = "buttonCriarC";
            this.buttonCriarC.Size = new System.Drawing.Size(148, 42);
            this.buttonCriarC.TabIndex = 22;
            this.buttonCriarC.Text = "Criar Conta";
            this.buttonCriarC.UseVisualStyleBackColor = false;
            this.buttonCriarC.Click += new System.EventHandler(this.buttonCriarC_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(170, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 22);
            this.label5.TabIndex = 24;
            this.label5.Text = "Esqueci a senha!";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(630, 630);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonCriarC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textB_senha);
            this.Controls.Add(this.textB_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(646, 669);
            this.MinimumSize = new System.Drawing.Size(646, 669);
            this.Name = "formLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormLogin_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textB_senha;
        private System.Windows.Forms.TextBox textB_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCriarC;
        private System.Windows.Forms.Label label5;
    }
}