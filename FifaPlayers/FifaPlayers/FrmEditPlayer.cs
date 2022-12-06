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
    public partial class FrmEditPlayer : Form
    {
        int id_sql;
        string country_name;
        public FrmEditPlayer(string id, string name, string birthdate, string height, string weight, string country)
        {
            InitializeComponent();
            id_sql = Convert.ToInt32(id);
            txtName.Text = name;
            dtp.Text = birthdate;
            txtHeight.Text = height;
            txtWeight.Text = weight;

            country_name = country;
        }


        private void FrmEditPlayer_Load(object sender, EventArgs e)
        {
            //get countries from database
            Database.GetCountries();

            //remove Todos from combobox
            Database.dataFill.Remove("Todos");

            //populate combobox with countries
            cboCountries.DataSource = Database.dataFill;

            //pre-selected country from player
            cboCountries.SelectedIndex = cboCountries.FindStringExact(country_name);
        }



        private void btnEditPlayer_Click(object sender, EventArgs e)
        {

            Database.UpdatePlayer(id_sql.ToString(), txtName.Text, dtp.Value.ToString("yyyy-MM-dd"), txtHeight.Text, txtWeight.Text, cboCountries.SelectedIndex + 1);
            this.Close();
            Database.GetPlayers();
            FrmDisplay fr = new FrmDisplay();
            fr.dgvPlayers.DataSource = Database.dt;
        }
    }
}
