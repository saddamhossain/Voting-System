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
    public partial class MainUi : Form
    {
        public MainUi()
        {
            InitializeComponent();
           
        }

        private void CandidateEntryButton_Click(object sender, EventArgs e)
        {
            CandidateEntryUi aCandidateEntryUi=new CandidateEntryUi();
            aCandidateEntryUi.ShowDialog();
            
        }

        private void selectNumberOfWinnerButton_Click(object sender, EventArgs e)
        {
            WinnerUi aWinnerUi=new WinnerUi();
            aWinnerUi.ShowDialog();
          
        }

        private void voteButton_Click(object sender, EventArgs e)
        {
            VotingUi aVotingUi=new VotingUi();
            aVotingUi.ShowDialog();
        }

        private void electionResultButton_Click(object sender, EventArgs e)
        {
            ElectionResultUi aElectionResultUi=new ElectionResultUi();
            aElectionResultUi.ShowDialog();
        }

      
    }
}
