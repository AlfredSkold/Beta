using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Alfa.Models
{
    public class Cups
    {

        public int id { get; set; }
        public string type { get; set; }
        public string year { get; set; }
        public string Host { get; set; }
        public string Winner { get; set; }

        public IEnumerable<GameResults> GameResults { get; set; }

    }
}