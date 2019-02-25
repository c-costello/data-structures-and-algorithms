using System;
using System.Collections.Generic;
using System.Text;

namespace graphsApp.Classes
{
    class Graph<T>
    {
        public Node<T> Root { get; set; }
        public LinkedList<LinkedList<Node<T>>> Nodes { get; set; }

        public Graph(Node<T> root)
        {
            Root = root;
            Nodes = new LinkedList<LinkedList<Node<T>>>();
            LinkedList<Node<T>> list = new LinkedList<Node<T>>();
            list.AddFirst(root);
            Nodes.AddFirst(list);
        }

        public Node<T> AddNode(T value)
        {
            Node<T> node = new Node<T>(value);
            LinkedList<Node<T>> list = new LinkedList<Node<T>>();
            list.AddFirst(node);
            Nodes.AddLast(list);
            return node;
        }



        public void AddEdge(Node<T> node1, Node<T> node2, int weight)
        {
            var current = Nodes.First;
            while (current.Next != null)
            {
                var currentNode = current.Value.First;
                if (currentNode.Value == node1)
                {
                    node2.Weight = weight;
                    currentNode.List.AddLast(node2);
                }
                if (currentNode.Value == node2)
                {
                    node1.Weight = weight;
                    currentNode.List.AddLast(node1);
                }
                current = current.Next;
            }
        }

        public List<Node<T>> GetNodes(Graph<T> graph)
        {
            List<Node<T>> list = new List<Node<T>>();
            var CurrentList = Nodes.First;
            while (CurrentList.Next != null)
            {
                var Current = CurrentList.Value.First;
                while (Current.Next != null)
                {
                    if (Current.Value.Visted == false)
                    {
                        Current.Value.Visted = true;
                        list.Add(Current.Value);
                    }
                    Current = Current.Next;
                }
                if (Current.Value.Visted == false)
                {
                    Current.Value.Visted = true;
                    list.Add(Current.Value);
                }
                CurrentList = CurrentList.Next;
            }
            var Current2 = CurrentList.Value.First;
            while (Current2.Next != null)
            {
                if (Current2.Value.Visted == false)
                {
                    Current2.Value.Visted = true;
                    list.Add(Current2.Value);
                }
                Current2 = Current2.Next;
            }
            if (Current2.Value.Visted == false)
            {
                Current2.Value.Visted = true;
                list.Add(Current2.Value);
            }
            foreach (var item in list)
            {
                item.Visted = false;
            }
            return list;
        }

        public List<Node<T>> GetNeighbors(Node<T> node)
        {
            List<Node<T>> list = new List<Node<T>>();

            var Current = Nodes.First;
            while (Current.Next != null)
            {
                if (Current.Value.First.Value == node)
                {
                    var CurrentNode = Current.Value.First.Next;
                    while (CurrentNode.Next != null)
                    {
                        list.Add(CurrentNode.Value);
                        CurrentNode = CurrentNode.Next;
                    }
                    list.Add(CurrentNode.Value);
                }
                Current = Current.Next;
            }
            if (Current.Value.First.Value == node)
            {
                var CurrentNode2 = Current.Value.First.Next;
                while (CurrentNode2.Next != null)
                {
                    list.Add(CurrentNode2.Value);
                    CurrentNode2 = CurrentNode2.Next;
                }
                list.Add(CurrentNode2.Value);
            }
            return list;
        }

        public int Size(Graph<T> graph)
        {
            int count = GetNodes(graph).Count;
            return count;
        }
    }
}
