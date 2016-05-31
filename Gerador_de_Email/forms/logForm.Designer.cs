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
            this.SuspendLayout();
            // 
            // tbRelaLog
            // 
            this.tbRelaLog.Location = new System.Drawing.Point(1, -2);
            this.tbRelaLog.Multiline = true;
            this.tbRelaLog.Name = "tbRelaLog";
            this.tbRelaLog.ReadOnly = true;
            this.tbRelaLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRelaLog.Size = new System.Drawing.Size(394, 550);
            this.tbRelaLog.TabIndex = 0;
            // 
            // btFechaRelat
            // 
            this.btFechaRelat.Location = new System.Drawing.Point(1, 544);
            this.btFechaRelat.Name = "btFechaRelat";
            this.btFechaRelat.Size = new System.Drawing.Size(394, 29);
            this.btFechaRelat.TabIndex = 1;
            this.btFechaRelat.Text = "Fechar Relatório";
            this.btFechaRelat.UseVisualStyleBackColor = true;
            this.btFechaRelat.Click += new System.EventHandler(this.btFechaRelat_Click);
            // 
            // logForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 574);
            this.Controls.Add(this.btFechaRelat);
            this.Controls.Add(this.tbRelaLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "logForm";
            this.Text = "Consuta de Log";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRelaLog;
        private System.Windows.Forms.Button btFechaRelat;
    }
}