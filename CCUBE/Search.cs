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
    public partial class Search : Form
    {
        FacadeController facade = FacadeController.getFController();
        public Search()
        {
            InitializeComponent();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            if(searchBox.Text != string.Empty)
            {
                string token = searchBox.Text;
                Player result = facade.SearchPlayer(token);
                if (result != null)
                {
                    idLabel.Text = result.PlayerID.ToString();
                    nameLabel.Text = result.PlayerName;
                    cnicLabel.Text = result.CNIC;
                    playedLabel.Text = result.GamesPlayed.ToString();
                    LostLabel.Text = result.GamesLost.ToString();
                    wonLabel.Text = result.GamesWon.ToString();
                }
                else
                    MessageBox.Show("No player with this name.");
            }

            else //Empty field
            {
                MessageBox.Show("Cant search without a clue.");
            }
        }
    }
}
