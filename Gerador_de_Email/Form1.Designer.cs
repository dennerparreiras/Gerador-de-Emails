namespace Gerador_de_Email
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.checkSENHA = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkObservacao = new System.Windows.Forms.CheckBox();
            this.checkCPF = new System.Windows.Forms.CheckBox();
            this.tbObservacoes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.cbLocal = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCargo = new System.Windows.Forms.TextBox();
            this.cbEmail = new System.Windows.Forms.ComboBox();
            this.checkEmail = new System.Windows.Forms.CheckBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbReturn = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btCopy = new System.Windows.Forms.Button();
            this.btGenerate = new System.Windows.Forms.Button();
            this.btClean = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosCriadosTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarLOG_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.buscar_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.carregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrador_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.parâmetrosDoSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.About_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(22, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // tbSenha
            // 
            this.tbSenha.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbSenha.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbSenha.Enabled = false;
            this.tbSenha.Location = new System.Drawing.Point(250, 89);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(110, 20);
            this.tbSenha.TabIndex = 28;
            // 
            // checkSENHA
            // 
            this.checkSENHA.AutoSize = true;
            this.checkSENHA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkSENHA.Location = new System.Drawing.Point(232, 94);
            this.checkSENHA.Name = "checkSENHA";
            this.checkSENHA.Size = new System.Drawing.Size(12, 11);
            this.checkSENHA.TabIndex = 27;
            this.checkSENHA.UseVisualStyleBackColor = true;
            this.checkSENHA.CheckedChanged += new System.EventHandler(this.checkSENHA_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(188, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Senha";
            // 
            // checkObservacao
            // 
            this.checkObservacao.AutoSize = true;
            this.checkObservacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkObservacao.Location = new System.Drawing.Point(66, 202);
            this.checkObservacao.Name = "checkObservacao";
            this.checkObservacao.Size = new System.Drawing.Size(12, 11);
            this.checkObservacao.TabIndex = 24;
            this.checkObservacao.UseVisualStyleBackColor = true;
            this.checkObservacao.CheckedChanged += new System.EventHandler(this.checkObservacao_CheckedChanged);
            // 
            // checkCPF
            // 
            this.checkCPF.AutoSize = true;
            this.checkCPF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkCPF.Location = new System.Drawing.Point(66, 94);
            this.checkCPF.Name = "checkCPF";
            this.checkCPF.Size = new System.Drawing.Size(12, 11);
            this.checkCPF.TabIndex = 23;
            this.checkCPF.UseVisualStyleBackColor = true;
            this.checkCPF.CheckedChanged += new System.EventHandler(this.checkCPF_CheckedChanged);
            // 
            // tbObservacoes
            // 
            this.tbObservacoes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbObservacoes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbObservacoes.Enabled = false;
            this.tbObservacoes.Location = new System.Drawing.Point(84, 197);
            this.tbObservacoes.Multiline = true;
            this.tbObservacoes.Name = "tbObservacoes";
            this.tbObservacoes.Size = new System.Drawing.Size(277, 63);
            this.tbObservacoes.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(22, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "OBS.";
            // 
            // mtbCPF
            // 
            this.mtbCPF.Enabled = false;
            this.mtbCPF.Location = new System.Drawing.Point(84, 89);
            this.mtbCPF.Mask = "000.000.000-00";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(98, 20);
            this.mtbCPF.TabIndex = 21;
            this.mtbCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbLocal
            // 
            this.cbLocal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbLocal.FormattingEnabled = true;
            this.cbLocal.Location = new System.Drawing.Point(84, 143);
            this.cbLocal.Name = "cbLocal";
            this.cbLocal.Size = new System.Drawing.Size(277, 21);
            this.cbLocal.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(22, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Local";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(22, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cargo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(22, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "CPF";
            // 
            // tbCargo
            // 
            this.tbCargo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbCargo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbCargo.Location = new System.Drawing.Point(84, 171);
            this.tbCargo.Name = "tbCargo";
            this.tbCargo.Size = new System.Drawing.Size(277, 20);
            this.tbCargo.TabIndex = 13;
            // 
            // cbEmail
            // 
            this.cbEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbEmail.FormattingEnabled = true;
            this.cbEmail.Location = new System.Drawing.Point(209, 116);
            this.cbEmail.Name = "cbEmail";
            this.cbEmail.Size = new System.Drawing.Size(152, 21);
            this.cbEmail.TabIndex = 11;
            // 
            // checkEmail
            // 
            this.checkEmail.AutoSize = true;
            this.checkEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkEmail.Location = new System.Drawing.Point(66, 121);
            this.checkEmail.Name = "checkEmail";
            this.checkEmail.Size = new System.Drawing.Size(12, 11);
            this.checkEmail.TabIndex = 9;
            this.checkEmail.UseVisualStyleBackColor = true;
            this.checkEmail.CheckedChanged += new System.EventHandler(this.checkEmail_CheckedChanged);
            // 
            // tbNome
            // 
            this.tbNome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbNome.Location = new System.Drawing.Point(84, 63);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(277, 20);
            this.tbNome.TabIndex = 8;
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbEmail.Enabled = false;
            this.tbEmail.Location = new System.Drawing.Point(84, 117);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(119, 20);
            this.tbEmail.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // tbReturn
            // 
            this.tbReturn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbReturn.Location = new System.Drawing.Point(387, 63);
            this.tbReturn.Multiline = true;
            this.tbReturn.Name = "tbReturn";
            this.tbReturn.ReadOnly = true;
            this.tbReturn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbReturn.Size = new System.Drawing.Size(226, 197);
            this.tbReturn.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btCopy);
            this.panel1.Controls.Add(this.tbSenha);
            this.panel1.Controls.Add(this.tbObservacoes);
            this.panel1.Controls.Add(this.tbReturn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.checkSENHA);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbCargo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.checkObservacao);
            this.panel1.Controls.Add(this.btGenerate);
            this.panel1.Controls.Add(this.tbNome);
            this.panel1.Controls.Add(this.cbLocal);
            this.panel1.Controls.Add(this.checkCPF);
            this.panel1.Controls.Add(this.cbEmail);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.mtbCPF);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Controls.Add(this.btClean);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.checkEmail);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 332);
            this.panel1.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(21, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "Dados do Usuário";
            // 
            // btCopy
            // 
            this.btCopy.BackColor = System.Drawing.Color.MidnightBlue;
            this.btCopy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btCopy.BackgroundImage")));
            this.btCopy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCopy.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btCopy.Location = new System.Drawing.Point(387, 266);
            this.btCopy.Name = "btCopy";
            this.btCopy.Size = new System.Drawing.Size(226, 23);
            this.btCopy.TabIndex = 12;
            this.btCopy.Text = "Copiar para área de transferência";
            this.btCopy.UseVisualStyleBackColor = false;
            this.btCopy.Click += new System.EventHandler(this.btCopy_Click);
            // 
            // btGenerate
            // 
            this.btGenerate.BackColor = System.Drawing.Color.MidnightBlue;
            this.btGenerate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btGenerate.BackgroundImage")));
            this.btGenerate.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGenerate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btGenerate.Location = new System.Drawing.Point(176, 266);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(185, 23);
            this.btGenerate.TabIndex = 14;
            this.btGenerate.Text = "Gerar Dados";
            this.btGenerate.UseVisualStyleBackColor = false;
            this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click);
            // 
            // btClean
            // 
            this.btClean.BackColor = System.Drawing.Color.MidnightBlue;
            this.btClean.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btClean.BackgroundImage")));
            this.btClean.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClean.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btClean.Location = new System.Drawing.Point(84, 266);
            this.btClean.Name = "btClean";
            this.btClean.Size = new System.Drawing.Size(86, 23);
            this.btClean.TabIndex = 16;
            this.btClean.Text = "Limpar";
            this.btClean.UseVisualStyleBackColor = false;
            this.btClean.Click += new System.EventHandler(this.btClean_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Gerador_de_Email.Properties.Resources.abstract_blue_backgrounds;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(657, 332);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MenuBar
            // 
            this.MenuBar.BackColor = System.Drawing.Color.MidnightBlue;
            this.MenuBar.BackgroundImage = global::Gerador_de_Email.Properties.Resources.big_bar2;
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatóriosToolStripMenuItem,
            this.About_TSMI});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(657, 25);
            this.MenuBar.TabIndex = 2;
            this.MenuBar.Text = "menuStrip1";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.BackColor = System.Drawing.Color.MidnightBlue;
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatóriosToolStripMenuItem1,
            this.salvarTSMI,
            this.carregarToolStripMenuItem,
            this.administrador_TSMI});
            this.relatóriosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relatóriosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.relatóriosToolStripMenuItem.Text = "Menu";
            // 
            // relatóriosToolStripMenuItem1
            // 
            this.relatóriosToolStripMenuItem1.BackColor = System.Drawing.Color.RoyalBlue;
            this.relatóriosToolStripMenuItem1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("relatóriosToolStripMenuItem1.BackgroundImage")));
            this.relatóriosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuáriosCriadosTSMI,
            this.consultarLOG_TSMI,
            this.buscar_TSMI});
            this.relatóriosToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.relatóriosToolStripMenuItem1.Name = "relatóriosToolStripMenuItem1";
            this.relatóriosToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.relatóriosToolStripMenuItem1.Text = "Relatórios...";
            // 
            // usuáriosCriadosTSMI
            // 
            this.usuáriosCriadosTSMI.BackColor = System.Drawing.Color.RoyalBlue;
            this.usuáriosCriadosTSMI.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("usuáriosCriadosTSMI.BackgroundImage")));
            this.usuáriosCriadosTSMI.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.usuáriosCriadosTSMI.Name = "usuáriosCriadosTSMI";
            this.usuáriosCriadosTSMI.Size = new System.Drawing.Size(177, 22);
            this.usuáriosCriadosTSMI.Text = "Usuários criados";
            this.usuáriosCriadosTSMI.Click += new System.EventHandler(this.usuáriosCriadosTSMI_Click);
            // 
            // consultarLOG_TSMI
            // 
            this.consultarLOG_TSMI.BackColor = System.Drawing.Color.RoyalBlue;
            this.consultarLOG_TSMI.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("consultarLOG_TSMI.BackgroundImage")));
            this.consultarLOG_TSMI.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.consultarLOG_TSMI.Name = "consultarLOG_TSMI";
            this.consultarLOG_TSMI.Size = new System.Drawing.Size(177, 22);
            this.consultarLOG_TSMI.Text = "Consultar LOG";
            this.consultarLOG_TSMI.Click += new System.EventHandler(this.consultarLOG_TSMI_Click);
            // 
            // buscar_TSMI
            // 
            this.buscar_TSMI.BackColor = System.Drawing.Color.RoyalBlue;
            this.buscar_TSMI.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buscar_TSMI.BackgroundImage")));
            this.buscar_TSMI.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buscar_TSMI.Name = "buscar_TSMI";
            this.buscar_TSMI.Size = new System.Drawing.Size(177, 22);
            this.buscar_TSMI.Text = "Buscar";
            this.buscar_TSMI.Click += new System.EventHandler(this.buscar_TSMI_Click);
            // 
            // salvarTSMI
            // 
            this.salvarTSMI.BackColor = System.Drawing.Color.RoyalBlue;
            this.salvarTSMI.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("salvarTSMI.BackgroundImage")));
            this.salvarTSMI.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.salvarTSMI.Name = "salvarTSMI";
            this.salvarTSMI.Size = new System.Drawing.Size(165, 22);
            this.salvarTSMI.Text = "Salvar...";
            this.salvarTSMI.Click += new System.EventHandler(this.salvarTSMI_Click);
            // 
            // carregarToolStripMenuItem
            // 
            this.carregarToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue;
            this.carregarToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("carregarToolStripMenuItem.BackgroundImage")));
            this.carregarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.carregarToolStripMenuItem.Name = "carregarToolStripMenuItem";
            this.carregarToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.carregarToolStripMenuItem.Text = "Carregar...";
            this.carregarToolStripMenuItem.Click += new System.EventHandler(this.carregarToolStripMenuItem_Click);
            // 
            // administrador_TSMI
            // 
            this.administrador_TSMI.BackgroundImage = global::Gerador_de_Email.Properties.Resources.red_silk;
            this.administrador_TSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parâmetrosDoSistemaToolStripMenuItem,
            this.opçõesToolStripMenuItem});
            this.administrador_TSMI.ForeColor = System.Drawing.SystemColors.Control;
            this.administrador_TSMI.Name = "administrador_TSMI";
            this.administrador_TSMI.Size = new System.Drawing.Size(165, 22);
            this.administrador_TSMI.Text = "Administrador";
            this.administrador_TSMI.Click += new System.EventHandler(this.administrador_TSMI_Click);
            // 
            // parâmetrosDoSistemaToolStripMenuItem
            // 
            this.parâmetrosDoSistemaToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("parâmetrosDoSistemaToolStripMenuItem.BackgroundImage")));
            this.parâmetrosDoSistemaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.parâmetrosDoSistemaToolStripMenuItem.Name = "parâmetrosDoSistemaToolStripMenuItem";
            this.parâmetrosDoSistemaToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.parâmetrosDoSistemaToolStripMenuItem.Text = "Parâmetros do Sistema";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("opçõesToolStripMenuItem.BackgroundImage")));
            this.opçõesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // About_TSMI
            // 
            this.About_TSMI.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.About_TSMI.Name = "About_TSMI";
            this.About_TSMI.Size = new System.Drawing.Size(49, 21);
            this.About_TSMI.Text = "Sobre";
            this.About_TSMI.Click += new System.EventHandler(this.About_TSMI_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(657, 332);
            this.Controls.Add(this.MenuBar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuBar;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FLUXUS - Gerador de Usuários";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.TextBox tbReturn;
        private System.Windows.Forms.Button btCopy;
        private System.Windows.Forms.Button btClean;
        private System.Windows.Forms.Button btGenerate;
        private System.Windows.Forms.TextBox tbCargo;
        private System.Windows.Forms.ComboBox cbLocal;
        private System.Windows.Forms.ComboBox cbEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.CheckBox checkEmail;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.TextBox tbObservacoes;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkCPF;
        private System.Windows.Forms.CheckBox checkObservacao;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.CheckBox checkSENHA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuáriosCriadosTSMI;
        private System.Windows.Forms.ToolStripMenuItem salvarTSMI;
        private System.Windows.Forms.ToolStripMenuItem carregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarLOG_TSMI;
        private System.Windows.Forms.ToolStripMenuItem buscar_TSMI;
        private System.Windows.Forms.ToolStripMenuItem About_TSMI;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem administrador_TSMI;
        private System.Windows.Forms.ToolStripMenuItem parâmetrosDoSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

