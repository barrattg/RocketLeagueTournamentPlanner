using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class TournamentModel
    {   

        /// <summary>
        /// Unique Name/Id for Tournament.
        /// </summary>
        public string TournamentName { get; set; }
        public decimal EntryFee { get; set; }

        /// <summary>
        /// List of all competing teams.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// How the prizes are allocated.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();

    }
}
