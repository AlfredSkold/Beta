using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Alfa.Models
{
    public class GameResults
    {
        public int Id { get; set; }
        public int GameNumber { get; set; }
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public string result { get; set; }
        public bool Played { get; set; }

    }
}