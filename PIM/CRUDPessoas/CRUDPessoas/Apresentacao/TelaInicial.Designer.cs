namespace CRUDPessoas
{
    partial class TelaInicial
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCadastroColab = new System.Windows.Forms.ToolStripMenuItem();
            this.mniPEE = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tsmFolhaPgto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPonto = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mniCadastroJorn = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCadastroSalario = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCadastroCargo = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCadastroEncarg = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCadastroPerfUsua = new System.Windows.Forms.ToolStripMenuItem();
            this.emitirFolhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reciboDePagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simularFolhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reciboDeFériasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baterPontoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeHorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarHorasExatasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmContratos = new System.Windows.Forms.ToolStripMenuItem();
            this.fichaDeFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataDeAdmissãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recisãoDeContratoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avisoPrévioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examesMédicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSair = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCadastros,
            this.tsmFolhaPgto,
            this.tsmPonto,
            this.tsmContratos});
            this.menuStrip1.Location = new System.Drawing.Point(9, 201);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(453, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // tsmCadastros
            // 
            this.tsmCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniCadastroColab,
            this.mniCadastroJorn,
            this.mniCadastroSalario,
            this.mniCadastroCargo,
            this.mniCadastroEncarg,
            this.mniCadastroPerfUsua,
            this.mniPEE});
            this.tsmCadastros.Name = "tsmCadastros";
            this.tsmCadastros.Size = new System.Drawing.Size(71, 20);
            this.tsmCadastros.Text = "Cadastros";
            this.tsmCadastros.Click += new System.EventHandler(this.tsmPessoas_Click);
            // 
            // mniCadastroColab
            // 
            this.mniCadastroColab.Name = "mniCadastroColab";
            this.mniCadastroColab.Size = new System.Drawing.Size(219, 22);
            this.mniCadastroColab.Text = "Cadastro de Coloborador";
            this.mniCadastroColab.Click += new System.EventHandler(this.mniCadastro_Click);
            // 
            // mniPEE
            // 
            this.mniPEE.Name = "mniPEE";
            this.mniPEE.Size = new System.Drawing.Size(219, 22);
            this.mniPEE.Text = "Pesquisa, edição e exclusão";
            this.mniPEE.Click += new System.EventHandler(this.mniPEE_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tsmFolhaPgto
            // 
            this.tsmFolhaPgto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emitirFolhaToolStripMenuItem,
            this.reciboDePagamentoToolStripMenuItem,
            this.simularFolhaToolStripMenuItem,
            this.reciboDeFériasToolStripMenuItem});
            this.tsmFolhaPgto.Name = "tsmFolhaPgto";
            this.tsmFolhaPgto.Size = new System.Drawing.Size(128, 20);
            this.tsmFolhaPgto.Text = "Folha de Pagamento";
            // 
            // tsmPonto
            // 
            this.tsmPonto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baterPontoToolStripMenuItem,
            this.relatórioDeHorasToolStripMenuItem,
            this.verificarHorasExatasToolStripMenuItem});
            this.tsmPonto.Name = "tsmPonto";
            this.tsmPonto.Size = new System.Drawing.Size(116, 20);
            this.tsmPonto.Text = "Controle de Ponto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(613, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // mniCadastroJorn
            // 
            this.mniCadastroJorn.Name = "mniCadastroJorn";
            this.mniCadastroJorn.Size = new System.Drawing.Size(219, 22);
            this.mniCadastroJorn.Text = "Cadastro de Jornadas";
            // 
            // mniCadastroSalario
            // 
            this.mniCadastroSalario.Name = "mniCadastroSalario";
            this.mniCadastroSalario.Size = new System.Drawing.Size(219, 22);
            this.mniCadastroSalario.Text = "Cadastro de Salários";
            // 
            // mniCadastroCargo
            // 
            this.mniCadastroCargo.Name = "mniCadastroCargo";
            this.mniCadastroCargo.Size = new System.Drawing.Size(219, 22);
            this.mniCadastroCargo.Text = "Cadastro de Cargos";
            // 
            // mniCadastroEncarg
            // 
            this.mniCadastroEncarg.Name = "mniCadastroEncarg";
            this.mniCadastroEncarg.Size = new System.Drawing.Size(219, 22);
            this.mniCadastroEncarg.Text = "Cadastro de Encargos";
            // 
            // mniCadastroPerfUsua
            // 
            this.mniCadastroPerfUsua.Name = "mniCadastroPerfUsua";
            this.mniCadastroPerfUsua.Size = new System.Drawing.Size(219, 22);
            this.mniCadastroPerfUsua.Text = "Cadastro de Perfil/Usuário";
            // 
            // emitirFolhaToolStripMenuItem
            // 
            this.emitirFolhaToolStripMenuItem.Name = "emitirFolhaToolStripMenuItem";
            this.emitirFolhaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.emitirFolhaToolStripMenuItem.Text = "Emitir Folha";
            // 
            // reciboDePagamentoToolStripMenuItem
            // 
            this.reciboDePagamentoToolStripMenuItem.Name = "reciboDePagamentoToolStripMenuItem";
            this.reciboDePagamentoToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.reciboDePagamentoToolStripMenuItem.Text = "Recibo de Pagamento";
            // 
            // simularFolhaToolStripMenuItem
            // 
            this.simularFolhaToolStripMenuItem.Name = "simularFolhaToolStripMenuItem";
            this.simularFolhaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.simularFolhaToolStripMenuItem.Text = "Simular Folha";
            // 
            // reciboDeFériasToolStripMenuItem
            // 
            this.reciboDeFériasToolStripMenuItem.Name = "reciboDeFériasToolStripMenuItem";
            this.reciboDeFériasToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.reciboDeFériasToolStripMenuItem.Text = "Recibo de Férias";
            // 
            // baterPontoToolStripMenuItem
            // 
            this.baterPontoToolStripMenuItem.Name = "baterPontoToolStripMenuItem";
            this.baterPontoToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.baterPontoToolStripMenuItem.Text = "Bater Ponto";
            // 
            // relatórioDeHorasToolStripMenuItem
            // 
            this.relatórioDeHorasToolStripMenuItem.Name = "relatórioDeHorasToolStripMenuItem";
            this.relatórioDeHorasToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.relatórioDeHorasToolStripMenuItem.Text = "Relatório de Horas";
            // 
            // verificarHorasExatasToolStripMenuItem
            // 
            this.verificarHorasExatasToolStripMenuItem.Name = "verificarHorasExatasToolStripMenuItem";
            this.verificarHorasExatasToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.verificarHorasExatasToolStripMenuItem.Text = "Verificar Horas Exatas";
            // 
            // tsmContratos
            // 
            this.tsmContratos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichaDeFuncionárioToolStripMenuItem,
            this.dataDeAdmissãoToolStripMenuItem,
            this.recisãoDeContratoToolStripMenuItem,
            this.avisoPrévioToolStripMenuItem,
            this.examesMédicosToolStripMenuItem});
            this.tsmContratos.Name = "tsmContratos";
            this.tsmContratos.Size = new System.Drawing.Size(130, 20);
            this.tsmContratos.Text = "Contrato de Trabalho";
            // 
            // fichaDeFuncionárioToolStripMenuItem
            // 
            this.fichaDeFuncionárioToolStripMenuItem.Name = "fichaDeFuncionárioToolStripMenuItem";
            this.fichaDeFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.fichaDeFuncionárioToolStripMenuItem.Text = "Ficha de Funcionário";
            // 
            // dataDeAdmissãoToolStripMenuItem
            // 
            this.dataDeAdmissãoToolStripMenuItem.Name = "dataDeAdmissãoToolStripMenuItem";
            this.dataDeAdmissãoToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.dataDeAdmissãoToolStripMenuItem.Text = "Data de Admissão";
            // 
            // recisãoDeContratoToolStripMenuItem
            // 
            this.recisãoDeContratoToolStripMenuItem.Name = "recisãoDeContratoToolStripMenuItem";
            this.recisãoDeContratoToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.recisãoDeContratoToolStripMenuItem.Text = "Recisão de Contrato";
            // 
            // avisoPrévioToolStripMenuItem
            // 
            this.avisoPrévioToolStripMenuItem.Name = "avisoPrévioToolStripMenuItem";
            this.avisoPrévioToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.avisoPrévioToolStripMenuItem.Text = "Aviso Prévio";
            // 
            // examesMédicosToolStripMenuItem
            // 
            this.examesMédicosToolStripMenuItem.Name = "examesMédicosToolStripMenuItem";
            this.examesMédicosToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.examesMédicosToolStripMenuItem.Text = "Exames Médicos";
            // 
            // btnSair
            // 
            this.btnSair.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSair.Location = new System.Drawing.Point(1331, 202);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1477, 587);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "RECTH - Recursos Humanos";
            this.TransparencyKey = System.Drawing.SystemColors.Window;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastros;
        private System.Windows.Forms.ToolStripMenuItem mniCadastroColab;
        private System.Windows.Forms.ToolStripMenuItem mniPEE;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem tsmFolhaPgto;
        private System.Windows.Forms.ToolStripMenuItem tsmPonto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem mniCadastroJorn;
        private System.Windows.Forms.ToolStripMenuItem mniCadastroSalario;
        private System.Windows.Forms.ToolStripMenuItem mniCadastroCargo;
        private System.Windows.Forms.ToolStripMenuItem mniCadastroEncarg;
        private System.Windows.Forms.ToolStripMenuItem mniCadastroPerfUsua;
        private System.Windows.Forms.ToolStripMenuItem emitirFolhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reciboDePagamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simularFolhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reciboDeFériasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baterPontoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeHorasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verificarHorasExatasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmContratos;
        private System.Windows.Forms.ToolStripMenuItem fichaDeFuncionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataDeAdmissãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recisãoDeContratoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avisoPrévioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examesMédicosToolStripMenuItem;
        private System.Windows.Forms.Button btnSair;
    }
}

