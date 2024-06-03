namespace SelecionadorFotos
{
    partial class FotoPicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FotoPicker));
            this.lbl_Files = new System.Windows.Forms.Label();
            this.txtBox_Arquivos = new System.Windows.Forms.TextBox();
            this.lbl_TextPath = new System.Windows.Forms.Label();
            this.txtBox_Path = new System.Windows.Forms.TextBox();
            this.btn_SelectPath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Files
            // 
            this.lbl_Files.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Files.Location = new System.Drawing.Point(12, 72);
            this.lbl_Files.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Files.Name = "lbl_Files";
            this.lbl_Files.Size = new System.Drawing.Size(284, 20);
            this.lbl_Files.TabIndex = 0;
            this.lbl_Files.Text = "Cole abaixo o texto copiado do Foto go:";
            this.lbl_Files.Click += new System.EventHandler(this.lbl_Files_Click);
            // 
            // txtBox_Arquivos
            // 
            this.txtBox_Arquivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Arquivos.Location = new System.Drawing.Point(15, 95);
            this.txtBox_Arquivos.Multiline = true;
            this.txtBox_Arquivos.Name = "txtBox_Arquivos";
            this.txtBox_Arquivos.Size = new System.Drawing.Size(281, 20);
            this.txtBox_Arquivos.TabIndex = 1;
            this.txtBox_Arquivos.TextChanged += new System.EventHandler(this.txtBox_Arquivos_TextChanged);
            // 
            // lbl_TextPath
            // 
            this.lbl_TextPath.AutoSize = true;
            this.lbl_TextPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TextPath.Location = new System.Drawing.Point(12, 9);
            this.lbl_TextPath.Name = "lbl_TextPath";
            this.lbl_TextPath.Size = new System.Drawing.Size(137, 16);
            this.lbl_TextPath.TabIndex = 2;
            this.lbl_TextPath.Text = "Selecione a pasta:";
            this.lbl_TextPath.Click += new System.EventHandler(this.TextPath_Click);
            // 
            // txtBox_Path
            // 
            this.txtBox_Path.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Path.Location = new System.Drawing.Point(15, 29);
            this.txtBox_Path.Name = "txtBox_Path";
            this.txtBox_Path.Size = new System.Drawing.Size(249, 20);
            this.txtBox_Path.TabIndex = 3;
            this.txtBox_Path.TextChanged += new System.EventHandler(this.txtBox_Path_TextChanged);
            // 
            // btn_SelectPath
            // 
            this.btn_SelectPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SelectPath.Location = new System.Drawing.Point(270, 29);
            this.btn_SelectPath.Name = "btn_SelectPath";
            this.btn_SelectPath.Size = new System.Drawing.Size(75, 20);
            this.btn_SelectPath.TabIndex = 4;
            this.btn_SelectPath.Text = "Procurar";
            this.btn_SelectPath.UseVisualStyleBackColor = true;
            this.btn_SelectPath.Click += new System.EventHandler(this.btn_SelectPath_Click);
            // 
            // FotoPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 468);
            this.Controls.Add(this.btn_SelectPath);
            this.Controls.Add(this.txtBox_Path);
            this.Controls.Add(this.lbl_TextPath);
            this.Controls.Add(this.txtBox_Arquivos);
            this.Controls.Add(this.lbl_Files);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FotoPicker";
            this.Text = "FotoPicker";
            this.Load += new System.EventHandler(this.FotoPicker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Files;
        private System.Windows.Forms.TextBox txtBox_Arquivos;
        private System.Windows.Forms.Label lbl_TextPath;
        private System.Windows.Forms.TextBox txtBox_Path;
        private System.Windows.Forms.Button btn_SelectPath;
    }
}

