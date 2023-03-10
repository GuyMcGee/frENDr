using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RedBadge.Models.IndividualResultsModels
{
    public class IRListItem
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public string OccasionName { get; set; }
        public string PlayerName { get; set; }
        public string RankName { get; set; }
    }
}
