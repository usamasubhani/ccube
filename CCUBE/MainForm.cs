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
    public partial class MainForm : Form
    {
        FacadeController facade = FacadeController.getFController();
        public MainForm()
        {
            InitializeComponent();    
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            if(nameTextBox.Text != string.Empty && cnicTextBox.Text != string.Empty)
            {
                string tempName = nameTextBox.Text;
                string tempCnic = cnicTextBox.Text;
                //int done = facade.RegisterPlayer(tempName, tempCnic);
                //if (done == 1)
                    MessageBox.Show("Registered!");
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            Search s = new Search();
            s.Show();
        }

        private void requestGameBtn_Click(object sender, EventArgs e)
        {
            NewGame ngame = new NewGame();
            ngame.Show();
        }

        private void declareResultBtn_Click(object sender, EventArgs e)
        {
            if (facade.GameStatus())
            {
                EndGame end = new EndGame();
                end.Show();
            }
            else
                MessageBox.Show("No game in progress.");
        }

        private void updateStatusTimer_Tick(object sender, EventArgs e)
        {
            Table[] tables = facade.GetTableStatus();
            if (tables[0].Busy == false)
                t1busyLabel.Text = "Available";
            else if(tables[0].Busy == true)
                t1busyLabel.Text = "Busy";

            if (tables[1].Busy == false)
                t2Busy.Text = "Available";
            else if (tables[1].Busy == true)
                t2Busy.Text = "Busy";

            if (tables[2].Busy == false)
                t3Busy.Text = "Available";
            else if (tables[2].Busy == true)
                t3Busy.Text = "Busy";

            if (tables[3].Busy == false)
                label4.Text = "Available";
            else if (tables[3].Busy == true)
                label4.Text = "Busy";

            if (tables[4].Busy == false)
                t5Busy.Text = "Available";
            else if (tables[4].Busy == true)
                t5Busy.Text = "Busy";

            if (tables[5].Busy == false)
                t6Busy.Text = "Available";
            else if (tables[5].Busy == true)
                t6Busy.Text = "Busy";

            if (tables[6].Busy == false)
                t7Busy.Text = "Available";
            else if (tables[6].Busy == true)
                t7Busy.Text = "Busy";

            if (tables[7].Busy == false)
                t8Busy.Text = "Available";
            else if (tables[7].Busy == true)
                t8Busy.Text = "Busy";

            if (tables[8].Busy == false)
                t9Busy.Text = "Available";
            else if (tables[8].Busy == true)
                t9Busy.Text = "Busy";
        }
    }
}
