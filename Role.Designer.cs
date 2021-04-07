namespace GiaoDien
{
    partial class Role
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
            this.topdashboard_text = new System.Windows.Forms.TextBox();
            this.buttom_in_Role = new System.Windows.Forms.Button();
            this.dgvrolelist = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrolelist)).BeginInit();
            this.SuspendLayout();
            // 
            // topdashboard_text
            // 
            this.topdashboard_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.topdashboard_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.topdashboard_text.Dock = System.Windows.Forms.DockStyle.Top;
            this.topdashboard_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topdashboard_text.ForeColor = System.Drawing.SystemColors.Window;
            this.topdashboard_text.Location = new System.Drawing.Point(0, 0);
            this.topdashboard_text.Name = "topdashboard_text";
            this.topdashboard_text.Size = new System.Drawing.Size(1266, 49);
            this.topdashboard_text.TabIndex = 5;
            this.topdashboard_text.Text = "Roles Management";
            this.topdashboard_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttom_in_Role
            // 
            this.buttom_in_Role.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttom_in_Role.BackColor = System.Drawing.Color.CadetBlue;
            this.buttom_in_Role.FlatAppearance.BorderSize = 0;
            this.buttom_in_Role.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buttom_in_Role.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttom_in_Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttom_in_Role.ForeColor = System.Drawing.Color.White;
            this.buttom_in_Role.Location = new System.Drawing.Point(862, 230);
            this.buttom_in_Role.Name = "buttom_in_Role";
            this.buttom_in_Role.Size = new System.Drawing.Size(286, 62);
            this.buttom_in_Role.TabIndex = 6;
            this.buttom_in_Role.Text = "Roles List";
            this.buttom_in_Role.UseVisualStyleBackColor = false;
            this.buttom_in_Role.Click += new System.EventHandler(this.buttom_in_Role_Click);
            // 
            // dgvrolelist
            // 
            this.dgvrolelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrolelist.Location = new System.Drawing.Point(48, 75);
            this.dgvrolelist.Name = "dgvrolelist";
            this.dgvrolelist.RowTemplate.Height = 24;
            this.dgvrolelist.Size = new System.Drawing.Size(328, 295);
            this.dgvrolelist.TabIndex = 7;
            // 
            // Role
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1266, 546);
            this.Controls.Add(this.dgvrolelist);
            this.Controls.Add(this.buttom_in_Role);
            this.Controls.Add(this.topdashboard_text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Role";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvrolelist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox topdashboard_text;
        private System.Windows.Forms.Button buttom_in_Role;
        private System.Windows.Forms.DataGridView dgvrolelist;
    }
}