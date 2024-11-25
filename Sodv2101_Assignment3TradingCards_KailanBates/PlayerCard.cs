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
    public partial class PlayerCard : UserControl
    {
        public PlayerCard()
        {
            InitializeComponent();
        }


        public string Name
        {
            get { return lblName.Text; }
            set { lblName.Text = value; } 
        }

        public string Team
        {
            get { return lblTeam.Text; }
            set { lblTeam.Text = value; }
        }


        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
