using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

using DbConnection;

namespace TelineApp
{
    public partial class FormServersList : DockContent
    {
        DbConnector dbConnector_;
        FormMain frmMain_;

        public FormServersList(DbConnector dbConnector, FormMain frmMain)
        {
            InitializeComponent();

            dbConnector_ = dbConnector;
            frmMain_ = frmMain;
        }

        private void cmiAddServer_Click(object sender, EventArgs e)
        {
            DlgAddServer dlgAddServer = new DlgAddServer();
            if (dlgAddServer.ShowDialog() == DialogResult.OK)
            {
                DbServer dbServer = new DbServer(dlgAddServer.ServerName, dlgAddServer.Host, dlgAddServer.Port, dlgAddServer.Password, dlgAddServer.SavePassword);
                dbConnector_.AddServer(dbServer);
                ShowServerList();
            }
        }

        private void ShowServerList()
        {
            tvServers.Nodes.Clear();
            int serversCount = dbConnector_.GetServersCount();
            if (serversCount == 0)
                return;

            for (int i = 0; i < serversCount; i++)
            {
                DbServer server = dbConnector_.GetServer(i);
                TreeNode treeNode = new TreeNode(server.ServerName, (int)server.Status, (int)server.Status);
                treeNode.ContextMenuStrip = contextMenuStripServer;
                tvServers.Nodes.Add(treeNode);
            }
        }

        private void FormServersList_Load(object sender, EventArgs e)
        {
            ShowServerList();
        }

        private void cmiConnect_Click(object sender, EventArgs e)
        {
            if (dbConnector_.ConnectToServer(tvServers.SelectedNode.Index))
            {
                dbConnector_.SetServerStatus(tvServers.SelectedNode.Index, ServerStatus.CONNECTED);
                frmMain_.LoadMainData();
            }
            else
                dbConnector_.SetServerStatus(tvServers.SelectedNode.Index, ServerStatus.ACCESS_DENIED);
            ShowServerList();
        }

        private void tvServers_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            tvServers.SelectedNode = e.Node;
        }

        private void cmiProperties_Click(object sender, EventArgs e)
        {
            DbServer server = dbConnector_.GetServer(tvServers.SelectedNode.Index);
            DlgAddServer dlg = new DlgAddServer();
            dlg.Text = "Properties";
            dlg.ServerName = server.ServerName;
            dlg.Host = server.Host;
            dlg.Port = server.Port;
            dlg.Password = server.Password;
            dlg.SavePassword = server.SavePassword;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                DbServer dbServer = new DbServer(dlg.ServerName, dlg.Host, dlg.Port, dlg.Password, dlg.SavePassword, server.Status);
                dbConnector_.SetServer(dbServer, tvServers.SelectedNode.Index);
                ShowServerList();
            }
        }

        private void cmiDisconnect_Click(object sender, EventArgs e)
        {
            dbConnector_.DisconnectFromServer();
            dbConnector_.SetServerStatus(tvServers.SelectedNode.Index, ServerStatus.UNKNOWN);
            frmMain_.EnableDatabaseButtons(false);
            ShowServerList();
        }

        private void tvServers_MouseClick(object sender, MouseEventArgs e)
        {
            if (tvServers.SelectedNode == null) return;
            cmiConnect.Visible = tvServers.SelectedNode.Index != dbConnector_.ConnectedServerIndex;
            cmiDisconnect.Visible = tvServers.SelectedNode.Index == dbConnector_.ConnectedServerIndex;
            cmiRefresh.Visible = tvServers.SelectedNode.Index == dbConnector_.ConnectedServerIndex;
        }

        private void tvServers_KeyUp(object sender, KeyEventArgs e)
        {
            if (tvServers.SelectedNode == null) return;
            cmiConnect.Visible = tvServers.SelectedNode.Index != dbConnector_.ConnectedServerIndex;
            cmiDisconnect.Visible = tvServers.SelectedNode.Index == dbConnector_.ConnectedServerIndex;
            cmiRefresh.Visible = tvServers.SelectedNode.Index == dbConnector_.ConnectedServerIndex;
        }

        private void cmiRefresh_Click(object sender, EventArgs e)
        {
            frmMain_.LoadMainData();
        }
    }
}
