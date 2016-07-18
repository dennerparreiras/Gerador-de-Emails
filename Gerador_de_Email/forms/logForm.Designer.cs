namespace Gerador_de_Email.forms
{
    partial class logForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logForm));
            this.tbRelaLog = new System.Windows.Forms.TextBox();
            this.btFechaRelat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btCopy = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbRelaLog
            // 
            this.tbRelaLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tbRelaLog.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tbRelaLog.Location = new System.Drawing.Point(27, 12);
            this.tbRelaLog.Multiline = true;
            this.tbRelaLog.Name = "tbRelaLog";
            this.tbRelaLog.ReadOnly = true;
            this.tbRelaLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRelaLog.Size = new System.Drawing.Size(394, 550);
            this.tbRelaLog.TabIndex = 0;
            // 
            // btFechaRelat
            // 
            this.btFechaRelat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btFechaRelat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btFechaRelat.BackgroundImage")));
            this.btFechaRelat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btFechaRelat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFechaRelat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFechaRelat.ForeColor = System.Drawing.Color.White;
            this.btFechaRelat.Location = new System.Drawing.Point(308, 566);
            this.btFechaRelat.Name = "btFechaRelat";
            this.btFechaRelat.Size = new System.Drawing.Size(113, 29);
            this.btFechaRelat.TabIndex = 1;
            this.btFechaRelat.Text = "Fechar Relatório";
            this.btFechaRelat.UseVisualStyleBackColor = true;
            this.btFechaRelat.Click += new System.EventHandler(this.btFechaRelat_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btCopy);
            this.panel1.Controls.Add(this.tbRelaLog);
            this.panel1.Controls.Add(this.btFechaRelat);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 607);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Gerador_de_Email.Properties.Resources.abstract_blue_backgrounds;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(451, 607);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btCopy
            // 
            this.btCopy.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btCopy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btCopy.BackgroundImage")));
            this.btCopy.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCopy.ForeColor = System.Drawing.Color.White;
            this.btCopy.Location = new System.Drawing.Point(27, 566);
            this.btCopy.Name = "btCopy";
            this.btCopy.Size = new System.Drawing.Size(275, 29);
            this.btCopy.TabIndex = 3;
            this.btCopy.Text = "Copiar para a área de transferência";
            this.btCopy.UseVisualStyleBackColor = true;
            this.btCopy.Click += new System.EventHandler(this.btCopy_Click);
            // 
            // logForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 607);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "logForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consuta de Log";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbRelaLog;
        private System.Windows.Forms.Button btFechaRelat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btCopy;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}