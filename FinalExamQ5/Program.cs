using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamQ5
{
    internal class Program
    {
        //Adj List
        static List<Vertex> colorList = new List<Vertex>();

        //Adj Matrix
        static int V = 8;
        static int M = 8;
        static int[,] adjMat = new int[V, M];

        static void Main(string[] args)
        {



            adjMat[(int)Ecolors.red, (int)Ecolors.red] = -1;
            adjMat[(int)Ecolors.red, (int)Ecolors.grey] = 5;
            adjMat[(int)Ecolors.red, (int)Ecolors.purple] = -1;
            adjMat[(int)Ecolors.red, (int)Ecolors.cyan] = -1;
            adjMat[(int)Ecolors.red, (int)Ecolors.navy] = 1;
            adjMat[(int)Ecolors.red, (int)Ecolors.yellow] = -1;
            adjMat[(int)Ecolors.red, (int)Ecolors.green] = -1;
            adjMat[(int)Ecolors.red, (int)Ecolors.orange] = -1;

            adjMat[(int)Ecolors.grey, (int)Ecolors.red] = -1;
            adjMat[(int)Ecolors.grey, (int)Ecolors.grey] = -1;
            adjMat[(int)Ecolors.grey, (int)Ecolors.purple] = -1;
            adjMat[(int)Ecolors.grey, (int)Ecolors.cyan] = 0;
            adjMat[(int)Ecolors.grey, (int)Ecolors.navy] = -1;
            adjMat[(int)Ecolors.grey, (int)Ecolors.yellow] = -1;
            adjMat[(int)Ecolors.grey, (int)Ecolors.green] = -1;
            adjMat[(int)Ecolors.grey, (int)Ecolors.orange] = 1;

            adjMat[(int)Ecolors.purple, (int)Ecolors.red] = -1;
            adjMat[(int)Ecolors.purple, (int)Ecolors.grey] = -1;
            adjMat[(int)Ecolors.purple, (int)Ecolors.purple] = -1;
            adjMat[(int)Ecolors.purple, (int)Ecolors.cyan] = -1;
            adjMat[(int)Ecolors.purple, (int)Ecolors.navy] = -1;
            adjMat[(int)Ecolors.purple, (int)Ecolors.yellow] = 1;
            adjMat[(int)Ecolors.purple, (int)Ecolors.green] = -1;
            adjMat[(int)Ecolors.purple, (int)Ecolors.orange] = -1;

            adjMat[(int)Ecolors.cyan, (int)Ecolors.red] = -1;
            adjMat[(int)Ecolors.cyan, (int)Ecolors.grey] = 0;
            adjMat[(int)Ecolors.cyan, (int)Ecolors.purple] = -1;
            adjMat[(int)Ecolors.cyan, (int)Ecolors.cyan] = -1;
            adjMat[(int)Ecolors.cyan, (int)Ecolors.navy] = 1;
            adjMat[(int)Ecolors.cyan, (int)Ecolors.yellow] = -1;
            adjMat[(int)Ecolors.cyan, (int)Ecolors.green] = -1;
            adjMat[(int)Ecolors.cyan, (int)Ecolors.orange] = -1;

            adjMat[(int)Ecolors.navy, (int)Ecolors.red] = -1;
            adjMat[(int)Ecolors.navy, (int)Ecolors.grey] = -1;
            adjMat[(int)Ecolors.navy, (int)Ecolors.purple] = -1;
            adjMat[(int)Ecolors.navy, (int)Ecolors.cyan] = 1;
            adjMat[(int)Ecolors.navy, (int)Ecolors.navy] = -1;
            adjMat[(int)Ecolors.navy, (int)Ecolors.yellow] = 8;
            adjMat[(int)Ecolors.navy, (int)Ecolors.green] = -1;
            adjMat[(int)Ecolors.navy, (int)Ecolors.orange] = -1;

            adjMat[(int)Ecolors.yellow, (int)Ecolors.red] = -1;
            adjMat[(int)Ecolors.yellow, (int)Ecolors.grey] = -1;
            adjMat[(int)Ecolors.yellow, (int)Ecolors.purple] = -1;
            adjMat[(int)Ecolors.yellow, (int)Ecolors.cyan] = -1;
            adjMat[(int)Ecolors.yellow, (int)Ecolors.navy] = -1;
            adjMat[(int)Ecolors.yellow, (int)Ecolors.yellow] = -1;
            adjMat[(int)Ecolors.yellow, (int)Ecolors.green] = 6;
            adjMat[(int)Ecolors.yellow, (int)Ecolors.orange] = -1;

            adjMat[(int)Ecolors.green, (int)Ecolors.red] = -1;
            adjMat[(int)Ecolors.green, (int)Ecolors.grey] = -1;
            adjMat[(int)Ecolors.green, (int)Ecolors.purple] = -1;
            adjMat[(int)Ecolors.green, (int)Ecolors.cyan] = -1;
            adjMat[(int)Ecolors.green, (int)Ecolors.navy] = -1;
            adjMat[(int)Ecolors.green, (int)Ecolors.yellow] = -1;
            adjMat[(int)Ecolors.green, (int)Ecolors.green] = -1;
            adjMat[(int)Ecolors.green, (int)Ecolors.orange] = -1;

            adjMat[(int)Ecolors.orange, (int)Ecolors.red] = -1;
            adjMat[(int)Ecolors.orange, (int)Ecolors.grey] = -1;
            adjMat[(int)Ecolors.orange, (int)Ecolors.purple] = 1;
            adjMat[(int)Ecolors.orange, (int)Ecolors.cyan] = -1;
            adjMat[(int)Ecolors.orange, (int)Ecolors.navy] = -1;
            adjMat[(int)Ecolors.orange, (int)Ecolors.yellow] = -1;
            adjMat[(int)Ecolors.orange, (int)Ecolors.green] = -1;
            adjMat[(int)Ecolors.orange, (int)Ecolors.orange] = -1;


            List<bool> visited = new List<bool>();

            for (int i = 0; i < V; i++)
            {
                visited.Add(false);
            }

          //  dfs((int)Ecolors.red, visited);


            // Add all the vertices
            foreach (string color in Enum.GetNames(typeof(Ecolors)))
            {
                Vertex vertex;
                vertex = new Vertex(color);
                colorList.Add(vertex);
            }

            // Add all the edges
            colorList[(int)Ecolors.red].AddEdge(1, colorList[(int)Ecolors.navy]);
            colorList[(int)Ecolors.red].AddEdge(5, colorList[(int)Ecolors.grey]);
            colorList[(int)Ecolors.grey].AddEdge(0, colorList[(int)Ecolors.cyan]);
            colorList[(int)Ecolors.grey].AddEdge(1, colorList[(int)Ecolors.orange]);
            colorList[(int)Ecolors.purple].AddEdge(1, colorList[(int)Ecolors.yellow]);
            colorList[(int)Ecolors.cyan].AddEdge(0, colorList[(int)Ecolors.grey]);
            colorList[(int)Ecolors.cyan].AddEdge(1, colorList[(int)Ecolors.navy]);
            colorList[(int)Ecolors.navy].AddEdge(1, colorList[(int)Ecolors.cyan]);
            colorList[(int)Ecolors.navy].AddEdge(8, colorList[(int)Ecolors.yellow]);
            colorList[(int)Ecolors.yellow].AddEdge(6, colorList[(int)Ecolors.green]);
            colorList[(int)Ecolors.orange].AddEdge(1, colorList[(int)Ecolors.purple]);




            dijkstra(adjMat, (int)Ecolors.red);




        }


        //Adj List
        public enum Ecolors
        {
            red,
            grey,
            purple,
            cyan,
            navy,
            yellow,
            green,
            orange
        }


        public class Vertex
        {

            string name = "";

            public Vertex(string name)
            {
                this.name = name;
            }

            public List<Edge> edges = new List<Edge>();

            public void AddEdge(int weight, Vertex connection)
            {
                Edge e = new Edge(weight, connection);
                edges.Add(e);
            }
        }




        public class Edge
        {
            public int weight;
            public Vertex connectedVertex;

            public Edge(int weight, Vertex connectedVertex)
            {
                this.weight = weight;
                this.connectedVertex = connectedVertex;
            }
        }

        /*   public void DFSUtil(int v, bool[] visited)
           {
               visited[v] = true;
               Console.WriteLine(v + " ");

               foreach(int i in adjMat[v])
               {
                   int n = i;
                   if (!visited[n])
                   {
                      DFSUtil(n, visited);
                   }
               }
           } */
        static void dfs(int start, List<bool> visited)
        {
            Console.WriteLine(Enum.GetName(typeof(Ecolors), start) + " ");

            visited[start] = true;

            for (int i = 0; i < V; i++)
            {
                if (adjMat[start, i] > -1 && (!visited[i]))
                {
                    dfs(i, visited);
                }
            }
        }


        static int minDistance(int[] dist,
                bool[] sptSet)
        {
            // Initialize min value
            int min = int.MaxValue, min_index = -1;

            for (int v = 0; v < V; v++)
                if (sptSet[v] == false && dist[v] <= min)
                {
                    min = dist[v];
                    min_index = v;
                }

            return min_index;
        }


        static void printSolution(int[] dist, int n)
        {
            Console.Write("Vertex	 Distance "
            + "from Source\n");

            Console.Write(Enum.GetName(typeof(Ecolors), (int)Ecolors.green) + " \t\t " + dist[(int)Ecolors.green] + "\n");

            //for (int i = 0; i < V; i++)
            //    Console.Write(i + " \t\t " + dist[i] + "\n");
        }



       
        static void dijkstra(int[,] graph, int src)
        {
            int[] dist = new int[V]; 

            
            bool[] sptSet = new bool[V];
            int[] shortestPath = new int[V];

            // Initialize all distances as
            // INFINITE and stpSet[] as false
            for (int i = 0; i < V; i++)
            {
                dist[i] = int.MaxValue;
                sptSet[i] = false;
            }

            // Distance of source vertex
            // from itself is always 0
            dist[src] = 0;

            // Find shortest path for all vertices
            for (int count = 0; count < V - 1; count++)
            {
                // Pick the minimum distance vertex
                // from the set of vertices not yet
                // processed. u is always equal to
                // src in first iteration.
                int u = minDistance(dist, sptSet);

                // Mark the picked vertex as processed
                sptSet[u] = true;

                // Update dist value of the adjacent
                // vertices of the picked vertex.
                
                    for (int v = 0; v < V; v++)
                    {

                        if (!sptSet[v] && graph[u, v] != -1 &&
                            dist[u] != int.MaxValue && dist[u] + graph[u, v] < dist[v])
                        {
                            dist[v] = dist[u] + graph[u, v];
                            shortestPath[count] = v;    // Change this to track the shortest path
                        }
                    }
                
            }


            for (int i = 0; i < shortestPath.Length; i++)
            {
                Console.Write(Enum.GetName(typeof(Ecolors), shortestPath[i]) + " - ");
            }
            Console.WriteLine();

            // print the constructed distance array
            printSolution(dist, V);
        }


    }
}