/*******************************************************
 * Brandon Lucas
 * 30 December 2011
 * Chloroplastiq (Mono-port)
*******************************************************/

namespace Chloroplastiq.TurtleGraphics
{
    using System.Drawing;

    public class Orientation
    {
        public Orientation(PointF p, float d)
        {
            Position = p;
            Direction = d;
        }

        public PointF Position { get; set; }

        public float Direction { get; set; }
    }
}