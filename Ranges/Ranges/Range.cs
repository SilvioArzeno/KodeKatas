using System;

namespace Ranges
{
    public class Range
    {
        public int[] ThisRange;

        public int LowerBound = 0;
        public int HigherBound = 0;

        public Range(string range)
        {

            if(range[0] == '[')
            {
                LowerBound = int.Parse(range[1].ToString());
            }
            else
            {
                LowerBound = int.Parse(range[1].ToString()) + 1;
            }

            if(range[range.Length-1] == ']')
            {
                HigherBound = int.Parse(range[range.Length - 2].ToString());
            }
            else
            {
                HigherBound = int.Parse(range[range.Length - 2].ToString()) - 1;
            }

            ThisRange = new int[HigherBound - LowerBound + 1];
            for(int i = 0; i < ThisRange.Length && LowerBound != HigherBound; i++)
            {
                ThisRange[i] = LowerBound;
            }
        }

        public bool Contains(string OtherRange)
        {
            Range NewRange = new Range(OtherRange);

            if(this.LowerBound <= NewRange.LowerBound && this.HigherBound >= NewRange.HigherBound)
            {
                return true;
            }

            return false;
        }
    }
}