/*******************************************************
 * Brandon Lucas
 * 30 December 2011
 * Chloroplastiq (Mono-port)
*******************************************************/
using System.Drawing;

namespace Chloroplastiq.TurtleGraphics
{
    public class Orientation
    {
        public Orientation(PointF p, float d)
        {
            this.Position = p;
            this.Direction = d;
        }

        public PointF Position { get; set; }
        public float Direction { get; set; }
    }
}