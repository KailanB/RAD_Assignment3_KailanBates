namespace Sodv2101_Assignment3TradingCards_KailanBates
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
			btnAdd = new Button();
			btnCancel = new Button();
			txtPlayerName = new TextBox();
			txtTeamName = new TextBox();
			numRed = new NumericUpDown();
			numGreen = new NumericUpDown();
			numBlue = new NumericUpDown();
			label1 = new Label();
			label2 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			groupBox1 = new GroupBox();
			groupBox2 = new GroupBox();
			numSoloTackles = new NumericUpDown();
			numTotalTackles = new NumericUpDown();
			numPassesDefended = new NumericUpDown();
			numInterceptions = new NumericUpDown();
			label9 = new Label();
			label8 = new Label();
			label7 = new Label();
			label3 = new Label();
			label10 = new Label();
			txtImgName = new TextBox();
			label11 = new Label();
			lblError = new Label();
			((System.ComponentModel.ISupportInitialize)numRed).BeginInit();
			((System.ComponentModel.ISupportInitialize)numGreen).BeginInit();
			((System.ComponentModel.ISupportInitialize)numBlue).BeginInit();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numSoloTackles).BeginInit();
			((System.ComponentModel.ISupportInitialize)numTotalTackles).BeginInit();
			((System.ComponentModel.ISupportInitialize)numPassesDefended).BeginInit();
			((System.ComponentModel.ISupportInitialize)numInterceptions).BeginInit();
			SuspendLayout();
			// 
			// btnAdd
			// 
			btnAdd.Location = new Point(247, 462);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(117, 23);
			btnAdd.TabIndex = 0;
			btnAdd.Text = "Add Player";
			btnAdd.UseVisualStyleBackColor = true;
			btnAdd.Click += btnAdd_Click;
			// 
			// btnCancel
			// 
			btnCancel.Location = new Point(10, 462);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(75, 23);
			btnCancel.TabIndex = 1;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = true;
			// 
			// txtPlayerName
			// 
			txtPlayerName.Location = new Point(143, 21);
			txtPlayerName.Name = "txtPlayerName";
			txtPlayerName.Size = new Size(163, 23);
			txtPlayerName.TabIndex = 2;
			// 
			// txtTeamName
			// 
			txtTeamName.Location = new Point(143, 59);
			txtTeamName.Name = "txtTeamName";
			txtTeamName.Size = new Size(163, 23);
			txtTeamName.TabIndex = 3;
			// 
			// numRed
			// 
			numRed.Location = new Point(131, 29);
			numRed.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
			numRed.Name = "numRed";
			numRed.Size = new Size(74, 23);
			numRed.TabIndex = 5;
			// 
			// numGreen
			// 
			numGreen.Location = new Point(131, 58);
			numGreen.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
			numGreen.Name = "numGreen";
			numGreen.Size = new Size(74, 23);
			numGreen.TabIndex = 6;
			// 
			// numBlue
			// 
			numBlue.Location = new Point(131, 87);
			numBlue.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
			numBlue.Name = "numBlue";
			numBlue.Size = new Size(74, 23);
			numBlue.TabIndex = 7;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(47, 24);
			label1.Name = "label1";
			label1.Size = new Size(74, 15);
			label1.TabIndex = 8;
			label1.Text = "Player Name";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(47, 62);
			label2.Name = "label2";
			label2.Size = new Size(70, 15);
			label2.TabIndex = 9;
			label2.Text = "Team Name";
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
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(6, 66);
			label5.Name = "label5";
			label5.Size = new Size(38, 15);
			label5.TabIndex = 12;
			label5.Text = "Green";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(8, 95);
			label6.Name = "label6";
			label6.Size = new Size(30, 15);
			label6.TabIndex = 13;
			label6.Text = "Blue";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(numGreen);
			groupBox1.Controls.Add(numRed);
			groupBox1.Controls.Add(label6);
			groupBox1.Controls.Add(numBlue);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(label4);
			groupBox1.Location = new Point(71, 103);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(218, 127);
			groupBox1.TabIndex = 15;
			groupBox1.TabStop = false;
			groupBox1.Text = "Team Color RGB";
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
			groupBox2.Location = new Point(71, 236);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(218, 149);
			groupBox2.TabIndex = 16;
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
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(71, 394);
			label10.Name = "label10";
			label10.Size = new Size(78, 15);
			label10.TabIndex = 17;
			label10.Text = "Image Name:";
			// 
			// txtImgName
			// 
			txtImgName.Location = new Point(163, 391);
			txtImgName.Name = "txtImgName";
			txtImgName.Size = new Size(126, 23);
			txtImgName.TabIndex = 18;
			// 
			// label11
			// 
			label11.Location = new Point(73, 421);
			label11.Name = "label11";
			label11.Size = new Size(216, 38);
			label11.TabIndex = 19;
			label11.Text = "Please make sure your desired image is in the app image folder!";
			// 
			// lblError
			// 
			lblError.AutoSize = true;
			lblError.ForeColor = Color.Red;
			lblError.Location = new Point(85, 500);
			lblError.Name = "lblError";
			lblError.Size = new Size(0, 15);
			lblError.TabIndex = 20;
			// 
			// CreatePlayerForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(376, 524);
			Controls.Add(lblError);
			Controls.Add(label11);
			Controls.Add(txtImgName);
			Controls.Add(label10);
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
			((System.ComponentModel.ISupportInitialize)numRed).EndInit();
			((System.ComponentModel.ISupportInitialize)numGreen).EndInit();
			((System.ComponentModel.ISupportInitialize)numBlue).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)numSoloTackles).EndInit();
			((System.ComponentModel.ISupportInitialize)numTotalTackles).EndInit();
			((System.ComponentModel.ISupportInitialize)numPassesDefended).EndInit();
			((System.ComponentModel.ISupportInitialize)numInterceptions).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnAdd;
		private Button btnCancel;
		private TextBox txtPlayerName;
		private TextBox txtTeamName;
		private NumericUpDown numRed;
		private NumericUpDown numGreen;
		private NumericUpDown numBlue;
		private Label label1;
		private Label label2;
		private Label label4;
		private Label label5;
		private Label label6;
		private GroupBox groupBox1;
		private GroupBox groupBox2;
		private NumericUpDown numSoloTackles;
		private NumericUpDown numTotalTackles;
		private NumericUpDown numPassesDefended;
		private NumericUpDown numInterceptions;
		private Label label9;
		private Label label8;
		private Label label7;
		private Label label3;
		private Label label10;
		private TextBox txtImgName;
		private Label label11;
		private Label lblError;
	}
}