// <summary>
//   The Turtle class, used for drawing an L-System.
// </summary>

namespace Chloroplastiq.TurtleGraphics
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;

    using Chloroplastiq.UI;

    /// <summary>
    /// The Turtle is a drawing abstraction in which lines are drawn from the perspective of a turtle. 
    /// The turtle only knows how to rotate and move forward.
    /// </summary>
    public class Turtle
    {
        #region Fields

        /// <summary>
        /// The config.
        /// </summary>
        private readonly ConfigurationManager config;

        /// <summary>
        /// The paths.
        /// </summary>
        private readonly Stack<Orientation> paths; 

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Turtle"/> class.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        /// <param name="origin">
        /// The origin.
        /// </param>
        public Turtle(Graphics context, PointF origin)
        {
            this.config = ConfigurationManager.Instance;
            this.Canvas = context;
            this.Position = origin;
            this.Direction = 90.0f;
            this.SizeX = this.Canvas.DpiX;
            this.SizeY = this.Canvas.DpiY;
            this.LineLength = this.config.InitialLength;

            this.paths = new Stack<Orientation>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Turtle"/> class.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        /// <param name="origin">
        /// The origin.
        /// </param>
        /// <param name="angle">
        /// The angle.
        /// </param>
        public Turtle(Graphics context, PointF origin, float angle)
            : this(context, origin)
        {
            this.Direction = angle;
        }

        #endregion

        /*This function finds the second point in a line, based off the angle and the distance -
        The Turtle doesn't actually know the exact location of the second point, he just knows his orientation
        and the distance he must travel.*/
        #region Public Properties

        /// <summary>
        /// Gets or sets the bitmap.
        /// </summary>
        public Bitmap Bitmap { get; set; }

        /// <summary>
        /// Gets or sets the canvas.
        /// </summary>
        public Graphics Canvas { get; set; }

        /// <summary>
        /// Gets or sets the direction.
        /// </summary>
        public float Direction { get; set; }

        /// <summary>
        /// Gets or sets the line length.
        /// </summary>
        public float LineLength { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether pen down.
        /// </summary>
        public bool PenDown { get; set; }

        /// <summary>
        /// Gets the paths.
        /// </summary>
        public Stack<Orientation> Paths
        {
            get
            {
                return this.paths;
            }
        }

        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        public PointF Position { get; set; }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the size x.
        /// </summary>
        private float SizeX { get; set; }

        /// <summary>
        /// Gets or sets the size y.
        /// </summary>
        private float SizeY { get; set; }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The forward.
        /// </summary>
        public void Forward()
        {
            this.Canvas.DrawLine(
                new Pen(Color.YellowGreen, this.config.InitialWidth * 1 / (this.Paths.Count + 1)), 
                this.Position, 
                this.AdvancePosition());
            this.Position = this.AdvancePosition();
        }

        /// <summary>
        /// The pop.
        /// </summary>
        public void Pop()
        {
            var o = this.Paths.Pop();
            this.Position = o.Position;
            this.Direction = o.Direction;
        }

        /// <summary>
        /// The push.
        /// </summary>
        /// <param name="o">
        /// The o.
        /// </param>
        public void Push(Orientation o)
        {
            this.Paths.Push(o);
        }

        /// <summary>
        /// The rotate.
        /// </summary>
        /// <param name="degrees">
        /// The degrees.
        /// </param>
        public void Rotate(float degrees)
        {
            if (this.Direction + degrees > 360)
            {
                this.Direction = this.Direction + degrees - 360;
            }
            else if (degrees < 0 && Math.Abs(degrees) > this.Direction)
            {
                this.Direction = 360 - (Math.Abs(degrees) - this.Direction);
            }
            else
            {
                this.Direction += degrees;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// The advance position.
        /// </summary>
        /// <returns>
        /// The <see cref="PointF"/>.
        /// </returns>
        private PointF AdvancePosition()
        {
            var xunit = this.SizeX / (1000 / this.config.Scaling);
            var yunit = this.SizeY / (1000 / this.config.Scaling);
            PointF next = new Point(0, 0);

            next.X = this.Position.X + (float)(this.Distance() * xunit * Math.Cos(this.ToRadians(this.Direction)));
            next.Y = this.Position.Y - (float)(this.Distance() * yunit * Math.Sin(this.ToRadians(this.Direction)));

            return next;
        }

        /// <summary>
        /// The distance.
        /// </summary>
        /// <returns>
        /// The <see cref="float"/>.
        /// </returns>
        private float Distance()
        {
            return this.LineLength;
        }

        /// <summary>
        /// The to radians.
        /// </summary>
        /// <param name="angle">
        /// The angle.
        /// </param>
        /// <returns>
        /// The <see cref="float"/>.
        /// </returns>
        private float ToRadians(float angle)
        {
            return (float)(Math.PI / 180) * angle;
        }

        #endregion
    }
}