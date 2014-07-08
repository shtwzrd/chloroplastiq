/*******************************************************
 * Brandon Lucas
 * 30 December 2011
 * Chloroplastiq (Mono-port)
*******************************************************/

namespace Chloroplastiq.TurtleGraphics
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using UI;

    // The Turtle is a drawing abstraction in which lines are drawn from the perspective of a turtle
    // The turtle only knows how to rotate and move forward.
    public class Turtle
    {
        public Turtle(Graphics context, PointF origin)
        {
            _config = ConfigurationManager.Instance;
            Canvas = context;
            Position = origin;
            Direction = 90.0f;
            SizeX = Canvas.DpiX;
            SizeY = Canvas.DpiY;
            LineLength = _config.InitialLength;

            Paths = new Stack<Orientation>();
        }

        public Turtle(Graphics context, PointF origin, float angle)
            : this(context, origin)
        {
            Direction = angle;
        }

        /*This function finds the second point in a line, based off the angle and the distance -
        The Turtle doesn't actually know the exact location of the second point, he just knows his orientation
        and the distance he must travel.*/

        public void Forward()
        {
            Canvas.DrawLine(new Pen(Color.YellowGreen, _config.InitialWidth * 1 / (Paths.Count + 1)), Position, AdvancePosition());
            Position = AdvancePosition();
        }

        public void Rotate(float degrees)
        {
            if (Direction + degrees > 360)
                Direction = Direction + degrees - 360;
            else if (degrees < 0 && Math.Abs(degrees) > Direction)
                Direction = 360 - (Math.Abs(degrees) - Direction);
            else
                Direction += degrees;
        }

        public void Push(Orientation o)
        {
            Paths.Push(o);
        }

        public void Pop()
        {
            var o = Paths.Pop();
            Position = o.Position;
            Direction = o.Direction;
        }

        private float Distance()
        {
            return LineLength;
        }

        private float ToRadians(float angle)
        {
            return (float)(Math.PI / 180) * angle;
        }

        private PointF AdvancePosition()
        {
            var xunit = SizeX / (1000 / _config.Scaling);
            var yunit = SizeY / (1000 / _config.Scaling);
            PointF next = new Point(0, 0);

            next.X = Position.X + (float)(Distance() * xunit * (Math.Cos(ToRadians(Direction))));
            next.Y = Position.Y - (float)(Distance() * yunit * (Math.Sin(ToRadians(Direction))));

            return next;
        }

        public bool PenDown { get; set; }

        public Bitmap Bitmap { get; set; }

        public float Direction { get; set; }

        public PointF Position { get; set; }

        public Graphics Canvas { get; set; }

        public float LineLength { get; set; }

        private float SizeX { get; set; }

        private float SizeY
        {
            get;
            set;
        }

        private readonly ConfigurationManager _config;

        public Stack<Orientation> Paths;
    }
}