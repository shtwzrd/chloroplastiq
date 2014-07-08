// <summary>
//   The orientation.
// </summary>
namespace Chloroplastiq.TurtleGraphics
{
    using System.Drawing;

    /// <summary>
    ///     The orientation.
    /// </summary>
    public struct Orientation
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the direction.
        /// </summary>
        public float Direction;

        /// <summary>
        ///     Gets or sets the position.
        /// </summary>
        public PointF Position;

        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="Orientation"/> struct.
        /// </summary>
        /// <param name="position">
        /// The position.
        /// </param>
        /// <param name="direction">
        /// The direction.
        /// </param>
        public Orientation(PointF position, float direction)
        {
            this.Direction = direction;
            this.Position = position;
        }
    }
}