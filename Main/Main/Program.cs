using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLight
{
    internal class Program
    {
      static class IntExtensions
      {
        public statis int GetNegative(this int number)
        {
            if(number > 0)
            {
                return - number;
            }
            else
            {
                return number;
            }
        }

        public static int GetPositive(this int number)
        {
            if(number < 0)
            {
                return - number;
            }
            else
            {
                return number;
            }
        }
      } 
    }
}
