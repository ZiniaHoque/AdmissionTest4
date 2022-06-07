using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class FormatChecker
    {
        public bool IsValid(string mobileNumber)
        {
            int length = mobileNumber.Length;
            string code = mobileNumber.Substring(0, 3);
            if (length == 14 && code == "+88")
            {
                return true;
            }
            return false;
            
            throw new NotImplementedException();
        }
    }
}
