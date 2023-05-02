
namespace TelineApp
{
    partial class DlgLisaaUusiOsa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgLisaaUusiOsa));
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbKuvaus = new System.Windows.Forms.TextBox();
            this.labelKuvaus = new System.Windows.Forms.Label();
            this.ctbOsanNimi = new TelineApp.ColoredTextBox();
            this.labelNimi = new System.Windows.Forms.Label();
            this.labelPituus = new System.Windows.Forms.Label();
            this.tbPituus = new System.Windows.Forms.TextBox();
            this.labelMaaraVarastossa = new System.Windows.Forms.Label();
            this.labelMinMaara = new System.Windows.Forms.Label();
            this.labelLaatikko = new System.Windows.Forms.Label();
            this.tbHinta = new System.Windows.Forms.TextBox();
            this.labelHinta = new System.Windows.Forms.Label();
            this.ctbMaaraVarastossa = new TelineApp.ColoredTextBox();
            this.ctbMinMaara = new TelineApp.ColoredTextBox();
            this.tbLaatikko = new System.Windows.Forms.TextBox();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnClose);
            this.panelButtons.Controls.Add(this.btnSave);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 399);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(369, 51);
            this.panelButtons.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(196, 7);
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
            this.btnSave.Location = new System.Drawing.Point(277, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 32);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // tbKuvaus
            // 
            this.tbKuvaus.Location = new System.Drawing.Point(17, 267);
            this.tbKuvaus.Multiline = true;
            this.tbKuvaus.Name = "tbKuvaus";
            this.tbKuvaus.Size = new System.Drawing.Size(335, 115);
            this.tbKuvaus.TabIndex = 22;
            // 
            // labelKuvaus
            // 
            this.labelKuvaus.AutoSize = true;
            this.labelKuvaus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKuvaus.Location = new System.Drawing.Point(14, 237);
            this.labelKuvaus.Name = "labelKuvaus";
            this.labelKuvaus.Size = new System.Drawing.Size(55, 17);
            this.labelKuvaus.TabIndex = 21;
            this.labelKuvaus.Text = "Kuvaus";
            // 
            // ctbOsanNimi
            // 
            this.ctbOsanNimi.Location = new System.Drawing.Point(109, 23);
            this.ctbOsanNimi.Name = "ctbOsanNimi";
            this.ctbOsanNimi.Size = new System.Drawing.Size(243, 20);
            this.ctbOsanNimi.TabIndex = 20;
            // 
            // labelNimi
            // 
            this.labelNimi.AutoSize = true;
            this.labelNimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNimi.Location = new System.Drawing.Point(57, 24);
            this.labelNimi.Name = "labelNimi";
            this.labelNimi.Size = new System.Drawing.Size(35, 17);
            this.labelNimi.TabIndex = 19;
            this.labelNimi.Text = "Nimi";
            // 
            // labelPituus
            // 
            this.labelPituus.AutoSize = true;
            this.labelPituus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPituus.Location = new System.Drawing.Point(125, 63);
            this.labelPituus.Name = "labelPituus";
            this.labelPituus.Size = new System.Drawing.Size(72, 17);
            this.labelPituus.TabIndex = 23;
            this.labelPituus.Text = "Pituus (m)";
            // 
            // tbPituus
            // 
            this.tbPituus.Location = new System.Drawing.Point(211, 62);
            this.tbPituus.Name = "tbPituus";
            this.tbPituus.Size = new System.Drawing.Size(141, 20);
            this.tbPituus.TabIndex = 24;
            this.tbPituus.TextChanged += new System.EventHandler(this.tbPituus_TextChanged);
            this.tbPituus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFloatValue_KeyPress);
            // 
            // labelMaaraVarastossa
            // 
            this.labelMaaraVarastossa.AutoSize = true;
            this.labelMaaraVarastossa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaaraVarastossa.Location = new System.Drawing.Point(14, 99);
            this.labelMaaraVarastossa.Name = "labelMaaraVarastossa";
            this.labelMaaraVarastossa.Size = new System.Drawing.Size(183, 17);
            this.labelMaaraVarastossa.TabIndex = 25;
            this.labelMaaraVarastossa.Text = "Nykyinen maara varastossa";
            // 
            // labelMinMaara
            // 
            this.labelMinMaara.AutoSize = true;
            this.labelMinMaara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMinMaara.Location = new System.Drawing.Point(14, 135);
            this.labelMinMaara.Name = "labelMinMaara";
            this.labelMinMaara.Size = new System.Drawing.Size(189, 17);
            this.labelMinMaara.TabIndex = 27;
            this.labelMinMaara.Text = "Vahimmaismaara varastossa";
            // 
            // labelLaatikko
            // 
            this.labelLaatikko.AutoSize = true;
            this.labelLaatikko.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLaatikko.Location = new System.Drawing.Point(136, 171);
            this.labelLaatikko.Name = "labelLaatikko";
            this.labelLaatikko.Size = new System.Drawing.Size(61, 17);
            this.labelLaatikko.TabIndex = 29;
            this.labelLaatikko.Text = "Laatikko";
            // 
            // tbHinta
            // 
            this.tbHinta.Location = new System.Drawing.Point(211, 205);
            this.tbHinta.Name = "tbHinta";
            this.tbHinta.Size = new System.Drawing.Size(141, 20);
            this.tbHinta.TabIndex = 32;
            this.tbHinta.TextChanged += new System.EventHandler(this.tbHinta_TextChanged);
            this.tbHinta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFloatValue_KeyPress);
            // 
            // labelHinta
            // 
            this.labelHinta.AutoSize = true;
            this.labelHinta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHinta.Location = new System.Drawing.Point(156, 206);
            this.labelHinta.Name = "labelHinta";
            this.labelHinta.Size = new System.Drawing.Size(41, 17);
            this.labelHinta.TabIndex = 31;
            this.labelHinta.Text = "Hinta";
            // 
            // ctbMaaraVarastossa
            // 
            this.ctbMaaraVarastossa.Location = new System.Drawing.Point(211, 98);
            this.ctbMaaraVarastossa.Name = "ctbMaaraVarastossa";
            this.ctbMaaraVarastossa.Size = new System.Drawing.Size(141, 20);
            this.ctbMaaraVarastossa.TabIndex = 33;
            this.ctbMaaraVarastossa.TextChanged += new System.EventHandler(this.ctbMaaraVarastossa_TextChanged);
            this.ctbMaaraVarastossa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIntValue_KeyPress);
            // 
            // ctbMinMaara
            // 
            this.ctbMinMaara.Location = new System.Drawing.Point(211, 134);
            this.ctbMinMaara.Name = "ctbMinMaara";
            this.ctbMinMaara.Size = new System.Drawing.Size(141, 20);
            this.ctbMinMaara.TabIndex = 34;
            this.ctbMinMaara.TextChanged += new System.EventHandler(this.ctbMinMaara_TextChanged);
            this.ctbMinMaara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIntValue_KeyPress);
            // 
            // tbLaatikko
            // 
            this.tbLaatikko.Location = new System.Drawing.Point(211, 170);
            this.tbLaatikko.Name = "tbLaatikko";
            this.tbLaatikko.Size = new System.Drawing.Size(141, 20);
            this.tbLaatikko.TabIndex = 35;
            // 
            // DlgLisaaUusiOsa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 450);
            this.Controls.Add(this.tbLaatikko);
            this.Controls.Add(this.ctbMinMaara);
            this.Controls.Add(this.ctbMaaraVarastossa);
            this.Controls.Add(this.tbHinta);
            this.Controls.Add(this.labelHinta);
            this.Controls.Add(this.labelLaatikko);
            this.Controls.Add(this.labelMinMaara);
            this.Controls.Add(this.labelMaaraVarastossa);
            this.Controls.Add(this.tbPituus);
            this.Controls.Add(this.labelPituus);
            this.Controls.Add(this.tbKuvaus);
            this.Controls.Add(this.labelKuvaus);
            this.Controls.Add(this.ctbOsanNimi);
            this.Controls.Add(this.labelNimi);
            this.Controls.Add(this.panelButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DlgLisaaUusiOsa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uusi Osa";
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbKuvaus;
        private System.Windows.Forms.Label labelKuvaus;
        private ColoredTextBox ctbOsanNimi;
        private System.Windows.Forms.Label labelNimi;
        private System.Windows.Forms.Label labelPituus;
        private System.Windows.Forms.TextBox tbPituus;
        private System.Windows.Forms.Label labelMaaraVarastossa;
        private System.Windows.Forms.Label labelMinMaara;
        private System.Windows.Forms.Label labelLaatikko;
        private System.Windows.Forms.TextBox tbHinta;
        private System.Windows.Forms.Label labelHinta;
        private ColoredTextBox ctbMaaraVarastossa;
        private ColoredTextBox ctbMinMaara;
        private System.Windows.Forms.TextBox tbLaatikko;
    }
}