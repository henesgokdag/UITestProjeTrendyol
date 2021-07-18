using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITestProjeTrendyol.Utilities
{
    public class Utilities
    {
        public static int GetRandomNumber(int maxNumber)
        {
            Random random = new Random();
            return random.Next(0, maxNumber - 1);
        }
    }
}
