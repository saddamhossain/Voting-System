using System.Windows.Forms;

namespace VotingSystemApp

{
    internal class Candidate
    {
        public int  CandidateID { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public static int numberOfWinner { get; set; }
        public  int Vote { get; set; }
      

        public Candidate(string name, string symbol)
        {
            Name = name;
            Symbol = symbol;
        }

        public Candidate()
        {
        }
    }
}