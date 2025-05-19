using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Представляет одну команду в матче
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Представляет счёт для этой конкретной команды
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Представляет матч, в котором эта команда победила
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
