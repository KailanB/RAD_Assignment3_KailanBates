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
            btnViewPlayer = new Button();
            label2 = new Label();
            lblName = new Label();
            lblTeam = new Label();
            dataGridPlayerStats = new DataGridView();
            lblStats = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridPlayers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridPlayerStats).BeginInit();
            SuspendLayout();
            // 
            // dataGridPlayers
            // 
            dataGridPlayers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPlayers.Location = new Point(29, 50);
            dataGridPlayers.Name = "dataGridPlayers";
            dataGridPlayers.Size = new Size(251, 227);
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
            // btnViewPlayer
            // 
            btnViewPlayer.Location = new Point(189, 294);
            btnViewPlayer.Name = "btnViewPlayer";
            btnViewPlayer.Size = new Size(91, 23);
            btnViewPlayer.TabIndex = 3;
            btnViewPlayer.Text = "View Player";
            btnViewPlayer.UseVisualStyleBackColor = true;
            btnViewPlayer.Click += btnViewPlayer_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(370, 23);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 5;
            label2.Text = "Player Card";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(370, 50);
            lblName.Name = "lblName";
            lblName.Size = new Size(10, 15);
            lblName.TabIndex = 6;
            lblName.Text = ".";
            // 
            // lblTeam
            // 
            lblTeam.AutoSize = true;
            lblTeam.Location = new Point(370, 77);
            lblTeam.Name = "lblTeam";
            lblTeam.Size = new Size(10, 15);
            lblTeam.TabIndex = 7;
            lblTeam.Text = ".";
            // 
            // dataGridPlayerStats
            // 
            dataGridPlayerStats.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPlayerStats.Location = new Point(370, 127);
            dataGridPlayerStats.Name = "dataGridPlayerStats";
            dataGridPlayerStats.Size = new Size(240, 150);
            dataGridPlayerStats.TabIndex = 8;
            // 
            // lblStats
            // 
            lblStats.AutoSize = true;
            lblStats.Location = new Point(370, 103);
            lblStats.Name = "lblStats";
            lblStats.Size = new Size(32, 15);
            lblStats.TabIndex = 9;
            lblStats.Text = "Stats";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 345);
            Controls.Add(lblStats);
            Controls.Add(dataGridPlayerStats);
            Controls.Add(lblTeam);
            Controls.Add(lblName);
            Controls.Add(label2);
            Controls.Add(btnViewPlayer);
            Controls.Add(label1);
            Controls.Add(dataGridPlayers);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridPlayers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridPlayerStats).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridPlayers;
        private Label label1;
        private Button btnViewPlayer;
        private Label label2;
        private Label lblName;
        private Label lblTeam;
        private DataGridView dataGridPlayerStats;
        private Label lblStats;
    }
}
