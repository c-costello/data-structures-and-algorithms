using graphsApp.Classes;
using System;

namespace graphsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<int> root = new Node<int>(1);
            Graph<int> graph = new Graph<int>(root);
            Node<int> node1 = graph.AddNode(3);
            Node<int> node2 = graph.AddNode(5);
            Node<int> node3 = graph.AddNode(6);
            graph.AddEdge(node1, node2, 7);

            var list = graph.GetNodes(graph);
            foreach (var item in list)
            {
                Console.WriteLine(item.Value);
            };

            var list2 = graph.GetNeighbors(node1);
            foreach (var item in list2)
            {
                Console.WriteLine(item.Value);
            };

            Console.WriteLine(graph.Size(graph));
        }
    }
}
