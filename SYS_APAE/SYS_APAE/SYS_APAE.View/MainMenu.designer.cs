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
            this.tabNewStudent = new System.Windows.Forms.TabPage();
            this.gpbAddress = new System.Windows.Forms.GroupBox();
            this.gpbStudentInfo = new System.Windows.Forms.GroupBox();
            this.lblDtExp = new System.Windows.Forms.Label();
            this.dtpExp = new System.Windows.Forms.DateTimePicker();
            this.dtpNasc = new System.Windows.Forms.DateTimePicker();
            this.lblNasc = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tabNewInstructor = new System.Windows.Forms.TabPage();
            this.btnClearNewInstructor = new System.Windows.Forms.Button();
            this.btnInsertNewInstructor = new System.Windows.Forms.Button();
            this.gpbMonitoria = new System.Windows.Forms.GroupBox();
            this.gpbLoginData = new System.Windows.Forms.GroupBox();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.gpbInstructorGeneral = new System.Windows.Forms.GroupBox();
            this.tabNewActivity = new System.Windows.Forms.TabPage();
            this.btnLimparNewActivity = new System.Windows.Forms.Button();
            this.btnAddNewActivity = new System.Windows.Forms.Button();
            this.lblDescriptionActivity = new System.Windows.Forms.Label();
            this.txtDescriptionActivity = new System.Windows.Forms.TextBox();
            this.tabNewClass = new System.Windows.Forms.TabPage();
            this.gpbInstructorReport = new System.Windows.Forms.GroupBox();
            this.cmbNomeMonitor = new System.Windows.Forms.ComboBox();
            this.cmbActivities = new System.Windows.Forms.ComboBox();
            this.btnRefreshReport = new System.Windows.Forms.Button();
            this.btnRelAdd = new System.Windows.Forms.Button();
            this.dtpRelCreated = new System.Windows.Forms.DateTimePicker();
            this.cmbNomeAluno = new System.Windows.Forms.ComboBox();
            this.gpBoxInteressante = new System.Windows.Forms.GroupBox();
            this.lblInteressante = new System.Windows.Forms.Label();
            this.radioInteressante0 = new System.Windows.Forms.RadioButton();
            this.radioInteressante5 = new System.Windows.Forms.RadioButton();
            this.radioInteressante3 = new System.Windows.Forms.RadioButton();
            this.radioInteressante4 = new System.Windows.Forms.RadioButton();
            this.radioInteressante2 = new System.Windows.Forms.RadioButton();
            this.radioInteressante1 = new System.Windows.Forms.RadioButton();
            this.gpBoxAtividade = new System.Windows.Forms.GroupBox();
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
            this.tabListStudents = new System.Windows.Forms.TabPage();
            this.lblListStudentsEmpty = new System.Windows.Forms.Label();
            this.dtgListStudents = new System.Windows.Forms.DataGridView();
            this.tabListInstructors = new System.Windows.Forms.TabPage();
            this.lblListInstructorsEmpty = new System.Windows.Forms.Label();
            this.dtgListInstructors = new System.Windows.Forms.DataGridView();
            this.tabListActivity = new System.Windows.Forms.TabPage();
            this.lblListActivitiesEmpty = new System.Windows.Forms.Label();
            this.dtgListActivities = new System.Windows.Forms.DataGridView();
            this.tabListClass = new System.Windows.Forms.TabPage();
            this.lblListClassEmpty = new System.Windows.Forms.Label();
            this.dtgReports = new System.Windows.Forms.DataGridView();
            this.logo_if = new System.Windows.Forms.PictureBox();
            this.pnlGreenDetail = new System.Windows.Forms.Panel();
            this.lblWUser = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.mnPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnItemNewStudents = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItemNewInstructor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItemNewActivity = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItemNewReports = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItemShowStudents = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItemListInstructors = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItemListActivities = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItemShowReports = new System.Windows.Forms.ToolStripMenuItem();
            this.txtEnd = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel();
            this.txtCep = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomMaskedTextBoxWithLabel();
            this.txtCidade = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel();
            this.txtCelular = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomMaskedTextBoxWithLabel();
            this.txtEstado = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel();
            this.txtTel = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomMaskedTextBoxWithLabel();
            this.txtBairro = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel();
            this.txtNome = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel();
            this.txtCPF = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomMaskedTextBoxWithLabel();
            this.txtEmail = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel();
            this.txtNaturalidade = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel();
            this.txtMae = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel();
            this.txtPai = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel();
            this.txtRG = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomMaskedTextBoxWithLabel();
            this.txtOrgExp = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel();
            this.txtTipoInstructor = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel();
            this.txtProntuarioInstructor = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomMaskedTextBoxWithLabel();
            this.txtPasswordInstructor = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel();
            this.txtCpfInstructor = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomMaskedTextBoxWithLabel();
            this.txtEmailInstructor = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel();
            this.txtNameInstructor = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel();
            this.txtTitleActivity = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel();
            this.txtProntRelatorio = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBox();
            this.lblProntReport = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomLabel();
            this.txtObsInteressante = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel();
            this.txtObs = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel();
            this.txtSearchStudents = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel();
            this.txtSearchInstructors = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel();
            this.txtSearchActivities = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel();
            this.txtSearchReports = new SYS_APAE_CUSTOM_COMPONENTS.CustomComponents.CustomTextBoxWithLabel();
            this.txtCargaInstructor = new System.Windows.Forms.NumericUpDown();
            this.lblCargaInstructor = new System.Windows.Forms.Label();
            this.tabControlGeral.SuspendLayout();
            this.tabNewStudent.SuspendLayout();
            this.gpbAddress.SuspendLayout();
            this.gpbStudentInfo.SuspendLayout();
            this.tabNewInstructor.SuspendLayout();
            this.gpbMonitoria.SuspendLayout();
            this.gpbLoginData.SuspendLayout();
            this.gpbInstructorGeneral.SuspendLayout();
            this.tabNewActivity.SuspendLayout();
            this.tabNewClass.SuspendLayout();
            this.gpbInstructorReport.SuspendLayout();
            this.gpBoxInteressante.SuspendLayout();
            this.gpBoxAtividade.SuspendLayout();
            this.gpBoxRecLetras.SuspendLayout();
            this.gpBoxLeitura.SuspendLayout();
            this.gpBoxDigitacao.SuspendLayout();
            this.tabListStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListStudents)).BeginInit();
            this.tabListInstructors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListInstructors)).BeginInit();
            this.tabListActivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListActivities)).BeginInit();
            this.tabListClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_if)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.mnPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCargaInstructor)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlGeral
            // 
            this.tabControlGeral.Controls.Add(this.tabNewStudent);
            this.tabControlGeral.Controls.Add(this.tabNewInstructor);
            this.tabControlGeral.Controls.Add(this.tabNewActivity);
            this.tabControlGeral.Controls.Add(this.tabNewClass);
            this.tabControlGeral.Controls.Add(this.tabListStudents);
            this.tabControlGeral.Controls.Add(this.tabListInstructors);
            this.tabControlGeral.Controls.Add(this.tabListActivity);
            this.tabControlGeral.Controls.Add(this.tabListClass);
            this.tabControlGeral.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabControlGeral.Location = new System.Drawing.Point(136, 91);
            this.tabControlGeral.Name = "tabControlGeral";
            this.tabControlGeral.SelectedIndex = 0;
            this.tabControlGeral.Size = new System.Drawing.Size(1098, 380);
            this.tabControlGeral.TabIndex = 1;
            // 
            // tabNewStudent
            // 
            this.tabNewStudent.AutoScroll = true;
            this.tabNewStudent.Controls.Add(this.gpbAddress);
            this.tabNewStudent.Controls.Add(this.gpbStudentInfo);
            this.tabNewStudent.Controls.Add(this.btnReset);
            this.tabNewStudent.Controls.Add(this.btnAdd);
            this.tabNewStudent.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabNewStudent.Location = new System.Drawing.Point(4, 22);
            this.tabNewStudent.Name = "tabNewStudent";
            this.tabNewStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabNewStudent.Size = new System.Drawing.Size(1090, 354);
            this.tabNewStudent.TabIndex = 0;
            this.tabNewStudent.Text = "Cadastrar Aluno";
            this.tabNewStudent.UseVisualStyleBackColor = true;
            // 
            // gpbAddress
            // 
            this.gpbAddress.Controls.Add(this.txtEnd);
            this.gpbAddress.Controls.Add(this.txtCep);
            this.gpbAddress.Controls.Add(this.txtCidade);
            this.gpbAddress.Controls.Add(this.txtCelular);
            this.gpbAddress.Controls.Add(this.txtEstado);
            this.gpbAddress.Controls.Add(this.txtTel);
            this.gpbAddress.Controls.Add(this.txtBairro);
            this.gpbAddress.Location = new System.Drawing.Point(3, 180);
            this.gpbAddress.Name = "gpbAddress";
            this.gpbAddress.Size = new System.Drawing.Size(1072, 120);
            this.gpbAddress.TabIndex = 2;
            this.gpbAddress.TabStop = false;
            this.gpbAddress.Text = "Contato";
            // 
            // gpbStudentInfo
            // 
            this.gpbStudentInfo.Controls.Add(this.lblDtExp);
            this.gpbStudentInfo.Controls.Add(this.txtNome);
            this.gpbStudentInfo.Controls.Add(this.txtCPF);
            this.gpbStudentInfo.Controls.Add(this.dtpExp);
            this.gpbStudentInfo.Controls.Add(this.dtpNasc);
            this.gpbStudentInfo.Controls.Add(this.lblNasc);
            this.gpbStudentInfo.Controls.Add(this.txtEmail);
            this.gpbStudentInfo.Controls.Add(this.txtNaturalidade);
            this.gpbStudentInfo.Controls.Add(this.txtMae);
            this.gpbStudentInfo.Controls.Add(this.txtPai);
            this.gpbStudentInfo.Controls.Add(this.txtRG);
            this.gpbStudentInfo.Controls.Add(this.txtOrgExp);
            this.gpbStudentInfo.Location = new System.Drawing.Point(3, 6);
            this.gpbStudentInfo.Name = "gpbStudentInfo";
            this.gpbStudentInfo.Size = new System.Drawing.Size(1072, 168);
            this.gpbStudentInfo.TabIndex = 1;
            this.gpbStudentInfo.TabStop = false;
            this.gpbStudentInfo.Text = "Dados Pessoais";
            // 
            // lblDtExp
            // 
            this.lblDtExp.AutoSize = true;
            this.lblDtExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtExp.Location = new System.Drawing.Point(802, 114);
            this.lblDtExp.Name = "lblDtExp";
            this.lblDtExp.Size = new System.Drawing.Size(82, 12);
            this.lblDtExp.TabIndex = 23;
            this.lblDtExp.Text = "Data de Expedição";
            // 
            // dtpExp
            // 
            this.dtpExp.CustomFormat = "\"dd-MM-yyyy\"";
            this.dtpExp.Location = new System.Drawing.Point(802, 129);
            this.dtpExp.Name = "dtpExp";
            this.dtpExp.Size = new System.Drawing.Size(249, 20);
            this.dtpExp.TabIndex = 10;
            this.dtpExp.Value = new System.DateTime(2018, 5, 13, 0, 19, 44, 0);
            // 
            // dtpNasc
            // 
            this.dtpNasc.CustomFormat = "\"dd-MM-yyyy\"";
            this.dtpNasc.Location = new System.Drawing.Point(19, 83);
            this.dtpNasc.Name = "dtpNasc";
            this.dtpNasc.Size = new System.Drawing.Size(249, 20);
            this.dtpNasc.TabIndex = 4;
            this.dtpNasc.Value = new System.DateTime(2018, 5, 13, 0, 19, 44, 0);
            // 
            // lblNasc
            // 
            this.lblNasc.AutoSize = true;
            this.lblNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNasc.Location = new System.Drawing.Point(18, 68);
            this.lblNasc.Name = "lblNasc";
            this.lblNasc.Size = new System.Drawing.Size(89, 12);
            this.lblNasc.TabIndex = 20;
            this.lblNasc.Text = "Data de Nascimento\r\n";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(15, 315);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(95, 33);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Limpar";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(336, 315);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(558, 33);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tabNewInstructor
            // 
            this.tabNewInstructor.Controls.Add(this.btnClearNewInstructor);
            this.tabNewInstructor.Controls.Add(this.btnInsertNewInstructor);
            this.tabNewInstructor.Controls.Add(this.gpbMonitoria);
            this.tabNewInstructor.Controls.Add(this.gpbLoginData);
            this.tabNewInstructor.Controls.Add(this.gpbInstructorGeneral);
            this.tabNewInstructor.Location = new System.Drawing.Point(4, 22);
            this.tabNewInstructor.Name = "tabNewInstructor";
            this.tabNewInstructor.Size = new System.Drawing.Size(1090, 354);
            this.tabNewInstructor.TabIndex = 4;
            this.tabNewInstructor.Text = "Cadastrar Monitor";
            this.tabNewInstructor.UseVisualStyleBackColor = true;
            // 
            // btnClearNewInstructor
            // 
            this.btnClearNewInstructor.Location = new System.Drawing.Point(577, 246);
            this.btnClearNewInstructor.Name = "btnClearNewInstructor";
            this.btnClearNewInstructor.Size = new System.Drawing.Size(118, 61);
            this.btnClearNewInstructor.TabIndex = 5;
            this.btnClearNewInstructor.Text = "Limpar";
            this.btnClearNewInstructor.UseVisualStyleBackColor = true;
            this.btnClearNewInstructor.Click += new System.EventHandler(this.btnClearNewInstructor_Click);
            // 
            // btnInsertNewInstructor
            // 
            this.btnInsertNewInstructor.Location = new System.Drawing.Point(859, 246);
            this.btnInsertNewInstructor.Name = "btnInsertNewInstructor";
            this.btnInsertNewInstructor.Size = new System.Drawing.Size(210, 61);
            this.btnInsertNewInstructor.TabIndex = 4;
            this.btnInsertNewInstructor.Text = "Cadastrar";
            this.btnInsertNewInstructor.UseVisualStyleBackColor = false;
            this.btnInsertNewInstructor.Click += new System.EventHandler(this.btnInsertNewInstructor_Click);
            // 
            // gpbMonitoria
            // 
            this.gpbMonitoria.Controls.Add(this.lblCargaInstructor);
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
            // tabNewActivity
            // 
            this.tabNewActivity.Controls.Add(this.btnLimparNewActivity);
            this.tabNewActivity.Controls.Add(this.btnAddNewActivity);
            this.tabNewActivity.Controls.Add(this.lblDescriptionActivity);
            this.tabNewActivity.Controls.Add(this.txtDescriptionActivity);
            this.tabNewActivity.Controls.Add(this.txtTitleActivity);
            this.tabNewActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNewActivity.Location = new System.Drawing.Point(4, 22);
            this.tabNewActivity.Name = "tabNewActivity";
            this.tabNewActivity.Padding = new System.Windows.Forms.Padding(3);
            this.tabNewActivity.Size = new System.Drawing.Size(1090, 354);
            this.tabNewActivity.TabIndex = 5;
            this.tabNewActivity.Text = "Cadastrar Atividade";
            this.tabNewActivity.UseVisualStyleBackColor = true;
            // 
            // btnLimparNewActivity
            // 
            this.btnLimparNewActivity.Location = new System.Drawing.Point(828, 113);
            this.btnLimparNewActivity.Name = "btnLimparNewActivity";
            this.btnLimparNewActivity.Size = new System.Drawing.Size(98, 36);
            this.btnLimparNewActivity.TabIndex = 5;
            this.btnLimparNewActivity.Text = "Limpar";
            this.btnLimparNewActivity.UseVisualStyleBackColor = true;
            this.btnLimparNewActivity.Click += new System.EventHandler(this.btnLimparNewActivity_Click);
            // 
            // btnAddNewActivity
            // 
            this.btnAddNewActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewActivity.Location = new System.Drawing.Point(756, 237);
            this.btnAddNewActivity.Name = "btnAddNewActivity";
            this.btnAddNewActivity.Size = new System.Drawing.Size(170, 67);
            this.btnAddNewActivity.TabIndex = 4;
            this.btnAddNewActivity.Text = "Adicionar";
            this.btnAddNewActivity.UseVisualStyleBackColor = true;
            this.btnAddNewActivity.Click += new System.EventHandler(this.btnAddNewActivity_Click);
            // 
            // lblDescriptionActivity
            // 
            this.lblDescriptionActivity.AutoSize = true;
            this.lblDescriptionActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptionActivity.Location = new System.Drawing.Point(87, 97);
            this.lblDescriptionActivity.Name = "lblDescriptionActivity";
            this.lblDescriptionActivity.Size = new System.Drawing.Size(47, 12);
            this.lblDescriptionActivity.TabIndex = 3;
            this.lblDescriptionActivity.Text = "Descrição";
            // 
            // txtDescriptionActivity
            // 
            this.txtDescriptionActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescriptionActivity.Location = new System.Drawing.Point(88, 113);
            this.txtDescriptionActivity.Multiline = true;
            this.txtDescriptionActivity.Name = "txtDescriptionActivity";
            this.txtDescriptionActivity.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescriptionActivity.Size = new System.Drawing.Size(628, 191);
            this.txtDescriptionActivity.TabIndex = 2;
            // 
            // tabNewClass
            // 
            this.tabNewClass.Controls.Add(this.gpbInstructorReport);
            this.tabNewClass.Controls.Add(this.cmbActivities);
            this.tabNewClass.Controls.Add(this.btnRefreshReport);
            this.tabNewClass.Controls.Add(this.btnRelAdd);
            this.tabNewClass.Controls.Add(this.dtpRelCreated);
            this.tabNewClass.Controls.Add(this.cmbNomeAluno);
            this.tabNewClass.Controls.Add(this.gpBoxInteressante);
            this.tabNewClass.Controls.Add(this.gpBoxAtividade);
            this.tabNewClass.Controls.Add(this.gpBoxRecLetras);
            this.tabNewClass.Controls.Add(this.gpBoxLeitura);
            this.tabNewClass.Controls.Add(this.gpBoxDigitacao);
            this.tabNewClass.Controls.Add(this.lblTitulo);
            this.tabNewClass.Controls.Add(this.lblData);
            this.tabNewClass.Controls.Add(this.lblNomeAluno);
            this.tabNewClass.Location = new System.Drawing.Point(4, 22);
            this.tabNewClass.Name = "tabNewClass";
            this.tabNewClass.Size = new System.Drawing.Size(1090, 354);
            this.tabNewClass.TabIndex = 3;
            this.tabNewClass.Text = "Criar Novo Relatório";
            this.tabNewClass.UseVisualStyleBackColor = true;
            // 
            // gpbInstructorReport
            // 
            this.gpbInstructorReport.Controls.Add(this.cmbNomeMonitor);
            this.gpbInstructorReport.Controls.Add(this.txtProntRelatorio);
            this.gpbInstructorReport.Controls.Add(this.lblProntReport);
            this.gpbInstructorReport.Location = new System.Drawing.Point(583, 5);
            this.gpbInstructorReport.Name = "gpbInstructorReport";
            this.gpbInstructorReport.Size = new System.Drawing.Size(473, 100);
            this.gpbInstructorReport.TabIndex = 66;
            this.gpbInstructorReport.TabStop = false;
            this.gpbInstructorReport.Text = "Monitor";
            // 
            // cmbNomeMonitor
            // 
            this.cmbNomeMonitor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNomeMonitor.FormattingEnabled = true;
            this.cmbNomeMonitor.Location = new System.Drawing.Point(15, 21);
            this.cmbNomeMonitor.Name = "cmbNomeMonitor";
            this.cmbNomeMonitor.Size = new System.Drawing.Size(430, 21);
            this.cmbNomeMonitor.TabIndex = 59;
            this.cmbNomeMonitor.SelectedIndexChanged += new System.EventHandler(this.cmbNomeMonitor_SelectedIndexChanged);
            this.cmbNomeMonitor.SelectedValueChanged += new System.EventHandler(this.cmbNomeMonitor_SelectedValueChanged);
            // 
            // cmbActivities
            // 
            this.cmbActivities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActivities.FormattingEnabled = true;
            this.cmbActivities.Items.AddRange(new object[] {
            "Selecionar"});
            this.cmbActivities.Location = new System.Drawing.Point(137, 57);
            this.cmbActivities.Name = "cmbActivities";
            this.cmbActivities.Size = new System.Drawing.Size(417, 21);
            this.cmbActivities.TabIndex = 65;
            this.cmbActivities.SelectedValueChanged += new System.EventHandler(this.cmbActivities_SelectedValueChanged);
            // 
            // btnRefreshReport
            // 
            this.btnRefreshReport.Location = new System.Drawing.Point(981, 124);
            this.btnRefreshReport.Name = "btnRefreshReport";
            this.btnRefreshReport.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshReport.TabIndex = 62;
            this.btnRefreshReport.Text = "Limpar";
            this.btnRefreshReport.UseVisualStyleBackColor = true;
            this.btnRefreshReport.Click += new System.EventHandler(this.btnRefreshReport_Click);
            // 
            // btnRelAdd
            // 
            this.btnRelAdd.Location = new System.Drawing.Point(961, 284);
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
            this.dtpRelCreated.Location = new System.Drawing.Point(137, 92);
            this.dtpRelCreated.Name = "dtpRelCreated";
            this.dtpRelCreated.Size = new System.Drawing.Size(243, 20);
            this.dtpRelCreated.TabIndex = 60;
            // 
            // cmbNomeAluno
            // 
            this.cmbNomeAluno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNomeAluno.FormattingEnabled = true;
            this.cmbNomeAluno.Items.AddRange(new object[] {
            "Selecionar"});
            this.cmbNomeAluno.Location = new System.Drawing.Point(136, 21);
            this.cmbNomeAluno.Name = "cmbNomeAluno";
            this.cmbNomeAluno.Size = new System.Drawing.Size(418, 21);
            this.cmbNomeAluno.TabIndex = 49;
            this.cmbNomeAluno.SelectedValueChanged += new System.EventHandler(this.cmbNomeAluno_SelectedValueChanged);
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
            this.gpBoxInteressante.Controls.Add(this.txtObsInteressante);
            this.gpBoxInteressante.Location = new System.Drawing.Point(436, 234);
            this.gpBoxInteressante.Name = "gpBoxInteressante";
            this.gpBoxInteressante.Size = new System.Drawing.Size(493, 112);
            this.gpBoxInteressante.TabIndex = 58;
            this.gpBoxInteressante.TabStop = false;
            // 
            // lblInteressante
            // 
            this.lblInteressante.AutoSize = true;
            this.lblInteressante.Location = new System.Drawing.Point(9, 16);
            this.lblInteressante.Name = "lblInteressante";
            this.lblInteressante.Size = new System.Drawing.Size(199, 13);
            this.lblInteressante.TabIndex = 41;
            this.lblInteressante.Text = "O Aluno achou a atividade interessante?";
            // 
            // radioInteressante0
            // 
            this.radioInteressante0.AutoSize = true;
            this.radioInteressante0.Location = new System.Drawing.Point(33, 43);
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
            this.radioInteressante5.Location = new System.Drawing.Point(339, 43);
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
            this.radioInteressante3.Location = new System.Drawing.Point(210, 43);
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
            this.radioInteressante4.Location = new System.Drawing.Point(273, 43);
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
            this.radioInteressante2.Location = new System.Drawing.Point(147, 43);
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
            this.radioInteressante1.Location = new System.Drawing.Point(87, 43);
            this.radioInteressante1.Name = "radioInteressante1";
            this.radioInteressante1.Size = new System.Drawing.Size(31, 17);
            this.radioInteressante1.TabIndex = 46;
            this.radioInteressante1.TabStop = true;
            this.radioInteressante1.Tag = "int";
            this.radioInteressante1.Text = "1";
            this.radioInteressante1.UseVisualStyleBackColor = true;
            this.radioInteressante1.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // gpBoxAtividade
            // 
            this.gpBoxAtividade.Controls.Add(this.txtObs);
            this.gpBoxAtividade.Controls.Add(this.radioAtividade0);
            this.gpBoxAtividade.Controls.Add(this.lblAtividade);
            this.gpBoxAtividade.Controls.Add(this.radioAtividade5);
            this.gpBoxAtividade.Controls.Add(this.radioAtividade3);
            this.gpBoxAtividade.Controls.Add(this.radioAtividade4);
            this.gpBoxAtividade.Controls.Add(this.radioAtividade2);
            this.gpBoxAtividade.Controls.Add(this.radioAtividade1);
            this.gpBoxAtividade.Location = new System.Drawing.Point(436, 123);
            this.gpBoxAtividade.Name = "gpBoxAtividade";
            this.gpBoxAtividade.Size = new System.Drawing.Size(493, 112);
            this.gpBoxAtividade.TabIndex = 57;
            this.gpBoxAtividade.TabStop = false;
            // 
            // radioAtividade0
            // 
            this.radioAtividade0.AutoSize = true;
            this.radioAtividade0.Location = new System.Drawing.Point(33, 43);
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
            this.lblAtividade.Location = new System.Drawing.Point(9, 16);
            this.lblAtividade.Name = "lblAtividade";
            this.lblAtividade.Size = new System.Drawing.Size(207, 13);
            this.lblAtividade.TabIndex = 33;
            this.lblAtividade.Text = "O Aluno teve dificuldade com a atividade?";
            // 
            // radioAtividade5
            // 
            this.radioAtividade5.AutoSize = true;
            this.radioAtividade5.Location = new System.Drawing.Point(339, 43);
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
            this.radioAtividade3.Location = new System.Drawing.Point(210, 43);
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
            this.radioAtividade4.Location = new System.Drawing.Point(273, 43);
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
            this.radioAtividade2.Location = new System.Drawing.Point(147, 43);
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
            this.radioAtividade1.Location = new System.Drawing.Point(87, 43);
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
            this.gpBoxRecLetras.Location = new System.Drawing.Point(32, 272);
            this.gpBoxRecLetras.Name = "gpBoxRecLetras";
            this.gpBoxRecLetras.Size = new System.Drawing.Size(390, 74);
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
            this.radioReconhecer0.Location = new System.Drawing.Point(39, 46);
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
            this.radioReconhecer5.Location = new System.Drawing.Point(345, 46);
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
            this.radioReconhecer3.Location = new System.Drawing.Point(216, 46);
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
            this.radioReconhecer4.Location = new System.Drawing.Point(279, 46);
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
            this.radioReconhecer2.Location = new System.Drawing.Point(153, 46);
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
            this.radioReconhecer1.Location = new System.Drawing.Point(93, 46);
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
            this.gpBoxLeitura.Location = new System.Drawing.Point(32, 199);
            this.gpBoxLeitura.Name = "gpBoxLeitura";
            this.gpBoxLeitura.Size = new System.Drawing.Size(390, 74);
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
            this.radioLeitura0.Location = new System.Drawing.Point(39, 46);
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
            this.radioLeitura5.Location = new System.Drawing.Point(345, 46);
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
            this.radioLeitura3.Location = new System.Drawing.Point(216, 46);
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
            this.radioLeitura4.Location = new System.Drawing.Point(279, 46);
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
            this.radioLeitura2.Location = new System.Drawing.Point(153, 46);
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
            this.radioLeitura1.Location = new System.Drawing.Point(93, 46);
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
            this.gpBoxDigitacao.Location = new System.Drawing.Point(32, 124);
            this.gpBoxDigitacao.Name = "gpBoxDigitacao";
            this.gpBoxDigitacao.Size = new System.Drawing.Size(390, 76);
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
            this.radioDig0.Location = new System.Drawing.Point(39, 46);
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
            this.radioDig5.Location = new System.Drawing.Point(345, 46);
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
            this.radioDig3.Location = new System.Drawing.Point(216, 46);
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
            this.radioDig4.Location = new System.Drawing.Point(279, 46);
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
            this.radioDig2.Location = new System.Drawing.Point(153, 46);
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
            this.radioDig1.Location = new System.Drawing.Point(93, 46);
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
            this.lblTitulo.Location = new System.Drawing.Point(31, 60);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(97, 13);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Título da Atividade";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(95, 96);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(36, 13);
            this.lblData.TabIndex = 7;
            this.lblData.Text = "Data: ";
            // 
            // lblNomeAluno
            // 
            this.lblNomeAluno.AutoSize = true;
            this.lblNomeAluno.Location = new System.Drawing.Point(96, 24);
            this.lblNomeAluno.Name = "lblNomeAluno";
            this.lblNomeAluno.Size = new System.Drawing.Size(34, 13);
            this.lblNomeAluno.TabIndex = 2;
            this.lblNomeAluno.Text = "Aluno";
            // 
            // tabListStudents
            // 
            this.tabListStudents.Controls.Add(this.txtSearchStudents);
            this.tabListStudents.Controls.Add(this.lblListStudentsEmpty);
            this.tabListStudents.Controls.Add(this.dtgListStudents);
            this.tabListStudents.Location = new System.Drawing.Point(4, 22);
            this.tabListStudents.Name = "tabListStudents";
            this.tabListStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tabListStudents.Size = new System.Drawing.Size(1090, 354);
            this.tabListStudents.TabIndex = 1;
            this.tabListStudents.Text = "Listar Alunos";
            this.tabListStudents.UseVisualStyleBackColor = true;
            // 
            // lblListStudentsEmpty
            // 
            this.lblListStudentsEmpty.AutoSize = true;
            this.lblListStudentsEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListStudentsEmpty.Location = new System.Drawing.Point(321, 149);
            this.lblListStudentsEmpty.Name = "lblListStudentsEmpty";
            this.lblListStudentsEmpty.Size = new System.Drawing.Size(447, 42);
            this.lblListStudentsEmpty.TabIndex = 6;
            this.lblListStudentsEmpty.Text = "Não há aluno cadastrado!";
            this.lblListStudentsEmpty.Visible = false;
            // 
            // dtgListStudents
            // 
            this.dtgListStudents.AllowUserToAddRows = false;
            this.dtgListStudents.AllowUserToDeleteRows = false;
            this.dtgListStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgListStudents.BackgroundColor = System.Drawing.Color.White;
            this.dtgListStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgListStudents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgListStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListStudents.Location = new System.Drawing.Point(3, 62);
            this.dtgListStudents.MultiSelect = false;
            this.dtgListStudents.Name = "dtgListStudents";
            this.dtgListStudents.ReadOnly = true;
            this.dtgListStudents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgListStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgListStudents.Size = new System.Drawing.Size(1084, 289);
            this.dtgListStudents.TabIndex = 5;
            this.dtgListStudents.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListStudents_CellDoubleClick);
            // 
            // tabListInstructors
            // 
            this.tabListInstructors.Controls.Add(this.lblListInstructorsEmpty);
            this.tabListInstructors.Controls.Add(this.dtgListInstructors);
            this.tabListInstructors.Controls.Add(this.txtSearchInstructors);
            this.tabListInstructors.Location = new System.Drawing.Point(4, 22);
            this.tabListInstructors.Name = "tabListInstructors";
            this.tabListInstructors.Padding = new System.Windows.Forms.Padding(3);
            this.tabListInstructors.Size = new System.Drawing.Size(1090, 354);
            this.tabListInstructors.TabIndex = 6;
            this.tabListInstructors.Text = "Listar Monitores";
            this.tabListInstructors.UseVisualStyleBackColor = true;
            // 
            // lblListInstructorsEmpty
            // 
            this.lblListInstructorsEmpty.AutoSize = true;
            this.lblListInstructorsEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListInstructorsEmpty.Location = new System.Drawing.Point(307, 156);
            this.lblListInstructorsEmpty.Name = "lblListInstructorsEmpty";
            this.lblListInstructorsEmpty.Size = new System.Drawing.Size(478, 42);
            this.lblListInstructorsEmpty.TabIndex = 11;
            this.lblListInstructorsEmpty.Text = "Não há monitor cadastrado!";
            this.lblListInstructorsEmpty.Visible = false;
            // 
            // dtgListInstructors
            // 
            this.dtgListInstructors.AllowUserToAddRows = false;
            this.dtgListInstructors.AllowUserToDeleteRows = false;
            this.dtgListInstructors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgListInstructors.BackgroundColor = System.Drawing.Color.White;
            this.dtgListInstructors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgListInstructors.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgListInstructors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListInstructors.Location = new System.Drawing.Point(3, 62);
            this.dtgListInstructors.MultiSelect = false;
            this.dtgListInstructors.Name = "dtgListInstructors";
            this.dtgListInstructors.ReadOnly = true;
            this.dtgListInstructors.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgListInstructors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgListInstructors.Size = new System.Drawing.Size(1084, 289);
            this.dtgListInstructors.TabIndex = 9;
            // 
            // tabListActivity
            // 
            this.tabListActivity.Controls.Add(this.lblListActivitiesEmpty);
            this.tabListActivity.Controls.Add(this.dtgListActivities);
            this.tabListActivity.Controls.Add(this.txtSearchActivities);
            this.tabListActivity.Location = new System.Drawing.Point(4, 22);
            this.tabListActivity.Name = "tabListActivity";
            this.tabListActivity.Padding = new System.Windows.Forms.Padding(3);
            this.tabListActivity.Size = new System.Drawing.Size(1090, 354);
            this.tabListActivity.TabIndex = 7;
            this.tabListActivity.Text = "Listar Atividades";
            this.tabListActivity.UseVisualStyleBackColor = true;
            // 
            // lblListActivitiesEmpty
            // 
            this.lblListActivitiesEmpty.AutoSize = true;
            this.lblListActivitiesEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListActivitiesEmpty.Location = new System.Drawing.Point(292, 156);
            this.lblListActivitiesEmpty.Name = "lblListActivitiesEmpty";
            this.lblListActivitiesEmpty.Size = new System.Drawing.Size(505, 42);
            this.lblListActivitiesEmpty.TabIndex = 13;
            this.lblListActivitiesEmpty.Text = "Não há atividade cadastrada!";
            this.lblListActivitiesEmpty.Visible = false;
            // 
            // dtgListActivities
            // 
            this.dtgListActivities.AllowUserToAddRows = false;
            this.dtgListActivities.AllowUserToDeleteRows = false;
            this.dtgListActivities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgListActivities.BackgroundColor = System.Drawing.Color.White;
            this.dtgListActivities.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgListActivities.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgListActivities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListActivities.Location = new System.Drawing.Point(3, 62);
            this.dtgListActivities.MultiSelect = false;
            this.dtgListActivities.Name = "dtgListActivities";
            this.dtgListActivities.ReadOnly = true;
            this.dtgListActivities.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgListActivities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgListActivities.Size = new System.Drawing.Size(1084, 289);
            this.dtgListActivities.TabIndex = 11;
            // 
            // tabListClass
            // 
            this.tabListClass.Controls.Add(this.lblListClassEmpty);
            this.tabListClass.Controls.Add(this.dtgReports);
            this.tabListClass.Controls.Add(this.txtSearchReports);
            this.tabListClass.Location = new System.Drawing.Point(4, 22);
            this.tabListClass.Name = "tabListClass";
            this.tabListClass.Size = new System.Drawing.Size(1090, 354);
            this.tabListClass.TabIndex = 2;
            this.tabListClass.Text = "Listar Relatórios";
            this.tabListClass.UseVisualStyleBackColor = true;
            // 
            // lblListClassEmpty
            // 
            this.lblListClassEmpty.AutoSize = true;
            this.lblListClassEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListClassEmpty.Location = new System.Drawing.Point(312, 156);
            this.lblListClassEmpty.Name = "lblListClassEmpty";
            this.lblListClassEmpty.Size = new System.Drawing.Size(426, 42);
            this.lblListClassEmpty.TabIndex = 8;
            this.lblListClassEmpty.Text = "Não há aula cadastrada!";
            this.lblListClassEmpty.Visible = false;
            // 
            // dtgReports
            // 
            this.dtgReports.AllowUserToAddRows = false;
            this.dtgReports.AllowUserToDeleteRows = false;
            this.dtgReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgReports.BackgroundColor = System.Drawing.Color.White;
            this.dtgReports.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgReports.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgReports.Location = new System.Drawing.Point(3, 62);
            this.dtgReports.MultiSelect = false;
            this.dtgReports.Name = "dtgReports";
            this.dtgReports.ReadOnly = true;
            this.dtgReports.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgReports.Size = new System.Drawing.Size(1084, 289);
            this.dtgReports.TabIndex = 6;
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
            // pnlGreenDetail
            // 
            this.pnlGreenDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGreenDetail.AutoSize = true;
            this.pnlGreenDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(153)))), ((int)(((byte)(54)))));
            this.pnlGreenDetail.Location = new System.Drawing.Point(12, 75);
            this.pnlGreenDetail.Name = "pnlGreenDetail";
            this.pnlGreenDetail.Size = new System.Drawing.Size(1249, 10);
            this.pnlGreenDetail.TabIndex = 6;
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
            this.mnItemNewActivity,
            this.mnItemNewReports,
            this.mnItemShowStudents,
            this.mnItemListInstructors,
            this.mnItemListActivities,
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
            this.mnItemNewStudents.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.mnItemNewStudents.Size = new System.Drawing.Size(134, 39);
            this.mnItemNewStudents.Text = "Cadastro Aluno";
            this.mnItemNewStudents.Click += new System.EventHandler(this.mnItemNewStudents_Click);
            // 
            // mnItemNewInstructor
            // 
            this.mnItemNewInstructor.Name = "mnItemNewInstructor";
            this.mnItemNewInstructor.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.mnItemNewInstructor.Size = new System.Drawing.Size(134, 39);
            this.mnItemNewInstructor.Text = "Cadastro Monitor";
            this.mnItemNewInstructor.Click += new System.EventHandler(this.mnItemNewInstructor_Click);
            // 
            // mnItemNewActivity
            // 
            this.mnItemNewActivity.Name = "mnItemNewActivity";
            this.mnItemNewActivity.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.mnItemNewActivity.Size = new System.Drawing.Size(134, 39);
            this.mnItemNewActivity.Text = "Cadastro Atividade";
            this.mnItemNewActivity.Click += new System.EventHandler(this.mnItemNewActivity_Click);
            // 
            // mnItemNewReports
            // 
            this.mnItemNewReports.Name = "mnItemNewReports";
            this.mnItemNewReports.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.mnItemNewReports.Size = new System.Drawing.Size(134, 39);
            this.mnItemNewReports.Text = "Cadastrar Aula";
            this.mnItemNewReports.Click += new System.EventHandler(this.mnItemNewReports_Click);
            // 
            // mnItemShowStudents
            // 
            this.mnItemShowStudents.Name = "mnItemShowStudents";
            this.mnItemShowStudents.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.mnItemShowStudents.Size = new System.Drawing.Size(134, 39);
            this.mnItemShowStudents.Text = "Listar Alunos";
            this.mnItemShowStudents.Click += new System.EventHandler(this.mnItemShowStudents_Click);
            // 
            // mnItemListInstructors
            // 
            this.mnItemListInstructors.Name = "mnItemListInstructors";
            this.mnItemListInstructors.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.mnItemListInstructors.Size = new System.Drawing.Size(134, 39);
            this.mnItemListInstructors.Text = "Listar Monitores";
            this.mnItemListInstructors.Click += new System.EventHandler(this.listarMonitoresToolStripMenuItem_Click);
            // 
            // mnItemListActivities
            // 
            this.mnItemListActivities.Name = "mnItemListActivities";
            this.mnItemListActivities.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.mnItemListActivities.Size = new System.Drawing.Size(134, 39);
            this.mnItemListActivities.Text = "Listar Atividades";
            this.mnItemListActivities.Click += new System.EventHandler(this.mnItemListActivities_Click);
            // 
            // mnItemShowReports
            // 
            this.mnItemShowReports.Name = "mnItemShowReports";
            this.mnItemShowReports.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.mnItemShowReports.Size = new System.Drawing.Size(134, 39);
            this.mnItemShowReports.Text = "Listar Aulas";
            this.mnItemShowReports.Click += new System.EventHandler(this.mnItemShowReports_Click);
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(145, 22);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.PasswordChar = '\0';
            this.txtEnd.ReadOnly = false;
            this.txtEnd.Size = new System.Drawing.Size(553, 35);
            this.txtEnd.TabIndex = 2;
            this.txtEnd.Tag = "Endereço";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(19, 22);
            this.txtCep.Mask = "00.000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(80, 35);
            this.txtCep.TabIndex = 1;
            this.txtCep.Tag = "CEP";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(417, 68);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.PasswordChar = '\0';
            this.txtCidade.ReadOnly = false;
            this.txtCidade.Size = new System.Drawing.Size(281, 35);
            this.txtCidade.TabIndex = 5;
            this.txtCidade.Tag = "Cidade";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(887, 17);
            this.txtCelular.Mask = "(00) 00000-000#";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(164, 35);
            this.txtCelular.TabIndex = 6;
            this.txtCelular.Tag = "Celular";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(283, 68);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.PasswordChar = '\0';
            this.txtEstado.ReadOnly = false;
            this.txtEstado.Size = new System.Drawing.Size(102, 35);
            this.txtEstado.TabIndex = 4;
            this.txtEstado.Tag = "Estado";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(887, 68);
            this.txtTel.Mask = "(00) 0000-0000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(164, 35);
            this.txtTel.TabIndex = 7;
            this.txtTel.Tag = "Telefone";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(19, 68);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.PasswordChar = '\0';
            this.txtBairro.ReadOnly = false;
            this.txtBairro.Size = new System.Drawing.Size(219, 35);
            this.txtBairro.TabIndex = 3;
            this.txtBairro.Tag = "Bairro";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(20, 22);
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.ReadOnly = false;
            this.txtNome.Size = new System.Drawing.Size(448, 35);
            this.txtNome.TabIndex = 1;
            this.txtNome.Tag = "Nome";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(956, 22);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(95, 35);
            this.txtCPF.TabIndex = 3;
            this.txtCPF.Tag = "CPF";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(560, 22);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ReadOnly = false;
            this.txtEmail.Size = new System.Drawing.Size(317, 35);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Tag = "E-mail";
            // 
            // txtNaturalidade
            // 
            this.txtNaturalidade.Location = new System.Drawing.Point(20, 114);
            this.txtNaturalidade.Name = "txtNaturalidade";
            this.txtNaturalidade.PasswordChar = '\0';
            this.txtNaturalidade.ReadOnly = false;
            this.txtNaturalidade.Size = new System.Drawing.Size(179, 35);
            this.txtNaturalidade.TabIndex = 8;
            this.txtNaturalidade.Tag = "Naturalidade";
            // 
            // txtMae
            // 
            this.txtMae.Location = new System.Drawing.Point(333, 68);
            this.txtMae.Name = "txtMae";
            this.txtMae.PasswordChar = '\0';
            this.txtMae.ReadOnly = false;
            this.txtMae.Size = new System.Drawing.Size(414, 35);
            this.txtMae.TabIndex = 5;
            this.txtMae.Tag = "Nome da mãe";
            // 
            // txtPai
            // 
            this.txtPai.Location = new System.Drawing.Point(333, 114);
            this.txtPai.Name = "txtPai";
            this.txtPai.PasswordChar = '\0';
            this.txtPai.ReadOnly = false;
            this.txtPai.Size = new System.Drawing.Size(414, 35);
            this.txtPai.TabIndex = 9;
            this.txtPai.Tag = "Nome do pai";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(802, 68);
            this.txtRG.Mask = "00.000.000-A";
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(75, 35);
            this.txtRG.TabIndex = 6;
            this.txtRG.Tag = "RG";
            // 
            // txtOrgExp
            // 
            this.txtOrgExp.Location = new System.Drawing.Point(897, 70);
            this.txtOrgExp.Name = "txtOrgExp";
            this.txtOrgExp.PasswordChar = '\0';
            this.txtOrgExp.ReadOnly = false;
            this.txtOrgExp.Size = new System.Drawing.Size(60, 35);
            this.txtOrgExp.TabIndex = 7;
            this.txtOrgExp.Tag = "Orgão Exp.";
            // 
            // txtTipoInstructor
            // 
            this.txtTipoInstructor.Location = new System.Drawing.Point(258, 25);
            this.txtTipoInstructor.Name = "txtTipoInstructor";
            this.txtTipoInstructor.PasswordChar = '\0';
            this.txtTipoInstructor.ReadOnly = false;
            this.txtTipoInstructor.Size = new System.Drawing.Size(196, 35);
            this.txtTipoInstructor.TabIndex = 2;
            this.txtTipoInstructor.Tag = "Tipo";
            // 
            // txtProntuarioInstructor
            // 
            this.txtProntuarioInstructor.Location = new System.Drawing.Point(47, 25);
            this.txtProntuarioInstructor.Mask = "000000-A";
            this.txtProntuarioInstructor.Name = "txtProntuarioInstructor";
            this.txtProntuarioInstructor.Size = new System.Drawing.Size(149, 35);
            this.txtProntuarioInstructor.TabIndex = 1;
            this.txtProntuarioInstructor.Tag = "Prontuário";
            // 
            // txtPasswordInstructor
            // 
            this.txtPasswordInstructor.Location = new System.Drawing.Point(233, 34);
            this.txtPasswordInstructor.Name = "txtPasswordInstructor";
            this.txtPasswordInstructor.PasswordChar = '*';
            this.txtPasswordInstructor.ReadOnly = false;
            this.txtPasswordInstructor.Size = new System.Drawing.Size(138, 35);
            this.txtPasswordInstructor.TabIndex = 2;
            this.txtPasswordInstructor.Tag = "Senha";
            // 
            // txtCpfInstructor
            // 
            this.txtCpfInstructor.Location = new System.Drawing.Point(61, 34);
            this.txtCpfInstructor.Mask = "000.000.000-00";
            this.txtCpfInstructor.Name = "txtCpfInstructor";
            this.txtCpfInstructor.Size = new System.Drawing.Size(82, 35);
            this.txtCpfInstructor.TabIndex = 1;
            this.txtCpfInstructor.Tag = "CPF";
            // 
            // txtEmailInstructor
            // 
            this.txtEmailInstructor.Location = new System.Drawing.Point(61, 75);
            this.txtEmailInstructor.Name = "txtEmailInstructor";
            this.txtEmailInstructor.PasswordChar = '\0';
            this.txtEmailInstructor.ReadOnly = false;
            this.txtEmailInstructor.Size = new System.Drawing.Size(389, 35);
            this.txtEmailInstructor.TabIndex = 2;
            this.txtEmailInstructor.Tag = "E-mail:";
            // 
            // txtNameInstructor
            // 
            this.txtNameInstructor.Location = new System.Drawing.Point(61, 25);
            this.txtNameInstructor.Name = "txtNameInstructor";
            this.txtNameInstructor.PasswordChar = '\0';
            this.txtNameInstructor.ReadOnly = false;
            this.txtNameInstructor.Size = new System.Drawing.Size(389, 35);
            this.txtNameInstructor.TabIndex = 1;
            this.txtNameInstructor.Tag = "Nome";
            // 
            // txtTitleActivity
            // 
            this.txtTitleActivity.Location = new System.Drawing.Point(88, 36);
            this.txtTitleActivity.Name = "txtTitleActivity";
            this.txtTitleActivity.PasswordChar = '\0';
            this.txtTitleActivity.ReadOnly = false;
            this.txtTitleActivity.Size = new System.Drawing.Size(437, 35);
            this.txtTitleActivity.TabIndex = 0;
            this.txtTitleActivity.Tag = "Título";
            // 
            // txtProntRelatorio
            // 
            this.txtProntRelatorio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProntRelatorio.Location = new System.Drawing.Point(15, 66);
            this.txtProntRelatorio.Name = "txtProntRelatorio";
            this.txtProntRelatorio.ReadOnly = true;
            this.txtProntRelatorio.Size = new System.Drawing.Size(178, 20);
            this.txtProntRelatorio.TabIndex = 51;
            this.txtProntRelatorio.Tag = "Prontuário";
            // 
            // lblProntReport
            // 
            this.lblProntReport.BackColor = System.Drawing.SystemColors.Control;
            this.lblProntReport.Font = new System.Drawing.Font("", 7F);
            this.lblProntReport.Location = new System.Drawing.Point(15, 51);
            this.lblProntReport.Name = "lblProntReport";
            this.lblProntReport.Size = new System.Drawing.Size(56, 15);
            this.lblProntReport.TabIndex = 63;
            this.lblProntReport.Text = "Prontuário";
            this.lblProntReport.TxtBorder = false;
            this.lblProntReport.TxtTag = false;
            // 
            // txtObsInteressante
            // 
            this.txtObsInteressante.Location = new System.Drawing.Point(28, 67);
            this.txtObsInteressante.Name = "txtObsInteressante";
            this.txtObsInteressante.PasswordChar = '\0';
            this.txtObsInteressante.ReadOnly = false;
            this.txtObsInteressante.Size = new System.Drawing.Size(430, 35);
            this.txtObsInteressante.TabIndex = 48;
            this.txtObsInteressante.Tag = "Observação";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(28, 67);
            this.txtObs.Name = "txtObs";
            this.txtObs.PasswordChar = '\0';
            this.txtObs.ReadOnly = false;
            this.txtObs.Size = new System.Drawing.Size(430, 35);
            this.txtObs.TabIndex = 39;
            this.txtObs.Tag = "Observação";
            // 
            // txtSearchStudents
            // 
            this.txtSearchStudents.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSearchStudents.Location = new System.Drawing.Point(3, 13);
            this.txtSearchStudents.Name = "txtSearchStudents";
            this.txtSearchStudents.PasswordChar = '\0';
            this.txtSearchStudents.ReadOnly = false;
            this.txtSearchStudents.Size = new System.Drawing.Size(326, 35);
            this.txtSearchStudents.TabIndex = 8;
            this.txtSearchStudents.Tag = "Procurar";
            this.txtSearchStudents.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchStudent_KeyUp);
            // 
            // txtSearchInstructors
            // 
            this.txtSearchInstructors.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSearchInstructors.Location = new System.Drawing.Point(3, 13);
            this.txtSearchInstructors.Name = "txtSearchInstructors";
            this.txtSearchInstructors.PasswordChar = '\0';
            this.txtSearchInstructors.ReadOnly = false;
            this.txtSearchInstructors.Size = new System.Drawing.Size(326, 35);
            this.txtSearchInstructors.TabIndex = 10;
            this.txtSearchInstructors.Tag = "Procurar";
            this.txtSearchInstructors.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchInstructors_KeyUp);
            // 
            // txtSearchActivities
            // 
            this.txtSearchActivities.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSearchActivities.Location = new System.Drawing.Point(3, 13);
            this.txtSearchActivities.Name = "txtSearchActivities";
            this.txtSearchActivities.PasswordChar = '\0';
            this.txtSearchActivities.ReadOnly = false;
            this.txtSearchActivities.Size = new System.Drawing.Size(326, 35);
            this.txtSearchActivities.TabIndex = 12;
            this.txtSearchActivities.Tag = "Procurar";
            this.txtSearchActivities.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchActivity_KeyUp);
            // 
            // txtSearchReports
            // 
            this.txtSearchReports.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSearchReports.Location = new System.Drawing.Point(3, 13);
            this.txtSearchReports.Name = "txtSearchReports";
            this.txtSearchReports.PasswordChar = '\0';
            this.txtSearchReports.ReadOnly = false;
            this.txtSearchReports.Size = new System.Drawing.Size(326, 35);
            this.txtSearchReports.TabIndex = 7;
            this.txtSearchReports.Tag = "Procurar";
            // 
            // txtCargaInstructor
            // 
            this.txtCargaInstructor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCargaInstructor.Location = new System.Drawing.Point(47, 94);
            this.txtCargaInstructor.Name = "txtCargaInstructor";
            this.txtCargaInstructor.Size = new System.Drawing.Size(120, 16);
            this.txtCargaInstructor.TabIndex = 3;
            // 
            // lblCargaInstructor
            // 
            this.lblCargaInstructor.AutoSize = true;
            this.lblCargaInstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargaInstructor.Location = new System.Drawing.Point(45, 76);
            this.lblCargaInstructor.Name = "lblCargaInstructor";
            this.lblCargaInstructor.Size = new System.Drawing.Size(93, 12);
            this.lblCargaInstructor.TabIndex = 3;
            this.lblCargaInstructor.Text = "Carga Horária (horas)";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1264, 487);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.lblWUser);
            this.Controls.Add(this.pnlGreenDetail);
            this.Controls.Add(this.logo_if);
            this.Controls.Add(this.tabControlGeral);
            this.Name = "MainMenu";
            this.Text = "APAE DataBase";
            this.tabControlGeral.ResumeLayout(false);
            this.tabNewStudent.ResumeLayout(false);
            this.gpbAddress.ResumeLayout(false);
            this.gpbStudentInfo.ResumeLayout(false);
            this.gpbStudentInfo.PerformLayout();
            this.tabNewInstructor.ResumeLayout(false);
            this.gpbMonitoria.ResumeLayout(false);
            this.gpbMonitoria.PerformLayout();
            this.gpbLoginData.ResumeLayout(false);
            this.gpbLoginData.PerformLayout();
            this.gpbInstructorGeneral.ResumeLayout(false);
            this.tabNewActivity.ResumeLayout(false);
            this.tabNewActivity.PerformLayout();
            this.tabNewClass.ResumeLayout(false);
            this.tabNewClass.PerformLayout();
            this.gpbInstructorReport.ResumeLayout(false);
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
            this.tabListStudents.ResumeLayout(false);
            this.tabListStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListStudents)).EndInit();
            this.tabListInstructors.ResumeLayout(false);
            this.tabListInstructors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListInstructors)).EndInit();
            this.tabListActivity.ResumeLayout(false);
            this.tabListActivity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListActivities)).EndInit();
            this.tabListClass.ResumeLayout(false);
            this.tabListClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_if)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.mnPrincipal.ResumeLayout(false);
            this.mnPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCargaInstructor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlGeral;
        private System.Windows.Forms.TabPage tabNewStudent;
        private System.Windows.Forms.TabPage tabListStudents;
        private System.Windows.Forms.TabPage tabListClass;
        private CustomMaskedTextBoxWithLabel txtCPF;
        private CustomTextBoxWithLabel txtNome;
        private System.Windows.Forms.PictureBox logo_if;
        private System.Windows.Forms.Panel pnlGreenDetail;
        private CustomTextBoxWithLabel txtOrgExp;
        private CustomMaskedTextBoxWithLabel txtRG;
        private CustomTextBoxWithLabel txtNaturalidade;
        private System.Windows.Forms.Label lblNasc;
        private CustomMaskedTextBoxWithLabel txtTel;
        private CustomTextBoxWithLabel txtEstado;
        private CustomTextBoxWithLabel txtCidade;
        private CustomMaskedTextBoxWithLabel txtCep;
        private CustomTextBoxWithLabel txtEnd;
        private CustomTextBoxWithLabel txtPai;
        private CustomTextBoxWithLabel txtMae;
        private CustomTextBoxWithLabel txtBairro;
        private CustomTextBoxWithLabel txtEmail;
        private CustomMaskedTextBoxWithLabel txtCelular;
        private System.Windows.Forms.TabPage tabNewClass;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblNomeAluno;
        private CustomTextBoxWithLabel txtObsInteressante;
        private System.Windows.Forms.RadioButton radioInteressante1;
        private System.Windows.Forms.RadioButton radioInteressante2;
        private System.Windows.Forms.RadioButton radioInteressante4;
        private System.Windows.Forms.RadioButton radioInteressante3;
        private System.Windows.Forms.RadioButton radioInteressante5;
        private System.Windows.Forms.Label lblInteressante;
        private System.Windows.Forms.RadioButton radioInteressante0;
        private CustomTextBoxWithLabel txtObs;
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
        private System.Windows.Forms.RadioButton radioDig0;
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
        private DataGridView dtgListStudents;
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
        private ToolStripMenuItem mnItemNewActivity;
        private CustomTextBoxWithLabel txtSearchReports;
        private TabPage tabNewInstructor;
        private GroupBox gpbLoginData;
        private CheckBox chkShowPassword;
        private CustomTextBoxWithLabel txtPasswordInstructor;
        private CustomMaskedTextBoxWithLabel txtCpfInstructor;
        private GroupBox gpbInstructorGeneral;
        private CustomTextBoxWithLabel txtEmailInstructor;
        private CustomTextBoxWithLabel txtNameInstructor;
        private GroupBox gpbMonitoria;
        private CustomTextBoxWithLabel txtTipoInstructor;
        private CustomMaskedTextBoxWithLabel txtProntuarioInstructor;
        private Button btnClearNewInstructor;
        private Button btnInsertNewInstructor;
        private CustomLabel lblProntReport;
        private GroupBox gpbInstructorReport;
        private ComboBox cmbActivities;
        private TabPage tabNewActivity;
        private Label lblDescriptionActivity;
        private TextBox txtDescriptionActivity;
        private CustomTextBoxWithLabel txtTitleActivity;
        private Button btnAddNewActivity;
        private GroupBox gpbAddress;
        private GroupBox gpbStudentInfo;
        private Label lblDtExp;
        private Button btnLimparNewActivity;
        private Label lblListStudentsEmpty;
        private Label lblListClassEmpty;
        private CustomTextBoxWithLabel txtSearchStudents;
        private ToolStripMenuItem mnItemListInstructors;
        private ToolStripMenuItem mnItemListActivities;
        private TabPage tabListInstructors;
        private CustomTextBoxWithLabel txtSearchInstructors;
        private DataGridView dtgListInstructors;
        private TabPage tabListActivity;
        private Label lblListInstructorsEmpty;
        private Label lblListActivitiesEmpty;
        private DataGridView dtgListActivities;
        private CustomTextBoxWithLabel txtSearchActivities;
        private Label lblCargaInstructor;
        private NumericUpDown txtCargaInstructor;
    }
}

