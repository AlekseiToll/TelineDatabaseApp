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
using TelineVarasto;


namespace TelineApp
{
    public partial class FormTelineTables : DockContent
    {
        private DbConnector dbConnector_;
        private Varasto varasto_;
        BindingSource bindingSourceOsat_ = new BindingSource();
        BindingSource bindingSourceTyomaat_ = new BindingSource();

        public FormTelineTables(DbConnector dbConnector)
        {
            InitializeComponent();

            dbConnector_ = dbConnector;
            varasto_ = new Varasto(dbConnector);
        }

        public void LoadTelineOsatData()
        {
            varasto_.LoadTelineOsatData();
            bindingSourceOsat_.ResetBindings(false);
        }

        public void LoadTyomaatData()
        {
            varasto_.LoadTyomaatData();
            bindingSourceTyomaat_.ResetBindings(false);
        }

        //public void LoadTyomaatData()
        //{
            //string query = "SELECT * FROM public.tyomaat;";

            //DataSet ds = new DataSet();
            //dbConnector_.CreateAndFillDataAdapter(query, "tyomaat", ref ds);
            //dgvTyomaat.DataSource = ds;
            //dgvTyomaat.DataMember = "tyomaat";
        //}

        public void EnableDatabaseButtons(bool enable)
        {
            btnUusiOsa.Enabled = enable;
            btnAvaaIkkunassa.Enabled = enable;
        }

        private void btnUusiOsa_Click(object sender, EventArgs e)
        {
            DlgLisaaUusiOsa dlgUusiOsa = new DlgLisaaUusiOsa();
            if (dlgUusiOsa.ShowDialog() == DialogResult.OK)
            {
                if(!dbConnector_.AddUusiOsa(
                    dlgUusiOsa.Nimi,
                    dlgUusiOsa.Pituus,
                    dlgUusiOsa.MaaraVarastossa,
                    dlgUusiOsa.MinMaara,
                    dlgUusiOsa.Laatikko,
                    dlgUusiOsa.Hinta))
                {
                    MessageBox.Show("Lisaaminen epaonnistui!", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    LoadTelineOsatData();
                }
            }
        }

        private void FormTelineTables_Load(object sender, EventArgs e)
        {
            dgvTeline.AutoGenerateColumns = false;
            dgvTyomaat.AutoGenerateColumns = false;
            bindingSourceOsat_.DataSource = varasto_.GetOsatVarastossa();
            dgvTeline.DataSource = bindingSourceOsat_;
            bindingSourceTyomaat_.DataSource = varasto_.GetTyomaat();
            dgvTyomaat.DataSource = bindingSourceTyomaat_;
        }
    }
}
