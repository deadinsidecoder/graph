using System;
using System.Collections.Generic;

namespace Graph
{
    public class Route
    {
        public Route()
        {
            _route = new List<Node>();
        }
        public int Cost { get; set; }
        
        private List<Node> _route;

        public void Add(Node node)
        {
            _route.Add(node);
        }

        public void AddRange(List<Node> nodes)
        {
            _route.AddRange(nodes);
        }
        
        public List<Node> Get()
        {
            return _route;
        }

        public void DisplayRoute()
        {
            string result = "";

            foreach (var node in _route)
            {
                result += $"{node.ToString()} -> ";
            }

            Console.WriteLine(result);
            Console.WriteLine(Cost);
        }
    }
}