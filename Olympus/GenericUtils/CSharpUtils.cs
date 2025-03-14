using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceHRM.GenericUtils
{
    public class CSharpUtils
    {
        public int GetRandomNumber(int range)
        {
            Random random = new Random();
            return random.Next(range);
        }
        public string GetCurrentDate()
        {
            return DateTime.Now.ToString("dd MM yyyy HH mm ss");
        }
    }
}
