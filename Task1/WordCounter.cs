using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class WordCounter
    {
        public int Count(string str)
        {
            int count = 0;
            foreach (var c in str)
            {
                if (!char.IsLetter(c))
                {
                    count++;
                }
            }
            return count + 1;

            throw new NotImplementedException();
        }
    }
}
