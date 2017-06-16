using ASHM.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASHM.Service.App
{
    public class FizzBuzzService
    {
        public List<string> BasicFizzBuzz(Normal fb)
        {
            return fb.Get();
        }
    }
}
