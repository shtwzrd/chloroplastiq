namespace Chloroplastiq.Grammar
{
    // Representation of a Single Rule in an L-system
    public class ProductionRule
    {
        public ProductionRule(char predecessor, string successor)
        {
            Predecessor = predecessor;
            Successor = successor;
        }

        public char Predecessor { get; set; }

        public string Successor { get; set; }
    }
}