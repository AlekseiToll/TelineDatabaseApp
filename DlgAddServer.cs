using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelineApp
{
    public partial class DlgAddServer : Form
    {
        public DlgAddServer()
        {
            InitializeComponent();
        }

        private void colorTextBox_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = ctbHostName.Text.Length > 0 && ctbServerName.Text.Length > 0 && ctbPort.Text.Length > 0 &&
                ctbPassword.Text.Length > 0;
            this.Refresh();
        }

        public string ServerName { get { return ctbServerName.Text; } set { ctbServerName.Text = value; } }

        public string Host { get { return ctbHostName.Text; } set { ctbHostName.Text = value; } }

        public int Port { get { return int.Parse(ctbPort.Text); } set { ctbPort.Text = value.ToString(); } }

        public string Password { get { return ctbPassword.Text; } set { ctbPassword.Text = value; } }

        public bool SavePassword { get { return chbSavePassword.Checked; } set { chbSavePassword.Checked = value; } }

        private void ctbPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ctbPort_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (!int.TryParse(ctbPort.Text, out i))
            {
                if (ctbPort.Text.Length > 0)
                    ctbPort.Text = ctbPort.Text.Remove(ctbPort.Text.Length - 1);
            }

            colorTextBox_TextChanged(sender, e);
        }
    }
}
