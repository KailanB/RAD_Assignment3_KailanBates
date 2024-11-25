namespace Sodv2101_Assignment3TradingCards_KailanBates
{
    partial class CardView
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
            playerCard1 = new PlayerCard();
            lblName = new Label();
            playerCard2 = new PlayerCard();
            SuspendLayout();
            // 
            // playerCard1
            // 
            playerCard1.Location = new Point(12, 12);
            playerCard1.Name = "playerCard1";
            playerCard1.Size = new Size(280, 278);
            playerCard1.TabIndex = 0;
            playerCard1.Team = ".";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(27, 294);
            lblName.Name = "lblName";
            lblName.Size = new Size(38, 15);
            lblName.TabIndex = 1;
            lblName.Text = "label1";
            // 
            // playerCard2
            // 
            playerCard2.Location = new Point(0, 0);
            playerCard2.Name = "playerCard2";
            playerCard2.Size = new Size(280, 278);
            playerCard2.TabIndex = 2;
            playerCard2.Team = ".";
            // 
            // CardView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 327);
            Controls.Add(playerCard2);
            Controls.Add(lblName);
            Controls.Add(playerCard1);
            Name = "CardView";
            Text = "CardView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PlayerCard playerCard1;
        private Label lblName;
        private PlayerCard playerCard2;
    }
}