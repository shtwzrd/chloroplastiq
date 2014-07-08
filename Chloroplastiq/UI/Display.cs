/*******************************************************
 * Brandon Lucas
 * 30 December 2011
 * Chloroplastiq (Mono-port)
*******************************************************/

using System.Drawing.Imaging;

namespace Chloroplastiq.UI
{

    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    using Grammar;
    using TurtleGraphics;

    public delegate void EventHandler(object sender, String grammar);

    public partial class Display : Form
    {
        private Graphics _g;
        private Product _product;
        private Turtle _turtle;
        private Turtle _toFile;
        public LInterpreter Lsystem;

        public event EventHandler Drawn;

        public Display()
        {
            InitializeComponent();
            var settings = new Settings(this);
            settings.Show();
            Drawn += settings.DrawnEventHandler;

            var config = ConfigurationManager.Instance;
            config.Axiom = "X";
            config.InitialLength = 1;
            config.InitialWidth = 3;
            config.Iteration = 4;
            config.Origin = new Point(Size.Width / 2, Size.Height);
            config.RotationAngle = 25;

            var p = new Dictionary<char, string> {{'X', "F-[[X]+X]+F[+FX]-X"}, {'F', "FF"}};

            config.Rules = p;
            config.Scaling = 50;
            config.StartAngle = 90;

            _g = CreateGraphics();
        }

        public void Redraw()
        {
            var config = ConfigurationManager.Instance;
            _g.Clear(Color.White);
            _product = new Product(config.Axiom, config.Rules)
            {
                Iterations = config.Iteration
            };

            _turtle = new Turtle(_g, config.Origin, config.StartAngle);
            Lsystem = new LInterpreter(_turtle, _product, config.RotationAngle);
            Lindenmayer.System.generation(_product.Axiom, _product.Rules);

            Lsystem.Render();
            OnDrawn(Lsystem.GetGrammar());
        }

        protected override void OnResize(EventArgs e)
        {
            var config = ConfigurationManager.Instance;
            _g = CreateGraphics();
            _g.Clear(Color.White);
            config.Origin = new Point(Size.Width / 2, Size.Height);
            _turtle = new Turtle(_g, config.Origin, config.StartAngle);
            Redraw();
        }

        protected virtual void OnDrawn(String grammar)
        {
            if (Drawn != null) Drawn(this, grammar);
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Redraw();
        }

        private void Display_Load(object sender, EventArgs e)
        {
            // Redraw();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var config = ConfigurationManager.Instance;
            var save = new SaveFileDialog();
            var file = new Bitmap(Width, Height);
            var wrapper = Graphics.FromImage(file);
            _toFile = new Turtle(wrapper, config.Origin);

            var output = new LInterpreter(_toFile, _product, config.RotationAngle);
            output.Render();

            save.Filter = @"Image files (*.png)|*.png|All files (*.*)|*.*";
            save.RestoreDirectory = true;

            if (save.ShowDialog() == DialogResult.OK)
            {
                var toImage = save.OpenFile();
                file.Save(toImage, ImageFormat.Png);
                toImage.Close();
            }
        }
    }
}