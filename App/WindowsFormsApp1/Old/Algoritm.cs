using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Algoritm
    {
        public static int Algo(int[,] graph, int first, int last)
        {
            int[] distance = new int[graph.GetLength(0)];
            bool[] path = new bool[graph.GetLength(0)];

            for (int i = 0; i < graph.GetLength(0); ++i)
            {
                distance[i] = int.MaxValue;
                path[i] = false;
            }

            distance[first] = 0;

            for (int count = 0; count < graph.GetLength(0) - 1; ++count)
            {
                int u = MaxDistance.distance(distance, path, graph.GetLength(0));
                path[u] = true;

                for (int v = 0; v < graph.GetLength(0); ++v)
                    if (!path[v] && Convert.ToBoolean(graph[u, v]) && distance[u] != int.MaxValue && distance[u] + graph[u, v] < distance[v])
                        distance[v] = distance[u] + graph[u, v];
            }
            return distance[last];
        }
    }
}
