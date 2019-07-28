using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CcubeLogicLayer;

namespace CCUBE
{
    public partial class SelectWinnerDialog : Form
    {
        public Player p1;
        public Player p2;
        public Player winner;
        public Player loser;
        public SelectWinnerDialog(Player p1, Player p2)
        {
            InitializeComponent();
            this.p1 = p1;
            p1Radio.Text = p1.PlayerName;
            this.p2 = p2;
            p2Radio.Text = p2.PlayerName;
        }

        private void SelectWinnerDialog_Load(object sender, EventArgs e)
        {
            
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (p1Radio.Checked)
            {
                winner = p1;
                loser = p2;
            }
            else if (p2Radio.Checked)
            {
                winner = p2;
                loser = p1;
            }
        }
    }
}
