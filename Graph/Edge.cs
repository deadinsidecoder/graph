namespace Graph
{
    public class Edge
    {
        public Edge()
        {
            
        }
        public Edge(Node from, Node to, int weight)
        {
            From = from;
            To = to;
            Weight = weight;
        }
        
        public Node From { get; set; }
        public Node To { get; set; }
        public int Weight { get; set; }

        public override string ToString()
        {
            return $"{From} => {To}";
        }
    }
}