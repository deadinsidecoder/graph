namespace Graph
{
    public class Node
    {
        public Node(int nodeNumber)
        {
            NodeNumber = nodeNumber;
            MinRoute = new Route();
        }
        
        public int NodeNumber { get; set; }
        
        public Route MinRoute { get; set; }
        
        public override string ToString()
        {
            return NodeNumber.ToString();
        }
    }
}