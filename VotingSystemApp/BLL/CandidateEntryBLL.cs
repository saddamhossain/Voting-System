namespace VotingSystemApp
{
    class CandidateEntryBLL
    {
        public string Save(Candidate aCandidate)
        {
            if (aCandidate.Name == "" || aCandidate.Symbol == "")
                return "Please fill the field accordingly";
           CandidateEntryGateway aCandidateEntryGateway=new CandidateEntryGateway();
            aCandidateEntryGateway.Save(aCandidate);
            
            return "Saved";
        }
    }
}