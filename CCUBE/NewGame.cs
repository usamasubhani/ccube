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
    public partial class NewGame : Form
    {
        Player player1;
        Player player2;
        FacadeController facade = FacadeController.getFController();
        int players = 2;
        public NewGame()
        {
            
            InitializeComponent();
        }

        private void NewGame_Load(object sender, EventArgs e)
        {
            
            
        }

        private void radio1_CheckedChanged(object sender, EventArgs e)
        {
            
            player2Box.Hide();
            players = 1;
        }

        private void radio2_CheckedChanged(object sender, EventArgs e)
        {
            player2Box.Show();
            players = 2;
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {   
            if (players == 2)
            {
                if (player1 != null && player2 != null)
                {
                    if (facade.StartGame(player1, player2)) //Game Started
                        MessageBox.Show("Game Started");
                    else
                        MessageBox.Show("No table available.");
                }
                else
                    MessageBox.Show("Select 2 Players.");
            }

            else if(players == 1)
            {
                if (player1 != null)
                    MessageBox.Show(facade.OnePlayerArrived(player1));
                else
                    MessageBox.Show("Select a player");
            }
            else 
                MessageBox.Show("Error!!!!");

            this.Close();
        }

        private void selectBtn1_Click(object sender, EventArgs e)
        {
            SelectPlayer dialog = new SelectPlayer();
            DialogResult result = dialog.ShowDialog();

            if(result == DialogResult.OK)
            {
                player1 = dialog.p;
            }
        }

        private void selectBtn2_Click(object sender, EventArgs e)
        {
            SelectPlayer dialog = new SelectPlayer();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                player2 = dialog.p;
            }
        }

        

    }
}
