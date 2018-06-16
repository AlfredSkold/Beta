using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Alfa.Models
{
    public class GameTip
    {
        public int Id { get; set; }
        public int GameNumber { get; set; }
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public string Score { get; set; }
        public int Points { get; set; }
        

    }
}