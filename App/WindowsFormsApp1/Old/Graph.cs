using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Graph
    {
        int pick;
        public Graph(int pick)
        {
            this.pick = pick;
        }
        public int[,] graph()
        {

            int[,] array = new int[pick, pick];
            foreach (var u in Main.U)
            {
                array[int.Parse(u.point1.Text), int.Parse(u.point2.Text)] = u.count;
            }
            return array;
        }
    }
}
