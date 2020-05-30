using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class MatchupEntryModel
    {  
        /// <summary>
        /// Represents one team in the matchup.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Score for particular team.
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// The previous match, that this team won in.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
      
    }
}
