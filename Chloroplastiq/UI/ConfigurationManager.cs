using Chloroplastiq.Annotations;

namespace Chloroplastiq.UI
{
    using System.Collections.Generic;
    using System.Drawing;

    public sealed class ConfigurationManager
    {
        private static ConfigurationManager _instance;

        private ConfigurationManager()
        {
            _rules = new Dictionary<char, string>();
            Axiom = "";

        }

        public static ConfigurationManager Instance
        {
            get
            {
                if (_instance != null) return _instance;
                _instance = new ConfigurationManager();
                return _instance;
            }
        }

        public PointF Origin
        {
            get { return _origin; }
            set { _origin = value; }
        }

        public ushort Iteration { get; set; }

        public string Axiom { get; set; }

        public Dictionary<char, string> Rules
        {
            get { return _rules; }
            set { _rules = value; }
        }

        public float StartAngle { get; set; }

        public float RotationAngle { get; set; }

        public float InitialLength { get; set; }

        public float InitialWidth { get; set; }

        public float Scaling { get; set; }

        private PointF _origin;
        private Dictionary<char, string> _rules;
    }
}