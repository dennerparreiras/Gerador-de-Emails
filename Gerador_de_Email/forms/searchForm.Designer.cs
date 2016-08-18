namespace Gerador_de_Email.forms
{
    partial class searchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progress = new System.Windows.Forms.ToolStripProgressBar();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.checkExibirSenha = new System.Windows.Forms.CheckBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.checkObservacoes = new System.Windows.Forms.CheckBox();
            this.checkCargo = new System.Windows.Forms.CheckBox();
            this.checkLocal = new System.Windows.Forms.CheckBox();
            this.checkUsuario = new System.Windows.Forms.CheckBox();
            this.checkCPF = new System.Windows.Forms.CheckBox();
            this.checkNome = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbObservacoes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCargo = new System.Windows.Forms.TextBox();
            this.tbLocal = new System.Windows.Forms.TextBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tabela_DGV = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabela_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.checkExibirSenha);
            this.panel1.Controls.Add(this.btSearch);
            this.panel1.Controls.Add(this.checkObservacoes);
            this.panel1.Controls.Add(this.checkCargo);
            this.panel1.Controls.Add(this.checkLocal);
            this.panel1.Controls.Add(this.checkUsuario);
            this.panel1.Controls.Add(this.checkCPF);
            this.panel1.Controls.Add(this.checkNome);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbObservacoes);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbCargo);
            this.panel1.Controls.Add(this.tbLocal);
            this.panel1.Controls.Add(this.tbUsuario);
            this.panel1.Controls.Add(this.mtbCPF);
            this.panel1.Controls.Add(this.tbNome);
            this.panel1.Controls.Add(this.tabela_DGV);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 479);
            this.panel1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.MidnightBlue;
            this.statusStrip1.BackgroundImage = global::Gerador_de_Email.Properties.Resources.big_bar2;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progress,
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 446);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(19, 0, 1, 0);
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(1083, 33);
            this.statusStrip1.TabIndex = 50;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progress
            // 
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(133, 27);
            // 
            // status
            // 
            this.status.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.status.ForeColor = System.Drawing.Color.White;
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(132, 28);
            this.status.Text = "Buscar usuários";
            // 
            // checkExibirSenha
            // 
            this.checkExibirSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkExibirSenha.AutoSize = true;
            this.checkExibirSenha.FlatAppearance.BorderSize = 0;
            this.checkExibirSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkExibirSenha.Location = new System.Drawing.Point(953, 155);
            this.checkExibirSenha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkExibirSenha.Name = "checkExibirSenha";
            this.checkExibirSenha.Size = new System.Drawing.Size(110, 21);
            this.checkExibirSenha.TabIndex = 49;
            this.checkExibirSenha.Text = "Exibir senhas";
            this.checkExibirSenha.UseVisualStyleBackColor = true;
            this.checkExibirSenha.CheckedChanged += new System.EventHandler(this.btSearch_Click);
            this.checkExibirSenha.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btSearch
            // 
            this.btSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btSearch.BackColor = System.Drawing.Color.DarkRed;
            this.btSearch.BackgroundImage = global::Gerador_de_Email.Properties.Resources.red_silk;
            this.btSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btSearch.Location = new System.Drawing.Point(473, 123);
            this.btSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(143, 53);
            this.btSearch.TabIndex = 48;
            this.btSearch.Text = "Buscar Usuário";
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // checkObservacoes
            // 
            this.checkObservacoes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkObservacoes.AutoSize = true;
            this.checkObservacoes.FlatAppearance.BorderSize = 0;
            this.checkObservacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkObservacoes.Location = new System.Drawing.Point(743, 57);
            this.checkObservacoes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkObservacoes.Name = "checkObservacoes";
            this.checkObservacoes.Size = new System.Drawing.Size(14, 13);
            this.checkObservacoes.TabIndex = 20;
            this.checkObservacoes.UseVisualStyleBackColor = true;
            this.checkObservacoes.CheckedChanged += new System.EventHandler(this.Check_All);
            this.checkObservacoes.Click += new System.EventHandler(this.Check_All);
            // 
            // checkCargo
            // 
            this.checkCargo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkCargo.AutoSize = true;
            this.checkCargo.FlatAppearance.BorderSize = 0;
            this.checkCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkCargo.Location = new System.Drawing.Point(743, 95);
            this.checkCargo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkCargo.Name = "checkCargo";
            this.checkCargo.Size = new System.Drawing.Size(14, 13);
            this.checkCargo.TabIndex = 19;
            this.checkCargo.UseVisualStyleBackColor = true;
            this.checkCargo.CheckedChanged += new System.EventHandler(this.Check_All);
            this.checkCargo.Click += new System.EventHandler(this.Check_All);
            // 
            // checkLocal
            // 
            this.checkLocal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkLocal.AutoSize = true;
            this.checkLocal.FlatAppearance.BorderSize = 0;
            this.checkLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkLocal.Location = new System.Drawing.Point(77, 89);
            this.checkLocal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkLocal.Name = "checkLocal";
            this.checkLocal.Size = new System.Drawing.Size(14, 13);
            this.checkLocal.TabIndex = 18;
            this.checkLocal.UseVisualStyleBackColor = true;
            this.checkLocal.CheckedChanged += new System.EventHandler(this.Check_All);
            this.checkLocal.Click += new System.EventHandler(this.Check_All);
            // 
            // checkUsuario
            // 
            this.checkUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkUsuario.AutoSize = true;
            this.checkUsuario.FlatAppearance.BorderSize = 0;
            this.checkUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkUsuario.Location = new System.Drawing.Point(412, 95);
            this.checkUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkUsuario.Name = "checkUsuario";
            this.checkUsuario.Size = new System.Drawing.Size(14, 13);
            this.checkUsuario.TabIndex = 17;
            this.checkUsuario.UseVisualStyleBackColor = true;
            this.checkUsuario.CheckedChanged += new System.EventHandler(this.Check_All);
            this.checkUsuario.Click += new System.EventHandler(this.Check_All);
            // 
            // checkCPF
            // 
            this.checkCPF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkCPF.AutoSize = true;
            this.checkCPF.FlatAppearance.BorderSize = 0;
            this.checkCPF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkCPF.Location = new System.Drawing.Point(412, 57);
            this.checkCPF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkCPF.Name = "checkCPF";
            this.checkCPF.Size = new System.Drawing.Size(14, 13);
            this.checkCPF.TabIndex = 16;
            this.checkCPF.UseVisualStyleBackColor = true;
            this.checkCPF.CheckedChanged += new System.EventHandler(this.Check_All);
            this.checkCPF.Click += new System.EventHandler(this.Check_All);
            // 
            // checkNome
            // 
            this.checkNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkNome.AutoSize = true;
            this.checkNome.FlatAppearance.BorderSize = 0;
            this.checkNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkNome.Location = new System.Drawing.Point(77, 57);
            this.checkNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkNome.Name = "checkNome";
            this.checkNome.Size = new System.Drawing.Size(14, 13);
            this.checkNome.TabIndex = 15;
            this.checkNome.UseVisualStyleBackColor = true;
            this.checkNome.CheckedChanged += new System.EventHandler(this.Check_All);
            this.checkNome.Click += new System.EventHandler(this.Check_All);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.MidnightBlue;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(16, 16);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Buscar Usuários";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.MidnightBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(627, 55);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Observações";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbObservacoes
            // 
            this.tbObservacoes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbObservacoes.Location = new System.Drawing.Point(771, 53);
            this.tbObservacoes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbObservacoes.Name = "tbObservacoes";
            this.tbObservacoes.ReadOnly = true;
            this.tbObservacoes.Size = new System.Drawing.Size(279, 22);
            this.tbObservacoes.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MidnightBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(681, 95);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cargo";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MidnightBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(16, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Local";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MidnightBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(329, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Usuário";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MidnightBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(329, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "CPF";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(16, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbCargo
            // 
            this.tbCargo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbCargo.Location = new System.Drawing.Point(771, 91);
            this.tbCargo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCargo.Name = "tbCargo";
            this.tbCargo.ReadOnly = true;
            this.tbCargo.Size = new System.Drawing.Size(279, 22);
            this.tbCargo.TabIndex = 6;
            // 
            // tbLocal
            // 
            this.tbLocal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbLocal.Location = new System.Drawing.Point(105, 85);
            this.tbLocal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLocal.Name = "tbLocal";
            this.tbLocal.ReadOnly = true;
            this.tbLocal.Size = new System.Drawing.Size(215, 22);
            this.tbLocal.TabIndex = 5;
            // 
            // tbUsuario
            // 
            this.tbUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbUsuario.Location = new System.Drawing.Point(440, 91);
            this.tbUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.ReadOnly = true;
            this.tbUsuario.Size = new System.Drawing.Size(229, 22);
            this.tbUsuario.TabIndex = 4;
            // 
            // mtbCPF
            // 
            this.mtbCPF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mtbCPF.Location = new System.Drawing.Point(440, 53);
            this.mtbCPF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtbCPF.Mask = "000.000.000-00";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.ReadOnly = true;
            this.mtbCPF.Size = new System.Drawing.Size(175, 22);
            this.mtbCPF.TabIndex = 3;
            this.mtbCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbNome
            // 
            this.tbNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbNome.Location = new System.Drawing.Point(105, 53);
            this.tbNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNome.Name = "tbNome";
            this.tbNome.ReadOnly = true;
            this.tbNome.Size = new System.Drawing.Size(215, 22);
            this.tbNome.TabIndex = 2;
            // 
            // tabela_DGV
            // 
            this.tabela_DGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabela_DGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabela_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela_DGV.Location = new System.Drawing.Point(16, 183);
            this.tabela_DGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabela_DGV.Name = "tabela_DGV";
            this.tabela_DGV.ReadOnly = true;
            this.tabela_DGV.Size = new System.Drawing.Size(1051, 255);
            this.tabela_DGV.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Gerador_de_Email.Properties.Resources.abstract_blue_backgrounds;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1083, 479);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // searchForm
            // 
            this.AcceptButton = this.btSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 479);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1098, 221);
            this.Name = "searchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Relatório - Buscar Usuário";
            this.Load += new System.EventHandler(this.searchForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabela_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbCargo;
        private System.Windows.Forms.TextBox tbLocal;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.DataGridView tabela_DGV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbObservacoes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkObservacoes;
        private System.Windows.Forms.CheckBox checkCargo;
        private System.Windows.Forms.CheckBox checkLocal;
        private System.Windows.Forms.CheckBox checkUsuario;
        private System.Windows.Forms.CheckBox checkCPF;
        private System.Windows.Forms.CheckBox checkNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.CheckBox checkExibirSenha;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.ToolStripProgressBar progress;
    }
}