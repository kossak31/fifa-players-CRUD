using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FifaPlayers
{
    public partial class FrmDisplay : Form
    {
        public FrmDisplay()
        {
            InitializeComponent();
        }

        private void FrmDisplay_Load(object sender, EventArgs e)
        {
            //get countries from database
            Database.GetCountries();
            
            //populate combobox with countries
            cboCountries.DataSource = Database.dataFill;

            //get players from database           
            Database.GetPlayers();
            dgvPlayers.DataSource = Database.dt;

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //show insert form
            FrmInsert frmInsert = new FrmInsert();
            frmInsert.Show();
        }
    }
}
