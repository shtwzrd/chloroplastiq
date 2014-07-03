using System.Collections.Generic;
using System.Drawing;

using Chloroplastiq.Lindenmayer.Grammar;

namespace Chloroplastiq.UI
{
    public sealed class ConfigurationManager
    {
        private static ConfigurationManager instance;

        private ConfigurationManager() { }

        public static ConfigurationManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ConfigurationManager();
                }

                return instance;
            }
        }

        public static PointF Origin
        {
            get { return origin; }
            set { origin = value; }
        }

        public static ushort Iteration
        {
            get { return iteration; }
            set { iteration = value; }
        }

        public static string Axiom
        {
            get { return axiom; }
            set { axiom = value; }
        }

        public static List<ProductionRule> Rules
        {
            get { return rules; }
            set { rules = value; }
        }

        public static float StartAngle
        {
            get { return startAngle; }
            set { startAngle = value; }
        }

        public static float RotationAngle
        {
            get { return rotateAngle; }
            set { rotateAngle = value; }
        }

        public static float InitialLength
        {
            get { return initLength; }
            set { initLength = value; }
        }

        public static float InitialWidth
        {
            get { return initWidth; }
            set { initWidth = value; }
        }

        public static float Scaling
        {
            get { return scaling; }
            set { scaling = value; }
        }

        private static PointF origin;
        private static ushort iteration;
        private static string axiom;
        private static List<ProductionRule> rules;
        private static float startAngle;
        private static float rotateAngle;
        private static float initLength;
        private static float initWidth;
        private static float scaling;
    }
}