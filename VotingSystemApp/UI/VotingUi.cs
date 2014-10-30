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
    public partial class VotingUi : Form
    {
        public VotingUi()
        {
            InitializeComponent();
            ShowSymbolOfCandidateInComboBox();
        }

        private void ShowSymbolOfCandidateInComboBox()
        {
            List<Candidate> candidatesList = VotingBll.GetCandidateList();
            foreach (var candidate in candidatesList)
            {
                selectSymbolOfCandidateComboBox.Items.Add(candidate);
            }
            selectSymbolOfCandidateComboBox.DisplayMember = "Symbol";
        }

        private void castButton_Click(object sender, EventArgs e)
        {
            if (votersEmailAddressTextBox.Text == "" || selectSymbolOfCandidateComboBox.Text == "")
            {
                MessageBox.Show("Please fill the filled accordingly");
                return;
            }
            Voter aVoter=new Voter();
            aVoter.Email = votersEmailAddressTextBox.Text;
            aVoter.VoterID = VotingBll.GetVoterID(aVoter.Email);
            Candidate aCandidate=new Candidate();
            aCandidate = (Candidate) selectSymbolOfCandidateComboBox.SelectedItem;
            string msg = VotingBll.VoteCast(aVoter.VoterID, aCandidate.CandidateID);
            MessageBox.Show(msg);

        }
    }
}
