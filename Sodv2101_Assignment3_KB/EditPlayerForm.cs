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

		public string Name;
		public string Team;
		public int TeamColorR;
		public int TeamColorG;
		public int TeamColorB;
		public int Interceptions;
		public int PassesDefended;
		public int TotalTackles;
		public int SoloTackles;
		public string Image;



		public EditPlayerForm()
		{
			InitializeComponent();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (txtPlayerName.Text != "" && txtTeamName.Text != "")
			{
				Name = txtPlayerName.Text;
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
				// Add open file dialog for adding image 
				// then get file path that way

			}
			else
			{
				lblError.Text = "Please provide player name and Team name";
			}
		}
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
