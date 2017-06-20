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

        public Dictionary<int, string> Tokens { get; set; }

        public Dictionary<int, string> Items { get; set; }

        public Advance()
        {
            MinEdge = 1;
            MaxEdge = 100;
            Tokens = new Dictionary<int, string> {{1, "Fizz"}, {2, "Buzz"}};
        }

        public BigList GetByRange()
        {
            var linked = new BigList();
            if (MaxEdge < MinEdge)
            {
                for (var i = MinEdge; i >= MaxEdge; i--)
                {
                    var s = string.Empty;
                    if ((i % 3) == 0) s += Tokens[1];
                    if ((i % 5) == 0) s += Tokens[2];

                    linked.AddLast(i, !string.IsNullOrEmpty(s) ? s : i.ToString(CultureInfo.InvariantCulture));
                }
                return linked;
            }

            for (var i = MinEdge; i <= MaxEdge; i++)
            {
                var s = string.Empty;
                if ((i % 3) == 0) s += Tokens[1];
                if ((i % 5) == 0) s += Tokens[2];

                linked.AddLast(i, !string.IsNullOrEmpty(s) ? s : i.ToString(CultureInfo.InvariantCulture));
            }
            return linked;
        }

        public BigList GetByInputUser()
        {
            var linked = new BigList();
            foreach (var i in Items)
            {
                var s = string.Empty;
                if ((i.Key % 3) == 0) s += Tokens[1];
                if ((i.Key % 5) == 0) s += Tokens[2];

                linked.AddLast(i.Key, !string.IsNullOrEmpty(s) ? s : i.Value);
            }
            return linked;
        }

        public BigList GetByCustomTokens()
        {
            var linked = new BigList();
            for (var i = MinEdge; i <= MaxEdge; i++)
            {
                var s = string.Empty;
                foreach (var t in Tokens)
                {
                    if((i % t.Key) == 0) s += t.Value; 
                }
                
                linked.AddLast(i, !string.IsNullOrEmpty(s) ? s : i.ToString(CultureInfo.InvariantCulture));
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
