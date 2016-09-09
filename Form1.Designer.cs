namespace ID3Utils
{
    partial class Form1
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
            this.fbdRoot = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDiretorioArquivos = new System.Windows.Forms.TextBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.gbEditando = new System.Windows.Forms.GroupBox();
            this.lblArquivosEncontrados = new System.Windows.Forms.Label();
            this.ckArtist = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckTitle = new System.Windows.Forms.CheckBox();
            this.ckAlbum = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbSeparador = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtExtra = new System.Windows.Forms.TextBox();
            this.btnRenomear = new System.Windows.Forms.Button();
            this.ckNumeracao = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.gbEditando.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnProcurar);
            this.groupBox1.Controls.Add(this.txtDiretorioArquivos);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Localização dos arquivos";
            // 
            // txtDiretorioArquivos
            // 
            this.txtDiretorioArquivos.Location = new System.Drawing.Point(67, 27);
            this.txtDiretorioArquivos.Name = "txtDiretorioArquivos";
            this.txtDiretorioArquivos.Size = new System.Drawing.Size(286, 20);
            this.txtDiretorioArquivos.TabIndex = 0;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(359, 25);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 23);
            this.btnProcurar.TabIndex = 1;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // gbEditando
            // 
            this.gbEditando.Controls.Add(this.ckNumeracao);
            this.gbEditando.Controls.Add(this.btnRenomear);
            this.gbEditando.Controls.Add(this.groupBox4);
            this.gbEditando.Controls.Add(this.groupBox3);
            this.gbEditando.Controls.Add(this.groupBox2);
            this.gbEditando.Controls.Add(this.lblArquivosEncontrados);
            this.gbEditando.Location = new System.Drawing.Point(12, 95);
            this.gbEditando.Name = "gbEditando";
            this.gbEditando.Size = new System.Drawing.Size(492, 238);
            this.gbEditando.TabIndex = 1;
            this.gbEditando.TabStop = false;
            this.gbEditando.Text = "Editando...";
            this.gbEditando.Visible = false;
            // 
            // lblArquivosEncontrados
            // 
            this.lblArquivosEncontrados.AutoSize = true;
            this.lblArquivosEncontrados.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblArquivosEncontrados.Location = new System.Drawing.Point(6, 16);
            this.lblArquivosEncontrados.Name = "lblArquivosEncontrados";
            this.lblArquivosEncontrados.Size = new System.Drawing.Size(107, 13);
            this.lblArquivosEncontrados.TabIndex = 0;
            this.lblArquivosEncontrados.Text = "arquivosEncontrados";
            // 
            // ckArtist
            // 
            this.ckArtist.AutoSize = true;
            this.ckArtist.Location = new System.Drawing.Point(6, 19);
            this.ckArtist.Name = "ckArtist";
            this.ckArtist.Size = new System.Drawing.Size(55, 17);
            this.ckArtist.TabIndex = 1;
            this.ckArtist.Text = "Artista";
            this.ckArtist.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ckAlbum);
            this.groupBox2.Controls.Add(this.ckTitle);
            this.groupBox2.Controls.Add(this.ckArtist);
            this.groupBox2.Location = new System.Drawing.Point(9, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(104, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ID3Tags";
            // 
            // ckTitle
            // 
            this.ckTitle.AutoSize = true;
            this.ckTitle.Location = new System.Drawing.Point(6, 42);
            this.ckTitle.Name = "ckTitle";
            this.ckTitle.Size = new System.Drawing.Size(54, 17);
            this.ckTitle.TabIndex = 2;
            this.ckTitle.Text = "Título";
            this.ckTitle.UseVisualStyleBackColor = true;
            // 
            // ckAlbum
            // 
            this.ckAlbum.AutoSize = true;
            this.ckAlbum.Location = new System.Drawing.Point(6, 65);
            this.ckAlbum.Name = "ckAlbum";
            this.ckAlbum.Size = new System.Drawing.Size(55, 17);
            this.ckAlbum.TabIndex = 3;
            this.ckAlbum.Text = "Álbum";
            this.ckAlbum.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbSeparador);
            this.groupBox3.Location = new System.Drawing.Point(119, 75);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(136, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Separador";
            // 
            // cmbSeparador
            // 
            this.cmbSeparador.FormattingEnabled = true;
            this.cmbSeparador.Items.AddRange(new object[] {
            "-",
            "_",
            "."});
            this.cmbSeparador.Location = new System.Drawing.Point(6, 29);
            this.cmbSeparador.Name = "cmbSeparador";
            this.cmbSeparador.Size = new System.Drawing.Size(121, 21);
            this.cmbSeparador.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtExtra);
            this.groupBox4.Location = new System.Drawing.Point(267, 75);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(225, 100);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Info. extra (opcional)";
            // 
            // txtExtra
            // 
            this.txtExtra.Location = new System.Drawing.Point(6, 30);
            this.txtExtra.Name = "txtExtra";
            this.txtExtra.Size = new System.Drawing.Size(213, 20);
            this.txtExtra.TabIndex = 0;
            // 
            // btnRenomear
            // 
            this.btnRenomear.Location = new System.Drawing.Point(9, 200);
            this.btnRenomear.Name = "btnRenomear";
            this.btnRenomear.Size = new System.Drawing.Size(477, 23);
            this.btnRenomear.TabIndex = 2;
            this.btnRenomear.Text = "Renomear";
            this.btnRenomear.UseVisualStyleBackColor = true;
            this.btnRenomear.Click += new System.EventHandler(this.btnRenomear_Click);
            // 
            // ckNumeracao
            // 
            this.ckNumeracao.AutoSize = true;
            this.ckNumeracao.Location = new System.Drawing.Point(14, 42);
            this.ckNumeracao.Name = "ckNumeracao";
            this.ckNumeracao.Size = new System.Drawing.Size(110, 17);
            this.ckNumeracao.TabIndex = 4;
            this.ckNumeracao.Text = "Incluir numeração";
            this.ckNumeracao.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 374);
            this.Controls.Add(this.gbEditando);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "ID3Utils";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbEditando.ResumeLayout(false);
            this.gbEditando.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fbdRoot;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.TextBox txtDiretorioArquivos;
        private System.Windows.Forms.GroupBox gbEditando;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ckAlbum;
        private System.Windows.Forms.CheckBox ckTitle;
        private System.Windows.Forms.CheckBox ckArtist;
        private System.Windows.Forms.Label lblArquivosEncontrados;
        private System.Windows.Forms.Button btnRenomear;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtExtra;
        private System.Windows.Forms.ComboBox cmbSeparador;
        private System.Windows.Forms.CheckBox ckNumeracao;
    }
}

