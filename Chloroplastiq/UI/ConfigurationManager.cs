// <summary>
//   The configuration manager.
// </summary>

namespace Chloroplastiq.UI
{
    using System.Collections.Generic;
    using System.Drawing;

    /// <summary>
    /// The configuration manager.
    /// </summary>
    public sealed class ConfigurationManager
    {
        /// <summary>
        /// The _instance.
        /// </summary>
        private static ConfigurationManager instance;

        /// <summary>
        /// The origin.
        /// </summary>
        private PointF origin;

        /// <summary>
        /// Prevents a default instance of the <see cref="ConfigurationManager"/> class from being created.
        /// </summary>
        private ConfigurationManager()
        {
            this.Rules = new Dictionary<char, string>();
            this.Axiom = string.Empty;
        }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        public static ConfigurationManager Instance
        {
            get
            {
                if (instance != null)
                {
                    return instance;
                }

                instance = new ConfigurationManager();
                return instance;
            }
        }

        /// <summary>
        /// Gets or sets the origin.
        /// </summary>
        public PointF Origin
        {
            get { return this.origin; }
            set { this.origin = value; }
        }

        /// <summary>
        /// Gets or sets the iteration.
        /// </summary>
        public ushort Iteration { get; set; }

        /// <summary>
        /// Gets or sets the axiom.
        /// </summary>
        public string Axiom { get; set; }

        /// <summary>
        /// Gets or sets the rules.
        /// </summary>
        public Dictionary<char, string> Rules { get; set; }

        /// <summary>
        /// Gets or sets the start angle.
        /// </summary>
        public float StartAngle { get; set; }

        /// <summary>
        /// Gets or sets the rotation angle.
        /// </summary>
        public float RotationAngle { get; set; }

        /// <summary>
        /// Gets or sets the initial length.
        /// </summary>
        public float InitialLength { get; set; }

        /// <summary>
        /// Gets or sets the initial width.
        /// </summary>
        public float InitialWidth { get; set; }

        /// <summary>
        /// Gets or sets the scaling.
        /// </summary>
        public float Scaling { get; set; }
    }
}