using System;

namespace RangesAgain
{
    public class Range
    {
        public int[] ThisRange;
        public int LowerBound;
        public int HigherBound;
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

            if( range[range.Length-1] == ']')
            {
                HigherBound = int.Parse(range[range.Length - 2].ToString());
            }

            else
            {
                HigherBound = int.Parse(range[range.Length - 2].ToString()) - 1;
            }

            ThisRange = new int[HigherBound - LowerBound + 1];

            for(int i = 0; i < ThisRange.Length && LowerBound + i <= HigherBound; i++)
            {
                ThisRange[i] = LowerBound + i;
            }
        }

        public string GetAllPoints()
        {
            string output = "{";
            for(int i = 0; i < ThisRange.Length; i++)
            {
                output += ThisRange[i].ToString() + ",";
            }
            output = output.Remove(output.Length - 1) +"}";
            return output;
        }

        public string EndPoints()
        {
            string output = "{" + LowerBound.ToString() + "," + HigherBound.ToString() + "}";
            return output;
        }

        public bool Overlaps(Range range2)
        {
            if(range2.LowerBound <= this.HigherBound || this.LowerBound <= range2.HigherBound)
            {
                return true;
            }
            return false;
        }

        public object Contains(string OtherRange)
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