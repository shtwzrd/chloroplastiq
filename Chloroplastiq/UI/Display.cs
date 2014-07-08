// <summary>
//   Handles the WinForm for Displaying the Render.
// </summary>
namespace Chloroplastiq.UI
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.Windows.Forms;

    using Chloroplastiq.Grammar;
    using Chloroplastiq.TurtleGraphics;

    using Lindenmayer;

    /// <summary>
    /// The event handler.
    /// </summary>
    /// <param name="sender">
    /// The sender.
    /// </param>
    /// <param name="grammar">
    /// The grammar.
    /// </param>
    public delegate void EventHandler(object sender, string grammar);

    /// <summary>
    /// The display.
    /// </summary>
    public partial class Display : Form
    {
        #region Fields

        /// <summary>
        /// The g.
        /// </summary>
        private Graphics g;

        /// <summary>
        /// The product.
        /// </summary>
        private Product product;

        /// <summary>
        /// The to file.
        /// </summary>
        private Turtle toFile;

        /// <summary>
        /// The turtle.
        /// </summary>
        private Turtle turtle;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Display"/> class.
        /// </summary>
        public Display()
        {
            this.InitializeComponent();
            var settings = new Settings(this);
            settings.Show();
            this.Drawn += settings.DrawnEventHandler;

            var config = ConfigurationManager.Instance;
            config.Axiom = "X";
            config.InitialLength = 1;
            config.InitialWidth = 3;
            config.Iteration = 4;
            config.Origin = new Point(this.Size.Width / 2, this.Size.Height);
            config.RotationAngle = 25;

            var p = new Dictionary<char, string> { { 'X', "F-[[X]+X]+F[+FX]-X" }, { 'F', "FF" } };

            config.Rules = p;
            config.Scaling = 50;
            config.StartAngle = 90;

            this.g = this.CreateGraphics();
        }

        #endregion

        #region Public Events

        /// <summary>
        /// The drawn.
        /// </summary>
        public event EventHandler Drawn;
        #endregion

        /// <summary>
        /// Gets or sets the interpreter for the L-System.
        /// </summary>
        public LInterpreter Lsystem { get; set; }

        #region Public Methods and Operators

        /// <summary>
        /// The redraw.
        /// </summary>
        public void Redraw()
        {
            var config = ConfigurationManager.Instance;
            this.g.Clear(Color.White);
            this.product = new Product(config.Axiom, config.Rules) { Iterations = config.Iteration };
            this.turtle = new Turtle(this.g, config.Origin, config.StartAngle);
            this.Lsystem = new LInterpreter(this.turtle, this.product, config.RotationAngle);
            System.generation(this.product.Axiom, this.product.Rules);
            this.Lsystem.Render();
            this.OnDrawn(this.Lsystem.GetGrammar());
        }

        #endregion
       
        #region Methods

        /// <summary>
        /// The on drawn.
        /// </summary>
        /// <param name="grammar">
        /// The grammar.
        /// </param>
        protected virtual void OnDrawn(string grammar)
        {
            if (this.Drawn != null)
            {
                this.Drawn(this, grammar);
            }
        }

        /// <summary>
        /// The on resize.
        /// </summary>
        /// <param name="e">
        /// The e.
        /// </param>
        protected override void OnResize(EventArgs e)
        {
            var config = ConfigurationManager.Instance;
            this.g = this.CreateGraphics();
            this.g.Clear(Color.White);
            config.Origin = new Point(this.Size.Width / 2, this.Size.Height);
            this.turtle = new Turtle(this.g, config.Origin, config.StartAngle);
            this.Redraw();
        }

        /// <summary>
        /// The display_ load.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void DisplayLoad(object sender, EventArgs e)
        {
            // Redraw();
        }

        /// <summary>
        /// The load tool strip menu item_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void LoadToolStripMenuItemClick(object sender, EventArgs e)
        {
            this.Redraw();
        }

        /// <summary>
        /// The save as tool strip menu item_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void SaveAsToolStripMenuItemClick(object sender, EventArgs e)
        {
            var config = ConfigurationManager.Instance;
            var save = new SaveFileDialog();
            var file = new Bitmap(this.Width, this.Height);
            var wrapper = Graphics.FromImage(file);
            this.toFile = new Turtle(wrapper, config.Origin);

            var output = new LInterpreter(this.toFile, this.product, config.RotationAngle);
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

        #endregion
    }
}