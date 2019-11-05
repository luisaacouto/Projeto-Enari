namespace Pont_Finder.servicos
{
    partial class Post
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
            System.Windows.Forms.Panel panel1;
            this.bt_icone = new System.Windows.Forms.Button();
            this.pb_icone = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelar = new System.Windows.Forms.Button();
            this.publicar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.openIcone = new System.Windows.Forms.OpenFileDialog();
            panel1 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icone)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(this.bt_icone);
            panel1.Controls.Add(this.pb_icone);
            panel1.Controls.Add(this.label3);
            panel1.Controls.Add(this.textBox3);
            panel1.Controls.Add(this.label2);
            panel1.Controls.Add(this.textBox1);
            panel1.Controls.Add(this.label1);
            panel1.Controls.Add(this.cancelar);
            panel1.Controls.Add(this.publicar);
            panel1.Controls.Add(this.textBox2);
            panel1.Location = new System.Drawing.Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(499, 500);
            panel1.TabIndex = 3;
            panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // bt_icone
            // 
            this.bt_icone.Location = new System.Drawing.Point(338, 12);
            this.bt_icone.Name = "bt_icone";
            this.bt_icone.Size = new System.Drawing.Size(44, 150);
            this.bt_icone.TabIndex = 1;
            this.bt_icone.Text = "Selecionar";
            this.bt_icone.UseVisualStyleBackColor = true;
            this.bt_icone.Click += new System.EventHandler(this.Bt_icone_Click);
            // 
            // pb_icone
            // 
            this.pb_icone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_icone.Image = global::Pont_Finder.Properties.Resources.offImage;
            this.pb_icone.InitialImage = global::Pont_Finder.Properties.Resources.offImage;
            this.pb_icone.Location = new System.Drawing.Point(132, 12);
            this.pb_icone.Name = "pb_icone";
            this.pb_icone.Size = new System.Drawing.Size(200, 150);
            this.pb_icone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_icone.TabIndex = 9;
            this.pb_icone.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Serviço";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(132, 197);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(250, 20);
            this.textBox3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Valor";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 236);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Detalhes";
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(287, 454);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(95, 34);
            this.cancelar.TabIndex = 6;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // publicar
            // 
            this.publicar.Location = new System.Drawing.Point(132, 454);
            this.publicar.Name = "publicar";
            this.publicar.Size = new System.Drawing.Size(99, 34);
            this.publicar.TabIndex = 5;
            this.publicar.Text = "Publicar";
            this.publicar.UseVisualStyleBackColor = true;
            this.publicar.Click += new System.EventHandler(this.Publicar_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(132, 285);
            this.textBox2.MaximumSize = new System.Drawing.Size(250, 150);
            this.textBox2.MaxLength = 380;
            this.textBox2.MinimumSize = new System.Drawing.Size(250, 150);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(250, 150);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // openIcone
            // 
            this.openIcone.FileName = "icone";
            this.openIcone.Filter = "\"Image|*.jpg;*.jpeg;*.bmp\"";
            this.openIcone.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenIcone_FileOk);
            // 
            // Post
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Post";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button publicar;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox pb_icone;
        private System.Windows.Forms.Button bt_icone;
        private System.Windows.Forms.OpenFileDialog openIcone;
    }
}