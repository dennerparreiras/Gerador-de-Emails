namespace Gerador_de_Email.forms
{
    partial class ParametersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParametersForm));
            this.label1 = new System.Windows.Forms.Label();
            this.tbDominio = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbIcone = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLocal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checkGenerateEnter = new System.Windows.Forms.CheckBox();
            this.checkDeleteUserBt = new System.Windows.Forms.CheckBox();
            this.checkAdm = new System.Windows.Forms.CheckBox();
            this.checkMinim = new System.Windows.Forms.CheckBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbRandom = new System.Windows.Forms.RadioButton();
            this.rbOrdered = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btDefaultPass = new System.Windows.Forms.Button();
            this.tbCharEspecial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numCharEspeciais = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numNumeros = new System.Windows.Forms.NumericUpDown();
            this.numLetras = new System.Windows.Forms.NumericUpDown();
            this.groupBoxAD = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbADpath = new System.Windows.Forms.TextBox();
            this.tbADdominio = new System.Windows.Forms.TextBox();
            this.tbADuser = new System.Windows.Forms.TextBox();
            this.tbADpasswd = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCharEspeciais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLetras)).BeginInit();
            this.groupBoxAD.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de domínios";
            // 
            // tbDominio
            // 
            this.tbDominio.Location = new System.Drawing.Point(133, 28);
            this.tbDominio.Name = "tbDominio";
            this.tbDominio.Size = new System.Drawing.Size(298, 20);
            this.tbDominio.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Navy;
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button11);
            this.groupBox1.Controls.Add(this.button12);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbIcone);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbLog);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbUsuario);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbLocal);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbDominio);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 194);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Locais dos arquivos do sistema";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(437, 159);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(156, 23);
            this.button7.TabIndex = 20;
            this.button7.Text = "Default";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.AllDefault);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button11.BackgroundImage")));
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(518, 130);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 19;
            this.button11.Text = "Default";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.DefaultIcone);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button12.BackgroundImage")));
            this.button12.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Location = new System.Drawing.Point(437, 130);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 18;
            this.button12.Text = "Verificar";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.VerificarIcone);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Arquivo de Ícone";
            // 
            // tbIcone
            // 
            this.tbIcone.Location = new System.Drawing.Point(133, 132);
            this.tbIcone.Name = "tbIcone";
            this.tbIcone.Size = new System.Drawing.Size(298, 20);
            this.tbIcone.TabIndex = 17;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button9.BackgroundImage")));
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(518, 104);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 15;
            this.button9.Text = "Default";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.DefaultLog);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button10.BackgroundImage")));
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(437, 104);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 14;
            this.button10.Text = "Verificar";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.VerificarLog);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Arquivo de Log";
            // 
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(133, 106);
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(298, 20);
            this.tbLog.TabIndex = 13;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(518, 78);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 11;
            this.button6.Text = "Default";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.DefaultUsuarios);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(518, 52);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Default";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.DefaultLocal);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(518, 26);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Default";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.DefaultDominio);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(437, 78);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Verificar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.VerificarUsuarios);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Arquivo de usuários";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(133, 80);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(298, 20);
            this.tbUsuario.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(437, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Verificar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.VerificarLocais);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lista de locais";
            // 
            // tbLocal
            // 
            this.tbLocal.Location = new System.Drawing.Point(133, 54);
            this.tbLocal.Name = "tbLocal";
            this.tbLocal.Size = new System.Drawing.Size(298, 20);
            this.tbLocal.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(437, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Verificar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.VerificarDominio);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Navy;
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.checkGenerateEnter);
            this.groupBox2.Controls.Add(this.checkDeleteUserBt);
            this.groupBox2.Controls.Add(this.checkAdm);
            this.groupBox2.Controls.Add(this.checkMinim);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 351);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 140);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Outras opções";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label10.Location = new System.Drawing.Point(22, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(239, 12);
            this.label10.TabIndex = 2;
            this.label10.Text = "(É necessário reiniciar o programa para ativar esta opção)";
            // 
            // checkGenerateEnter
            // 
            this.checkGenerateEnter.AutoSize = true;
            this.checkGenerateEnter.Location = new System.Drawing.Point(24, 93);
            this.checkGenerateEnter.Name = "checkGenerateEnter";
            this.checkGenerateEnter.Size = new System.Drawing.Size(242, 17);
            this.checkGenerateEnter.TabIndex = 1;
            this.checkGenerateEnter.Text = "Gerar dados de usuário pressionando ENTER";
            this.checkGenerateEnter.UseVisualStyleBackColor = true;
            // 
            // checkDeleteUserBt
            // 
            this.checkDeleteUserBt.AutoSize = true;
            this.checkDeleteUserBt.Location = new System.Drawing.Point(24, 70);
            this.checkDeleteUserBt.Name = "checkDeleteUserBt";
            this.checkDeleteUserBt.Size = new System.Drawing.Size(174, 17);
            this.checkDeleteUserBt.TabIndex = 1;
            this.checkDeleteUserBt.Text = "Ocultar botão \"Apagar usuário\"";
            this.checkDeleteUserBt.UseVisualStyleBackColor = true;
            // 
            // checkAdm
            // 
            this.checkAdm.AutoSize = true;
            this.checkAdm.Location = new System.Drawing.Point(24, 47);
            this.checkAdm.Name = "checkAdm";
            this.checkAdm.Size = new System.Drawing.Size(212, 17);
            this.checkAdm.TabIndex = 1;
            this.checkAdm.Text = "Iniciar sempre no \"Modo Administrador\"";
            this.checkAdm.UseVisualStyleBackColor = true;
            // 
            // checkMinim
            // 
            this.checkMinim.AutoSize = true;
            this.checkMinim.Location = new System.Drawing.Point(24, 24);
            this.checkMinim.Name = "checkMinim";
            this.checkMinim.Size = new System.Drawing.Size(180, 17);
            this.checkMinim.TabIndex = 0;
            this.checkMinim.Text = "Minimizar sempre para a bandeja";
            this.checkMinim.UseVisualStyleBackColor = true;
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSalvar.BackgroundImage")));
            this.btSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.ForeColor = System.Drawing.Color.White;
            this.btSalvar.Location = new System.Drawing.Point(463, 468);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(155, 23);
            this.btSalvar.TabIndex = 12;
            this.btSalvar.Text = "Salvar alterações";
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.Salvar);
            // 
            // btCancelar
            // 
            this.btCancelar.BackgroundImage = global::Gerador_de_Email.Properties.Resources.red_silk;
            this.btCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.ForeColor = System.Drawing.Color.White;
            this.btCancelar.Location = new System.Drawing.Point(342, 468);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(115, 23);
            this.btCancelar.TabIndex = 13;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.Cancelar);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Navy;
            this.groupBox3.Controls.Add(this.rbRandom);
            this.groupBox3.Controls.Add(this.rbOrdered);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(9, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(261, 67);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Aleatoriedade das Senhas";
            // 
            // rbRandom
            // 
            this.rbRandom.AutoSize = true;
            this.rbRandom.Location = new System.Drawing.Point(21, 42);
            this.rbRandom.Name = "rbRandom";
            this.rbRandom.Size = new System.Drawing.Size(66, 17);
            this.rbRandom.TabIndex = 8;
            this.rbRandom.Text = "Aleatório";
            this.rbRandom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbRandom.UseVisualStyleBackColor = true;
            // 
            // rbOrdered
            // 
            this.rbOrdered.AutoSize = true;
            this.rbOrdered.Checked = true;
            this.rbOrdered.Location = new System.Drawing.Point(21, 19);
            this.rbOrdered.Name = "rbOrdered";
            this.rbOrdered.Size = new System.Drawing.Size(72, 17);
            this.rbOrdered.TabIndex = 7;
            this.rbOrdered.TabStop = true;
            this.rbOrdered.Text = "Ordenado";
            this.rbOrdered.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbOrdered.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Navy;
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.btDefaultPass);
            this.groupBox4.Controls.Add(this.tbCharEspecial);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.numCharEspeciais);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.numNumeros);
            this.groupBox4.Controls.Add(this.numLetras);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(341, 212);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(276, 250);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Opções de Senha";
            // 
            // btDefaultPass
            // 
            this.btDefaultPass.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btDefaultPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btDefaultPass.BackgroundImage")));
            this.btDefaultPass.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btDefaultPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDefaultPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDefaultPass.ForeColor = System.Drawing.Color.White;
            this.btDefaultPass.Location = new System.Drawing.Point(195, 196);
            this.btDefaultPass.Name = "btDefaultPass";
            this.btDefaultPass.Size = new System.Drawing.Size(75, 36);
            this.btDefaultPass.TabIndex = 20;
            this.btDefaultPass.Text = "Default";
            this.btDefaultPass.UseVisualStyleBackColor = false;
            this.btDefaultPass.Click += new System.EventHandler(this.ResetPassConfig);
            // 
            // tbCharEspecial
            // 
            this.tbCharEspecial.Location = new System.Drawing.Point(9, 212);
            this.tbCharEspecial.Name = "tbCharEspecial";
            this.tbCharEspecial.Size = new System.Drawing.Size(180, 20);
            this.tbCharEspecial.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Caracteres especiais utilizados:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(18, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Qtde. de Car. Especiais";
            // 
            // numCharEspeciais
            // 
            this.numCharEspeciais.BackColor = System.Drawing.Color.Wheat;
            this.numCharEspeciais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numCharEspeciais.Location = new System.Drawing.Point(180, 159);
            this.numCharEspeciais.Name = "numCharEspeciais";
            this.numCharEspeciais.Size = new System.Drawing.Size(72, 20);
            this.numCharEspeciais.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(18, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Quantidade de Números";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(18, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Quantidade de Letras";
            // 
            // numNumeros
            // 
            this.numNumeros.BackColor = System.Drawing.Color.Wheat;
            this.numNumeros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numNumeros.Location = new System.Drawing.Point(180, 133);
            this.numNumeros.Name = "numNumeros";
            this.numNumeros.Size = new System.Drawing.Size(72, 20);
            this.numNumeros.TabIndex = 2;
            this.numNumeros.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numLetras
            // 
            this.numLetras.BackColor = System.Drawing.Color.Wheat;
            this.numLetras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numLetras.Location = new System.Drawing.Point(180, 107);
            this.numLetras.Name = "numLetras";
            this.numLetras.Size = new System.Drawing.Size(72, 20);
            this.numLetras.TabIndex = 1;
            this.numLetras.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // groupBoxAD
            // 
            this.groupBoxAD.BackColor = System.Drawing.Color.Navy;
            this.groupBoxAD.Controls.Add(this.tbADpasswd);
            this.groupBoxAD.Controls.Add(this.tbADuser);
            this.groupBoxAD.Controls.Add(this.tbADdominio);
            this.groupBoxAD.Controls.Add(this.tbADpath);
            this.groupBoxAD.Controls.Add(this.label14);
            this.groupBoxAD.Controls.Add(this.label13);
            this.groupBoxAD.Controls.Add(this.label12);
            this.groupBoxAD.Controls.Add(this.label11);
            this.groupBoxAD.ForeColor = System.Drawing.Color.White;
            this.groupBoxAD.Location = new System.Drawing.Point(12, 212);
            this.groupBoxAD.Name = "groupBoxAD";
            this.groupBoxAD.Size = new System.Drawing.Size(323, 133);
            this.groupBoxAD.TabIndex = 3;
            this.groupBoxAD.TabStop = false;
            this.groupBoxAD.Text = "Opções do Active Directory";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Caminho";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Usuário";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Senha";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Dominio";
            // 
            // tbADpath
            // 
            this.tbADpath.Location = new System.Drawing.Point(71, 19);
            this.tbADpath.Name = "tbADpath";
            this.tbADpath.Size = new System.Drawing.Size(225, 20);
            this.tbADpath.TabIndex = 21;
            // 
            // tbADdominio
            // 
            this.tbADdominio.Location = new System.Drawing.Point(71, 45);
            this.tbADdominio.Name = "tbADdominio";
            this.tbADdominio.Size = new System.Drawing.Size(225, 20);
            this.tbADdominio.TabIndex = 21;
            // 
            // tbADuser
            // 
            this.tbADuser.Location = new System.Drawing.Point(71, 71);
            this.tbADuser.Name = "tbADuser";
            this.tbADuser.Size = new System.Drawing.Size(225, 20);
            this.tbADuser.TabIndex = 21;
            // 
            // tbADpasswd
            // 
            this.tbADpasswd.Location = new System.Drawing.Point(71, 97);
            this.tbADpasswd.Name = "tbADpasswd";
            this.tbADpasswd.PasswordChar = '●';
            this.tbADpasswd.Size = new System.Drawing.Size(225, 20);
            this.tbADpasswd.TabIndex = 22;
            // 
            // ParametersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gerador_de_Email.Properties.Resources.abstract_blue_backgrounds;
            this.ClientSize = new System.Drawing.Size(630, 503);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.groupBoxAD);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ParametersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Parâmetros do Sistema - FLUXUS";
            this.Load += new System.EventHandler(this.ParametersForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCharEspeciais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLetras)).EndInit();
            this.groupBoxAD.ResumeLayout(false);
            this.groupBoxAD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDominio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLocal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkAdm;
        private System.Windows.Forms.CheckBox checkMinim;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbIcone;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbRandom;
        private System.Windows.Forms.RadioButton rbOrdered;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbCharEspecial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numCharEspeciais;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numNumeros;
        private System.Windows.Forms.NumericUpDown numLetras;
        private System.Windows.Forms.Button btDefaultPass;
        private System.Windows.Forms.CheckBox checkDeleteUserBt;
        private System.Windows.Forms.CheckBox checkGenerateEnter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBoxAD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox tbADpasswd;
        private System.Windows.Forms.TextBox tbADuser;
        private System.Windows.Forms.TextBox tbADdominio;
        private System.Windows.Forms.TextBox tbADpath;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}