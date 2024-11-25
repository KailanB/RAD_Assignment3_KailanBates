using System;
using System.ComponentModel;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Sodv2101_Assignment3TradingCards_KailanBates
{
    public partial class Form1 : Form
    {

        private BindingList<Player> players;

        public Form1()
        {
            InitializeComponent();
            LoadData();
        }


        private void LoadData()
        {
            players = new BindingList<Player>(PlayerData.GetPlayers());

            //MessageBox.Show(players[0].Name);

            DataTable table = new DataTable();
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Team", typeof(string));
            table.Columns.Add("ID", typeof(int));
            foreach (var player in players)
            {
                table.Rows.Add(player.Name, player.Team, player.Id);
            }

            dataGridPlayers.DataSource = table;

        }

        private void btnViewPlayer_Click(object sender, EventArgs e)
        {
            int playerId = (int)dataGridPlayers.SelectedRows[0].Cells["ID"].Value;

            var player = players.Where(p => p.Id == playerId).SingleOrDefault();

            //MessageBox.Show(player.Name);

            lblName.DataBindings.Add("Text", player, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
            lblTeam.DataBindings.Add("Text", player, "Team", true, DataSourceUpdateMode.OnPropertyChanged);


            //MessageBox.Show((string)dataGridPlayers.SelectedRows[0].Cells["Name"].Value);
            //playerCard1.Name.DataBindings.Add("Text", player, "Name", true, DataSourceUpdateMode.OnPropertyChanged);

            //playerCard1.Name = (string)dataGridPlayers.SelectedRows[0].Cells["Name"].Value;
            //playerCard1.Team = (string)dataGridPlayers.SelectedRows[0].Cells["Team"].Value;

        }
    }
}
