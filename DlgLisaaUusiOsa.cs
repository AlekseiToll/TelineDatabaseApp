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
    public partial class DlgLisaaUusiOsa : Form
    {
        public DlgLisaaUusiOsa()
        {
            InitializeComponent();
        }

        public string Nimi { get { return ctbOsanNimi.Text; } }

        public float Pituus
        {
            get
            {
                if (tbPituus.Text.Length == 0) return 0;
                return float.Parse(tbPituus.Text);
            }
        }

        public int MaaraVarastossa { get { return int.Parse(ctbMaaraVarastossa.Text); } }

        public int MinMaara { get { return int.Parse(ctbMinMaara.Text); } }

        public string Laatikko { get { return tbLaatikko.Text; } }

        public float Hinta
        {
            get
            {
                if (tbHinta.Text.Length == 0) return 0;
                return float.Parse(tbHinta.Text);
            }
        }

        #region Input handlers
        private void colorTextBox_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = ctbOsanNimi.Text.Length > 0 && ctbMaaraVarastossa.Text.Length > 0 && ctbMinMaara.Text.Length > 0;
            this.Refresh();
        }

        private void tbFloatValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '.') return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }

        private void tbIntValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }

        private void tbPituus_TextChanged(object sender, EventArgs e)
        {
            float f;
            if (!float.TryParse(tbPituus.Text, out f))
            {
                if (tbPituus.Text.Length > 0)
                    tbPituus.Text = tbPituus.Text.Remove(tbPituus.Text.Length - 1);
            }
        }

        private void tbHinta_TextChanged(object sender, EventArgs e)
        {
            float f;
            if (!float.TryParse(tbHinta.Text, out f))
            {
                if (tbHinta.Text.Length > 0)
                    tbHinta.Text = tbHinta.Text.Remove(tbHinta.Text.Length - 1);
            }
        }

        private void ctbMaaraVarastossa_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (!int.TryParse(ctbMaaraVarastossa.Text, out i))
            {
                if (ctbMaaraVarastossa.Text.Length > 0)
                    ctbMaaraVarastossa.Text = ctbMaaraVarastossa.Text.Remove(ctbMaaraVarastossa.Text.Length - 1);
            }

            colorTextBox_TextChanged(sender, e);
        }

        private void ctbMinMaara_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (!int.TryParse(ctbMinMaara.Text, out i))
            {
                if (ctbMinMaara.Text.Length > 0)
                    ctbMinMaara.Text = ctbMinMaara.Text.Remove(ctbMinMaara.Text.Length - 1);
            }

            colorTextBox_TextChanged(sender, e);
        }

        #endregion
    }
}
