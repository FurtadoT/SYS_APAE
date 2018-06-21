using System.Windows.Forms;
using SYS_APAE_CUSTOM_COMPONENTS.CustomComponents;


namespace SYS_APAE
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.tabControlGeral = new System.Windows.Forms.TabControl();
            this.tabCadastro = new System.Windows.Forms.TabPage();
            this.btnReset = new System.Windows.Forms.Button();
            this.dtpExp = new System.Windows.Forms.DateTimePicker();
            this.dtpNasc = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtEmail = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDDD = new System.Windows.Forms.Label();
            this.txtCelular = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBox();
            this.txtDDD = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblDDDTel = new System.Windows.Forms.Label();
            this.txtTel = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBox();
            this.txtDDDTel = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtEstado = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtCidade = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCep = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtEnd = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.txtPai = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBox();
            this.txtMae = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBox();
            this.txtBairro = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBox();
            this.txtNaturalidade = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBox();
            this.lblNasc = new System.Windows.Forms.Label();
            this.lblDataExp = new System.Windows.Forms.Label();
            this.txtOrgExp = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBox();
            this.txtRG = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblOrgExp = new System.Windows.Forms.Label();
            this.lblNaturalidade = new System.Windows.Forms.Label();
            this.lblFiliacao = new System.Windows.Forms.Label();
            this.lblPai = new System.Windows.Forms.Label();
            this.lblMae = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.txtCPF = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtNome = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.tabCadastroMonitor = new System.Windows.Forms.TabPage();
            this.btnClearNewInstructor = new System.Windows.Forms.Button();
            this.btnInsertNewInstructor = new System.Windows.Forms.Button();
            this.gpbMonitoria = new System.Windows.Forms.GroupBox();
            this.txtCargaInstructor = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel();
            this.txtTipoInstructor = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel();
            this.txtProntuarioInstructor = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel();
            this.gpbLoginData = new System.Windows.Forms.GroupBox();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.txtPasswordInstructor = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel();
            this.txtCpfInstructor = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomMaskedTextBoxWithLabel();
            this.gpbInstructorGeneral = new System.Windows.Forms.GroupBox();
            this.txtEmailInstructor = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel();
            this.txtNameInstructor = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel();
            this.tabParticipante = new System.Windows.Forms.TabPage();
            this.dtgParticipantes = new System.Windows.Forms.DataGridView();
            this.radioListMonitor = new System.Windows.Forms.RadioButton();
            this.radioListAluno = new System.Windows.Forms.RadioButton();
            this.tabVisuRel = new System.Windows.Forms.TabPage();
            this.lblSearchReports = new System.Windows.Forms.Label();
            this.dtgReports = new System.Windows.Forms.DataGridView();
            this.txtSearchReports = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBox();
            this.tabGerarRel = new System.Windows.Forms.TabPage();
            this.btnRefreshReport = new System.Windows.Forms.Button();
            this.btnRelAdd = new System.Windows.Forms.Button();
            this.dtpRelCreated = new System.Windows.Forms.DateTimePicker();
            this.cmbNomeMonitor = new System.Windows.Forms.ComboBox();
            this.cmbNomeAluno = new System.Windows.Forms.ComboBox();
            this.gpBoxInteressante = new System.Windows.Forms.GroupBox();
            this.lblInteressante = new System.Windows.Forms.Label();
            this.radioInteressante0 = new System.Windows.Forms.RadioButton();
            this.radioInteressante5 = new System.Windows.Forms.RadioButton();
            this.radioInteressante3 = new System.Windows.Forms.RadioButton();
            this.radioInteressante4 = new System.Windows.Forms.RadioButton();
            this.radioInteressante2 = new System.Windows.Forms.RadioButton();
            this.radioInteressante1 = new System.Windows.Forms.RadioButton();
            this.lblObsInteressante = new System.Windows.Forms.Label();
            this.txtObsInteressante = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBox();
            this.gpBoxAtividade = new System.Windows.Forms.GroupBox();
            this.txtObs = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.radioAtividade0 = new System.Windows.Forms.RadioButton();
            this.lblAtividade = new System.Windows.Forms.Label();
            this.radioAtividade5 = new System.Windows.Forms.RadioButton();
            this.radioAtividade3 = new System.Windows.Forms.RadioButton();
            this.radioAtividade4 = new System.Windows.Forms.RadioButton();
            this.radioAtividade2 = new System.Windows.Forms.RadioButton();
            this.radioAtividade1 = new System.Windows.Forms.RadioButton();
            this.gpBoxRecLetras = new System.Windows.Forms.GroupBox();
            this.lblReconhecer = new System.Windows.Forms.Label();
            this.radioReconhecer0 = new System.Windows.Forms.RadioButton();
            this.radioReconhecer5 = new System.Windows.Forms.RadioButton();
            this.radioReconhecer3 = new System.Windows.Forms.RadioButton();
            this.radioReconhecer4 = new System.Windows.Forms.RadioButton();
            this.radioReconhecer2 = new System.Windows.Forms.RadioButton();
            this.radioReconhecer1 = new System.Windows.Forms.RadioButton();
            this.gpBoxLeitura = new System.Windows.Forms.GroupBox();
            this.lblLeitura = new System.Windows.Forms.Label();
            this.radioLeitura0 = new System.Windows.Forms.RadioButton();
            this.radioLeitura5 = new System.Windows.Forms.RadioButton();
            this.radioLeitura3 = new System.Windows.Forms.RadioButton();
            this.radioLeitura4 = new System.Windows.Forms.RadioButton();
            this.radioLeitura2 = new System.Windows.Forms.RadioButton();
            this.radioLeitura1 = new System.Windows.Forms.RadioButton();
            this.gpBoxDigitacao = new System.Windows.Forms.GroupBox();
            this.lblDigitacao = new System.Windows.Forms.Label();
            this.radioDig0 = new System.Windows.Forms.RadioButton();
            this.radioDig5 = new System.Windows.Forms.RadioButton();
            this.radioDig3 = new System.Windows.Forms.RadioButton();
            this.radioDig4 = new System.Windows.Forms.RadioButton();
            this.radioDig2 = new System.Windows.Forms.RadioButton();
            this.radioDig1 = new System.Windows.Forms.RadioButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblNomeAluno = new System.Windows.Forms.Label();
            this.lblPront = new System.Windows.Forms.Label();
            this.lblNomeMonitor = new System.Windows.Forms.Label();
            this.txtTitulo = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBox();
            this.txtProntRelatorio = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBox();
            this.logo_if = new System.Windows.Forms.PictureBox();
            this.pnlGreenDatail = new System.Windows.Forms.Panel();
            this.lblWUser = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.mnPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnItemNewStudents = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItemNewInstructor = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroAtividadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItemShowStudents = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItemNewReports = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItemShowReports = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlGeral.SuspendLayout();
            this.tabCadastro.SuspendLayout();
            this.tabCadastroMonitor.SuspendLayout();
            this.gpbMonitoria.SuspendLayout();
            this.gpbLoginData.SuspendLayout();
            this.gpbInstructorGeneral.SuspendLayout();
            this.tabParticipante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgParticipantes)).BeginInit();
            this.tabVisuRel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReports)).BeginInit();
            this.tabGerarRel.SuspendLayout();
            this.gpBoxInteressante.SuspendLayout();
            this.gpBoxAtividade.SuspendLayout();
            this.gpBoxRecLetras.SuspendLayout();
            this.gpBoxLeitura.SuspendLayout();
            this.gpBoxDigitacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_if)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.mnPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlGeral
            // 
            this.tabControlGeral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlGeral.Controls.Add(this.tabCadastro);
            this.tabControlGeral.Controls.Add(this.tabCadastroMonitor);
            this.tabControlGeral.Controls.Add(this.tabParticipante);
            this.tabControlGeral.Controls.Add(this.tabVisuRel);
            this.tabControlGeral.Controls.Add(this.tabGerarRel);
            this.tabControlGeral.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabControlGeral.Location = new System.Drawing.Point(136, 91);
            this.tabControlGeral.Name = "tabControlGeral";
            this.tabControlGeral.SelectedIndex = 0;
            this.tabControlGeral.Size = new System.Drawing.Size(1098, 380);
            this.tabControlGeral.TabIndex = 1;
            // 
            // tabCadastro
            // 
            this.tabCadastro.AutoScroll = true;
            this.tabCadastro.Controls.Add(this.btnReset);
            this.tabCadastro.Controls.Add(this.dtpExp);
            this.tabCadastro.Controls.Add(this.dtpNasc);
            this.tabCadastro.Controls.Add(this.btnAdd);
            this.tabCadastro.Controls.Add(this.txtEmail);
            this.tabCadastro.Controls.Add(this.lblEmail);
            this.tabCadastro.Controls.Add(this.lblDDD);
            this.tabCadastro.Controls.Add(this.txtCelular);
            this.tabCadastro.Controls.Add(this.txtDDD);
            this.tabCadastro.Controls.Add(this.lblCelular);
            this.tabCadastro.Controls.Add(this.lblDDDTel);
            this.tabCadastro.Controls.Add(this.txtTel);
            this.tabCadastro.Controls.Add(this.txtDDDTel);
            this.tabCadastro.Controls.Add(this.lblTel);
            this.tabCadastro.Controls.Add(this.txtEstado);
            this.tabCadastro.Controls.Add(this.lblEstado);
            this.tabCadastro.Controls.Add(this.txtCidade);
            this.tabCadastro.Controls.Add(this.lblCidade);
            this.tabCadastro.Controls.Add(this.txtCep);
            this.tabCadastro.Controls.Add(this.lblBairro);
            this.tabCadastro.Controls.Add(this.txtEnd);
            this.tabCadastro.Controls.Add(this.lblCep);
            this.tabCadastro.Controls.Add(this.txtPai);
            this.tabCadastro.Controls.Add(this.txtMae);
            this.tabCadastro.Controls.Add(this.txtBairro);
            this.tabCadastro.Controls.Add(this.txtNaturalidade);
            this.tabCadastro.Controls.Add(this.lblNasc);
            this.tabCadastro.Controls.Add(this.lblDataExp);
            this.tabCadastro.Controls.Add(this.txtOrgExp);
            this.tabCadastro.Controls.Add(this.txtRG);
            this.tabCadastro.Controls.Add(this.lblRG);
            this.tabCadastro.Controls.Add(this.lblOrgExp);
            this.tabCadastro.Controls.Add(this.lblNaturalidade);
            this.tabCadastro.Controls.Add(this.lblFiliacao);
            this.tabCadastro.Controls.Add(this.lblPai);
            this.tabCadastro.Controls.Add(this.lblMae);
            this.tabCadastro.Controls.Add(this.lblEnd);
            this.tabCadastro.Controls.Add(this.txtCPF);
            this.tabCadastro.Controls.Add(this.lblCPF);
            this.tabCadastro.Controls.Add(this.txtNome);
            this.tabCadastro.Controls.Add(this.lblNome);
            this.tabCadastro.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabCadastro.Location = new System.Drawing.Point(4, 22);
            this.tabCadastro.Name = "tabCadastro";
            this.tabCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastro.Size = new System.Drawing.Size(1090, 354);
            this.tabCadastro.TabIndex = 0;
            this.tabCadastro.Text = "Cadastrar Aluno";
            this.tabCadastro.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(107, 308);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(95, 33);
            this.btnReset.TabIndex = 24;
            this.btnReset.Text = "Limpar";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dtpExp
            // 
            this.dtpExp.CustomFormat = "\"dd-MM-yyyy\"";
            this.dtpExp.Location = new System.Drawing.Point(76, 137);
            this.dtpExp.Name = "dtpExp";
            this.dtpExp.Size = new System.Drawing.Size(204, 20);
            this.dtpExp.TabIndex = 10;
            this.dtpExp.Value = new System.DateTime(2018, 5, 13, 0, 19, 44, 0);
            this.dtpExp.Enter += new System.EventHandler(this.dtpExp_Enter);
            // 
            // dtpNasc
            // 
            this.dtpNasc.CustomFormat = "\"dd-MM-yyyy\"";
            this.dtpNasc.Location = new System.Drawing.Point(408, 52);
            this.dtpNasc.Name = "dtpNasc";
            this.dtpNasc.Size = new System.Drawing.Size(249, 20);
            this.dtpNasc.TabIndex = 6;
            this.dtpNasc.Value = new System.DateTime(2018, 5, 13, 0, 19, 44, 0);
            this.dtpNasc.Enter += new System.EventHandler(this.dtpNasc_Enter);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(341, 308);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(558, 33);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Location = new System.Drawing.Point(715, 222);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(360, 20);
            this.txtEmail.TabIndex = 22;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(671, 224);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 46;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblDDD
            // 
            this.lblDDD.AutoSize = true;
            this.lblDDD.Location = new System.Drawing.Point(30, 224);
            this.lblDDD.Name = "lblDDD";
            this.lblDDD.Size = new System.Drawing.Size(34, 13);
            this.lblDDD.TabIndex = 45;
            this.lblDDD.Text = "DDD:";
            // 
            // txtCelular
            // 
            this.txtCelular.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCelular.Location = new System.Drawing.Point(160, 221);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(164, 20);
            this.txtCelular.TabIndex = 19;
            // 
            // txtDDD
            // 
            this.txtDDD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDDD.Location = new System.Drawing.Point(76, 221);
            this.txtDDD.Name = "txtDDD";
            this.txtDDD.Size = new System.Drawing.Size(30, 20);
            this.txtDDD.TabIndex = 18;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(112, 224);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(42, 13);
            this.lblCelular.TabIndex = 42;
            this.lblCelular.Text = "Celular:";
            // 
            // lblDDDTel
            // 
            this.lblDDDTel.AutoSize = true;
            this.lblDDDTel.Location = new System.Drawing.Point(343, 224);
            this.lblDDDTel.Name = "lblDDDTel";
            this.lblDDDTel.Size = new System.Drawing.Size(34, 13);
            this.lblDDDTel.TabIndex = 41;
            this.lblDDDTel.Text = "DDD:";
            // 
            // txtTel
            // 
            this.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTel.Location = new System.Drawing.Point(477, 221);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(164, 20);
            this.txtTel.TabIndex = 21;
            // 
            // txtDDDTel
            // 
            this.txtDDDTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDDDTel.Location = new System.Drawing.Point(383, 221);
            this.txtDDDTel.Name = "txtDDDTel";
            this.txtDDDTel.Size = new System.Drawing.Size(30, 20);
            this.txtDDDTel.TabIndex = 20;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(419, 224);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(52, 13);
            this.lblTel.TabIndex = 38;
            this.lblTel.Text = "Telefone:";
            // 
            // txtEstado
            // 
            this.txtEstado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEstado.Location = new System.Drawing.Point(715, 194);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(360, 20);
            this.txtEstado.TabIndex = 17;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(666, 197);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 33;
            this.lblEstado.Text = "Estado:";
            // 
            // txtCidade
            // 
            this.txtCidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCidade.Location = new System.Drawing.Point(282, 194);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(271, 20);
            this.txtCidade.TabIndex = 16;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(233, 197);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 31;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtCep
            // 
            this.txtCep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCep.Location = new System.Drawing.Point(76, 194);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(141, 20);
            this.txtCep.TabIndex = 15;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(672, 169);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 29;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtEnd
            // 
            this.txtEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEnd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEnd.Location = new System.Drawing.Point(76, 166);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(477, 20);
            this.txtEnd.TabIndex = 13;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(33, 197);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(31, 13);
            this.lblCep.TabIndex = 27;
            this.lblCep.Text = "CEP:";
            // 
            // txtPai
            // 
            this.txtPai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPai.Location = new System.Drawing.Point(375, 127);
            this.txtPai.Name = "txtPai";
            this.txtPai.Size = new System.Drawing.Size(700, 20);
            this.txtPai.TabIndex = 12;
            // 
            // txtMae
            // 
            this.txtMae.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMae.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMae.Location = new System.Drawing.Point(375, 87);
            this.txtMae.Name = "txtMae";
            this.txtMae.Size = new System.Drawing.Size(700, 20);
            this.txtMae.TabIndex = 11;
            // 
            // txtBairro
            // 
            this.txtBairro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBairro.Location = new System.Drawing.Point(715, 166);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(360, 20);
            this.txtBairro.TabIndex = 14;
            // 
            // txtNaturalidade
            // 
            this.txtNaturalidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNaturalidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNaturalidade.Location = new System.Drawing.Point(752, 50);
            this.txtNaturalidade.Name = "txtNaturalidade";
            this.txtNaturalidade.Size = new System.Drawing.Size(323, 20);
            this.txtNaturalidade.TabIndex = 7;
            // 
            // lblNasc
            // 
            this.lblNasc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNasc.AutoSize = true;
            this.lblNasc.Location = new System.Drawing.Point(295, 53);
            this.lblNasc.Name = "lblNasc";
            this.lblNasc.Size = new System.Drawing.Size(107, 13);
            this.lblNasc.TabIndex = 20;
            this.lblNasc.Text = "Data de Nascimento:\r\n";
            // 
            // lblDataExp
            // 
            this.lblDataExp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDataExp.AutoSize = true;
            this.lblDataExp.Location = new System.Drawing.Point(7, 138);
            this.lblDataExp.Name = "lblDataExp";
            this.lblDataExp.Size = new System.Drawing.Size(57, 13);
            this.lblDataExp.TabIndex = 19;
            this.lblDataExp.Text = "Data Exp.:";
            // 
            // txtOrgExp
            // 
            this.txtOrgExp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOrgExp.Location = new System.Drawing.Point(76, 108);
            this.txtOrgExp.Name = "txtOrgExp";
            this.txtOrgExp.Size = new System.Drawing.Size(60, 20);
            this.txtOrgExp.TabIndex = 9;
            // 
            // txtRG
            // 
            this.txtRG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRG.Location = new System.Drawing.Point(76, 80);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(141, 20);
            this.txtRG.TabIndex = 8;
            // 
            // lblRG
            // 
            this.lblRG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(38, 83);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(26, 13);
            this.lblRG.TabIndex = 16;
            this.lblRG.Text = "RG:";
            // 
            // lblOrgExp
            // 
            this.lblOrgExp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrgExp.AutoSize = true;
            this.lblOrgExp.Location = new System.Drawing.Point(13, 111);
            this.lblOrgExp.Name = "lblOrgExp";
            this.lblOrgExp.Size = new System.Drawing.Size(51, 13);
            this.lblOrgExp.TabIndex = 15;
            this.lblOrgExp.Text = "Org. Exp:";
            // 
            // lblNaturalidade
            // 
            this.lblNaturalidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNaturalidade.AutoSize = true;
            this.lblNaturalidade.Location = new System.Drawing.Point(676, 53);
            this.lblNaturalidade.Name = "lblNaturalidade";
            this.lblNaturalidade.Size = new System.Drawing.Size(70, 13);
            this.lblNaturalidade.TabIndex = 14;
            this.lblNaturalidade.Text = "Naturalidade:";
            // 
            // lblFiliacao
            // 
            this.lblFiliacao.AutoSize = true;
            this.lblFiliacao.Location = new System.Drawing.Point(294, 110);
            this.lblFiliacao.Name = "lblFiliacao";
            this.lblFiliacao.Size = new System.Drawing.Size(46, 13);
            this.lblFiliacao.TabIndex = 13;
            this.lblFiliacao.Text = "Filiação:";
            // 
            // lblPai
            // 
            this.lblPai.AutoSize = true;
            this.lblPai.Location = new System.Drawing.Point(344, 130);
            this.lblPai.Name = "lblPai";
            this.lblPai.Size = new System.Drawing.Size(25, 13);
            this.lblPai.TabIndex = 12;
            this.lblPai.Text = "Pai:";
            // 
            // lblMae
            // 
            this.lblMae.AutoSize = true;
            this.lblMae.Location = new System.Drawing.Point(338, 90);
            this.lblMae.Name = "lblMae";
            this.lblMae.Size = new System.Drawing.Size(31, 13);
            this.lblMae.TabIndex = 11;
            this.lblMae.Text = "Mãe:";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(8, 169);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(56, 13);
            this.lblEnd.TabIndex = 10;
            this.lblEnd.Text = "Endereço:";
            // 
            // txtCPF
            // 
            this.txtCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCPF.Location = new System.Drawing.Point(76, 50);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(203, 20);
            this.txtCPF.TabIndex = 5;
            // 
            // lblCPF
            // 
            this.lblCPF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(34, 53);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 7;
            this.lblCPF.Text = "CPF:";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Location = new System.Drawing.Point(76, 22);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(999, 20);
            this.txtNome.TabIndex = 4;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(26, 25);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome:";
            // 
            // tabCadastroMonitor
            // 
            this.tabCadastroMonitor.Controls.Add(this.btnClearNewInstructor);
            this.tabCadastroMonitor.Controls.Add(this.btnInsertNewInstructor);
            this.tabCadastroMonitor.Controls.Add(this.gpbMonitoria);
            this.tabCadastroMonitor.Controls.Add(this.gpbLoginData);
            this.tabCadastroMonitor.Controls.Add(this.gpbInstructorGeneral);
            this.tabCadastroMonitor.Location = new System.Drawing.Point(4, 22);
            this.tabCadastroMonitor.Name = "tabCadastroMonitor";
            this.tabCadastroMonitor.Size = new System.Drawing.Size(1090, 354);
            this.tabCadastroMonitor.TabIndex = 4;
            this.tabCadastroMonitor.Text = "Cadastrar Monitor";
            this.tabCadastroMonitor.UseVisualStyleBackColor = true;
            // 
            // btnClearNewInstructor
            // 
            this.btnClearNewInstructor.Location = new System.Drawing.Point(951, 219);
            this.btnClearNewInstructor.Name = "btnClearNewInstructor";
            this.btnClearNewInstructor.Size = new System.Drawing.Size(118, 61);
            this.btnClearNewInstructor.TabIndex = 5;
            this.btnClearNewInstructor.Text = "Limpar";
            this.btnClearNewInstructor.UseVisualStyleBackColor = true;
            this.btnClearNewInstructor.Click += new System.EventHandler(this.btnClearNewInstructor_Click);
            // 
            // btnInsertNewInstructor
            // 
            this.btnInsertNewInstructor.Location = new System.Drawing.Point(647, 219);
            this.btnInsertNewInstructor.Name = "btnInsertNewInstructor";
            this.btnInsertNewInstructor.Size = new System.Drawing.Size(210, 61);
            this.btnInsertNewInstructor.TabIndex = 4;
            this.btnInsertNewInstructor.Text = "Cadastrar";
            this.btnInsertNewInstructor.UseVisualStyleBackColor = true;
            this.btnInsertNewInstructor.Click += new System.EventHandler(this.btnInsertNewInstructor_Click);
            // 
            // gpbMonitoria
            // 
            this.gpbMonitoria.Controls.Add(this.txtCargaInstructor);
            this.gpbMonitoria.Controls.Add(this.txtTipoInstructor);
            this.gpbMonitoria.Controls.Add(this.txtProntuarioInstructor);
            this.gpbMonitoria.Location = new System.Drawing.Point(577, 34);
            this.gpbMonitoria.Name = "gpbMonitoria";
            this.gpbMonitoria.Size = new System.Drawing.Size(492, 134);
            this.gpbMonitoria.TabIndex = 2;
            this.gpbMonitoria.TabStop = false;
            this.gpbMonitoria.Text = "Monitoria";
            // 
            // txtCargaInstructor
            // 
            this.txtCargaInstructor.Location = new System.Drawing.Point(47, 75);
            this.txtCargaInstructor.Name = "txtCargaInstructor";
            this.txtCargaInstructor.PasswordChar = '\0';
            this.txtCargaInstructor.Size = new System.Drawing.Size(104, 35);
            this.txtCargaInstructor.TabIndex = 3;
            this.txtCargaInstructor.Tag = "Carga Horária";
            // 
            // txtTipoInstructor
            // 
            this.txtTipoInstructor.Location = new System.Drawing.Point(258, 25);
            this.txtTipoInstructor.Name = "txtTipoInstructor";
            this.txtTipoInstructor.PasswordChar = '\0';
            this.txtTipoInstructor.Size = new System.Drawing.Size(196, 35);
            this.txtTipoInstructor.TabIndex = 2;
            this.txtTipoInstructor.Tag = "Tipo";
            // 
            // txtProntuarioInstructor
            // 
            this.txtProntuarioInstructor.Location = new System.Drawing.Point(47, 25);
            this.txtProntuarioInstructor.Name = "txtProntuarioInstructor";
            this.txtProntuarioInstructor.PasswordChar = '\0';
            this.txtProntuarioInstructor.Size = new System.Drawing.Size(149, 35);
            this.txtProntuarioInstructor.TabIndex = 1;
            this.txtProntuarioInstructor.Tag = "Prontuário";
            // 
            // gpbLoginData
            // 
            this.gpbLoginData.Controls.Add(this.chkShowPassword);
            this.gpbLoginData.Controls.Add(this.txtPasswordInstructor);
            this.gpbLoginData.Controls.Add(this.txtCpfInstructor);
            this.gpbLoginData.Location = new System.Drawing.Point(22, 185);
            this.gpbLoginData.Name = "gpbLoginData";
            this.gpbLoginData.Size = new System.Drawing.Size(502, 122);
            this.gpbLoginData.TabIndex = 3;
            this.gpbLoginData.TabStop = false;
            this.gpbLoginData.Text = "Credenciais";
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Location = new System.Drawing.Point(390, 48);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(60, 17);
            this.chkShowPassword.TabIndex = 8;
            this.chkShowPassword.Text = "mostrar";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // txtPasswordInstructor
            // 
            this.txtPasswordInstructor.Location = new System.Drawing.Point(233, 34);
            this.txtPasswordInstructor.Name = "txtPasswordInstructor";
            this.txtPasswordInstructor.PasswordChar = '*';
            this.txtPasswordInstructor.Size = new System.Drawing.Size(138, 35);
            this.txtPasswordInstructor.TabIndex = 2;
            this.txtPasswordInstructor.Tag = "Senha";
            // 
            // txtCpfInstructor
            // 
            this.txtCpfInstructor.Location = new System.Drawing.Point(61, 34);
            this.txtCpfInstructor.Mask = "###.###.###-##";
            this.txtCpfInstructor.Name = "txtCpfInstructor";
            this.txtCpfInstructor.Size = new System.Drawing.Size(82, 35);
            this.txtCpfInstructor.TabIndex = 1;
            this.txtCpfInstructor.Tag = "CPF";
            // 
            // gpbInstructorGeneral
            // 
            this.gpbInstructorGeneral.Controls.Add(this.txtEmailInstructor);
            this.gpbInstructorGeneral.Controls.Add(this.txtNameInstructor);
            this.gpbInstructorGeneral.Location = new System.Drawing.Point(22, 34);
            this.gpbInstructorGeneral.Name = "gpbInstructorGeneral";
            this.gpbInstructorGeneral.Size = new System.Drawing.Size(502, 134);
            this.gpbInstructorGeneral.TabIndex = 1;
            this.gpbInstructorGeneral.TabStop = false;
            this.gpbInstructorGeneral.Text = "Dados Gerais";
            // 
            // txtEmailInstructor
            // 
            this.txtEmailInstructor.Location = new System.Drawing.Point(61, 75);
            this.txtEmailInstructor.Name = "txtEmailInstructor";
            this.txtEmailInstructor.PasswordChar = '\0';
            this.txtEmailInstructor.Size = new System.Drawing.Size(389, 35);
            this.txtEmailInstructor.TabIndex = 2;
            this.txtEmailInstructor.Tag = "E-mail:";
            // 
            // txtNameInstructor
            // 
            this.txtNameInstructor.Location = new System.Drawing.Point(61, 25);
            this.txtNameInstructor.Name = "txtNameInstructor";
            this.txtNameInstructor.PasswordChar = '\0';
            this.txtNameInstructor.Size = new System.Drawing.Size(389, 35);
            this.txtNameInstructor.TabIndex = 1;
            this.txtNameInstructor.Tag = "Nome";
            // 
            // tabParticipante
            // 
            this.tabParticipante.Controls.Add(this.dtgParticipantes);
            this.tabParticipante.Controls.Add(this.radioListMonitor);
            this.tabParticipante.Controls.Add(this.radioListAluno);
            this.tabParticipante.Location = new System.Drawing.Point(4, 22);
            this.tabParticipante.Name = "tabParticipante";
            this.tabParticipante.Padding = new System.Windows.Forms.Padding(3);
            this.tabParticipante.Size = new System.Drawing.Size(1090, 354);
            this.tabParticipante.TabIndex = 1;
            this.tabParticipante.Text = "Listar Alunos";
            this.tabParticipante.UseVisualStyleBackColor = true;
            // 
            // dtgParticipantes
            // 
            this.dtgParticipantes.AllowUserToAddRows = false;
            this.dtgParticipantes.AllowUserToDeleteRows = false;
            this.dtgParticipantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgParticipantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgParticipantes.Location = new System.Drawing.Point(0, 62);
            this.dtgParticipantes.Name = "dtgParticipantes";
            this.dtgParticipantes.ReadOnly = true;
            this.dtgParticipantes.Size = new System.Drawing.Size(1087, 289);
            this.dtgParticipantes.TabIndex = 5;
            // 
            // radioListMonitor
            // 
            this.radioListMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioListMonitor.AutoSize = true;
            this.radioListMonitor.Location = new System.Drawing.Point(25, 23);
            this.radioListMonitor.Name = "radioListMonitor";
            this.radioListMonitor.Size = new System.Drawing.Size(60, 17);
            this.radioListMonitor.TabIndex = 4;
            this.radioListMonitor.TabStop = true;
            this.radioListMonitor.Text = "Monitor";
            this.radioListMonitor.UseVisualStyleBackColor = true;
            this.radioListMonitor.CheckedChanged += new System.EventHandler(this.radioListMonitor_CheckedChanged);
            // 
            // radioListAluno
            // 
            this.radioListAluno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioListAluno.AutoSize = true;
            this.radioListAluno.Location = new System.Drawing.Point(108, 23);
            this.radioListAluno.Name = "radioListAluno";
            this.radioListAluno.Size = new System.Drawing.Size(52, 17);
            this.radioListAluno.TabIndex = 3;
            this.radioListAluno.TabStop = true;
            this.radioListAluno.Text = "Aluno";
            this.radioListAluno.UseVisualStyleBackColor = true;
            this.radioListAluno.CheckedChanged += new System.EventHandler(this.radioListAluno_CheckedChanged);
            // 
            // tabVisuRel
            // 
            this.tabVisuRel.Controls.Add(this.lblSearchReports);
            this.tabVisuRel.Controls.Add(this.dtgReports);
            this.tabVisuRel.Controls.Add(this.txtSearchReports);
            this.tabVisuRel.Location = new System.Drawing.Point(4, 22);
            this.tabVisuRel.Name = "tabVisuRel";
            this.tabVisuRel.Size = new System.Drawing.Size(1090, 354);
            this.tabVisuRel.TabIndex = 2;
            this.tabVisuRel.Text = "Listar Relatórios";
            this.tabVisuRel.UseVisualStyleBackColor = true;
            // 
            // lblSearchReports
            // 
            this.lblSearchReports.AutoSize = true;
            this.lblSearchReports.Location = new System.Drawing.Point(829, 15);
            this.lblSearchReports.Name = "lblSearchReports";
            this.lblSearchReports.Size = new System.Drawing.Size(47, 13);
            this.lblSearchReports.TabIndex = 8;
            this.lblSearchReports.Text = "Procurar";
            // 
            // dtgReports
            // 
            this.dtgReports.AllowUserToAddRows = false;
            this.dtgReports.AllowUserToDeleteRows = false;
            this.dtgReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgReports.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgReports.Location = new System.Drawing.Point(3, 39);
            this.dtgReports.Name = "dtgReports";
            this.dtgReports.ReadOnly = true;
            this.dtgReports.Size = new System.Drawing.Size(1084, 312);
            this.dtgReports.TabIndex = 6;
            // 
            // txtSearchReports
            // 
            this.txtSearchReports.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSearchReports.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchReports.Location = new System.Drawing.Point(882, 13);
            this.txtSearchReports.Name = "txtSearchReports";
            this.txtSearchReports.Size = new System.Drawing.Size(205, 20);
            this.txtSearchReports.TabIndex = 7;
            // 
            // tabGerarRel
            // 
            this.tabGerarRel.Controls.Add(this.btnRefreshReport);
            this.tabGerarRel.Controls.Add(this.btnRelAdd);
            this.tabGerarRel.Controls.Add(this.dtpRelCreated);
            this.tabGerarRel.Controls.Add(this.cmbNomeMonitor);
            this.tabGerarRel.Controls.Add(this.cmbNomeAluno);
            this.tabGerarRel.Controls.Add(this.gpBoxInteressante);
            this.tabGerarRel.Controls.Add(this.gpBoxAtividade);
            this.tabGerarRel.Controls.Add(this.gpBoxRecLetras);
            this.tabGerarRel.Controls.Add(this.gpBoxLeitura);
            this.tabGerarRel.Controls.Add(this.gpBoxDigitacao);
            this.tabGerarRel.Controls.Add(this.lblTitulo);
            this.tabGerarRel.Controls.Add(this.lblData);
            this.tabGerarRel.Controls.Add(this.lblNomeAluno);
            this.tabGerarRel.Controls.Add(this.lblPront);
            this.tabGerarRel.Controls.Add(this.lblNomeMonitor);
            this.tabGerarRel.Controls.Add(this.txtTitulo);
            this.tabGerarRel.Controls.Add(this.txtProntRelatorio);
            this.tabGerarRel.Location = new System.Drawing.Point(4, 22);
            this.tabGerarRel.Name = "tabGerarRel";
            this.tabGerarRel.Size = new System.Drawing.Size(1090, 354);
            this.tabGerarRel.TabIndex = 3;
            this.tabGerarRel.Text = "Criar Novo Relatório";
            this.tabGerarRel.UseVisualStyleBackColor = true;
            // 
            // btnRefreshReport
            // 
            this.btnRefreshReport.Location = new System.Drawing.Point(1071, 124);
            this.btnRefreshReport.Name = "btnRefreshReport";
            this.btnRefreshReport.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshReport.TabIndex = 62;
            this.btnRefreshReport.Text = "Limpar";
            this.btnRefreshReport.UseVisualStyleBackColor = true;
            this.btnRefreshReport.Click += new System.EventHandler(this.btnRefreshReport_Click);
            // 
            // btnRelAdd
            // 
            this.btnRelAdd.Location = new System.Drawing.Point(1051, 284);
            this.btnRelAdd.Name = "btnRelAdd";
            this.btnRelAdd.Size = new System.Drawing.Size(95, 62);
            this.btnRelAdd.TabIndex = 61;
            this.btnRelAdd.Text = "Salvar";
            this.btnRelAdd.UseVisualStyleBackColor = true;
            this.btnRelAdd.Click += new System.EventHandler(this.btnRelAdd_Click);
            // 
            // dtpRelCreated
            // 
            this.dtpRelCreated.CustomFormat = "\"dd-MM-yyyy\"";
            this.dtpRelCreated.Location = new System.Drawing.Point(349, 81);
            this.dtpRelCreated.Name = "dtpRelCreated";
            this.dtpRelCreated.Size = new System.Drawing.Size(243, 20);
            this.dtpRelCreated.TabIndex = 60;
            // 
            // cmbNomeMonitor
            // 
            this.cmbNomeMonitor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNomeMonitor.FormattingEnabled = true;
            this.cmbNomeMonitor.Location = new System.Drawing.Point(112, 48);
            this.cmbNomeMonitor.Name = "cmbNomeMonitor";
            this.cmbNomeMonitor.Size = new System.Drawing.Size(1034, 21);
            this.cmbNomeMonitor.TabIndex = 59;
            this.cmbNomeMonitor.SelectedIndexChanged += new System.EventHandler(this.cmbNomeMonitor_SelectedIndexChanged);
            // 
            // cmbNomeAluno
            // 
            this.cmbNomeAluno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNomeAluno.FormattingEnabled = true;
            this.cmbNomeAluno.Items.AddRange(new object[] {
            "Selecionar"});
            this.cmbNomeAluno.Location = new System.Drawing.Point(112, 14);
            this.cmbNomeAluno.Name = "cmbNomeAluno";
            this.cmbNomeAluno.Size = new System.Drawing.Size(1034, 21);
            this.cmbNomeAluno.TabIndex = 49;
            // 
            // gpBoxInteressante
            // 
            this.gpBoxInteressante.Controls.Add(this.lblInteressante);
            this.gpBoxInteressante.Controls.Add(this.radioInteressante0);
            this.gpBoxInteressante.Controls.Add(this.radioInteressante5);
            this.gpBoxInteressante.Controls.Add(this.radioInteressante3);
            this.gpBoxInteressante.Controls.Add(this.radioInteressante4);
            this.gpBoxInteressante.Controls.Add(this.radioInteressante2);
            this.gpBoxInteressante.Controls.Add(this.radioInteressante1);
            this.gpBoxInteressante.Controls.Add(this.lblObsInteressante);
            this.gpBoxInteressante.Controls.Add(this.txtObsInteressante);
            this.gpBoxInteressante.Location = new System.Drawing.Point(427, 234);
            this.gpBoxInteressante.Name = "gpBoxInteressante";
            this.gpBoxInteressante.Size = new System.Drawing.Size(606, 112);
            this.gpBoxInteressante.TabIndex = 58;
            this.gpBoxInteressante.TabStop = false;
            // 
            // lblInteressante
            // 
            this.lblInteressante.AutoSize = true;
            this.lblInteressante.Location = new System.Drawing.Point(6, 16);
            this.lblInteressante.Name = "lblInteressante";
            this.lblInteressante.Size = new System.Drawing.Size(199, 13);
            this.lblInteressante.TabIndex = 41;
            this.lblInteressante.Text = "O Aluno achou a atividade interessante?";
            // 
            // radioInteressante0
            // 
            this.radioInteressante0.AutoSize = true;
            this.radioInteressante0.Location = new System.Drawing.Point(33, 50);
            this.radioInteressante0.Name = "radioInteressante0";
            this.radioInteressante0.Size = new System.Drawing.Size(31, 17);
            this.radioInteressante0.TabIndex = 40;
            this.radioInteressante0.TabStop = true;
            this.radioInteressante0.Tag = "int";
            this.radioInteressante0.Text = "0";
            this.radioInteressante0.UseVisualStyleBackColor = true;
            this.radioInteressante0.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioInteressante5
            // 
            this.radioInteressante5.AutoSize = true;
            this.radioInteressante5.Location = new System.Drawing.Point(339, 50);
            this.radioInteressante5.Margin = new System.Windows.Forms.Padding(10);
            this.radioInteressante5.Name = "radioInteressante5";
            this.radioInteressante5.Size = new System.Drawing.Size(31, 17);
            this.radioInteressante5.TabIndex = 42;
            this.radioInteressante5.TabStop = true;
            this.radioInteressante5.Tag = "int";
            this.radioInteressante5.Text = "5";
            this.radioInteressante5.UseVisualStyleBackColor = true;
            this.radioInteressante5.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioInteressante3
            // 
            this.radioInteressante3.AutoSize = true;
            this.radioInteressante3.Location = new System.Drawing.Point(210, 50);
            this.radioInteressante3.Name = "radioInteressante3";
            this.radioInteressante3.Size = new System.Drawing.Size(31, 17);
            this.radioInteressante3.TabIndex = 43;
            this.radioInteressante3.TabStop = true;
            this.radioInteressante3.Tag = "int";
            this.radioInteressante3.Text = "3";
            this.radioInteressante3.UseVisualStyleBackColor = true;
            this.radioInteressante3.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioInteressante4
            // 
            this.radioInteressante4.AutoSize = true;
            this.radioInteressante4.Location = new System.Drawing.Point(273, 50);
            this.radioInteressante4.Name = "radioInteressante4";
            this.radioInteressante4.Size = new System.Drawing.Size(31, 17);
            this.radioInteressante4.TabIndex = 44;
            this.radioInteressante4.TabStop = true;
            this.radioInteressante4.Tag = "int";
            this.radioInteressante4.Text = "4";
            this.radioInteressante4.UseVisualStyleBackColor = true;
            this.radioInteressante4.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioInteressante2
            // 
            this.radioInteressante2.AutoSize = true;
            this.radioInteressante2.Location = new System.Drawing.Point(147, 50);
            this.radioInteressante2.Name = "radioInteressante2";
            this.radioInteressante2.Size = new System.Drawing.Size(31, 17);
            this.radioInteressante2.TabIndex = 45;
            this.radioInteressante2.TabStop = true;
            this.radioInteressante2.Tag = "int";
            this.radioInteressante2.Text = "2";
            this.radioInteressante2.UseVisualStyleBackColor = true;
            this.radioInteressante2.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioInteressante1
            // 
            this.radioInteressante1.AutoSize = true;
            this.radioInteressante1.Location = new System.Drawing.Point(87, 50);
            this.radioInteressante1.Name = "radioInteressante1";
            this.radioInteressante1.Size = new System.Drawing.Size(31, 17);
            this.radioInteressante1.TabIndex = 46;
            this.radioInteressante1.TabStop = true;
            this.radioInteressante1.Tag = "int";
            this.radioInteressante1.Text = "1";
            this.radioInteressante1.UseVisualStyleBackColor = true;
            this.radioInteressante1.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // lblObsInteressante
            // 
            this.lblObsInteressante.AutoSize = true;
            this.lblObsInteressante.Location = new System.Drawing.Point(30, 83);
            this.lblObsInteressante.Name = "lblObsInteressante";
            this.lblObsInteressante.Size = new System.Drawing.Size(35, 13);
            this.lblObsInteressante.TabIndex = 47;
            this.lblObsInteressante.Text = "OBS: ";
            // 
            // txtObsInteressante
            // 
            this.txtObsInteressante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtObsInteressante.Location = new System.Drawing.Point(71, 80);
            this.txtObsInteressante.Name = "txtObsInteressante";
            this.txtObsInteressante.Size = new System.Drawing.Size(529, 20);
            this.txtObsInteressante.TabIndex = 48;
            // 
            // gpBoxAtividade
            // 
            this.gpBoxAtividade.Controls.Add(this.txtObs);
            this.gpBoxAtividade.Controls.Add(this.lblObs);
            this.gpBoxAtividade.Controls.Add(this.radioAtividade0);
            this.gpBoxAtividade.Controls.Add(this.lblAtividade);
            this.gpBoxAtividade.Controls.Add(this.radioAtividade5);
            this.gpBoxAtividade.Controls.Add(this.radioAtividade3);
            this.gpBoxAtividade.Controls.Add(this.radioAtividade4);
            this.gpBoxAtividade.Controls.Add(this.radioAtividade2);
            this.gpBoxAtividade.Controls.Add(this.radioAtividade1);
            this.gpBoxAtividade.Location = new System.Drawing.Point(427, 123);
            this.gpBoxAtividade.Name = "gpBoxAtividade";
            this.gpBoxAtividade.Size = new System.Drawing.Size(606, 112);
            this.gpBoxAtividade.TabIndex = 57;
            this.gpBoxAtividade.TabStop = false;
            // 
            // txtObs
            // 
            this.txtObs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtObs.Location = new System.Drawing.Point(71, 80);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(529, 20);
            this.txtObs.TabIndex = 39;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(30, 83);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(35, 13);
            this.lblObs.TabIndex = 11;
            this.lblObs.Text = "OBS: ";
            // 
            // radioAtividade0
            // 
            this.radioAtividade0.AutoSize = true;
            this.radioAtividade0.Location = new System.Drawing.Point(33, 50);
            this.radioAtividade0.Name = "radioAtividade0";
            this.radioAtividade0.Size = new System.Drawing.Size(31, 17);
            this.radioAtividade0.TabIndex = 32;
            this.radioAtividade0.TabStop = true;
            this.radioAtividade0.Tag = "atv";
            this.radioAtividade0.Text = "0";
            this.radioAtividade0.UseVisualStyleBackColor = true;
            this.radioAtividade0.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // lblAtividade
            // 
            this.lblAtividade.AutoSize = true;
            this.lblAtividade.Location = new System.Drawing.Point(6, 16);
            this.lblAtividade.Name = "lblAtividade";
            this.lblAtividade.Size = new System.Drawing.Size(207, 13);
            this.lblAtividade.TabIndex = 33;
            this.lblAtividade.Text = "O Aluno teve dificuldade com a atividade?";
            // 
            // radioAtividade5
            // 
            this.radioAtividade5.AutoSize = true;
            this.radioAtividade5.Location = new System.Drawing.Point(339, 50);
            this.radioAtividade5.Margin = new System.Windows.Forms.Padding(10);
            this.radioAtividade5.Name = "radioAtividade5";
            this.radioAtividade5.Size = new System.Drawing.Size(31, 17);
            this.radioAtividade5.TabIndex = 34;
            this.radioAtividade5.TabStop = true;
            this.radioAtividade5.Tag = "atv";
            this.radioAtividade5.Text = "5";
            this.radioAtividade5.UseVisualStyleBackColor = true;
            this.radioAtividade5.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioAtividade3
            // 
            this.radioAtividade3.AutoSize = true;
            this.radioAtividade3.Location = new System.Drawing.Point(210, 50);
            this.radioAtividade3.Name = "radioAtividade3";
            this.radioAtividade3.Size = new System.Drawing.Size(31, 17);
            this.radioAtividade3.TabIndex = 35;
            this.radioAtividade3.TabStop = true;
            this.radioAtividade3.Tag = "atv";
            this.radioAtividade3.Text = "3";
            this.radioAtividade3.UseVisualStyleBackColor = true;
            this.radioAtividade3.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioAtividade4
            // 
            this.radioAtividade4.AutoSize = true;
            this.radioAtividade4.Location = new System.Drawing.Point(273, 50);
            this.radioAtividade4.Name = "radioAtividade4";
            this.radioAtividade4.Size = new System.Drawing.Size(31, 17);
            this.radioAtividade4.TabIndex = 36;
            this.radioAtividade4.TabStop = true;
            this.radioAtividade4.Tag = "atv";
            this.radioAtividade4.Text = "4";
            this.radioAtividade4.UseVisualStyleBackColor = true;
            this.radioAtividade4.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioAtividade2
            // 
            this.radioAtividade2.AutoSize = true;
            this.radioAtividade2.Location = new System.Drawing.Point(147, 50);
            this.radioAtividade2.Name = "radioAtividade2";
            this.radioAtividade2.Size = new System.Drawing.Size(31, 17);
            this.radioAtividade2.TabIndex = 37;
            this.radioAtividade2.TabStop = true;
            this.radioAtividade2.Tag = "atv";
            this.radioAtividade2.Text = "2";
            this.radioAtividade2.UseVisualStyleBackColor = true;
            this.radioAtividade2.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioAtividade1
            // 
            this.radioAtividade1.AutoSize = true;
            this.radioAtividade1.Location = new System.Drawing.Point(87, 50);
            this.radioAtividade1.Name = "radioAtividade1";
            this.radioAtividade1.Size = new System.Drawing.Size(31, 17);
            this.radioAtividade1.TabIndex = 38;
            this.radioAtividade1.TabStop = true;
            this.radioAtividade1.Tag = "atv";
            this.radioAtividade1.Text = "1";
            this.radioAtividade1.UseVisualStyleBackColor = true;
            this.radioAtividade1.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // gpBoxRecLetras
            // 
            this.gpBoxRecLetras.Controls.Add(this.lblReconhecer);
            this.gpBoxRecLetras.Controls.Add(this.radioReconhecer0);
            this.gpBoxRecLetras.Controls.Add(this.radioReconhecer5);
            this.gpBoxRecLetras.Controls.Add(this.radioReconhecer3);
            this.gpBoxRecLetras.Controls.Add(this.radioReconhecer4);
            this.gpBoxRecLetras.Controls.Add(this.radioReconhecer2);
            this.gpBoxRecLetras.Controls.Add(this.radioReconhecer1);
            this.gpBoxRecLetras.Location = new System.Drawing.Point(23, 272);
            this.gpBoxRecLetras.Name = "gpBoxRecLetras";
            this.gpBoxRecLetras.Size = new System.Drawing.Size(384, 74);
            this.gpBoxRecLetras.TabIndex = 56;
            this.gpBoxRecLetras.TabStop = false;
            // 
            // lblReconhecer
            // 
            this.lblReconhecer.AutoSize = true;
            this.lblReconhecer.Location = new System.Drawing.Point(12, 16);
            this.lblReconhecer.Name = "lblReconhecer";
            this.lblReconhecer.Size = new System.Drawing.Size(245, 13);
            this.lblReconhecer.TabIndex = 26;
            this.lblReconhecer.Text = "O Aluno teve dificuldade em reconhecer as letras?";
            // 
            // radioReconhecer0
            // 
            this.radioReconhecer0.AutoSize = true;
            this.radioReconhecer0.Location = new System.Drawing.Point(42, 49);
            this.radioReconhecer0.Name = "radioReconhecer0";
            this.radioReconhecer0.Size = new System.Drawing.Size(31, 17);
            this.radioReconhecer0.TabIndex = 25;
            this.radioReconhecer0.TabStop = true;
            this.radioReconhecer0.Tag = "rec";
            this.radioReconhecer0.Text = "0";
            this.radioReconhecer0.UseVisualStyleBackColor = true;
            this.radioReconhecer0.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioReconhecer5
            // 
            this.radioReconhecer5.AutoSize = true;
            this.radioReconhecer5.Location = new System.Drawing.Point(348, 49);
            this.radioReconhecer5.Margin = new System.Windows.Forms.Padding(10);
            this.radioReconhecer5.Name = "radioReconhecer5";
            this.radioReconhecer5.Size = new System.Drawing.Size(31, 17);
            this.radioReconhecer5.TabIndex = 27;
            this.radioReconhecer5.TabStop = true;
            this.radioReconhecer5.Tag = "rec";
            this.radioReconhecer5.Text = "5";
            this.radioReconhecer5.UseVisualStyleBackColor = true;
            this.radioReconhecer5.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioReconhecer3
            // 
            this.radioReconhecer3.AutoSize = true;
            this.radioReconhecer3.Location = new System.Drawing.Point(219, 49);
            this.radioReconhecer3.Name = "radioReconhecer3";
            this.radioReconhecer3.Size = new System.Drawing.Size(31, 17);
            this.radioReconhecer3.TabIndex = 28;
            this.radioReconhecer3.TabStop = true;
            this.radioReconhecer3.Tag = "rec";
            this.radioReconhecer3.Text = "3";
            this.radioReconhecer3.UseVisualStyleBackColor = true;
            this.radioReconhecer3.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioReconhecer4
            // 
            this.radioReconhecer4.AutoSize = true;
            this.radioReconhecer4.Location = new System.Drawing.Point(282, 49);
            this.radioReconhecer4.Name = "radioReconhecer4";
            this.radioReconhecer4.Size = new System.Drawing.Size(31, 17);
            this.radioReconhecer4.TabIndex = 29;
            this.radioReconhecer4.TabStop = true;
            this.radioReconhecer4.Tag = "rec";
            this.radioReconhecer4.Text = "4";
            this.radioReconhecer4.UseVisualStyleBackColor = true;
            this.radioReconhecer4.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioReconhecer2
            // 
            this.radioReconhecer2.AutoSize = true;
            this.radioReconhecer2.Location = new System.Drawing.Point(156, 49);
            this.radioReconhecer2.Name = "radioReconhecer2";
            this.radioReconhecer2.Size = new System.Drawing.Size(31, 17);
            this.radioReconhecer2.TabIndex = 30;
            this.radioReconhecer2.TabStop = true;
            this.radioReconhecer2.Tag = "rec";
            this.radioReconhecer2.Text = "2";
            this.radioReconhecer2.UseVisualStyleBackColor = true;
            this.radioReconhecer2.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioReconhecer1
            // 
            this.radioReconhecer1.AutoSize = true;
            this.radioReconhecer1.Location = new System.Drawing.Point(96, 49);
            this.radioReconhecer1.Name = "radioReconhecer1";
            this.radioReconhecer1.Size = new System.Drawing.Size(31, 17);
            this.radioReconhecer1.TabIndex = 31;
            this.radioReconhecer1.TabStop = true;
            this.radioReconhecer1.Tag = "rec";
            this.radioReconhecer1.Text = "1";
            this.radioReconhecer1.UseVisualStyleBackColor = true;
            this.radioReconhecer1.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // gpBoxLeitura
            // 
            this.gpBoxLeitura.Controls.Add(this.lblLeitura);
            this.gpBoxLeitura.Controls.Add(this.radioLeitura0);
            this.gpBoxLeitura.Controls.Add(this.radioLeitura5);
            this.gpBoxLeitura.Controls.Add(this.radioLeitura3);
            this.gpBoxLeitura.Controls.Add(this.radioLeitura4);
            this.gpBoxLeitura.Controls.Add(this.radioLeitura2);
            this.gpBoxLeitura.Controls.Add(this.radioLeitura1);
            this.gpBoxLeitura.Location = new System.Drawing.Point(23, 199);
            this.gpBoxLeitura.Name = "gpBoxLeitura";
            this.gpBoxLeitura.Size = new System.Drawing.Size(384, 74);
            this.gpBoxLeitura.TabIndex = 55;
            this.gpBoxLeitura.TabStop = false;
            // 
            // lblLeitura
            // 
            this.lblLeitura.AutoSize = true;
            this.lblLeitura.Location = new System.Drawing.Point(12, 16);
            this.lblLeitura.Name = "lblLeitura";
            this.lblLeitura.Size = new System.Drawing.Size(192, 13);
            this.lblLeitura.TabIndex = 19;
            this.lblLeitura.Text = "O Aluno teve dificuldade com a leitura?";
            // 
            // radioLeitura0
            // 
            this.radioLeitura0.AutoSize = true;
            this.radioLeitura0.Location = new System.Drawing.Point(42, 49);
            this.radioLeitura0.Name = "radioLeitura0";
            this.radioLeitura0.Size = new System.Drawing.Size(31, 17);
            this.radioLeitura0.TabIndex = 18;
            this.radioLeitura0.TabStop = true;
            this.radioLeitura0.Tag = "lei";
            this.radioLeitura0.Text = "0";
            this.radioLeitura0.UseVisualStyleBackColor = true;
            this.radioLeitura0.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioLeitura5
            // 
            this.radioLeitura5.AutoSize = true;
            this.radioLeitura5.Location = new System.Drawing.Point(348, 49);
            this.radioLeitura5.Margin = new System.Windows.Forms.Padding(10);
            this.radioLeitura5.Name = "radioLeitura5";
            this.radioLeitura5.Size = new System.Drawing.Size(31, 17);
            this.radioLeitura5.TabIndex = 20;
            this.radioLeitura5.TabStop = true;
            this.radioLeitura5.Tag = "lei";
            this.radioLeitura5.Text = "5";
            this.radioLeitura5.UseVisualStyleBackColor = true;
            this.radioLeitura5.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioLeitura3
            // 
            this.radioLeitura3.AutoSize = true;
            this.radioLeitura3.Location = new System.Drawing.Point(219, 49);
            this.radioLeitura3.Name = "radioLeitura3";
            this.radioLeitura3.Size = new System.Drawing.Size(31, 17);
            this.radioLeitura3.TabIndex = 21;
            this.radioLeitura3.TabStop = true;
            this.radioLeitura3.Tag = "lei";
            this.radioLeitura3.Text = "3";
            this.radioLeitura3.UseVisualStyleBackColor = true;
            this.radioLeitura3.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioLeitura4
            // 
            this.radioLeitura4.AutoSize = true;
            this.radioLeitura4.Location = new System.Drawing.Point(282, 49);
            this.radioLeitura4.Name = "radioLeitura4";
            this.radioLeitura4.Size = new System.Drawing.Size(31, 17);
            this.radioLeitura4.TabIndex = 22;
            this.radioLeitura4.TabStop = true;
            this.radioLeitura4.Tag = "lei";
            this.radioLeitura4.Text = "4";
            this.radioLeitura4.UseVisualStyleBackColor = true;
            this.radioLeitura4.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioLeitura2
            // 
            this.radioLeitura2.AutoSize = true;
            this.radioLeitura2.Location = new System.Drawing.Point(156, 49);
            this.radioLeitura2.Name = "radioLeitura2";
            this.radioLeitura2.Size = new System.Drawing.Size(31, 17);
            this.radioLeitura2.TabIndex = 23;
            this.radioLeitura2.TabStop = true;
            this.radioLeitura2.Tag = "lei";
            this.radioLeitura2.Text = "2";
            this.radioLeitura2.UseVisualStyleBackColor = true;
            this.radioLeitura2.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioLeitura1
            // 
            this.radioLeitura1.AutoSize = true;
            this.radioLeitura1.Location = new System.Drawing.Point(96, 49);
            this.radioLeitura1.Name = "radioLeitura1";
            this.radioLeitura1.Size = new System.Drawing.Size(31, 17);
            this.radioLeitura1.TabIndex = 24;
            this.radioLeitura1.TabStop = true;
            this.radioLeitura1.Tag = "lei";
            this.radioLeitura1.Text = "1";
            this.radioLeitura1.UseVisualStyleBackColor = true;
            this.radioLeitura1.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // gpBoxDigitacao
            // 
            this.gpBoxDigitacao.Controls.Add(this.lblDigitacao);
            this.gpBoxDigitacao.Controls.Add(this.radioDig0);
            this.gpBoxDigitacao.Controls.Add(this.radioDig5);
            this.gpBoxDigitacao.Controls.Add(this.radioDig3);
            this.gpBoxDigitacao.Controls.Add(this.radioDig4);
            this.gpBoxDigitacao.Controls.Add(this.radioDig2);
            this.gpBoxDigitacao.Controls.Add(this.radioDig1);
            this.gpBoxDigitacao.Location = new System.Drawing.Point(23, 124);
            this.gpBoxDigitacao.Name = "gpBoxDigitacao";
            this.gpBoxDigitacao.Size = new System.Drawing.Size(384, 76);
            this.gpBoxDigitacao.TabIndex = 54;
            this.gpBoxDigitacao.TabStop = false;
            // 
            // lblDigitacao
            // 
            this.lblDigitacao.AutoSize = true;
            this.lblDigitacao.Location = new System.Drawing.Point(12, 16);
            this.lblDigitacao.Name = "lblDigitacao";
            this.lblDigitacao.Size = new System.Drawing.Size(207, 13);
            this.lblDigitacao.TabIndex = 12;
            this.lblDigitacao.Text = "O Aluno teve dificuldade com a digitação?";
            // 
            // radioDig0
            // 
            this.radioDig0.AutoSize = true;
            this.radioDig0.Location = new System.Drawing.Point(42, 49);
            this.radioDig0.Name = "radioDig0";
            this.radioDig0.Size = new System.Drawing.Size(31, 17);
            this.radioDig0.TabIndex = 9;
            this.radioDig0.TabStop = true;
            this.radioDig0.Tag = "dig";
            this.radioDig0.Text = "0";
            this.radioDig0.UseVisualStyleBackColor = true;
            this.radioDig0.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioDig5
            // 
            this.radioDig5.AutoSize = true;
            this.radioDig5.Location = new System.Drawing.Point(348, 49);
            this.radioDig5.Margin = new System.Windows.Forms.Padding(10);
            this.radioDig5.Name = "radioDig5";
            this.radioDig5.Size = new System.Drawing.Size(31, 17);
            this.radioDig5.TabIndex = 13;
            this.radioDig5.TabStop = true;
            this.radioDig5.Tag = "dig";
            this.radioDig5.Text = "5";
            this.radioDig5.UseVisualStyleBackColor = true;
            this.radioDig5.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioDig3
            // 
            this.radioDig3.AutoSize = true;
            this.radioDig3.Location = new System.Drawing.Point(219, 49);
            this.radioDig3.Name = "radioDig3";
            this.radioDig3.Size = new System.Drawing.Size(31, 17);
            this.radioDig3.TabIndex = 14;
            this.radioDig3.TabStop = true;
            this.radioDig3.Tag = "dig";
            this.radioDig3.Text = "3";
            this.radioDig3.UseVisualStyleBackColor = true;
            this.radioDig3.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioDig4
            // 
            this.radioDig4.AutoSize = true;
            this.radioDig4.Location = new System.Drawing.Point(282, 49);
            this.radioDig4.Name = "radioDig4";
            this.radioDig4.Size = new System.Drawing.Size(31, 17);
            this.radioDig4.TabIndex = 15;
            this.radioDig4.TabStop = true;
            this.radioDig4.Tag = "dig";
            this.radioDig4.Text = "4";
            this.radioDig4.UseVisualStyleBackColor = true;
            this.radioDig4.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioDig2
            // 
            this.radioDig2.AutoSize = true;
            this.radioDig2.Location = new System.Drawing.Point(156, 49);
            this.radioDig2.Name = "radioDig2";
            this.radioDig2.Size = new System.Drawing.Size(31, 17);
            this.radioDig2.TabIndex = 16;
            this.radioDig2.TabStop = true;
            this.radioDig2.Tag = "dig";
            this.radioDig2.Text = "2";
            this.radioDig2.UseVisualStyleBackColor = true;
            this.radioDig2.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioDig1
            // 
            this.radioDig1.AutoSize = true;
            this.radioDig1.Location = new System.Drawing.Point(96, 49);
            this.radioDig1.Name = "radioDig1";
            this.radioDig1.Size = new System.Drawing.Size(31, 17);
            this.radioDig1.TabIndex = 17;
            this.radioDig1.TabStop = true;
            this.radioDig1.Tag = "dig";
            this.radioDig1.Text = "1";
            this.radioDig1.UseVisualStyleBackColor = true;
            this.radioDig1.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(615, 84);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(100, 13);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Título da Atividade:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(307, 84);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(36, 13);
            this.lblData.TabIndex = 7;
            this.lblData.Text = "Data: ";
            // 
            // lblNomeAluno
            // 
            this.lblNomeAluno.AutoSize = true;
            this.lblNomeAluno.Location = new System.Drawing.Point(24, 17);
            this.lblNomeAluno.Name = "lblNomeAluno";
            this.lblNomeAluno.Size = new System.Drawing.Size(83, 13);
            this.lblNomeAluno.TabIndex = 2;
            this.lblNomeAluno.Text = "Nome do Aluno:";
            // 
            // lblPront
            // 
            this.lblPront.AutoSize = true;
            this.lblPront.Location = new System.Drawing.Point(48, 84);
            this.lblPront.Name = "lblPront";
            this.lblPront.Size = new System.Drawing.Size(58, 13);
            this.lblPront.TabIndex = 1;
            this.lblPront.Text = "Prontuário:";
            // 
            // lblNomeMonitor
            // 
            this.lblNomeMonitor.AutoSize = true;
            this.lblNomeMonitor.Location = new System.Drawing.Point(16, 51);
            this.lblNomeMonitor.Name = "lblNomeMonitor";
            this.lblNomeMonitor.Size = new System.Drawing.Size(91, 13);
            this.lblNomeMonitor.TabIndex = 0;
            this.lblNomeMonitor.Text = "Nome do Monitor:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitulo.Location = new System.Drawing.Point(721, 81);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(425, 20);
            this.txtTitulo.TabIndex = 53;
            // 
            // txtProntRelatorio
            // 
            this.txtProntRelatorio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProntRelatorio.Location = new System.Drawing.Point(112, 81);
            this.txtProntRelatorio.Name = "txtProntRelatorio";
            this.txtProntRelatorio.ReadOnly = true;
            this.txtProntRelatorio.Size = new System.Drawing.Size(178, 20);
            this.txtProntRelatorio.TabIndex = 51;
            // 
            // logo_if
            // 
            this.logo_if.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo_if.BackgroundImage")));
            this.logo_if.Location = new System.Drawing.Point(12, 8);
            this.logo_if.Name = "logo_if";
            this.logo_if.Size = new System.Drawing.Size(48, 61);
            this.logo_if.TabIndex = 5;
            this.logo_if.TabStop = false;
            // 
            // pnlGreenDatail
            // 
            this.pnlGreenDatail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGreenDatail.AutoSize = true;
            this.pnlGreenDatail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(153)))), ((int)(((byte)(54)))));
            this.pnlGreenDatail.Location = new System.Drawing.Point(12, 75);
            this.pnlGreenDatail.Name = "pnlGreenDatail";
            this.pnlGreenDatail.Size = new System.Drawing.Size(1249, 10);
            this.pnlGreenDatail.TabIndex = 6;
            // 
            // lblWUser
            // 
            this.lblWUser.AutoSize = true;
            this.lblWUser.Location = new System.Drawing.Point(1100, 60);
            this.lblWUser.Name = "lblWUser";
            this.lblWUser.Size = new System.Drawing.Size(0, 13);
            this.lblWUser.TabIndex = 34;
            // 
            // pnlMenu
            // 
            this.pnlMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMenu.Controls.Add(this.mnPrincipal);
            this.pnlMenu.Location = new System.Drawing.Point(0, 93);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(135, 320);
            this.pnlMenu.TabIndex = 35;
            // 
            // mnPrincipal
            // 
            this.mnPrincipal.AutoSize = false;
            this.mnPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.mnPrincipal.GripMargin = new System.Windows.Forms.Padding(0);
            this.mnPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnItemNewStudents,
            this.mnItemNewInstructor,
            this.cadastroAtividadeToolStripMenuItem,
            this.mnItemShowStudents,
            this.mnItemNewReports,
            this.mnItemShowReports});
            this.mnPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnPrincipal.Name = "mnPrincipal";
            this.mnPrincipal.Padding = new System.Windows.Forms.Padding(0);
            this.mnPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mnPrincipal.Size = new System.Drawing.Size(135, 320);
            this.mnPrincipal.TabIndex = 0;
            // 
            // mnItemNewStudents
            // 
            this.mnItemNewStudents.Name = "mnItemNewStudents";
            this.mnItemNewStudents.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.mnItemNewStudents.Size = new System.Drawing.Size(134, 49);
            this.mnItemNewStudents.Text = "Cadastro Aluno";
            this.mnItemNewStudents.Click += new System.EventHandler(this.mnItemNewStudents_Click);
            // 
            // mnItemNewInstructor
            // 
            this.mnItemNewInstructor.Name = "mnItemNewInstructor";
            this.mnItemNewInstructor.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.mnItemNewInstructor.Size = new System.Drawing.Size(134, 49);
            this.mnItemNewInstructor.Text = "Cadastro Monitor";
            this.mnItemNewInstructor.Click += new System.EventHandler(this.mnItemNewInstructor_Click);
            // 
            // cadastroAtividadeToolStripMenuItem
            // 
            this.cadastroAtividadeToolStripMenuItem.Name = "cadastroAtividadeToolStripMenuItem";
            this.cadastroAtividadeToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.cadastroAtividadeToolStripMenuItem.Size = new System.Drawing.Size(134, 49);
            this.cadastroAtividadeToolStripMenuItem.Text = "Cadastro Atividade";
            // 
            // mnItemShowStudents
            // 
            this.mnItemShowStudents.Name = "mnItemShowStudents";
            this.mnItemShowStudents.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.mnItemShowStudents.Size = new System.Drawing.Size(134, 49);
            this.mnItemShowStudents.Text = "Visualizar Participantes";
            this.mnItemShowStudents.Click += new System.EventHandler(this.mnItemShowStudents_Click);
            // 
            // mnItemNewReports
            // 
            this.mnItemNewReports.Name = "mnItemNewReports";
            this.mnItemNewReports.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.mnItemNewReports.Size = new System.Drawing.Size(134, 49);
            this.mnItemNewReports.Text = "Gerar Relatórios";
            this.mnItemNewReports.Click += new System.EventHandler(this.mnItemNewReports_Click);
            // 
            // mnItemShowReports
            // 
            this.mnItemShowReports.Name = "mnItemShowReports";
            this.mnItemShowReports.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.mnItemShowReports.Size = new System.Drawing.Size(134, 49);
            this.mnItemShowReports.Text = "Visualizar Relatórios";
            this.mnItemShowReports.Click += new System.EventHandler(this.mnItemShowReports_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1264, 487);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.lblWUser);
            this.Controls.Add(this.pnlGreenDatail);
            this.Controls.Add(this.logo_if);
            this.Controls.Add(this.tabControlGeral);
            this.Name = "MainMenu";
            this.Text = "APAE DataBase";
            this.tabControlGeral.ResumeLayout(false);
            this.tabCadastro.ResumeLayout(false);
            this.tabCadastro.PerformLayout();
            this.tabCadastroMonitor.ResumeLayout(false);
            this.gpbMonitoria.ResumeLayout(false);
            this.gpbLoginData.ResumeLayout(false);
            this.gpbLoginData.PerformLayout();
            this.gpbInstructorGeneral.ResumeLayout(false);
            this.tabParticipante.ResumeLayout(false);
            this.tabParticipante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgParticipantes)).EndInit();
            this.tabVisuRel.ResumeLayout(false);
            this.tabVisuRel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReports)).EndInit();
            this.tabGerarRel.ResumeLayout(false);
            this.tabGerarRel.PerformLayout();
            this.gpBoxInteressante.ResumeLayout(false);
            this.gpBoxInteressante.PerformLayout();
            this.gpBoxAtividade.ResumeLayout(false);
            this.gpBoxAtividade.PerformLayout();
            this.gpBoxRecLetras.ResumeLayout(false);
            this.gpBoxRecLetras.PerformLayout();
            this.gpBoxLeitura.ResumeLayout(false);
            this.gpBoxLeitura.PerformLayout();
            this.gpBoxDigitacao.ResumeLayout(false);
            this.gpBoxDigitacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_if)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.mnPrincipal.ResumeLayout(false);
            this.mnPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlGeral;
        private System.Windows.Forms.TabPage tabCadastro;
        private System.Windows.Forms.TabPage tabParticipante;
        private System.Windows.Forms.TabPage tabVisuRel;
        private CustomTextBox txtCPF;
        private System.Windows.Forms.Label lblCPF;
        private CustomTextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.PictureBox logo_if;
        private System.Windows.Forms.Panel pnlGreenDatail;
        private System.Windows.Forms.Label lblDataExp;
        private CustomTextBox txtOrgExp;
        private CustomTextBox txtRG;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblOrgExp;
        private System.Windows.Forms.Label lblNaturalidade;
        private System.Windows.Forms.Label lblFiliacao;
        private System.Windows.Forms.Label lblPai;
        private System.Windows.Forms.Label lblMae;
        private System.Windows.Forms.Label lblEnd;
        private CustomTextBox txtNaturalidade;
        private System.Windows.Forms.Label lblNasc;
        private CustomTextBox txtTel;
        private CustomTextBox txtDDDTel;
        private System.Windows.Forms.Label lblTel;
        private CustomTextBox txtEstado;
        private System.Windows.Forms.Label lblEstado;
        private CustomTextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private CustomTextBox txtCep;
        private System.Windows.Forms.Label lblBairro;
        private CustomTextBox txtEnd;
        private System.Windows.Forms.Label lblCep;
        private CustomTextBox txtPai;
        private CustomTextBox txtMae;
        private CustomTextBox txtBairro;
        private CustomTextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDDD;
        private CustomTextBox txtCelular;
        private CustomTextBox txtDDD;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblDDDTel;
        private System.Windows.Forms.RadioButton radioListMonitor;
        private System.Windows.Forms.RadioButton radioListAluno;
        private System.Windows.Forms.TabPage tabGerarRel;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblNomeAluno;
        private System.Windows.Forms.Label lblPront;
        private System.Windows.Forms.Label lblNomeMonitor;
        private CustomTextBox txtObsInteressante;
        private System.Windows.Forms.Label lblObsInteressante;
        private System.Windows.Forms.RadioButton radioInteressante1;
        private System.Windows.Forms.RadioButton radioInteressante2;
        private System.Windows.Forms.RadioButton radioInteressante4;
        private System.Windows.Forms.RadioButton radioInteressante3;
        private System.Windows.Forms.RadioButton radioInteressante5;
        private System.Windows.Forms.Label lblInteressante;
        private System.Windows.Forms.RadioButton radioInteressante0;
        private CustomTextBox txtObs;
        private System.Windows.Forms.RadioButton radioAtividade1;
        private System.Windows.Forms.RadioButton radioAtividade2;
        private System.Windows.Forms.RadioButton radioAtividade4;
        private System.Windows.Forms.RadioButton radioAtividade3;
        private System.Windows.Forms.RadioButton radioAtividade5;
        private System.Windows.Forms.Label lblAtividade;
        private System.Windows.Forms.RadioButton radioAtividade0;
        private System.Windows.Forms.RadioButton radioReconhecer1;
        private System.Windows.Forms.RadioButton radioReconhecer2;
        private System.Windows.Forms.RadioButton radioReconhecer4;
        private System.Windows.Forms.RadioButton radioReconhecer3;
        private System.Windows.Forms.RadioButton radioReconhecer5;
        private System.Windows.Forms.Label lblReconhecer;
        private System.Windows.Forms.RadioButton radioReconhecer0;
        private System.Windows.Forms.RadioButton radioLeitura1;
        private System.Windows.Forms.RadioButton radioLeitura2;
        private System.Windows.Forms.RadioButton radioLeitura4;
        private System.Windows.Forms.RadioButton radioLeitura3;
        private System.Windows.Forms.RadioButton radioLeitura5;
        private System.Windows.Forms.Label lblLeitura;
        private System.Windows.Forms.RadioButton radioLeitura0;
        private System.Windows.Forms.RadioButton radioDig1;
        private System.Windows.Forms.RadioButton radioDig2;
        private System.Windows.Forms.RadioButton radioDig4;
        private System.Windows.Forms.RadioButton radioDig3;
        private System.Windows.Forms.RadioButton radioDig5;
        private System.Windows.Forms.Label lblDigitacao;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.RadioButton radioDig0;
        private CustomTextBox txtTitulo;
        private CustomTextBox txtProntRelatorio;
        private System.Windows.Forms.GroupBox gpBoxDigitacao;
        private System.Windows.Forms.GroupBox gpBoxRecLetras;
        private System.Windows.Forms.GroupBox gpBoxLeitura;
        private GroupBox gpBoxAtividade;
        private GroupBox gpBoxInteressante;
        private Button btnAdd;
        private DateTimePicker dtpNasc;
        private DateTimePicker dtpExp;
        private Button btnReset;
        private DataGridView dtgParticipantes;
        private ComboBox cmbNomeAluno;
        private ComboBox cmbNomeMonitor;
        private DateTimePicker dtpRelCreated;
        private Button btnRelAdd;
        private Button btnRefreshReport;
        private DataGridView dtgReports;
        private Label lblWUser;
        private Panel pnlMenu;
        private ToolStripMenuItem mnItemShowStudents;
        private MenuStrip mnPrincipal;
        private ToolStripMenuItem mnItemNewReports;
        private ToolStripMenuItem mnItemShowReports;
        private ToolStripMenuItem mnItemNewStudents;
        private ToolStripMenuItem mnItemNewInstructor;
        private ToolStripMenuItem cadastroAtividadeToolStripMenuItem;
        private Label lblSearchReports;
        private CustomTextBox txtSearchReports;
        private TabPage tabCadastroMonitor;
        private GroupBox gpbLoginData;
        private CheckBox chkShowPassword;
        private CustomTextBoxWithLabel txtPasswordInstructor;
        private CustomMaskedTextBoxWithLabel txtCpfInstructor;
        private GroupBox gpbInstructorGeneral;
        private CustomTextBoxWithLabel txtEmailInstructor;
        private CustomTextBoxWithLabel txtNameInstructor;
        private GroupBox gpbMonitoria;
        private CustomTextBoxWithLabel txtCargaInstructor;
        private CustomTextBoxWithLabel txtTipoInstructor;
        private CustomTextBoxWithLabel txtProntuarioInstructor;
        private Button btnClearNewInstructor;
        private Button btnInsertNewInstructor;
    }
}

