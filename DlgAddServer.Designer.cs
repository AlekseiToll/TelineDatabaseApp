
namespace TelineApp
{
    partial class DlgAddServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgAddServer));
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.chbSavePassword = new System.Windows.Forms.CheckBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.labelHostname = new System.Windows.Forms.Label();
            this.tbComments = new System.Windows.Forms.TextBox();
            this.labelComments = new System.Windows.Forms.Label();
            this.ctbHostName = new TelineApp.ColoredTextBox();
            this.ctbServerName = new TelineApp.ColoredTextBox();
            this.ctbPassword = new TelineApp.ColoredTextBox();
            this.ctbPort = new TelineApp.ColoredTextBox();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnClose);
            this.panelButtons.Controls.Add(this.btnSave);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 424);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(505, 51);
            this.panelButtons.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(329, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 32);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(410, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 32);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(58, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            // 
            // chbSavePassword
            // 
            this.chbSavePassword.AutoSize = true;
            this.chbSavePassword.Checked = true;
            this.chbSavePassword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbSavePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbSavePassword.Location = new System.Drawing.Point(37, 204);
            this.chbSavePassword.Name = "chbSavePassword";
            this.chbSavePassword.Size = new System.Drawing.Size(123, 21);
            this.chbSavePassword.TabIndex = 15;
            this.chbSavePassword.Text = "Save password";
            this.chbSavePassword.UseVisualStyleBackColor = true;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(34, 152);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(69, 17);
            this.labelPassword.TabIndex = 14;
            this.labelPassword.Text = "Password";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPort.Location = new System.Drawing.Point(69, 111);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(34, 17);
            this.labelPort.TabIndex = 12;
            this.labelPort.Text = "Port";
            // 
            // labelHostname
            // 
            this.labelHostname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHostname.Location = new System.Drawing.Point(24, 69);
            this.labelHostname.Name = "labelHostname";
            this.labelHostname.Size = new System.Drawing.Size(89, 38);
            this.labelHostname.TabIndex = 10;
            this.labelHostname.Text = "Host Name / Address";
            // 
            // tbComments
            // 
            this.tbComments.Location = new System.Drawing.Point(37, 303);
            this.tbComments.Multiline = true;
            this.tbComments.Name = "tbComments";
            this.tbComments.Size = new System.Drawing.Size(444, 95);
            this.tbComments.TabIndex = 18;
            // 
            // labelComments
            // 
            this.labelComments.AutoSize = true;
            this.labelComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelComments.Location = new System.Drawing.Point(34, 271);
            this.labelComments.Name = "labelComments";
            this.labelComments.Size = new System.Drawing.Size(74, 17);
            this.labelComments.TabIndex = 17;
            this.labelComments.Text = "Comments";
            // 
            // ctbHostName
            // 
            this.ctbHostName.Location = new System.Drawing.Point(119, 69);
            this.ctbHostName.Name = "ctbHostName";
            this.ctbHostName.Size = new System.Drawing.Size(362, 20);
            this.ctbHostName.TabIndex = 16;
            this.ctbHostName.Text = "localhost";
            this.ctbHostName.TextChanged += new System.EventHandler(this.colorTextBox_TextChanged);
            // 
            // ctbServerName
            // 
            this.ctbServerName.Location = new System.Drawing.Point(119, 28);
            this.ctbServerName.Name = "ctbServerName";
            this.ctbServerName.Size = new System.Drawing.Size(362, 20);
            this.ctbServerName.TabIndex = 6;
            this.ctbServerName.TextChanged += new System.EventHandler(this.colorTextBox_TextChanged);
            // 
            // ctbPassword
            // 
            this.ctbPassword.Location = new System.Drawing.Point(119, 151);
            this.ctbPassword.Name = "ctbPassword";
            this.ctbPassword.PasswordChar = '*';
            this.ctbPassword.Size = new System.Drawing.Size(362, 20);
            this.ctbPassword.TabIndex = 19;
            this.ctbPassword.TextChanged += new System.EventHandler(this.colorTextBox_TextChanged);
            // 
            // ctbPort
            // 
            this.ctbPort.Location = new System.Drawing.Point(119, 110);
            this.ctbPort.Name = "ctbPort";
            this.ctbPort.Size = new System.Drawing.Size(362, 20);
            this.ctbPort.TabIndex = 20;
            this.ctbPort.Text = "5432";
            this.ctbPort.TextChanged += new System.EventHandler(this.ctbPort_TextChanged);
            this.ctbPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ctbPort_KeyPress);
            // 
            // DlgAddServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 475);
            this.Controls.Add(this.ctbPort);
            this.Controls.Add(this.ctbPassword);
            this.Controls.Add(this.tbComments);
            this.Controls.Add(this.labelComments);
            this.Controls.Add(this.ctbHostName);
            this.Controls.Add(this.chbSavePassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.labelHostname);
            this.Controls.Add(this.ctbServerName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.panelButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DlgAddServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Server";
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private ColoredTextBox ctbServerName;
        private System.Windows.Forms.Label lblName;
        private ColoredTextBox ctbHostName;
        private System.Windows.Forms.CheckBox chbSavePassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label labelHostname;
        private System.Windows.Forms.TextBox tbComments;
        private System.Windows.Forms.Label labelComments;
        private ColoredTextBox ctbPassword;
        private ColoredTextBox ctbPort;
    }
}