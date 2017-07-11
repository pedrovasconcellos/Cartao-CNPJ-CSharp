namespace CartaoCNPJ
{
    partial class U_CARTAOCNPJ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(U_CARTAOCNPJ));
            this.txtCNPJNum = new System.Windows.Forms.TextBox();
            this.btnCNPJ = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.cbxTipoArquivo = new System.Windows.Forms.ComboBox();
            this.gbxDadosCNPJ = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lblTipoArquivo = new System.Windows.Forms.Label();
            this.lblNumeroCNPJ = new System.Windows.Forms.Label();
            this.gbxDadosProxy = new System.Windows.Forms.GroupBox();
            this.txtPasswordProxy = new System.Windows.Forms.TextBox();
            this.lblPasswordProxy = new System.Windows.Forms.Label();
            this.lblUsernameProxy = new System.Windows.Forms.Label();
            this.txtUsernameProxy = new System.Windows.Forms.TextBox();
            this.btnAbrirCNPJ = new System.Windows.Forms.Button();
            this.txtMensagens = new System.Windows.Forms.TextBox();
            this.lblMensagens = new System.Windows.Forms.Label();
            this.btnAbrirDiretorio = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblClick = new System.Windows.Forms.Label();
            this.btnLinkVS = new System.Windows.Forms.Button();
            this.lblCopyRight = new System.Windows.Forms.Label();
            this.txtNotePad = new System.Windows.Forms.TextBox();
            this.lblNotePad = new System.Windows.Forms.Label();
            this.btnControlV = new System.Windows.Forms.Button();
            this.gbxDadosCNPJ.SuspendLayout();
            this.gbxDadosProxy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCNPJNum
            // 
            this.txtCNPJNum.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCNPJNum.Location = new System.Drawing.Point(14, 42);
            this.txtCNPJNum.MaxLength = 19;
            this.txtCNPJNum.Name = "txtCNPJNum";
            this.txtCNPJNum.Size = new System.Drawing.Size(119, 22);
            this.txtCNPJNum.TabIndex = 0;
            this.txtCNPJNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCNPJNum_KeyPress);
            // 
            // btnCNPJ
            // 
            this.btnCNPJ.BackColor = System.Drawing.Color.CadetBlue;
            this.btnCNPJ.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCNPJ.ForeColor = System.Drawing.Color.Transparent;
            this.btnCNPJ.Location = new System.Drawing.Point(393, 62);
            this.btnCNPJ.Name = "btnCNPJ";
            this.btnCNPJ.Size = new System.Drawing.Size(98, 39);
            this.btnCNPJ.TabIndex = 4;
            this.btnCNPJ.Text = "Solicitar Cartão CNPJ";
            this.btnCNPJ.UseVisualStyleBackColor = false;
            this.btnCNPJ.Click += new System.EventHandler(this.btnCNPJ_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Transparent;
            this.btnSair.Location = new System.Drawing.Point(497, 110);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(98, 29);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // cbxTipoArquivo
            // 
            this.cbxTipoArquivo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoArquivo.FormattingEnabled = true;
            this.cbxTipoArquivo.Items.AddRange(new object[] {
            ".JSON",
            ".TXT"});
            this.cbxTipoArquivo.Location = new System.Drawing.Point(14, 92);
            this.cbxTipoArquivo.Name = "cbxTipoArquivo";
            this.cbxTipoArquivo.Size = new System.Drawing.Size(119, 21);
            this.cbxTipoArquivo.TabIndex = 1;
            // 
            // gbxDadosCNPJ
            // 
            this.gbxDadosCNPJ.Controls.Add(this.btnControlV);
            this.gbxDadosCNPJ.Controls.Add(this.btnLimpar);
            this.gbxDadosCNPJ.Controls.Add(this.btnHelp);
            this.gbxDadosCNPJ.Controls.Add(this.lblTipoArquivo);
            this.gbxDadosCNPJ.Controls.Add(this.lblNumeroCNPJ);
            this.gbxDadosCNPJ.Controls.Add(this.txtCNPJNum);
            this.gbxDadosCNPJ.Controls.Add(this.cbxTipoArquivo);
            this.gbxDadosCNPJ.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDadosCNPJ.ForeColor = System.Drawing.Color.White;
            this.gbxDadosCNPJ.Location = new System.Drawing.Point(159, 12);
            this.gbxDadosCNPJ.Name = "gbxDadosCNPJ";
            this.gbxDadosCNPJ.Size = new System.Drawing.Size(219, 137);
            this.gbxDadosCNPJ.TabIndex = 0;
            this.gbxDadosCNPJ.TabStop = false;
            this.gbxDadosCNPJ.Text = "Dados";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.Transparent;
            this.btnLimpar.Location = new System.Drawing.Point(178, 37);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(33, 27);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "L";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.CadetBlue;
            this.btnHelp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.Transparent;
            this.btnHelp.Location = new System.Drawing.Point(139, 37);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(33, 27);
            this.btnHelp.TabIndex = 2;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // lblTipoArquivo
            // 
            this.lblTipoArquivo.AutoSize = true;
            this.lblTipoArquivo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoArquivo.Location = new System.Drawing.Point(14, 76);
            this.lblTipoArquivo.Name = "lblTipoArquivo";
            this.lblTipoArquivo.Size = new System.Drawing.Size(95, 13);
            this.lblTipoArquivo.TabIndex = 5;
            this.lblTipoArquivo.Text = "Tipo do Arquivo:";
            // 
            // lblNumeroCNPJ
            // 
            this.lblNumeroCNPJ.AutoSize = true;
            this.lblNumeroCNPJ.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroCNPJ.Location = new System.Drawing.Point(14, 23);
            this.lblNumeroCNPJ.Name = "lblNumeroCNPJ";
            this.lblNumeroCNPJ.Size = new System.Drawing.Size(100, 13);
            this.lblNumeroCNPJ.TabIndex = 4;
            this.lblNumeroCNPJ.Text = "Número do CNPJ:";
            // 
            // gbxDadosProxy
            // 
            this.gbxDadosProxy.Controls.Add(this.txtPasswordProxy);
            this.gbxDadosProxy.Controls.Add(this.lblPasswordProxy);
            this.gbxDadosProxy.Controls.Add(this.lblUsernameProxy);
            this.gbxDadosProxy.Controls.Add(this.txtUsernameProxy);
            this.gbxDadosProxy.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDadosProxy.ForeColor = System.Drawing.Color.White;
            this.gbxDadosProxy.Location = new System.Drawing.Point(159, 168);
            this.gbxDadosProxy.Name = "gbxDadosProxy";
            this.gbxDadosProxy.Size = new System.Drawing.Size(219, 137);
            this.gbxDadosProxy.TabIndex = 18;
            this.gbxDadosProxy.TabStop = false;
            this.gbxDadosProxy.Text = "Dados do Proxy (Uso com PROXY)";
            // 
            // txtPasswordProxy
            // 
            this.txtPasswordProxy.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordProxy.Location = new System.Drawing.Point(14, 93);
            this.txtPasswordProxy.MaxLength = 20;
            this.txtPasswordProxy.Name = "txtPasswordProxy";
            this.txtPasswordProxy.Size = new System.Drawing.Size(119, 22);
            this.txtPasswordProxy.TabIndex = 9;
            // 
            // lblPasswordProxy
            // 
            this.lblPasswordProxy.AutoSize = true;
            this.lblPasswordProxy.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordProxy.Location = new System.Drawing.Point(14, 76);
            this.lblPasswordProxy.Name = "lblPasswordProxy";
            this.lblPasswordProxy.Size = new System.Drawing.Size(42, 13);
            this.lblPasswordProxy.TabIndex = 5;
            this.lblPasswordProxy.Text = "Senha:";
            // 
            // lblUsernameProxy
            // 
            this.lblUsernameProxy.AutoSize = true;
            this.lblUsernameProxy.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameProxy.Location = new System.Drawing.Point(14, 23);
            this.lblUsernameProxy.Name = "lblUsernameProxy";
            this.lblUsernameProxy.Size = new System.Drawing.Size(50, 13);
            this.lblUsernameProxy.TabIndex = 4;
            this.lblUsernameProxy.Text = "Usuário:";
            // 
            // txtUsernameProxy
            // 
            this.txtUsernameProxy.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameProxy.Location = new System.Drawing.Point(14, 42);
            this.txtUsernameProxy.MaxLength = 20;
            this.txtUsernameProxy.Name = "txtUsernameProxy";
            this.txtUsernameProxy.Size = new System.Drawing.Size(119, 22);
            this.txtUsernameProxy.TabIndex = 8;
            // 
            // btnAbrirCNPJ
            // 
            this.btnAbrirCNPJ.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAbrirCNPJ.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirCNPJ.ForeColor = System.Drawing.Color.Transparent;
            this.btnAbrirCNPJ.Location = new System.Drawing.Point(497, 62);
            this.btnAbrirCNPJ.Name = "btnAbrirCNPJ";
            this.btnAbrirCNPJ.Size = new System.Drawing.Size(98, 39);
            this.btnAbrirCNPJ.TabIndex = 5;
            this.btnAbrirCNPJ.Text = "Abrir Cartão CNPJ";
            this.btnAbrirCNPJ.UseVisualStyleBackColor = false;
            this.btnAbrirCNPJ.Click += new System.EventHandler(this.btnAbrirCNPJ_Click);
            // 
            // txtMensagens
            // 
            this.txtMensagens.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensagens.Location = new System.Drawing.Point(393, 181);
            this.txtMensagens.Multiline = true;
            this.txtMensagens.Name = "txtMensagens";
            this.txtMensagens.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMensagens.Size = new System.Drawing.Size(202, 124);
            this.txtMensagens.TabIndex = 11;
            // 
            // lblMensagens
            // 
            this.lblMensagens.AutoSize = true;
            this.lblMensagens.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagens.ForeColor = System.Drawing.Color.White;
            this.lblMensagens.Location = new System.Drawing.Point(390, 165);
            this.lblMensagens.Name = "lblMensagens";
            this.lblMensagens.Size = new System.Drawing.Size(130, 13);
            this.lblMensagens.TabIndex = 8;
            this.lblMensagens.Text = "Mensagens do Sistema:";
            // 
            // btnAbrirDiretorio
            // 
            this.btnAbrirDiretorio.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAbrirDiretorio.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirDiretorio.ForeColor = System.Drawing.Color.Transparent;
            this.btnAbrirDiretorio.Location = new System.Drawing.Point(393, 110);
            this.btnAbrirDiretorio.Name = "btnAbrirDiretorio";
            this.btnAbrirDiretorio.Size = new System.Drawing.Size(98, 29);
            this.btnAbrirDiretorio.TabIndex = 6;
            this.btnAbrirDiretorio.Text = "Abrir Diretório";
            this.btnAbrirDiretorio.UseVisualStyleBackColor = false;
            this.btnAbrirDiretorio.Click += new System.EventHandler(this.btnAbrirDiretorio_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 86);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblClick
            // 
            this.lblClick.AutoSize = true;
            this.lblClick.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClick.ForeColor = System.Drawing.Color.White;
            this.lblClick.Location = new System.Drawing.Point(431, 12);
            this.lblClick.Name = "lblClick";
            this.lblClick.Size = new System.Drawing.Size(115, 13);
            this.lblClick.TabIndex = 12;
            this.lblClick.Text = "Venha nos conhecer!";
            // 
            // btnLinkVS
            // 
            this.btnLinkVS.BackColor = System.Drawing.Color.CadetBlue;
            this.btnLinkVS.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLinkVS.ForeColor = System.Drawing.Color.Transparent;
            this.btnLinkVS.Location = new System.Drawing.Point(393, 29);
            this.btnLinkVS.Name = "btnLinkVS";
            this.btnLinkVS.Size = new System.Drawing.Size(202, 27);
            this.btnLinkVS.TabIndex = 10;
            this.btnLinkVS.Text = "www.vasconcellossolutions.com";
            this.btnLinkVS.UseVisualStyleBackColor = false;
            this.btnLinkVS.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCopyRight
            // 
            this.lblCopyRight.AutoSize = true;
            this.lblCopyRight.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyRight.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCopyRight.Location = new System.Drawing.Point(358, 320);
            this.lblCopyRight.Name = "lblCopyRight";
            this.lblCopyRight.Size = new System.Drawing.Size(235, 13);
            this.lblCopyRight.TabIndex = 14;
            this.lblCopyRight.Text = "Copyright © YYYY Vasconcellos IT Solutions";
            // 
            // txtNotePad
            // 
            this.txtNotePad.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotePad.Location = new System.Drawing.Point(12, 181);
            this.txtNotePad.Multiline = true;
            this.txtNotePad.Name = "txtNotePad";
            this.txtNotePad.Size = new System.Drawing.Size(135, 124);
            this.txtNotePad.TabIndex = 15;
            // 
            // lblNotePad
            // 
            this.lblNotePad.AutoSize = true;
            this.lblNotePad.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotePad.ForeColor = System.Drawing.Color.White;
            this.lblNotePad.Location = new System.Drawing.Point(9, 165);
            this.lblNotePad.Name = "lblNotePad";
            this.lblNotePad.Size = new System.Drawing.Size(114, 13);
            this.lblNotePad.TabIndex = 16;
            this.lblNotePad.Text = "Bloco de anotações: ";
            // 
            // btnControlV
            // 
            this.btnControlV.BackColor = System.Drawing.Color.CadetBlue;
            this.btnControlV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControlV.ForeColor = System.Drawing.Color.Transparent;
            this.btnControlV.Location = new System.Drawing.Point(139, 70);
            this.btnControlV.Name = "btnControlV";
            this.btnControlV.Size = new System.Drawing.Size(72, 27);
            this.btnControlV.TabIndex = 6;
            this.btnControlV.Text = "Ctrl + V";
            this.btnControlV.UseVisualStyleBackColor = false;
            this.btnControlV.Click += new System.EventHandler(this.btnControlV_Click);
            // 
            // U_CARTAOCNPJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(613, 344);
            this.Controls.Add(this.lblNotePad);
            this.Controls.Add(this.txtNotePad);
            this.Controls.Add(this.lblCopyRight);
            this.Controls.Add(this.btnLinkVS);
            this.Controls.Add(this.lblClick);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAbrirDiretorio);
            this.Controls.Add(this.lblMensagens);
            this.Controls.Add(this.txtMensagens);
            this.Controls.Add(this.btnAbrirCNPJ);
            this.Controls.Add(this.gbxDadosProxy);
            this.Controls.Add(this.gbxDadosCNPJ);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCNPJ);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "U_CARTAOCNPJ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de Cartão CNPJ  -  VASCONCELLOS IT SOLUTIONS";
            this.gbxDadosCNPJ.ResumeLayout(false);
            this.gbxDadosCNPJ.PerformLayout();
            this.gbxDadosProxy.ResumeLayout(false);
            this.gbxDadosProxy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCNPJNum;
        private System.Windows.Forms.Button btnCNPJ;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ComboBox cbxTipoArquivo;
        private System.Windows.Forms.GroupBox gbxDadosCNPJ;
        private System.Windows.Forms.Label lblTipoArquivo;
        private System.Windows.Forms.Label lblNumeroCNPJ;
        private System.Windows.Forms.GroupBox gbxDadosProxy;
        private System.Windows.Forms.TextBox txtPasswordProxy;
        private System.Windows.Forms.Label lblPasswordProxy;
        private System.Windows.Forms.Label lblUsernameProxy;
        private System.Windows.Forms.TextBox txtUsernameProxy;
        private System.Windows.Forms.Button btnAbrirCNPJ;
        private System.Windows.Forms.TextBox txtMensagens;
        private System.Windows.Forms.Label lblMensagens;
        private System.Windows.Forms.Button btnAbrirDiretorio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label lblClick;
        private System.Windows.Forms.Button btnLinkVS;
        private System.Windows.Forms.Label lblCopyRight;
        private System.Windows.Forms.TextBox txtNotePad;
        private System.Windows.Forms.Label lblNotePad;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnControlV;
    }
}

