namespace Pont_Finder.servicos
{
    partial class postcard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(postcard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_descricao = new System.Windows.Forms.Label();
            this.pb_down = new System.Windows.Forms.PictureBox();
            this.pb_up = new System.Windows.Forms.PictureBox();
            this.lb_username = new System.Windows.Forms.Label();
            this.pb_user = new System.Windows.Forms.PictureBox();
            this.bt_obter = new System.Windows.Forms.Button();
            this.lb_valor = new System.Windows.Forms.Label();
            this.lb_like = new System.Windows.Forms.Label();
            this.lb_visualizacao = new System.Windows.Forms.Label();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.pb_icone = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icone)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lb_descricao);
            this.panel1.Controls.Add(this.pb_down);
            this.panel1.Controls.Add(this.pb_up);
            this.panel1.Controls.Add(this.lb_username);
            this.panel1.Controls.Add(this.pb_user);
            this.panel1.Controls.Add(this.bt_obter);
            this.panel1.Controls.Add(this.lb_valor);
            this.panel1.Controls.Add(this.lb_like);
            this.panel1.Controls.Add(this.lb_visualizacao);
            this.panel1.Controls.Add(this.lb_titulo);
            this.panel1.Controls.Add(this.pb_icone);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 195);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // lb_descricao
            // 
            this.lb_descricao.BackColor = System.Drawing.Color.White;
            this.lb_descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lb_descricao.Location = new System.Drawing.Point(213, 29);
            this.lb_descricao.Name = "lb_descricao";
            this.lb_descricao.Size = new System.Drawing.Size(250, 141);
            this.lb_descricao.TabIndex = 29;
            this.lb_descricao.Text = "descricao";
            // 
            // pb_down
            // 
            this.pb_down.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_down.BackgroundImage")));
            this.pb_down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_down.Image = global::Pont_Finder.Properties.Resources.downgrey;
            this.pb_down.Location = new System.Drawing.Point(469, 78);
            this.pb_down.Name = "pb_down";
            this.pb_down.Size = new System.Drawing.Size(25, 25);
            this.pb_down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_down.TabIndex = 28;
            this.pb_down.TabStop = false;
            this.pb_down.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pb_up
            // 
            this.pb_up.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_up.BackgroundImage")));
            this.pb_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_up.Image = global::Pont_Finder.Properties.Resources.upgrey;
            this.pb_up.Location = new System.Drawing.Point(469, 29);
            this.pb_up.Name = "pb_up";
            this.pb_up.Size = new System.Drawing.Size(25, 25);
            this.pb_up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_up.TabIndex = 27;
            this.pb_up.TabStop = false;
            this.pb_up.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Location = new System.Drawing.Point(512, 9);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(27, 13);
            this.lb_username.TabIndex = 25;
            this.lb_username.Text = "user";
            // 
            // pb_user
            // 
            this.pb_user.Location = new System.Drawing.Point(556, 9);
            this.pb_user.Name = "pb_user";
            this.pb_user.Size = new System.Drawing.Size(40, 33);
            this.pb_user.TabIndex = 24;
            this.pb_user.TabStop = false;
            // 
            // bt_obter
            // 
            this.bt_obter.BackColor = System.Drawing.Color.RoyalBlue;
            this.bt_obter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_obter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bt_obter.ForeColor = System.Drawing.Color.White;
            this.bt_obter.Location = new System.Drawing.Point(469, 138);
            this.bt_obter.Name = "bt_obter";
            this.bt_obter.Size = new System.Drawing.Size(127, 32);
            this.bt_obter.TabIndex = 23;
            this.bt_obter.Text = "Obter";
            this.bt_obter.UseVisualStyleBackColor = false;
            // 
            // lb_valor
            // 
            this.lb_valor.AutoSize = true;
            this.lb_valor.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_valor.ForeColor = System.Drawing.Color.Green;
            this.lb_valor.Location = new System.Drawing.Point(469, 106);
            this.lb_valor.Name = "lb_valor";
            this.lb_valor.Size = new System.Drawing.Size(55, 26);
            this.lb_valor.TabIndex = 22;
            this.lb_valor.Text = "valor";
            this.lb_valor.Click += new System.EventHandler(this.valor_Click);
            // 
            // lb_like
            // 
            this.lb_like.AutoSize = true;
            this.lb_like.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lb_like.Location = new System.Drawing.Point(475, 59);
            this.lb_like.Name = "lb_like";
            this.lb_like.Size = new System.Drawing.Size(12, 14);
            this.lb_like.TabIndex = 20;
            this.lb_like.Text = "L";
            this.lb_like.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lb_visualizacao
            // 
            this.lb_visualizacao.AutoSize = true;
            this.lb_visualizacao.Location = new System.Drawing.Point(267, 14);
            this.lb_visualizacao.Name = "lb_visualizacao";
            this.lb_visualizacao.Size = new System.Drawing.Size(76, 13);
            this.lb_visualizacao.TabIndex = 19;
            this.lb_visualizacao.Text = "nvisualizacoes";
            this.lb_visualizacao.Click += new System.EventHandler(this.visualizacoes_Click_1);
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.Location = new System.Drawing.Point(212, 9);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(49, 20);
            this.lb_titulo.TabIndex = 15;
            this.lb_titulo.Text = "titulo";
            // 
            // pb_icone
            // 
            this.pb_icone.Location = new System.Drawing.Point(6, 20);
            this.pb_icone.Name = "pb_icone";
            this.pb_icone.Size = new System.Drawing.Size(200, 150);
            this.pb_icone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_icone.TabIndex = 14;
            this.pb_icone.TabStop = false;
            this.pb_icone.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // postcard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "postcard";
            this.Size = new System.Drawing.Size(605, 196);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.PictureBox pb_user;
        private System.Windows.Forms.Button bt_obter;
        private System.Windows.Forms.Label lb_valor;
        private System.Windows.Forms.Label lb_like;
        private System.Windows.Forms.Label lb_visualizacao;
        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.PictureBox pb_icone;
        private System.Windows.Forms.PictureBox pb_down;
        private System.Windows.Forms.PictureBox pb_up;
        private System.Windows.Forms.Label lb_descricao;
    }
}
