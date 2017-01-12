using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class Graphs
    {
        public int V;
        public LinkedList<int>[] adjList;

        public Graphs(int v)
        {
            V = v;
            adjList = new LinkedList<int>[v];
            for (int i = 0; i < V; i++)
                adjList[i] = new LinkedList<int>();
        }

        public void AddEdge(int v, int w)
        {
            adjList[v].AddLast(w);
        }

        public void BFS(int startNode)
        {
            bool[] visited = new bool[V];
            Queue<int> que = new Queue<int>();

            visited[startNode] = true;
            que.Enqueue(startNode);
            while (que.Count!=0)
            {
                startNode = que.Dequeue();
                Console.Write(startNode + " ");
                IEnumerator<int> i = adjList[startNode].GetEnumerator();

                while (i.MoveNext())
                {
                    int n = i.Current;
                    if (!visited[n])
                    {
                        visited[n] = true;
                        que.Enqueue(n);
                    }
                } 
            }
        }

        public void DFS()
        {
            bool[] visited = new bool[V];

            for (int i = 0; i < V; i++)
            {
                if (visited[i]==false)
                {
                    DFSUtil(i, visited);
                }
            }

        }
        public void DFSUtil(int v, bool[] visited)
        {
            visited[v] = true;
            Console.Write(v + " ");
            IEnumerator<int> i = adjList[v].GetEnumerator();

            while (i.MoveNext())
            {
                int n = i.Current;
                if (!visited[n])
                {
                    DFSUtil(n, visited);
                }
            }
        }

        static void Main(string[] args)
        {
            Graphs objG = new Graphs(4);

            objG.AddEdge(0, 1);
            objG.AddEdge(0, 2);
            objG.AddEdge(1, 2);
            objG.AddEdge(2, 0);
            objG.AddEdge(2, 3);
            objG.AddEdge(3, 3);

            Console.WriteLine("");
            Console.WriteLine("Following is Breadth First Traversal (starting from vertex 2)");
            objG.BFS(2);

            Console.WriteLine("");
            Console.WriteLine("Following is Depth First Traversal");
            objG.DFS();



            Console.Read();
        }
    }
}
