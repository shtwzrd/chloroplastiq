/*******************************************************
 * Brandon Lucas
 * 30 December 2011
 * Chloroplastiq (Mono-port)
*******************************************************/

namespace Chloroplastiq.Lindenmayer.Grammar
{
    //Representation of a Single Rule in an L-system
    public class ProductionRule
    {
        public ProductionRule(char predecessor, string successor)
        {
            this.Predecessor = predecessor;
            this.Successor = successor;
        }

        public char Predecessor { get; set; }
        public string Successor { get; set; }
    }
}