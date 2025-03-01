namespace CS_DSA_Solutions
{
    public class Node
    {
        public int Data;
        public Node Next;
        public Node Prev; 

        public Node(int data)
        {
            Data = data;
            Next = null;
            Prev = null;
        }
    }
}
