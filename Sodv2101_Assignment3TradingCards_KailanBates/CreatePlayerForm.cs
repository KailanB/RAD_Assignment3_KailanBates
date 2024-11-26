using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sodv2101_Assignment3TradingCards_KailanBates
{
	public partial class CreatePlayerForm : Form
	{

		private Player _player;


		public CreatePlayerForm()
		{
			InitializeComponent();

			_player = new Player();


			txtPlayerName.DataBindings.Add("Text", _player, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
			txtTeamName.DataBindings.Add("Text", _player, "Team", true, DataSourceUpdateMode.OnPropertyChanged);


			numRed.DataBindings.Add("Text", _player, "TeamColorR", true, DataSourceUpdateMode.OnPropertyChanged);
			numGreen.DataBindings.Add("Text", _player, "TeamColorG", true, DataSourceUpdateMode.OnPropertyChanged);
			numBlue.DataBindings.Add("Text", _player, "TeamColorB", true, DataSourceUpdateMode.OnPropertyChanged);
			numInterceptions.DataBindings.Add("Text", _player, "Interceptions", true, DataSourceUpdateMode.OnPropertyChanged);
			numPassesDefended.DataBindings.Add("Text", _player, "PassesDefended", true, DataSourceUpdateMode.OnPropertyChanged);
			numTotalTackles.DataBindings.Add("Text", _player, "TotalTackles", true, DataSourceUpdateMode.OnPropertyChanged);
			numSoloTackles.DataBindings.Add("Text", _player, "SoloTackles", true, DataSourceUpdateMode.OnPropertyChanged);

			txtImgName.DataBindings.Add("Text", _player, "Image", true, DataSourceUpdateMode.OnPropertyChanged);

			//_player.PropertyChanged += OnPropChange;

		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (txtPlayerName.Text != "" && txtTeamName.Text != "")
			{

				this.DialogResult = DialogResult.OK;
				this.Close();

			}
			else
			{
				lblError.Text = "Please provide player name and Team name";
			}
		}

		public void ChangeBtnName(string newName)
		{
			btnAdd.Text = newName;
		}

		public Player GetPlayer()
		{

			return _player;
		}

	}
}
