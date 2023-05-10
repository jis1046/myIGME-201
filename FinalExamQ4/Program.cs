using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamQ4
{
    internal class Program
    {
        //Adj List
        static List<Vertex> colorList = new List<Vertex>();

        //Adj Matrix
        static int v = 8;
        static int m = 8;
        static int[,] adjMat = new int[v, m];

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


            List<bool> visited = new List <bool>();

            for (int i = 0; i < v; i++)
            {
                visited.Add(false);
            }

            dfs((int)Ecolors.red, visited);
            

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

            for (int i = 0; i < v; i++)
            {
                if (adjMat[start,i] > -1 && (!visited[i]))
                {
                    dfs(i, visited);
                }
            }
        }

    }
}

