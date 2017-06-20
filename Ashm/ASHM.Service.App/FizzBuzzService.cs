using ASHM.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASHM.Common.Entities.Linked;

namespace ASHM.Service.App
{
    public class FizzBuzzService
    {
        public List<string> BasicFizzBuzz(Normal fb)
        {
            return fb.Get();
        }

        public BigList AdvanceByRange(Advance adv)
        {
            return adv.GetByRange();
        }

        public BigList AdvanceByInputUser(Advance adv)
        {
            return adv.GetByInputUser();
        }

        public BigList AdvanceByCustomTokens(Advance adv)
        {
            return adv.GetByCustomTokens();
        }
    }
}
