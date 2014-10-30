using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace VotingSystemApp
{
    public partial class WinnerUi : Form
    {
        public WinnerUi()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                int numberOfWinner = Convert.ToInt32(numberOfWinnerTextBox.Text);
                Candidate.numberOfWinner = numberOfWinner;
            }
            catch (Exception)
            {
                MessageBox.Show("Only numbers are in the field");
                return;
            }
          
            MessageBox.Show("Number of winner is saved");
            
        }
    }
}
