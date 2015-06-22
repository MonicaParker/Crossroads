using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crossroads.Data.Model
{
    public class Map: Base
    {
        public string Tags { get; set; }
        public List<Character> Characters { get; set; }
    }
}
