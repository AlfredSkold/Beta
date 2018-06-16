using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Alfa.Models
{
    public class Bets
    {
        public int Id { get; set; }
        public Users User { get; set; }
        public Cups Cup { get; set; }
        public IEnumerable<GameTip> GameTips { get; set; }
        
    }
}