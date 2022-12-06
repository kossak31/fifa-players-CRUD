using MySqlConnector;
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
            FrmInsertPlayer frmInsert = new FrmInsertPlayer();       
            frmInsert.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Database.Search(txtSearch.Text, cboCountries.SelectedItem.ToString());
            dgvPlayers.DataSource = Database.dt;
        }

        private void cboCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            Database.Search(txtSearch.Text, cboCountries.SelectedItem.ToString());
            dgvPlayers.DataSource = Database.dt;
        }

        private void btnEditPlayer_Click(object sender, EventArgs e)
        {


            string id = Convert.ToString(dgvPlayers.CurrentRow.Cells[0].Value);
            string name = Convert.ToString(dgvPlayers.CurrentRow.Cells[1].Value);
            string birthdate = Convert.ToString(dgvPlayers.CurrentRow.Cells[2].Value);
            string height = Convert.ToString(dgvPlayers.CurrentRow.Cells[3].Value);
            string weight = Convert.ToString(dgvPlayers.CurrentRow.Cells[4].Value);
            string country = Convert.ToString(dgvPlayers.CurrentRow.Cells[5].Value);

            Form frmEditPlayer = new FrmEditPlayer(id, name, birthdate, height, weight, country);


            frmEditPlayer.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            string id = Convert.ToString(dgvPlayers.CurrentRow.Cells[0].Value);
            Database.DeletePlayer(id);
            Database.GetPlayers();
            dgvPlayers.DataSource = Database.dt;
            
        }
    }
}
