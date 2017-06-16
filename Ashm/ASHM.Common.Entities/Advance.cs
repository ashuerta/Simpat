using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ASHM.Common.Entities.Linked;

namespace ASHM.Common.Entities
{
    public class Advance : IFizzBuzz
    {
        public int MaxEdge { get; set; }

        public int MinEdge { get; set; }

        public List<string> Tokens { get; set; }

        public Advance()
        {
            MinEdge = 1;
            MaxEdge = 100;
            Tokens = new List<string>();
            Tokens.AddRange(new[] {"Fizz", "Buzz"});
        }

        public BigList GetByRange()
        {
            var linked = new BigList();
            for (var i = MinEdge; i <= MaxEdge; i++)
            {
                var s = string.Empty;
                if ((i % 3) == 0) s += Tokens[0];
                if ((i % 5) == 0) s += Tokens[1];

                linked.AddLast(!string.IsNullOrEmpty(s) ? s : i.ToString(CultureInfo.InvariantCulture));
            }
            return linked;
        }

        public List<string> Get()
        {
            var r = new List<string>();
            for (var i = MinEdge; i <= MaxEdge; i++)
            {
                var s = string.Empty;
                if ((i % 3) == 0) s += Tokens[0];
                if ((i % 5) == 0) s += Tokens[1];
                r.Add(!string.IsNullOrEmpty(s) ? s : i.ToString(CultureInfo.InvariantCulture));
            }
            return r;
        }
    }
}
