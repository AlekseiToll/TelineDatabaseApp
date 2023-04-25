
namespace TelineApp
{
    partial class FormServersList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormServersList));
            this.tvServers = new System.Windows.Forms.TreeView();
            this.contextMenuStripMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmiAddServer = new System.Windows.Forms.ToolStripMenuItem();
            this.imageListServers = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStripServer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmiConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiDisconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripMain.SuspendLayout();
            this.contextMenuStripServer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvServers
            // 
            this.tvServers.ContextMenuStrip = this.contextMenuStripMain;
            this.tvServers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvServers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tvServers.ImageIndex = 0;
            this.tvServers.ImageList = this.imageListServers;
            this.tvServers.Location = new System.Drawing.Point(0, 0);
            this.tvServers.Name = "tvServers";
            this.tvServers.SelectedImageIndex = 0;
            this.tvServers.Size = new System.Drawing.Size(283, 450);
            this.tvServers.TabIndex = 0;
            this.tvServers.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvServers_NodeMouseClick);
            this.tvServers.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tvServers_KeyUp);
            this.tvServers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tvServers_MouseClick);
            // 
            // contextMenuStripMain
            // 
            this.contextMenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmiAddServer});
            this.contextMenuStripMain.Name = "contextMenuStripMain";
            this.contextMenuStripMain.Size = new System.Drawing.Size(140, 26);
            // 
            // cmiAddServer
            // 
            this.cmiAddServer.Name = "cmiAddServer";
            this.cmiAddServer.Size = new System.Drawing.Size(139, 22);
            this.cmiAddServer.Text = "Add server...";
            this.cmiAddServer.Click += new System.EventHandler(this.cmiAddServer_Click);
            // 
            // imageListServers
            // 
            this.imageListServers.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListServers.ImageStream")));
            this.imageListServers.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListServers.Images.SetKeyName(0, "Fasticon-Servers-Server.128.ico");
            this.imageListServers.Images.SetKeyName(1, "Fasticon-Servers-Enable-server.128.ico");
            this.imageListServers.Images.SetKeyName(2, "Fasticon-Servers-Remove-server.128.ico");
            // 
            // contextMenuStripServer
            // 
            this.contextMenuStripServer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmiConnect,
            this.cmiDisconnect,
            this.cmiRefresh,
            this.cmiProperties});
            this.contextMenuStripServer.Name = "contextMenuStripServer";
            this.contextMenuStripServer.Size = new System.Drawing.Size(181, 114);
            // 
            // cmiConnect
            // 
            this.cmiConnect.Name = "cmiConnect";
            this.cmiConnect.Size = new System.Drawing.Size(180, 22);
            this.cmiConnect.Text = "Connect";
            this.cmiConnect.Click += new System.EventHandler(this.cmiConnect_Click);
            // 
            // cmiDisconnect
            // 
            this.cmiDisconnect.Name = "cmiDisconnect";
            this.cmiDisconnect.Size = new System.Drawing.Size(180, 22);
            this.cmiDisconnect.Text = "Disconnect";
            this.cmiDisconnect.Click += new System.EventHandler(this.cmiDisconnect_Click);
            // 
            // cmiProperties
            // 
            this.cmiProperties.Name = "cmiProperties";
            this.cmiProperties.Size = new System.Drawing.Size(180, 22);
            this.cmiProperties.Text = "Properties...";
            this.cmiProperties.Click += new System.EventHandler(this.cmiProperties_Click);
            // 
            // cmiRefresh
            // 
            this.cmiRefresh.Name = "cmiRefresh";
            this.cmiRefresh.Size = new System.Drawing.Size(180, 22);
            this.cmiRefresh.Text = "Refresh";
            this.cmiRefresh.Click += new System.EventHandler(this.cmiRefresh_Click);
            // 
            // FormServersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 450);
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.Controls.Add(this.tvServers);
            this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormServersList";
            this.Load += new System.EventHandler(this.FormServersList_Load);
            this.contextMenuStripMain.ResumeLayout(false);
            this.contextMenuStripServer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvServers;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem cmiAddServer;
        private System.Windows.Forms.ImageList imageListServers;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripServer;
        private System.Windows.Forms.ToolStripMenuItem cmiConnect;
        private System.Windows.Forms.ToolStripMenuItem cmiProperties;
        private System.Windows.Forms.ToolStripMenuItem cmiDisconnect;
        private System.Windows.Forms.ToolStripMenuItem cmiRefresh;
    }
}