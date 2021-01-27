using System;

namespace Challenge_200
{
    public class Challenge_204
    {
        public int Potato(string str)
        {
            // might be faster ways, execution-wise, but potato
            return str.ToUpper().Split("POTATO", StringSplitOptions.None).Length - 1;
        }
    }
}
