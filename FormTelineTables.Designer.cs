
namespace TelineApp
{
    partial class FormTelineTables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTelineTables));
            this.splitContainerTables = new System.Windows.Forms.SplitContainer();
            this.splitContainerOsat = new System.Windows.Forms.SplitContainer();
            this.dgvTeline = new System.Windows.Forms.DataGridView();
            this.dgvcolKokoNimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcolMaara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcolMinMaara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcolLaatikko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAvaaIkkunassa = new System.Windows.Forms.Button();
            this.btnUusiOsa = new System.Windows.Forms.Button();
            this.dgvTyomaat = new System.Windows.Forms.DataGridView();
            this.dgvcolTyomaaNimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcolMaaraYhteensa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcolYhteyshenkilo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcolPuhelin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTables)).BeginInit();
            this.splitContainerTables.Panel1.SuspendLayout();
            this.splitContainerTables.Panel2.SuspendLayout();
            this.splitContainerTables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerOsat)).BeginInit();
            this.splitContainerOsat.Panel1.SuspendLayout();
            this.splitContainerOsat.Panel2.SuspendLayout();
            this.splitContainerOsat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTyomaat)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerTables
            // 
            this.splitContainerTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerTables.Location = new System.Drawing.Point(0, 0);
            this.splitContainerTables.Name = "splitContainerTables";
            this.splitContainerTables.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerTables.Panel1
            // 
            this.splitContainerTables.Panel1.Controls.Add(this.splitContainerOsat);
            // 
            // splitContainerTables.Panel2
            // 
            this.splitContainerTables.Panel2.Controls.Add(this.dgvTyomaat);
            this.splitContainerTables.Size = new System.Drawing.Size(800, 450);
            this.splitContainerTables.SplitterDistance = 266;
            this.splitContainerTables.TabIndex = 0;
            // 
            // splitContainerOsat
            // 
            this.splitContainerOsat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerOsat.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerOsat.IsSplitterFixed = true;
            this.splitContainerOsat.Location = new System.Drawing.Point(0, 0);
            this.splitContainerOsat.Name = "splitContainerOsat";
            // 
            // splitContainerOsat.Panel1
            // 
            this.splitContainerOsat.Panel1.Controls.Add(this.dgvTeline);
            // 
            // splitContainerOsat.Panel2
            // 
            this.splitContainerOsat.Panel2.Controls.Add(this.btnAvaaIkkunassa);
            this.splitContainerOsat.Panel2.Controls.Add(this.btnUusiOsa);
            this.splitContainerOsat.Size = new System.Drawing.Size(800, 266);
            this.splitContainerOsat.SplitterDistance = 673;
            this.splitContainerOsat.TabIndex = 1;
            // 
            // dgvTeline
            // 
            this.dgvTeline.AllowUserToAddRows = false;
            this.dgvTeline.AllowUserToDeleteRows = false;
            this.dgvTeline.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeline.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcolKokoNimi,
            this.dgvcolMaara,
            this.dgvcolMinMaara,
            this.dgvcolLaatikko});
            this.dgvTeline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTeline.Location = new System.Drawing.Point(0, 0);
            this.dgvTeline.Name = "dgvTeline";
            this.dgvTeline.Size = new System.Drawing.Size(673, 266);
            this.dgvTeline.TabIndex = 1;
            // 
            // dgvcolKokoNimi
            // 
            this.dgvcolKokoNimi.DataPropertyName = "KokoNimi";
            this.dgvcolKokoNimi.HeaderText = "Nimi";
            this.dgvcolKokoNimi.Name = "dgvcolKokoNimi";
            this.dgvcolKokoNimi.ReadOnly = true;
            // 
            // dgvcolMaara
            // 
            this.dgvcolMaara.DataPropertyName = "Maara";
            this.dgvcolMaara.HeaderText = "Maara Varastossa";
            this.dgvcolMaara.Name = "dgvcolMaara";
            this.dgvcolMaara.ReadOnly = true;
            // 
            // dgvcolMinMaara
            // 
            this.dgvcolMinMaara.DataPropertyName = "MinMaara";
            this.dgvcolMinMaara.HeaderText = "Min Maara";
            this.dgvcolMinMaara.Name = "dgvcolMinMaara";
            this.dgvcolMinMaara.ReadOnly = true;
            // 
            // dgvcolLaatikko
            // 
            this.dgvcolLaatikko.DataPropertyName = "Laatikko";
            this.dgvcolLaatikko.HeaderText = "Laatikko";
            this.dgvcolLaatikko.Name = "dgvcolLaatikko";
            this.dgvcolLaatikko.ReadOnly = true;
            // 
            // btnAvaaIkkunassa
            // 
            this.btnAvaaIkkunassa.Enabled = false;
            this.btnAvaaIkkunassa.Location = new System.Drawing.Point(14, 65);
            this.btnAvaaIkkunassa.Name = "btnAvaaIkkunassa";
            this.btnAvaaIkkunassa.Size = new System.Drawing.Size(97, 52);
            this.btnAvaaIkkunassa.TabIndex = 1;
            this.btnAvaaIkkunassa.Text = "Avaa uudessa ikkunassa muokkaukseen";
            this.btnAvaaIkkunassa.UseVisualStyleBackColor = true;
            // 
            // btnUusiOsa
            // 
            this.btnUusiOsa.Enabled = false;
            this.btnUusiOsa.Location = new System.Drawing.Point(14, 12);
            this.btnUusiOsa.Name = "btnUusiOsa";
            this.btnUusiOsa.Size = new System.Drawing.Size(97, 37);
            this.btnUusiOsa.TabIndex = 0;
            this.btnUusiOsa.Text = "Lisaa uusi osa";
            this.btnUusiOsa.UseVisualStyleBackColor = true;
            this.btnUusiOsa.Click += new System.EventHandler(this.btnUusiOsa_Click);
            // 
            // dgvTyomaat
            // 
            this.dgvTyomaat.AllowUserToAddRows = false;
            this.dgvTyomaat.AllowUserToDeleteRows = false;
            this.dgvTyomaat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTyomaat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcolTyomaaNimi,
            this.dgvcolMaaraYhteensa,
            this.dgvcolYhteyshenkilo,
            this.dgvcolPuhelin});
            this.dgvTyomaat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTyomaat.Location = new System.Drawing.Point(0, 0);
            this.dgvTyomaat.Name = "dgvTyomaat";
            this.dgvTyomaat.Size = new System.Drawing.Size(800, 180);
            this.dgvTyomaat.TabIndex = 0;
            // 
            // dgvcolTyomaaNimi
            // 
            this.dgvcolTyomaaNimi.HeaderText = "Nimi";
            this.dgvcolTyomaaNimi.Name = "dgvcolTyomaaNimi";
            // 
            // dgvcolMaaraYhteensa
            // 
            this.dgvcolMaaraYhteensa.HeaderText = "Maara Yhteensa";
            this.dgvcolMaaraYhteensa.Name = "dgvcolMaaraYhteensa";
            // 
            // dgvcolYhteyshenkilo
            // 
            this.dgvcolYhteyshenkilo.HeaderText = "Yhteyshenkilo";
            this.dgvcolYhteyshenkilo.Name = "dgvcolYhteyshenkilo";
            // 
            // dgvcolPuhelin
            // 
            this.dgvcolPuhelin.HeaderText = "Puhelin";
            this.dgvcolPuhelin.Name = "dgvcolPuhelin";
            // 
            // FormTelineTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.Controls.Add(this.splitContainerTables);
            this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.Document;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTelineTables";
            this.Text = "Tables";
            this.Load += new System.EventHandler(this.FormTelineTables_Load);
            this.splitContainerTables.Panel1.ResumeLayout(false);
            this.splitContainerTables.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTables)).EndInit();
            this.splitContainerTables.ResumeLayout(false);
            this.splitContainerOsat.Panel1.ResumeLayout(false);
            this.splitContainerOsat.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerOsat)).EndInit();
            this.splitContainerOsat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTyomaat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerTables;
        private System.Windows.Forms.DataGridView dgvTyomaat;
        private System.Windows.Forms.SplitContainer splitContainerOsat;
        private System.Windows.Forms.DataGridView dgvTeline;
        private System.Windows.Forms.Button btnAvaaIkkunassa;
        private System.Windows.Forms.Button btnUusiOsa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcolTyomaaNimi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcolMaaraYhteensa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcolYhteyshenkilo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcolPuhelin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcolKokoNimi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcolMaara;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcolMinMaara;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcolLaatikko;
    }
}