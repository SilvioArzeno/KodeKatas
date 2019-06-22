using System;
using System.Collections.Generic;

namespace SortingItOutAgain
{
    public class Rack
    {
        public List<int> balls;

        public Rack()
        {
            balls = new List<int>();
        }

        public Rack(int[] NewBalls)
        {
            balls = new List<int>(NewBalls);
        }

        public int[] Balls()
        {
            for(int i = 0; i < balls.Count; i++)
            {
                for (int j = i; j < balls.Count; j++)
                {
                    if(balls[i] > balls[j])
                    {
                        //Swap item i with item j
                        int temp = balls[i];
                        balls[i] = balls[j];
                        balls[j] = temp;
                    }
                }
            }
            return balls.ToArray();
        }
    }
}