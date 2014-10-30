using System;
using System.Collections.Generic;

namespace VotingSystemApp
{
    internal class VotingBll
    {
        public static List<Candidate> GetCandidateList()
        {
            return VotingGateway.GetCandidateList();
        }

        public static int GetVoterID(string email)
        {
            return VotingGateway.GetVoterID(email);
        }

        public static string VoteCast(int voterId, int candidateId)
        {
            if (Candidate.numberOfWinner == 0)
                return "Number of winner has not been selected for this election\nYour vote will not be casted at this moment";
            if (VotingGateway.NumberOfVoteOfAVoter(voterId) < Candidate.numberOfWinner)
            {
                try
                {
                    VotingGateway.VoteCast(voterId, candidateId);
                }
                catch (Exception)
                {

                    return "Your email is not registared for this vote";
                }
               
                return "Vote has been casted";
            }
            return "You have already casted your "+Candidate.numberOfWinner+" votes";
        }
    }
}