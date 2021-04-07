namespace GiaoDien
{
    partial class EditUser
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkPassExpired = new System.Windows.Forms.CheckBox();
            this.checkOperatingSys = new System.Windows.Forms.CheckBox();
            this.checkLock = new System.Windows.Forms.CheckBox();
            this.checkEdition = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.defaultTablespace = new System.Windows.Forms.ComboBox();
            this.tempTablespace = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 448);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.tempTablespace);
            this.tabPage2.Controls.Add(this.defaultTablespace);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.checkEdition);
            this.tabPage2.Controls.Add(this.checkLock);
            this.tabPage2.Controls.Add(this.checkOperatingSys);
            this.tabPage2.Controls.Add(this.checkPassExpired);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtConfirmPass);
            this.tabPage2.Controls.Add(this.txtNewPass);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtUserName);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(791, 419);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "User";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(791, 419);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(791, 419);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Enabled = false;
            this.txtUserName.Location = new System.Drawing.Point(174, 7);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(350, 22);
            this.txtUserName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "New Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(174, 53);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(350, 22);
            this.txtNewPass.TabIndex = 3;
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(174, 81);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(350, 22);
            this.txtConfirmPass.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirm Password";
            // 
            // checkPassExpired
            // 
            this.checkPassExpired.AutoSize = true;
            this.checkPassExpired.Location = new System.Drawing.Point(15, 117);
            this.checkPassExpired.Name = "checkPassExpired";
            this.checkPassExpired.Size = new System.Drawing.Size(333, 21);
            this.checkPassExpired.TabIndex = 6;
            this.checkPassExpired.Text = "Password Expired (user must change next login)";
            this.checkPassExpired.UseVisualStyleBackColor = true;
            // 
            // checkOperatingSys
            // 
            this.checkOperatingSys.AutoSize = true;
            this.checkOperatingSys.Location = new System.Drawing.Point(15, 145);
            this.checkOperatingSys.Name = "checkOperatingSys";
            this.checkOperatingSys.Size = new System.Drawing.Size(177, 21);
            this.checkOperatingSys.TabIndex = 7;
            this.checkOperatingSys.Text = "Operating System User\r\n";
            this.checkOperatingSys.UseVisualStyleBackColor = true;
            // 
            // checkLock
            // 
            this.checkLock.AutoSize = true;
            this.checkLock.Location = new System.Drawing.Point(15, 173);
            this.checkLock.Name = "checkLock";
            this.checkLock.Size = new System.Drawing.Size(145, 21);
            this.checkLock.TabIndex = 8;
            this.checkLock.Text = "Account is Locked";
            this.checkLock.UseVisualStyleBackColor = true;
            // 
            // checkEdition
            // 
            this.checkEdition.AutoSize = true;
            this.checkEdition.Location = new System.Drawing.Point(15, 200);
            this.checkEdition.Name = "checkEdition";
            this.checkEdition.Size = new System.Drawing.Size(129, 21);
            this.checkEdition.TabIndex = 9;
            this.checkEdition.Text = "Edition Enabled";
            this.checkEdition.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Default Tablespace";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Temporary Tablespace";
            // 
            // defaultTablespace
            // 
            this.defaultTablespace.FormattingEnabled = true;
            this.defaultTablespace.Items.AddRange(new object[] {
            "USERS",
            "SYSAUX",
            "SYSTEM",
            "TEMP",
            "UNDOTBS1"});
            this.defaultTablespace.Location = new System.Drawing.Point(174, 232);
            this.defaultTablespace.Name = "defaultTablespace";
            this.defaultTablespace.Size = new System.Drawing.Size(350, 24);
            this.defaultTablespace.TabIndex = 12;
            this.defaultTablespace.Text = "USERS";
            // 
            // tempTablespace
            // 
            this.tempTablespace.FormattingEnabled = true;
            this.tempTablespace.Items.AddRange(new object[] {
            "TEMP"});
            this.tempTablespace.Location = new System.Drawing.Point(174, 262);
            this.tempTablespace.Name = "tempTablespace";
            this.tempTablespace.Size = new System.Drawing.Size(350, 24);
            this.tempTablespace.TabIndex = 13;
            this.tempTablespace.Text = "TEMP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 14;
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "EditUser";
            this.Text = "EditUser";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.CheckBox checkEdition;
        private System.Windows.Forms.CheckBox checkLock;
        private System.Windows.Forms.CheckBox checkOperatingSys;
        private System.Windows.Forms.CheckBox checkPassExpired;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox tempTablespace;
        private System.Windows.Forms.ComboBox defaultTablespace;
    }
}