using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeClone
{
    public class Counter
    {
        private static Counter instance;
        public int number;

        private Counter()
        {
            number = 0;
        }

        public static Counter GetInstance()
        {
            if (instance == null)
            {
                instance = new Counter();
            }
            return instance;
        }
    }
}
