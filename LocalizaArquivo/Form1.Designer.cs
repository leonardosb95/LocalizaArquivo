namespace LocalizaArquivo
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
            this.label2 = new System.Windows.Forms.Label();
            this.textoArquivo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTotalDeArquivos = new System.Windows.Forms.Label();
            this.botaoLocaliza = new System.Windows.Forms.Button();
            this.comboPastas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mensagemLabel = new System.Windows.Forms.Label();
            this.listViewResultado = new System.Windows.Forms.ListView();
            this.columLinguagem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columArquivo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.folderBrowserPasta = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonEscolhePasta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digite a palavra";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textoArquivo
            // 
            this.textoArquivo.Location = new System.Drawing.Point(128, 31);
            this.textoArquivo.Name = "textoArquivo";
            this.textoArquivo.Size = new System.Drawing.Size(176, 20);
            this.textoArquivo.TabIndex = 3;
            this.textoArquivo.Click += new System.EventHandler(this.textoArquivo_Click);
            this.textoArquivo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textoArquivo_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total de arquivos:";
            // 
            // labelTotalDeArquivos
            // 
            this.labelTotalDeArquivos.AutoSize = true;
            this.labelTotalDeArquivos.Location = new System.Drawing.Point(132, 109);
            this.labelTotalDeArquivos.Name = "labelTotalDeArquivos";
            this.labelTotalDeArquivos.Size = new System.Drawing.Size(0, 13);
            this.labelTotalDeArquivos.TabIndex = 8;
            // 
            // botaoLocaliza
            // 
            this.botaoLocaliza.BackColor = System.Drawing.Color.GhostWhite;
            this.botaoLocaliza.Location = new System.Drawing.Point(335, 19);
            this.botaoLocaliza.Name = "botaoLocaliza";
            this.botaoLocaliza.Size = new System.Drawing.Size(114, 42);
            this.botaoLocaliza.TabIndex = 9;
            this.botaoLocaliza.Text = "Localizar palavra";
            this.botaoLocaliza.UseVisualStyleBackColor = false;
            this.botaoLocaliza.Click += new System.EventHandler(this.botaoLocaliza_Click);
            // 
            // comboPastas
            // 
            this.comboPastas.FormattingEnabled = true;
            this.comboPastas.Location = new System.Drawing.Point(571, 31);
            this.comboPastas.Name = "comboPastas";
            this.comboPastas.Size = new System.Drawing.Size(121, 21);
            this.comboPastas.TabIndex = 11;
            this.comboPastas.SelectedIndexChanged += new System.EventHandler(this.comboPastas_SelectedIndexChanged);
            this.comboPastas.Click += new System.EventHandler(this.comboPastas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(514, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Pastas";
            // 
            // mensagemLabel
            // 
            this.mensagemLabel.AutoSize = true;
            this.mensagemLabel.Location = new System.Drawing.Point(111, 73);
            this.mensagemLabel.Name = "mensagemLabel";
            this.mensagemLabel.Size = new System.Drawing.Size(0, 13);
            this.mensagemLabel.TabIndex = 13;
            // 
            // listViewResultado
            // 
            this.listViewResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewResultado.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columLinguagem,
            this.columArquivo});
            this.listViewResultado.FullRowSelect = true;
            this.listViewResultado.GridLines = true;
            this.listViewResultado.Location = new System.Drawing.Point(12, 172);
            this.listViewResultado.Name = "listViewResultado";
            this.listViewResultado.Size = new System.Drawing.Size(695, 275);
            this.listViewResultado.TabIndex = 14;
            this.listViewResultado.UseCompatibleStateImageBehavior = false;
            this.listViewResultado.View = System.Windows.Forms.View.Details;
            this.listViewResultado.DoubleClick += new System.EventHandler(this.listViewResultado_DoubleClick);
            // 
            // columLinguagem
            // 
            this.columLinguagem.DisplayIndex = 1;
            this.columLinguagem.Text = "Linguagem";
            this.columLinguagem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columLinguagem.Width = 370;
            // 
            // columArquivo
            // 
            this.columArquivo.DisplayIndex = 0;
            this.columArquivo.Text = "Arquivo";
            this.columArquivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columArquivo.Width = 429;
            // 
            // buttonEscolhePasta
            // 
            this.buttonEscolhePasta.Location = new System.Drawing.Point(571, 73);
            this.buttonEscolhePasta.Name = "buttonEscolhePasta";
            this.buttonEscolhePasta.Size = new System.Drawing.Size(121, 23);
            this.buttonEscolhePasta.TabIndex = 15;
            this.buttonEscolhePasta.Text = "button1";
            this.buttonEscolhePasta.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(719, 459);
            this.Controls.Add(this.buttonEscolhePasta);
            this.Controls.Add(this.listViewResultado);
            this.Controls.Add(this.mensagemLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboPastas);
            this.Controls.Add(this.botaoLocaliza);
            this.Controls.Add(this.labelTotalDeArquivos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textoArquivo);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Localiza arquivos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textoArquivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTotalDeArquivos;
        private System.Windows.Forms.Button botaoLocaliza;
        private System.Windows.Forms.ComboBox comboPastas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mensagemLabel;
        private System.Windows.Forms.ListView listViewResultado;
        public System.Windows.Forms.ColumnHeader columLinguagem;
        public System.Windows.Forms.ColumnHeader columArquivo;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserPasta;
        private System.Windows.Forms.Button buttonEscolhePasta;
    }
}

