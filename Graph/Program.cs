using System.Collections.Generic;

namespace Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();
            
            var node1 = new Node(1);
            var node2 = new Node(2);
            var node3 = new Node(3);
            var node4 = new Node(4);
            var node5 = new Node(5);
            var node6 = new Node(6);
            var node7 = new Node(7);
            var node8 = new Node(8);
            var node9 = new Node(9);
            var node10 = new Node(10);
            var node11 = new Node(11);
            var node12 = new Node(12);
            var node13 = new Node(13);
            var node14 = new Node(14);
            
            var nodes = new List<Node> {node1, node2, node3, node4, node5, node6, 
                node7, node8, node9, node10, node11, node12, node13, node14};
            
            graph.Nodes.AddRange(nodes);
            
            var edge1to2 = new Edge(node1, node2, 18);
            var edge1to3 = new Edge(node1, node3, 19);
            var edge1to4 = new Edge(node1, node4, 17);
            var edge2to5 = new Edge(node2, node5, 13);
            var edge2to6 = new Edge(node2, node6, 14);
            var edge3to6 = new Edge(node3, node6, 15);
            var edge3to7 = new Edge(node3, node7, 16);
            var edge4to7 = new Edge(node4, node7, 17);
            var edge4to8 = new Edge(node4, node8, 18);
            var edge5to6 = new Edge(node5, node6, 21);
            var edge5to9 = new Edge(node5, node9, 19);
            var edge6to9 = new Edge(node6, node9, 22);
            var edge6to10 = new Edge(node6, node10, 21);
            var edge7to10 = new Edge(node7, node10, 23);
            var edge7to11 = new Edge(node7, node11, 18);
            var edge7to8 = new Edge(node7, node8, 21);
            var edge8to11 = new Edge(node8, node11, 17);
            var edge9to12 = new Edge(node9, node12, 32);
            var edge10to12 = new Edge(node10, node12, 33);
            var edge10to13 = new Edge(node10, node13, 37);
            var edge11to13 = new Edge(node11, node13, 36);
            var edge10to14 = new Edge(node10, node14, 41);
            var edge12to14 = new Edge(node12, node14, 32);
            var edge13to14 = new Edge(node13, node14, 31);
            
            var edges = new List<Edge>
            {
                edge1to2, edge1to3, edge1to4, edge2to5, edge2to6, edge3to6, edge3to7,
                edge4to7, edge4to8, edge5to6, edge5to9, edge6to9, edge6to10, edge7to10, edge7to11, edge7to8, edge8to11,
                edge9to12, edge10to12, edge10to13, edge11to13, edge10to14, edge12to14, edge13to14
            };
            
            graph.Edges.AddRange(edges);

            // Node node1 = new Node(1);
            // Node node2 = new Node(2);
            // Node node3 = new Node(3);
            // Node node4 = new Node(4);
            // Node node5 = new Node(5);
            // Node node6 = new Node(6);
            // Node node7 = new Node(7);
            //
            // var nodes = new List<Node>()
            // {
            //     node1, node2, node3, node4, node5, node6, node7
            // };
            //
            // graph.Nodes.AddRange(nodes);
            //
            // Edge edge1to2 = new Edge(node1, node2, 2);
            // Edge edge1to3 = new Edge(node1, node3, 4);
            // Edge edge1to4 = new Edge(node1, node4, 10);
            // Edge edge2to5 = new Edge(node2, node5, 5);
            // Edge edge2to4 = new Edge(node2, node4, 11);
            // Edge edge3to4 = new Edge(node3, node4, 3);
            // Edge edge3to6 = new Edge(node3, node6, 1);
            // Edge edge4to5 = new Edge(node4, node5, 8);
            // Edge edge4to6 = new Edge(node4, node6, 8);
            // Edge edge5to7 = new Edge(node5, node7, 6);
            // Edge edge6to7 = new Edge(node6, node7, 9);
            //
            // var edges = new List<Edge>()
            // {
            //     edge1to2, edge1to3, edge1to4, edge2to4, edge2to5, edge3to4, edge3to6, 
            //     edge4to5, edge4to6, edge5to7, edge6to7
            // };
            //
            // graph.Edges.AddRange(edges);

            Route result = graph.GetMinimumRoute(node1, node7);
            result.DisplayRoute();
        }
    } 
}