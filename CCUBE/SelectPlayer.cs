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
    public partial class SelectPlayer : Form
    {
        public Player p;
        FacadeController facade = FacadeController.getFController();
        public SelectPlayer()
        {
            InitializeComponent();
        }

        private void SelectPlayer_Load(object sender, EventArgs e)
        {
            playersCombo.DataSource = facade.GetPlayers();
            playersCombo.ValueMember = null;
            playersCombo.DisplayMember = "PlayerName";

        }

        private void okbtn_Click(object sender, EventArgs e)
        {
            p = (Player)playersCombo.SelectedItem;
            
        }



        private void playersCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            p = (Player)playersCombo.SelectedItem;
            MessageBox.Show(p.PlayerName);
        }
    }
}
