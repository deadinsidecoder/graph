using System.Collections.Generic;
using System.Linq;

namespace Graph
{
    public class Graph
    {
        public Graph()
        {
            Nodes = new List<Node>();
            Edges = new List<Edge>();
        }
        public List<Node> Nodes { get; set; }
        public List<Edge> Edges { get; set; }

        public int[,] GetAdjacentMatrix()
        {
            var matrix = new int[Nodes.Count, Nodes.Count];

            foreach (var edge in Edges)
            {
                var row = edge.From.NodeNumber - 1;
                var column = edge.To.NodeNumber - 1;

                matrix[row, column] = edge.Weight;
            }
            
            return matrix;
        }

        public List<Node> GetNodesFrom(Node node)
        {
            var list = new List<Node>();

            var edges = Edges.Where(x => x.From.NodeNumber == node.NodeNumber);
            
            list.AddRange(edges.Select(x => x.To));

            return list;
        }

        public List<Node> GetNodesTo(Node node)
        {
            var list = new List<Node>();

            var edges = Edges.Where(x => x.To.NodeNumber == node.NodeNumber);
            
            list.AddRange(edges.Select(x => x.From));
            
            return list;
        }
        
        public Route GetMinimumRoute(Node start, Node finish)
        {
            for (int i = 0; i < Nodes.Count; i++)
            {
                var nodes = GetNodesTo(Nodes[i]);

                if (nodes.Count == 0)
                {
                    continue;
                }

                var edges = new List<Edge>();

                foreach (var node in nodes)
                {
                    var edge = Edges.First(x => x.From.NodeNumber == node.NodeNumber
                                                && x.To.NodeNumber == Nodes[i].NodeNumber);
                    edges.Add(edge);
                }

                Edge minEdge = MinBetweenEdges(edges);

                Route route = new Route();
                route.Cost = minEdge.From.MinRoute.Cost + minEdge.Weight;
                route.AddRange(minEdge.From.MinRoute.Get());
                route.Add(minEdge.From);

                Nodes[i].MinRoute = route;
            }

            return Nodes.First(x => x.NodeNumber == finish.NodeNumber).MinRoute;
        }

        private Edge MinBetweenEdges(List<Edge> edges)
        {
            var minEdge = new Edge{ Weight = int.MaxValue};

            foreach (var edge in edges)
            {
                minEdge = MinBetweenTwoEdge(minEdge, edge);
            }

            return minEdge;
        }
        
        private Edge MinBetweenTwoEdge(Edge first, Edge second)
        {
            int firstRouteCost = (first.From?.MinRoute.Cost ?? 0) + first.Weight;
            int secondRouteCost = (second.From?.MinRoute.Cost ?? 0) + second.Weight;

            if (firstRouteCost > secondRouteCost)
            {
                return second;
            }
            else
            {
                return first;
            }
        }
    }
}