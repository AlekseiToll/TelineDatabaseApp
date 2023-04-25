using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DbConnection;

namespace TelineApp
{
    public partial class FormMain : Form
    {
        FormServersList frmServersList_;
        FormTelineTables frmTelineTables_;

        DbConnector dbConnector_ = new DbConnector();

        public FormMain()
        {
            InitializeComponent();

            frmServersList_ = new FormServersList(dbConnector_, this);
            frmTelineTables_ = new FormTelineTables(dbConnector_);
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dbConnector_.LoadServerData();

            frmServersList_.Show(dockPanelMain);
            frmTelineTables_.Show(dockPanelMain);
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            dbConnector_.SaveServerData();
            dbConnector_.DisconnectFromServer();
        }

        public void LoadMainData()
        {
            frmTelineTables_.LoadTelineOsatData();
            frmTelineTables_.LoadTyomaatData();
            frmTelineTables_.EnableDatabaseButtons(true);
        }

        public void EnableDatabaseButtons(bool enable)
        {
            frmTelineTables_.EnableDatabaseButtons(enable);
        }
    }
}
