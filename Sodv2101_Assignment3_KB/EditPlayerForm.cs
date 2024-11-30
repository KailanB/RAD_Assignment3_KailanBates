using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sodv2101_Assignment3_KB
{
	public partial class EditPlayerForm : Form
	{

		public string PlayerName { get; set; }
		public string Team { get; set; }
		public int TeamColorR { get; set; }
		public int TeamColorG { get; set; }
		public int TeamColorB { get; set; }
		public int Interceptions { get; set; }
		public int PassesDefended { get; set; }
		public int TotalTackles { get; set; }
		public int SoloTackles { get; set; }
		public string Image { get; set; }



		public EditPlayerForm()
		{
			InitializeComponent();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (txtPlayerName.Text != "" && txtTeamName.Text != "")
			{
				PlayerName = txtPlayerName.Text;
				Team = txtTeamName.Text;
				TeamColorR = (Int32)numRed.Value;
				TeamColorG = (Int32)numGreen.Value;
				TeamColorB = (Int32)numBlue.Value;
				Interceptions = (Int32)numInterceptions.Value;
				PassesDefended = (Int32)numPassesDefended.Value;
				TotalTackles = (Int32)numTotalTackles.Value;
				SoloTackles = (Int32)numSoloTackles.Value;

				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			else
			{
				lblError.Text = "Please provide player name and Team name";
			}
		}
		// used to pre populate the edit form with current player details
		public void PopulateCurrentPlayer(Player player)
		{
			txtPlayerName.Text = player.Name;
			txtTeamName.Text = player.Team;
			numRed.Value = player.TeamColorR;
			numGreen.Value = player.TeamColorG;
			numBlue.Value = player.TeamColorB;
			numInterceptions.Value = player.Interceptions;
			numPassesDefended.Value = player.PassesDefended;
			numTotalTackles.Value = player.TotalTackles;
			numSoloTackles.Value = player.SoloTackles;
			Image = player.Image;
			picPlayer.ImageLocation = player.Image;

		}

		private void btnAddImg_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				picPlayer.ImageLocation = ofd.FileName;
				Image = ofd.FileName;
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
	}




}
