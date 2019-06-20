using System;
using System.Collections.Generic;

namespace SortingItOut
{
    public class Rack
    {
       public List<int> balls;
        public Rack(int[] Winners)
        {
            balls = new List<int>();
            foreach(int a in Winners)
            {
                balls.Add(a);
            }
        }

        public static int[] Balls(Rack rack)
        {
            for(int i = 0; i < rack.balls.Count; i++)
            {
                for(int j = i; j < rack.balls.Count; j++)
                {
                    if(rack.balls[i] > rack.balls[j])
                    {
                        int temp = rack.balls[i];
                        rack.balls[i] = rack.balls[j];
                        rack.balls[j] = temp;
                    }
                }
            }

            return rack.balls.ToArray();
        }
    }
}