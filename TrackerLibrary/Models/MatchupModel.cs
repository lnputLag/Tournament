using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Представляет собой один матч в турнире
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// Команды, которые участвуют в этом матче
        /// </summary>
        
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// Победитель матча
        /// </summary>
        
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Выход в определённый раунд
        /// </summary>
        
        public int MatchupRound { get; set; }
    }
}
