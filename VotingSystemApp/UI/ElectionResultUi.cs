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
    public partial class ElectionResultUi : Form
    {
        public ElectionResultUi()
        {
            InitializeComponent();
            ShowResult();
        }

        private void ShowResult()
        {
            List<Result> results = ElectionResultBll.GetEllectionResult();
            results=results.OrderByDescending(o=>o.vote).ToList();
            foreach (var result in results)
            {
                ListViewItem item=new ListViewItem(result.CandidateName);
                item.SubItems.Add(result.Symbol);
                item.SubItems.Add(result.Status);
                item.SubItems.Add(result.vote.ToString());
                electionResultListView.Items.Add(item);
            }
        }
    }
}
