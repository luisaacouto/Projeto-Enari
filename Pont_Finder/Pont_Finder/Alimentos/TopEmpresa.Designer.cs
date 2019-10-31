namespace Pont_Finder
{
    partial class UserControl1
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TopEmp = new System.Windows.Forms.Panel();
            this.NomeTopEmp = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TopEmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TopEmp
            // 
            this.TopEmp.BackColor = System.Drawing.Color.Transparent;
            this.TopEmp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TopEmp.Controls.Add(this.NomeTopEmp);
            this.TopEmp.Controls.Add(this.pictureBox1);
            this.TopEmp.Location = new System.Drawing.Point(0, 0);
            this.TopEmp.Name = "TopEmp";
            this.TopEmp.Size = new System.Drawing.Size(294, 50);
            this.TopEmp.TabIndex = 0;
            this.TopEmp.Paint += new System.Windows.Forms.PaintEventHandler(this.TopEmp_Paint);
            // 
            // NomeTopEmp
            // 
            this.NomeTopEmp.AutoSize = true;
            this.NomeTopEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeTopEmp.Location = new System.Drawing.Point(50, 15);
            this.NomeTopEmp.Name = "NomeTopEmp";
            this.NomeTopEmp.Size = new System.Drawing.Size(57, 20);
            this.NomeTopEmp.TabIndex = 1;
            this.NomeTopEmp.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TopEmp);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(294, 50);
            this.TopEmp.ResumeLayout(false);
            this.TopEmp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopEmp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label NomeTopEmp;
    }
}
