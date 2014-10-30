using System.Collections.Generic;
using System.Linq;

namespace VotingSystemApp
{
    internal class ElectionResultBll
    {
        public static List<Result> GetEllectionResult()
        {
            if (Candidate.numberOfWinner==0)
            {
                List<Result> emptyResult=new List<Result>();
                return emptyResult;
            }
            return GetResult();
        }

        private static List<Result> GetResult()
        {
            int vote=0;
            int disableTieLoop = 0;
            int disableLooserLoop = 0;
            int tieFlag = 0;
            
            List<Result> results = new List<Result>();
            List<Candidate> candidatesWithVoteInOrder = GetCandidateVoteInOrder();
            foreach (var candidate in candidatesWithVoteInOrder)
            {
                int looserIndex = 0;
                Result aResult = new Result();
                aResult.CandidateName = candidate.Name;
                aResult.Symbol = candidate.Symbol;

                foreach (var candidate1 in candidatesWithVoteInOrder)
                {
                    if (candidate.Vote < candidate1.Vote)
                    {
                        looserIndex++;
                        if (looserIndex == Candidate.numberOfWinner&& aResult.Status==null&& disableLooserLoop==0)
                        {
                            aResult.Status = "Looser";
                            aResult.vote = candidate.Vote;
                            results.Add(aResult);
                            looserIndex = 0;
                        }                     
                    }                    
                }                
              
                if (aResult.Status == null)
                {
                    disableLooserLoop = 1;
                    foreach (var candidate1 in candidatesWithVoteInOrder)
                    {
                        
                        if (tieFlag==1)
                        {
                            if (vote != candidate.Vote)
                                disableTieLoop = 1;
                        }
                        if (tieFlag == 0)
                        {
                            if (Candidate.numberOfWinner == candidatesWithVoteInOrder.Count - results.Count)
                                disableTieLoop = 1;
                        }
                        if (candidate.Vote == candidate1.Vote&&disableTieLoop==0&&candidate.CandidateID!=candidate1.CandidateID)
                        {
                         
                                aResult.Status = "Tie";
                                aResult.vote = candidate.Vote;
                                results.Add(aResult);
                                vote = candidate.Vote;
                                tieFlag = 1;
                                break;
                        }
                    }
                }

               if (aResult.Status == null)
               {
                   disableTieLoop = 1;
                    aResult.Status = "Winner";
                    aResult.vote = candidate.Vote;
                    results.Add(aResult);
                }
            }        
            return results;
        }

        private static List<Candidate> GetCandidateVoteInOrder()
        {
            List<Candidate> candidateList = VotingGateway.GetCandidateList();
            List<Candidate> candidateListWithVote = new List<Candidate>();
            foreach (var candidate in candidateList)
            {
                candidate.Vote = ElectionResultGateway.GetCandidateVote(candidate.CandidateID);
                candidateListWithVote.Add(candidate);
            }
            List<Candidate> candidateShortingList = new List<Candidate>();
            return candidateShortingList = candidateListWithVote.OrderBy(candidate => candidate.Vote).ToList();

        }
    }
}