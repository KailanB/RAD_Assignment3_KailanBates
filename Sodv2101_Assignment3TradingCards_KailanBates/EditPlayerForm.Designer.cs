namespace Sodv2101_Assignment3TradingCards_KailanBates
{
	partial class EditPlayerForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			groupBox2 = new GroupBox();
			numSoloTackles = new NumericUpDown();
			numTotalTackles = new NumericUpDown();
			numPassesDefended = new NumericUpDown();
			numInterceptions = new NumericUpDown();
			label9 = new Label();
			label8 = new Label();
			label7 = new Label();
			label3 = new Label();
			groupBox1 = new GroupBox();
			numGreen = new NumericUpDown();
			numRed = new NumericUpDown();
			label6 = new Label();
			numBlue = new NumericUpDown();
			label5 = new Label();
			label4 = new Label();
			label2 = new Label();
			label1 = new Label();
			txtTeamName = new TextBox();
			txtPlayerName = new TextBox();
			btnCancel = new Button();
			btnEdit = new Button();
			picPlayer = new PictureBox();
			btnAddImg = new Button();
			lblError = new Label();
			groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numSoloTackles).BeginInit();
			((System.ComponentModel.ISupportInitialize)numTotalTackles).BeginInit();
			((System.ComponentModel.ISupportInitialize)numPassesDefended).BeginInit();
			((System.ComponentModel.ISupportInitialize)numInterceptions).BeginInit();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numGreen).BeginInit();
			((System.ComponentModel.ISupportInitialize)numRed).BeginInit();
			((System.ComponentModel.ISupportInitialize)numBlue).BeginInit();
			((System.ComponentModel.ISupportInitialize)picPlayer).BeginInit();
			SuspendLayout();
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(numSoloTackles);
			groupBox2.Controls.Add(numTotalTackles);
			groupBox2.Controls.Add(numPassesDefended);
			groupBox2.Controls.Add(numInterceptions);
			groupBox2.Controls.Add(label9);
			groupBox2.Controls.Add(label8);
			groupBox2.Controls.Add(label7);
			groupBox2.Controls.Add(label3);
			groupBox2.Location = new Point(252, 101);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(218, 149);
			groupBox2.TabIndex = 27;
			groupBox2.TabStop = false;
			groupBox2.Text = "groupBox2";
			// 
			// numSoloTackles
			// 
			numSoloTackles.Location = new Point(131, 108);
			numSoloTackles.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
			numSoloTackles.Name = "numSoloTackles";
			numSoloTackles.Size = new Size(81, 23);
			numSoloTackles.TabIndex = 7;
			// 
			// numTotalTackles
			// 
			numTotalTackles.Location = new Point(131, 79);
			numTotalTackles.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
			numTotalTackles.Name = "numTotalTackles";
			numTotalTackles.Size = new Size(81, 23);
			numTotalTackles.TabIndex = 6;
			// 
			// numPassesDefended
			// 
			numPassesDefended.Location = new Point(131, 50);
			numPassesDefended.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
			numPassesDefended.Name = "numPassesDefended";
			numPassesDefended.Size = new Size(81, 23);
			numPassesDefended.TabIndex = 5;
			// 
			// numInterceptions
			// 
			numInterceptions.Location = new Point(131, 21);
			numInterceptions.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
			numInterceptions.Name = "numInterceptions";
			numInterceptions.Size = new Size(81, 23);
			numInterceptions.TabIndex = 4;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(8, 116);
			label9.Name = "label9";
			label9.Size = new Size(70, 15);
			label9.TabIndex = 3;
			label9.Text = "Solo Tackles";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(6, 87);
			label8.Name = "label8";
			label8.Size = new Size(72, 15);
			label8.TabIndex = 2;
			label8.Text = "Total Tackles";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(6, 58);
			label7.Name = "label7";
			label7.Size = new Size(95, 15);
			label7.TabIndex = 1;
			label7.Text = "Passes Defended";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(6, 29);
			label3.Name = "label3";
			label3.Size = new Size(76, 15);
			label3.TabIndex = 0;
			label3.Text = "Interceptions";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(numGreen);
			groupBox1.Controls.Add(numRed);
			groupBox1.Controls.Add(label6);
			groupBox1.Controls.Add(numBlue);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(label4);
			groupBox1.Location = new Point(12, 101);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(218, 149);
			groupBox1.TabIndex = 26;
			groupBox1.TabStop = false;
			groupBox1.Text = "Team Color RGB";
			// 
			// numGreen
			// 
			numGreen.Location = new Point(131, 70);
			numGreen.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
			numGreen.Name = "numGreen";
			numGreen.Size = new Size(74, 23);
			numGreen.TabIndex = 6;
			// 
			// numRed
			// 
			numRed.Location = new Point(131, 29);
			numRed.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
			numRed.Name = "numRed";
			numRed.Size = new Size(74, 23);
			numRed.TabIndex = 5;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(8, 116);
			label6.Name = "label6";
			label6.Size = new Size(30, 15);
			label6.TabIndex = 13;
			label6.Text = "Blue";
			// 
			// numBlue
			// 
			numBlue.Location = new Point(131, 108);
			numBlue.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
			numBlue.Name = "numBlue";
			numBlue.Size = new Size(74, 23);
			numBlue.TabIndex = 7;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(6, 78);
			label5.Name = "label5";
			label5.Size = new Size(38, 15);
			label5.TabIndex = 12;
			label5.Text = "Green";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(6, 37);
			label4.Name = "label4";
			label4.Size = new Size(27, 15);
			label4.TabIndex = 11;
			label4.Text = "Red";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 52);
			label2.Name = "label2";
			label2.Size = new Size(70, 15);
			label2.TabIndex = 25;
			label2.Text = "Team Name";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 14);
			label1.Name = "label1";
			label1.Size = new Size(74, 15);
			label1.TabIndex = 24;
			label1.Text = "Player Name";
			// 
			// txtTeamName
			// 
			txtTeamName.Location = new Point(108, 49);
			txtTeamName.Name = "txtTeamName";
			txtTeamName.Size = new Size(163, 23);
			txtTeamName.TabIndex = 23;
			// 
			// txtPlayerName
			// 
			txtPlayerName.Location = new Point(108, 11);
			txtPlayerName.Name = "txtPlayerName";
			txtPlayerName.Size = new Size(163, 23);
			txtPlayerName.TabIndex = 22;
			// 
			// btnCancel
			// 
			btnCancel.Location = new Point(12, 483);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(75, 23);
			btnCancel.TabIndex = 21;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnEdit
			// 
			btnEdit.Location = new Point(353, 483);
			btnEdit.Name = "btnEdit";
			btnEdit.Size = new Size(117, 23);
			btnEdit.TabIndex = 20;
			btnEdit.Text = "Edit Player";
			btnEdit.UseVisualStyleBackColor = true;
			btnEdit.Click += btnEdit_Click;
			// 
			// picPlayer
			// 
			picPlayer.Location = new Point(164, 267);
			picPlayer.Name = "picPlayer";
			picPlayer.Size = new Size(306, 204);
			picPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
			picPlayer.TabIndex = 28;
			picPlayer.TabStop = false;
			// 
			// btnAddImg
			// 
			btnAddImg.Location = new Point(12, 267);
			btnAddImg.Name = "btnAddImg";
			btnAddImg.Size = new Size(92, 23);
			btnAddImg.TabIndex = 29;
			btnAddImg.Text = "Add Image";
			btnAddImg.UseVisualStyleBackColor = true;
			btnAddImg.Click += btnAddImg_Click;
			// 
			// lblError
			// 
			lblError.AutoSize = true;
			lblError.ForeColor = Color.Red;
			lblError.Location = new Point(188, 529);
			lblError.Name = "lblError";
			lblError.Size = new Size(0, 15);
			lblError.TabIndex = 30;
			// 
			// EditPlayerForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(487, 553);
			Controls.Add(lblError);
			Controls.Add(btnAddImg);
			Controls.Add(picPlayer);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(txtTeamName);
			Controls.Add(txtPlayerName);
			Controls.Add(btnCancel);
			Controls.Add(btnEdit);
			Name = "EditPlayerForm";
			Text = "EditPlayerForm";
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)numSoloTackles).EndInit();
			((System.ComponentModel.ISupportInitialize)numTotalTackles).EndInit();
			((System.ComponentModel.ISupportInitialize)numPassesDefended).EndInit();
			((System.ComponentModel.ISupportInitialize)numInterceptions).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)numGreen).EndInit();
			((System.ComponentModel.ISupportInitialize)numRed).EndInit();
			((System.ComponentModel.ISupportInitialize)numBlue).EndInit();
			((System.ComponentModel.ISupportInitialize)picPlayer).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private GroupBox groupBox2;
		private NumericUpDown numSoloTackles;
		private NumericUpDown numTotalTackles;
		private NumericUpDown numPassesDefended;
		private NumericUpDown numInterceptions;
		private Label label9;
		private Label label8;
		private Label label7;
		private Label label3;
		private GroupBox groupBox1;
		private NumericUpDown numGreen;
		private NumericUpDown numRed;
		private Label label6;
		private NumericUpDown numBlue;
		private Label label5;
		private Label label4;
		private Label label2;
		private Label label1;
		private TextBox txtTeamName;
		private TextBox txtPlayerName;
		private Button btnCancel;
		private Button btnEdit;
		private PictureBox picPlayer;
		private Button btnAddImg;
		private Label lblError;
	}
}