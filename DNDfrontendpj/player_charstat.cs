namespace DNDfrontendpj
{
    public partial class character_stat : Form
    {
        public int rowClicked;
        public int id_row;
        public character_stat()
        {
            InitializeComponent();
        }

        private void campname_TXT_Click(object sender, EventArgs e)
        {

        }

        private void ret2welcomeplayer_Click(object sender, EventArgs e)
        {
            player_welcome playerwelcome = new player_welcome();
            playerwelcome.Show();
            this.Close();
        }

        private void searchchar_BT_Click(object sender, EventArgs e)
        {
            searchchar go2search = new searchchar();
            go2search.Show();
            //this.Close();
        }

        private void viewinven_BT_Click(object sender, EventArgs e)
        {
            player_inventory inventory = new player_inventory();
            inventory.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //does nothing

        }

        private void charstat_DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            rowClicked = dataGridView.CurrentRow.Index;
            id_row = Int32.Parse(dataGridView.Rows[rowClicked].Cells[0].Value.ToString());
        }
    }
}
