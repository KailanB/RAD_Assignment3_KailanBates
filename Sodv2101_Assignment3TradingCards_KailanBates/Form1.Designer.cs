namespace Sodv2101_Assignment3TradingCards_KailanBates
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			dataGridPlayers = new DataGridView();
			label1 = new Label();
			label2 = new Label();
			lblName = new Label();
			lblTeam = new Label();
			btnEdit = new Button();
			btnDelete = new Button();
			btnAdd = new Button();
			label3 = new Label();
			label4 = new Label();
			groupBox1 = new GroupBox();
			lblSoloTackles = new Label();
			lblTotalTackles = new Label();
			lblPassesDefended = new Label();
			lblInterceptions = new Label();
			label8 = new Label();
			label7 = new Label();
			label6 = new Label();
			label5 = new Label();
			picBoxPlayer = new PictureBox();
			((System.ComponentModel.ISupportInitialize)dataGridPlayers).BeginInit();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)picBoxPlayer).BeginInit();
			SuspendLayout();
			// 
			// dataGridPlayers
			// 
			dataGridPlayers.AllowUserToAddRows = false;
			dataGridPlayers.AllowUserToDeleteRows = false;
			dataGridPlayers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridPlayers.Location = new Point(29, 50);
			dataGridPlayers.Name = "dataGridPlayers";
			dataGridPlayers.Size = new Size(310, 390);
			dataGridPlayers.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(29, 23);
			label1.Name = "label1";
			label1.Size = new Size(44, 15);
			label1.TabIndex = 2;
			label1.Text = "Players";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(402, 9);
			label2.Name = "label2";
			label2.Size = new Size(67, 15);
			label2.TabIndex = 5;
			label2.Text = "Player Card";
			// 
			// lblName
			// 
			lblName.AutoSize = true;
			lblName.Location = new Point(541, 50);
			lblName.Name = "lblName";
			lblName.Size = new Size(10, 15);
			lblName.TabIndex = 6;
			lblName.Text = ".";
			// 
			// lblTeam
			// 
			lblTeam.AutoSize = true;
			lblTeam.Location = new Point(541, 79);
			lblTeam.Name = "lblTeam";
			lblTeam.Size = new Size(10, 15);
			lblTeam.TabIndex = 7;
			lblTeam.Text = ".";
			// 
			// btnEdit
			// 
			btnEdit.Location = new Point(145, 463);
			btnEdit.Name = "btnEdit";
			btnEdit.Size = new Size(75, 23);
			btnEdit.TabIndex = 10;
			btnEdit.Text = "Edit";
			btnEdit.UseVisualStyleBackColor = true;
			btnEdit.Click += btnEdit_Click;
			// 
			// btnDelete
			// 
			btnDelete.Location = new Point(264, 463);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(75, 23);
			btnDelete.TabIndex = 11;
			btnDelete.Text = "Delete";
			btnDelete.UseVisualStyleBackColor = true;
			btnDelete.Click += btnDelete_Click;
			// 
			// btnAdd
			// 
			btnAdd.Location = new Point(29, 463);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(75, 23);
			btnAdd.TabIndex = 12;
			btnAdd.Text = "Add New";
			btnAdd.UseVisualStyleBackColor = true;
			btnAdd.Click += btnAdd_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(402, 50);
			label3.Name = "label3";
			label3.Size = new Size(77, 15);
			label3.TabIndex = 13;
			label3.Text = "Player Name:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(402, 79);
			label4.Name = "label4";
			label4.Size = new Size(76, 15);
			label4.TabIndex = 14;
			label4.Text = "Team Name: ";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(lblSoloTackles);
			groupBox1.Controls.Add(lblTotalTackles);
			groupBox1.Controls.Add(lblPassesDefended);
			groupBox1.Controls.Add(lblInterceptions);
			groupBox1.Controls.Add(label8);
			groupBox1.Controls.Add(label7);
			groupBox1.Controls.Add(label6);
			groupBox1.Controls.Add(label5);
			groupBox1.Location = new Point(454, 307);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(198, 118);
			groupBox1.TabIndex = 15;
			groupBox1.TabStop = false;
			groupBox1.Text = "Stats";
			// 
			// lblSoloTackles
			// 
			lblSoloTackles.AutoSize = true;
			lblSoloTackles.Location = new Point(139, 94);
			lblSoloTackles.Name = "lblSoloTackles";
			lblSoloTackles.Size = new Size(10, 15);
			lblSoloTackles.TabIndex = 7;
			lblSoloTackles.Text = ".";
			// 
			// lblTotalTackles
			// 
			lblTotalTackles.AutoSize = true;
			lblTotalTackles.Location = new Point(139, 68);
			lblTotalTackles.Name = "lblTotalTackles";
			lblTotalTackles.Size = new Size(10, 15);
			lblTotalTackles.TabIndex = 6;
			lblTotalTackles.Text = ".";
			// 
			// lblPassesDefended
			// 
			lblPassesDefended.AutoSize = true;
			lblPassesDefended.Location = new Point(139, 43);
			lblPassesDefended.Name = "lblPassesDefended";
			lblPassesDefended.Size = new Size(10, 15);
			lblPassesDefended.TabIndex = 5;
			lblPassesDefended.Text = ".";
			// 
			// lblInterceptions
			// 
			lblInterceptions.AutoSize = true;
			lblInterceptions.Location = new Point(139, 19);
			lblInterceptions.Name = "lblInterceptions";
			lblInterceptions.Size = new Size(10, 15);
			lblInterceptions.TabIndex = 4;
			lblInterceptions.Text = ".";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(6, 94);
			label8.Name = "label8";
			label8.Size = new Size(73, 15);
			label8.TabIndex = 3;
			label8.Text = "Solo Tackles:";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(6, 68);
			label7.Name = "label7";
			label7.Size = new Size(75, 15);
			label7.TabIndex = 2;
			label7.Text = "Total Tackles:";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(6, 43);
			label6.Name = "label6";
			label6.Size = new Size(98, 15);
			label6.TabIndex = 1;
			label6.Text = "Passes Defended:";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(6, 19);
			label5.Name = "label5";
			label5.Size = new Size(79, 15);
			label5.TabIndex = 0;
			label5.Text = "Interceptions:";
			// 
			// picBoxPlayer
			// 
			picBoxPlayer.Location = new Point(402, 97);
			picBoxPlayer.Name = "picBoxPlayer";
			picBoxPlayer.Size = new Size(306, 204);
			picBoxPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
			picBoxPlayer.TabIndex = 16;
			picBoxPlayer.TabStop = false;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(867, 525);
			Controls.Add(picBoxPlayer);
			Controls.Add(groupBox1);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(btnAdd);
			Controls.Add(btnDelete);
			Controls.Add(btnEdit);
			Controls.Add(lblTeam);
			Controls.Add(lblName);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(dataGridPlayers);
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)dataGridPlayers).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)picBoxPlayer).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private DataGridView dataGridPlayers;
        private Label label1;
        private Label label2;
        private Label lblName;
        private Label lblTeam;
		private Button btnEdit;
		private Button btnDelete;
		private Button btnAdd;
		private Label label3;
		private Label label4;
		private GroupBox groupBox1;
		private Label lblSoloTackles;
		private Label lblTotalTackles;
		private Label lblPassesDefended;
		private Label lblInterceptions;
		private Label label8;
		private Label label7;
		private Label label6;
		private Label label5;
		private PictureBox picBoxPlayer;
	}
}
