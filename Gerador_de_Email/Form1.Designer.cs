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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btClean = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btGenerate = new System.Windows.Forms.Button();
            this.tbCargo = new System.Windows.Forms.TextBox();
            this.cbLocal = new System.Windows.Forms.ComboBox();
            this.cbEmail = new System.Windows.Forms.ComboBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.checkEmail = new System.Windows.Forms.CheckBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarLogMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbReturn = new System.Windows.Forms.TextBox();
            this.btFechar = new System.Windows.Forms.Button();
            this.btCopy = new System.Windows.Forms.Button();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.btUserExists = new System.Windows.Forms.Button();
            this.groupActions = new System.Windows.Forms.GroupBox();
            this.btCancelReg = new System.Windows.Forms.Button();
            this.btHide = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.tbObservacoes = new System.Windows.Forms.TextBox();
            this.checkCPF = new System.Windows.Forms.CheckBox();
            this.checkObservacao = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.MenuBar.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.groupActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkObservacao);
            this.groupBox1.Controls.Add(this.checkCPF);
            this.groupBox1.Controls.Add(this.tbObservacoes);
            this.groupBox1.Controls.Add(this.mtbCPF);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btClean);
            this.groupBox1.Controls.Add(this.btAlterar);
            this.groupBox1.Controls.Add(this.btGenerate);
            this.groupBox1.Controls.Add(this.tbCargo);
            this.groupBox1.Controls.Add(this.cbLocal);
            this.groupBox1.Controls.Add(this.cbEmail);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.checkEmail);
            this.groupBox1.Controls.Add(this.tbNome);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 251);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Usuário";
            // 
            // btClean
            // 
            this.btClean.BackColor = System.Drawing.Color.RoyalBlue;
            this.btClean.FlatAppearance.BorderSize = 0;
            this.btClean.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClean.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btClean.Location = new System.Drawing.Point(101, 222);
            this.btClean.Name = "btClean";
            this.btClean.Size = new System.Drawing.Size(86, 23);
            this.btClean.TabIndex = 16;
            this.btClean.Text = "Limpar";
            this.btClean.UseVisualStyleBackColor = false;
            this.btClean.Click += new System.EventHandler(this.btClean_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btAlterar.Enabled = false;
            this.btAlterar.FlatAppearance.BorderSize = 0;
            this.btAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlterar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btAlterar.Location = new System.Drawing.Point(9, 222);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(86, 23);
            this.btAlterar.TabIndex = 15;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = false;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btGenerate
            // 
            this.btGenerate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btGenerate.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btGenerate.FlatAppearance.BorderSize = 0;
            this.btGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGenerate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btGenerate.Location = new System.Drawing.Point(193, 222);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(152, 23);
            this.btGenerate.TabIndex = 14;
            this.btGenerate.Text = "Gerar Dados";
            this.btGenerate.UseVisualStyleBackColor = false;
            this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click);
            // 
            // tbCargo
            // 
            this.tbCargo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbCargo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbCargo.Location = new System.Drawing.Point(68, 102);
            this.tbCargo.Name = "tbCargo";
            this.tbCargo.Size = new System.Drawing.Size(277, 20);
            this.tbCargo.TabIndex = 13;
            // 
            // cbLocal
            // 
            this.cbLocal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbLocal.FormattingEnabled = true;
            this.cbLocal.Location = new System.Drawing.Point(68, 74);
            this.cbLocal.Name = "cbLocal";
            this.cbLocal.Size = new System.Drawing.Size(277, 21);
            this.cbLocal.TabIndex = 12;
            // 
            // cbEmail
            // 
            this.cbEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbEmail.FormattingEnabled = true;
            this.cbEmail.Location = new System.Drawing.Point(185, 44);
            this.cbEmail.Name = "cbEmail";
            this.cbEmail.Size = new System.Drawing.Size(160, 21);
            this.cbEmail.TabIndex = 11;
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbEmail.Enabled = false;
            this.tbEmail.Location = new System.Drawing.Point(68, 45);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(110, 20);
            this.tbEmail.TabIndex = 10;
            // 
            // checkEmail
            // 
            this.checkEmail.AutoSize = true;
            this.checkEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkEmail.Location = new System.Drawing.Point(50, 49);
            this.checkEmail.Name = "checkEmail";
            this.checkEmail.Size = new System.Drawing.Size(12, 11);
            this.checkEmail.TabIndex = 9;
            this.checkEmail.UseVisualStyleBackColor = true;
            this.checkEmail.CheckedChanged += new System.EventHandler(this.checkEmail_CheckedChanged);
            // 
            // tbNome
            // 
            this.tbNome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbNome.Location = new System.Drawing.Point(68, 19);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(277, 20);
            this.tbNome.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(6, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cargo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Local";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // MenuBar
            // 
            this.MenuBar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatóriosToolStripMenuItem});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(375, 25);
            this.MenuBar.TabIndex = 2;
            this.MenuBar.Text = "menuStrip1";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarLogMenuItem});
            this.relatóriosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relatóriosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.relatóriosToolStripMenuItem.Text = "Menu";
            // 
            // consultarLogMenuItem
            // 
            this.consultarLogMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultarLogMenuItem.Name = "consultarLogMenuItem";
            this.consultarLogMenuItem.Size = new System.Drawing.Size(210, 22);
            this.consultarLogMenuItem.Text = "Consultar Arquivo de Log";
            this.consultarLogMenuItem.Click += new System.EventHandler(this.consultarLogMenuItem_Click);
            // 
            // tbReturn
            // 
            this.tbReturn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbReturn.Location = new System.Drawing.Point(12, 345);
            this.tbReturn.Multiline = true;
            this.tbReturn.Name = "tbReturn";
            this.tbReturn.ReadOnly = true;
            this.tbReturn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbReturn.Size = new System.Drawing.Size(351, 195);
            this.tbReturn.TabIndex = 3;
            // 
            // btFechar
            // 
            this.btFechar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btFechar.FlatAppearance.BorderSize = 0;
            this.btFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFechar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btFechar.Location = new System.Drawing.Point(228, 546);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(135, 23);
            this.btFechar.TabIndex = 11;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = false;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // btCopy
            // 
            this.btCopy.BackColor = System.Drawing.Color.RoyalBlue;
            this.btCopy.FlatAppearance.BorderSize = 0;
            this.btCopy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCopy.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btCopy.Location = new System.Drawing.Point(12, 546);
            this.btCopy.Name = "btCopy";
            this.btCopy.Size = new System.Drawing.Size(210, 23);
            this.btCopy.TabIndex = 12;
            this.btCopy.Text = "Copiar para área de transferência";
            this.btCopy.UseVisualStyleBackColor = false;
            this.btCopy.Click += new System.EventHandler(this.btCopy_Click);
            // 
            // statusBar
            // 
            this.statusBar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 572);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(375, 22);
            this.statusBar.TabIndex = 13;
            this.statusBar.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(152, 17);
            this.statusLabel.Text = "Criado por Denner Parreiras";
            this.statusLabel.Click += new System.EventHandler(this.statusLabel_Click);
            // 
            // btUserExists
            // 
            this.btUserExists.BackColor = System.Drawing.Color.RoyalBlue;
            this.btUserExists.FlatAppearance.BorderSize = 0;
            this.btUserExists.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btUserExists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUserExists.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUserExists.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btUserExists.Location = new System.Drawing.Point(6, 10);
            this.btUserExists.Name = "btUserExists";
            this.btUserExists.Size = new System.Drawing.Size(160, 23);
            this.btUserExists.TabIndex = 17;
            this.btUserExists.Text = "Usuário já existe";
            this.btUserExists.UseVisualStyleBackColor = false;
            this.btUserExists.Click += new System.EventHandler(this.btUserExists_Click);
            // 
            // groupActions
            // 
            this.groupActions.Controls.Add(this.btCancelReg);
            this.groupActions.Controls.Add(this.btUserExists);
            this.groupActions.Enabled = false;
            this.groupActions.Location = new System.Drawing.Point(12, 301);
            this.groupActions.Name = "groupActions";
            this.groupActions.Size = new System.Drawing.Size(351, 38);
            this.groupActions.TabIndex = 18;
            this.groupActions.TabStop = false;
            // 
            // btCancelReg
            // 
            this.btCancelReg.BackColor = System.Drawing.Color.RoyalBlue;
            this.btCancelReg.FlatAppearance.BorderSize = 0;
            this.btCancelReg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btCancelReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelReg.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btCancelReg.Location = new System.Drawing.Point(185, 10);
            this.btCancelReg.Name = "btCancelReg";
            this.btCancelReg.Size = new System.Drawing.Size(160, 23);
            this.btCancelReg.TabIndex = 18;
            this.btCancelReg.Text = "Cancelar Registro";
            this.btCancelReg.UseVisualStyleBackColor = false;
            this.btCancelReg.Click += new System.EventHandler(this.btCancelReg_Click);
            // 
            // btHide
            // 
            this.btHide.BackColor = System.Drawing.Color.RoyalBlue;
            this.btHide.FlatAppearance.BorderSize = 0;
            this.btHide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHide.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btHide.Location = new System.Drawing.Point(12, 284);
            this.btHide.Name = "btHide";
            this.btHide.Size = new System.Drawing.Size(153, 21);
            this.btHide.TabIndex = 20;
            this.btHide.Text = "Exibir Opções de Log";
            this.btHide.UseVisualStyleBackColor = false;
            this.btHide.Click += new System.EventHandler(this.btHide_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(6, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "CPF";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(6, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "OBS.";
            // 
            // mtbCPF
            // 
            this.mtbCPF.Enabled = false;
            this.mtbCPF.Location = new System.Drawing.Point(68, 128);
            this.mtbCPF.Mask = "000.000.000-00";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(110, 20);
            this.mtbCPF.TabIndex = 21;
            this.mtbCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbObservacoes
            // 
            this.tbObservacoes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbObservacoes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbObservacoes.Enabled = false;
            this.tbObservacoes.Location = new System.Drawing.Point(68, 154);
            this.tbObservacoes.Multiline = true;
            this.tbObservacoes.Name = "tbObservacoes";
            this.tbObservacoes.Size = new System.Drawing.Size(277, 62);
            this.tbObservacoes.TabIndex = 22;
            // 
            // checkCPF
            // 
            this.checkCPF.AutoSize = true;
            this.checkCPF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkCPF.Location = new System.Drawing.Point(50, 133);
            this.checkCPF.Name = "checkCPF";
            this.checkCPF.Size = new System.Drawing.Size(12, 11);
            this.checkCPF.TabIndex = 23;
            this.checkCPF.UseVisualStyleBackColor = true;
            this.checkCPF.CheckedChanged += new System.EventHandler(this.checkCPF_CheckedChanged);
            // 
            // checkObservacao
            // 
            this.checkObservacao.AutoSize = true;
            this.checkObservacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkObservacao.Location = new System.Drawing.Point(50, 159);
            this.checkObservacao.Name = "checkObservacao";
            this.checkObservacao.Size = new System.Drawing.Size(12, 11);
            this.checkObservacao.TabIndex = 24;
            this.checkObservacao.UseVisualStyleBackColor = true;
            this.checkObservacao.CheckedChanged += new System.EventHandler(this.checkObservacao_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(375, 594);
            this.Controls.Add(this.btHide);
            this.Controls.Add(this.groupActions);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.btCopy);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.tbReturn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MenuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuBar;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Gerador de Usuários - Grupo ATERPA";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.groupActions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.TextBox tbReturn;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Button btCopy;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Button btClean;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btGenerate;
        private System.Windows.Forms.TextBox tbCargo;
        private System.Windows.Forms.ComboBox cbLocal;
        private System.Windows.Forms.ComboBox cbEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.CheckBox checkEmail;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarLogMenuItem;
        private System.Windows.Forms.Button btUserExists;
        private System.Windows.Forms.GroupBox groupActions;
        private System.Windows.Forms.Button btCancelReg;
        private System.Windows.Forms.Button btHide;
        private System.Windows.Forms.TextBox tbObservacoes;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkCPF;
        private System.Windows.Forms.CheckBox checkObservacao;
    }
}

