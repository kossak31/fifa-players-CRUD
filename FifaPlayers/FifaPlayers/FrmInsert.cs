using MySqlConnector;

namespace FifaPlayers
{
    public partial class FrmInsert : Form
    {
        public FrmInsert()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || dtp.Text == "" || txtHeight.Text == "" || txtWeight.Text == "" )
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
                Player player = new Player(txtName.Text, dtp.Value.ToString("yyyy-MM-dd"), Convert.ToDouble(txtHeight.Text), Convert.ToDouble(txtWeight.Text), Convert.ToInt32(cboCountries.SelectedIndex + 1));
                Database.InsertPlayer(player.Name, player.Birthdate, player.Height, player.Weight, player.Country);
                this.Close();
            }
        }

        private void FrmInsert_Load(object sender, EventArgs e)
        {
            Database.GetCountries();
            cboCountries.DataSource = Database.dataFill;

        }


    }
}