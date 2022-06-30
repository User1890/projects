using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class MaxDistance
    {
        public static int distance(int[] distance, bool[] path, int vCount)
        {
            int max = int.MaxValue;
            int index = 0;
            for (int i = 0; i < vCount; i++)
            {
                if (path[i] == false && distance[i] <= max)
                {
                    max = distance[i];
                    index = i;
                }
            }
            return index;
        }
    }
}
