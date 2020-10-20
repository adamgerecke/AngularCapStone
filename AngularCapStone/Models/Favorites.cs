using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace AngularCapStone.Models
{
    [Table("Favorites")]
    public class Favorites
    {
        public long id { get; set; }
        public string userid { get; set; }
        public string question { get; set; }
        public string answer { get; set; }
    }
}
