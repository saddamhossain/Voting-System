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
    public partial class CandidateEntryUi : Form
    {
        public CandidateEntryUi()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Candidate aCandidate=new Candidate(candidateNameTextBox.Text,symbolTextBox.Text);
            CandidateEntryBLL aCandidateEntryBLL=new CandidateEntryBLL();
            string msg = aCandidateEntryBLL.Save(aCandidate);
            MessageBox.Show(msg);

        }
    }
}
