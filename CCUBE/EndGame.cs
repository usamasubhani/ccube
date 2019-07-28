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
    public partial class EndGame : Form
    {
        FacadeController facade = FacadeController.getFController();
        List<Game> list = new List<Game>();
        int i = 0;
        public EndGame()
        {
            InitializeComponent();
            list = facade.GetGames();
        }

        private void EndGame_Load(object sender, EventArgs e)
        {
            
            int games = list.Count;
            
            switch (games)
            {
                case 9:
                    button1.Text = list[8].TableName + "\r\n" + list[8].Player1.PlayerName + "\r\n" + list[8].Player2.PlayerName;
                    button1.Show();
                    goto case 8;
                case 8:
                    button2.Text = list[7].TableName + "\r\n" + list[7].Player1.PlayerName + "\r\n" + list[7].Player2.PlayerName;
                    button2.Show();
                    goto case 7;
                case 7:
                    button3.Text = list[6].TableName + "\r\n" + list[6].Player1.PlayerName + "\r\n" + list[6].Player2.PlayerName;
                    button3.Show();
                    goto case 6;
                case 6:
                    button4.Text = list[5].TableName + "\r\n" + list[5].Player1.PlayerName + "\r\n" + list[5].Player2.PlayerName;
                    button4.Show();
                    goto case 6;
                case 5:
                    button5.Text = list[4].TableName + "\r\n" + list[4].Player1.PlayerName + "\r\n" + list[4].Player2.PlayerName;
                    button5.Show();
                    goto case 4;
                case 4:
                    button6.Text = list[3].TableName + "\r\n" + list[3].Player1.PlayerName + "\r\n" + list[3].Player2.PlayerName;
                    button6.Show();
                    goto case 3;
                case 3:
                    button7.Text = list[2].TableName + "\r\n" + list[2].Player1.PlayerName + "\r\n" + list[2].Player2.PlayerName;
                    button7.Show();
                    goto case 2;
                case 2:
                    button8.Text = list[1].TableName + "\r\n" + list[1].Player1.PlayerName + "\r\n" + list[1].Player2.PlayerName;
                    button8.Show();
                    goto case 1;
                case 1:
                    button9.Text = list[0].TableName + "\r\n" + list[0].Player1.PlayerName + "\r\n" + list[0].Player2.PlayerName;
                    button9.Show();
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectWinnerDialog dialog = new SelectWinnerDialog(list[8].Player1, list[8].Player2);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                list[8].Player1.GamesPlayed++;
                list[8].Player2.GamesPlayed++;
                if(dialog.winner == list[8].Player1)
                {
                    list[8].Player1.GamesWon++;
                    list[8].Player2.GamesLost++;
                }
                else if (dialog.winner == list[8].Player2)
                {
                    list[8].Player2.GamesWon++;
                    list[8].Player1.GamesLost++;
                }

                list[8].GameEnd();
                facade.FreeTable(list[8].TableName, list, 8);
                button1.Hide();
            }
            
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            i = 7;
            SelectWinnerDialog dialog = new SelectWinnerDialog(list[i].Player1, list[i].Player2);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                list[i].Player1.GamesPlayed++;
                list[i].Player2.GamesPlayed++;
                if (dialog.winner == list[i].Player1)
                {
                    list[i].Player1.GamesWon++;
                    list[i].Player2.GamesLost++;
                }
                else if (dialog.winner == list[i].Player2)
                {
                    list[i].Player2.GamesWon++;
                    list[i].Player1.GamesLost++;
                }

                list[i].GameEnd();
                facade.FreeTable(list[i].TableName, list, i);
                button2.Hide();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            i = 6;
            SelectWinnerDialog dialog = new SelectWinnerDialog(list[i].Player1, list[i].Player2);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                list[i].Player1.GamesPlayed++;
                list[i].Player2.GamesPlayed++;
                if (dialog.winner == list[i].Player1)
                {
                    list[i].Player1.GamesWon++;
                    list[i].Player2.GamesLost++;
                }
                else if (dialog.winner == list[i].Player2)
                {
                    list[i].Player2.GamesWon++;
                    list[i].Player1.GamesLost++;
                }

                list[i].GameEnd();
                facade.FreeTable(list[i].TableName, list, i);
                button3.Hide();
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            i = 5;
            SelectWinnerDialog dialog = new SelectWinnerDialog(list[i].Player1, list[i].Player2);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                list[i].Player1.GamesPlayed++;
                list[i].Player2.GamesPlayed++;
                if (dialog.winner == list[i].Player1)
                {
                    list[i].Player1.GamesWon++;
                    list[i].Player2.GamesLost++;
                }
                else if (dialog.winner == list[i].Player2)
                {
                    list[i].Player2.GamesWon++;
                    list[i].Player1.GamesLost++;
                }

                list[i].GameEnd();
                facade.FreeTable(list[i].TableName, list, i);
                button4.Hide();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            i = 4;
            SelectWinnerDialog dialog = new SelectWinnerDialog(list[i].Player1, list[i].Player2);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                list[i].Player1.GamesPlayed++;
                list[i].Player2.GamesPlayed++;
                if (dialog.winner == list[i].Player1)
                {
                    list[i].Player1.GamesWon++;
                    list[i].Player2.GamesLost++;
                }
                else if (dialog.winner == list[i].Player2)
                {
                    list[i].Player2.GamesWon++;
                    list[i].Player1.GamesLost++;
                }

                list[i].GameEnd();
                facade.FreeTable(list[i].TableName, list, i);
                button5.Hide();
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            i = 3;
            SelectWinnerDialog dialog = new SelectWinnerDialog(list[i].Player1, list[i].Player2);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                list[i].Player1.GamesPlayed++;
                list[i].Player2.GamesPlayed++;
                if (dialog.winner == list[i].Player1)
                {
                    list[i].Player1.GamesWon++;
                    list[i].Player2.GamesLost++;
                }
                else if (dialog.winner == list[i].Player2)
                {
                    list[i].Player2.GamesWon++;
                    list[i].Player1.GamesLost++;
                }

                list[i].GameEnd();
                facade.FreeTable(list[i].TableName, list, i);
                button6.Hide();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            i = 2;
            SelectWinnerDialog dialog = new SelectWinnerDialog(list[i].Player1, list[i].Player2);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                list[i].Player1.GamesPlayed++;
                list[i].Player2.GamesPlayed++;
                if (dialog.winner == list[i].Player1)
                {
                    list[i].Player1.GamesWon++;
                    list[i].Player2.GamesLost++;
                }
                else if (dialog.winner == list[i].Player2)
                {
                    list[i].Player2.GamesWon++;
                    list[i].Player1.GamesLost++;
                }

                list[i].GameEnd();
                facade.FreeTable(list[i].TableName, list, i);
                button7.Hide();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            i = 1;
            SelectWinnerDialog dialog = new SelectWinnerDialog(list[i].Player1, list[i].Player2);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                list[i].Player1.GamesPlayed++;
                list[i].Player2.GamesPlayed++;
                if (dialog.winner == list[i].Player1)
                {
                    list[i].Player1.GamesWon++;
                    list[i].Player2.GamesLost++;
                }
                else if (dialog.winner == list[i].Player2)
                {
                    list[i].Player2.GamesWon++;
                    list[i].Player1.GamesLost++;
                }

                list[i].GameEnd();
                facade.FreeTable(list[i].TableName, list, i);
                button8.Hide();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            i = 0;
            SelectWinnerDialog dialog = new SelectWinnerDialog(list[i].Player1, list[i].Player2);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                list[i].Player1.GamesPlayed++;
                list[i].Player2.GamesPlayed++;
                if (dialog.winner == list[i].Player1)
                {
                    list[i].Player1.GamesWon++;
                    list[i].Player2.GamesLost++;
                }
                else if (dialog.winner == list[i].Player2)
                {
                    list[i].Player2.GamesWon++;
                    list[i].Player1.GamesLost++;
                }

                list[i].GameEnd();
                facade.FreeTable(list[i].TableName, list, i);
                button9.Hide();
            }

        }

        

        
    }
}
