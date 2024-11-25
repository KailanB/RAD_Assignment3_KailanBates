using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sodv2101_Assignment3TradingCards_KailanBates
{
    public partial class CardView : Form
    {
        private int PlayerId {  get; set; } 

        public CardView()
        {
            InitializeComponent();
        }


        public CardView(int ID)
        {
            PlayerId = ID;

            InitializeComponent();

            LoadPlayerData();
        }

        private void LoadPlayerData()
        {
            //BindingList<Player> playerList = new BindingList<Player>();
            //playerList = PlayerData.GetPlayers();

            //var player = playerList.Where(p => p.Id == PlayerId);

            //playerCard1.Name.DataBindings.Add("Text", player, "Name", true, DataSourceUpdateMode.OnPropertyChanged);

            //lblName.DataBindings.Add("Text", player, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
            //playerCard1.Name = (string)dataGridPlayers.SelectedRows[0].Cells["Name"].Value;
            //playerCard1.Team = (string)dataGridPlayers.SelectedRows[0].Cells["Team"].Value;

        }
    }
}
