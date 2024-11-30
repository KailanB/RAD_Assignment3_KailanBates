namespace Sodv2101_Assignment3_KB
{
	partial class CreatePlayerForm
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
			lblError = new Label();
			btnAddImg = new Button();
			picPlayer = new PictureBox();
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
			btnAdd = new Button();
			((System.ComponentModel.ISupportInitialize)picPlayer).BeginInit();
			groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numSoloTackles).BeginInit();
			((System.ComponentModel.ISupportInitialize)numTotalTackles).BeginInit();
			((System.ComponentModel.ISupportInitialize)numPassesDefended).BeginInit();
			((System.ComponentModel.ISupportInitialize)numInterceptions).BeginInit();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numGreen).BeginInit();
			((System.ComponentModel.ISupportInitialize)numRed).BeginInit();
			((System.ComponentModel.ISupportInitialize)numBlue).BeginInit();
			SuspendLayout();
			// 
			// lblError
			// 
			lblError.AutoSize = true;
			lblError.ForeColor = Color.Red;
			lblError.Location = new Point(207, 519);
			lblError.Name = "lblError";
			lblError.Size = new Size(0, 15);
			lblError.TabIndex = 41;
			// 
			// btnAddImg
			// 
			btnAddImg.Location = new Point(12, 265);
			btnAddImg.Name = "btnAddImg";
			btnAddImg.Size = new Size(92, 23);
			btnAddImg.TabIndex = 40;
			btnAddImg.Text = "Add Image";
			btnAddImg.UseVisualStyleBackColor = true;
			btnAddImg.Click += btnAddImg_Click;
			// 
			// picPlayer
			// 
			picPlayer.Location = new Point(164, 265);
			picPlayer.Name = "picPlayer";
			picPlayer.Size = new Size(306, 204);
			picPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
			picPlayer.TabIndex = 39;
			picPlayer.TabStop = false;
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
			groupBox2.Location = new Point(252, 99);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(218, 149);
			groupBox2.TabIndex = 38;
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
			groupBox1.Location = new Point(12, 99);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(218, 149);
			groupBox1.TabIndex = 37;
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
			label2.Location = new Point(12, 50);
			label2.Name = "label2";
			label2.Size = new Size(70, 15);
			label2.TabIndex = 36;
			label2.Text = "Team Name";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 12);
			label1.Name = "label1";
			label1.Size = new Size(74, 15);
			label1.TabIndex = 35;
			label1.Text = "Player Name";
			// 
			// txtTeamName
			// 
			txtTeamName.Location = new Point(108, 47);
			txtTeamName.Name = "txtTeamName";
			txtTeamName.Size = new Size(163, 23);
			txtTeamName.TabIndex = 34;
			// 
			// txtPlayerName
			// 
			txtPlayerName.Location = new Point(108, 9);
			txtPlayerName.Name = "txtPlayerName";
			txtPlayerName.Size = new Size(163, 23);
			txtPlayerName.TabIndex = 33;
			// 
			// btnCancel
			// 
			btnCancel.Location = new Point(12, 481);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(75, 23);
			btnCancel.TabIndex = 32;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = true;
			btnCancel.Click += btnCancel_Click;
			// 
			// btnAdd
			// 
			btnAdd.Location = new Point(353, 481);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(117, 23);
			btnAdd.TabIndex = 31;
			btnAdd.Text = "Add Player";
			btnAdd.UseVisualStyleBackColor = true;
			btnAdd.Click += btnAdd_Click;
			// 
			// CreatePlayerForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(498, 540);
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
			Controls.Add(btnAdd);
			Name = "CreatePlayerForm";
			Text = "CreatePlayerForm";
			((System.ComponentModel.ISupportInitialize)picPlayer).EndInit();
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
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblError;
		private Button btnAddImg;
		private PictureBox picPlayer;
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
		private Button btnAdd;
	}
}