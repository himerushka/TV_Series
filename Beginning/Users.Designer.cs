namespace Beginning
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.tBLog = new System.Windows.Forms.TextBox();
            this.tBPass = new System.Windows.Forms.TextBox();
            this.lblLog = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBLog
            // 
            this.tBLog.Location = new System.Drawing.Point(152, 6);
            this.tBLog.Name = "tBLog";
            this.tBLog.Size = new System.Drawing.Size(136, 22);
            this.tBLog.TabIndex = 0;
            this.tBLog.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tBPass
            // 
            this.tBPass.Location = new System.Drawing.Point(152, 42);
            this.tBPass.Name = "tBPass";
            this.tBPass.Size = new System.Drawing.Size(136, 22);
            this.tBPass.TabIndex = 1;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(12, 9);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(51, 17);
            this.lblLog.TabIndex = 2;
            this.lblLog.Text = "Логин:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(12, 43);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(61, 17);
            this.lblPass.TabIndex = 3;
            this.lblPass.Text = "Пароль:";
            this.lblPass.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnOK
            // 
            this.btnOK.AutoSize = true;
            this.btnOK.Location = new System.Drawing.Point(152, 76);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(104, 27);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "Подтвердить";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 115);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.tBPass);
            this.Controls.Add(this.tBLog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение пользователя";
            this.Load += new System.EventHandler(this.Users_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBLog;
        private System.Windows.Forms.TextBox tBPass;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Button btnOK;
    }
}