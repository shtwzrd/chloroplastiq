/*******************************************************
 * Brandon Lucas
 * 30 December 2011
 * Chloroplastiq (Mono-port)
*******************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Chloroplastiq.Lindenmayer.TurtleGraphics;
using Chloroplastiq.Lindenmayer.Grammar;
namespace Chloroplastiq.UI
{
    public delegate void EventHandler(object sender, String grammar);

    public partial class Display : Form
    {
        Settings settings;
        Graphics g;
        Product product;
        Turtle turtle;
        Turtle toFile;
        public LInterpreter lsystem;

        public event EventHandler Drawn;

        protected virtual void OnDrawn(String grammar)
        {
            if (Drawn != null) Drawn(this, grammar);
        }

        public Display()
        {
            InitializeComponent();
            settings = new Settings(this);
            settings.Show();
            Drawn += settings.DrawnEventHandler;

            ConfigurationManager.Axiom = "X";
            ConfigurationManager.InitialLength = 1;
            ConfigurationManager.InitialWidth = 3;
            ConfigurationManager.Iteration = 4;
            ConfigurationManager.Origin = new Point(this.Size.Width / 2, this.Size.Height);
            ConfigurationManager.RotationAngle = 25;

            List<ProductionRule> P = new List<ProductionRule>();
            P.Add(new ProductionRule('X', "F-[[X]+X]+F[+FX]-X"));
            P.Add(new ProductionRule('F', "FF"));

            ConfigurationManager.Rules = P;
            ConfigurationManager.Scaling = 50;
            ConfigurationManager.StartAngle = 90;

            g = this.CreateGraphics();
            //Redraw();
        }

        protected override void OnResize(EventArgs e)
        {
            g = this.CreateGraphics();
            g.Clear(Color.White);
            ConfigurationManager.Origin = new Point(this.Size.Width / 2, this.Size.Height);
            turtle = new Turtle(g, ConfigurationManager.Origin, ConfigurationManager.StartAngle);
            Redraw();
        }

        public void Redraw()
        {
            g.Clear(Color.White);

            product = new Product(ConfigurationManager.Axiom, ConfigurationManager.Rules);
            product.Iterations = ConfigurationManager.Iteration;

            turtle = new Turtle(g, ConfigurationManager.Origin, ConfigurationManager.StartAngle);
            lsystem = new LInterpreter(turtle, product, ConfigurationManager.RotationAngle);

            lsystem.Render();
            OnDrawn(lsystem.GetGrammar());

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Redraw();
        }

        private void Display_Load(object sender, EventArgs e)
        {
            //Redraw();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            Stream toImage;
            Bitmap file = new Bitmap(this.Width, this.Height);
            Graphics wrapper = Graphics.FromImage(file);
            toFile = new Turtle(wrapper, ConfigurationManager.Origin);

            LInterpreter output = new LInterpreter(toFile, product, ConfigurationManager.RotationAngle);
            output.Render();

            save.Filter = "Image files (*.png)|*.png|All files (*.*)|*.*";
            save.RestoreDirectory = true;

            if (save.ShowDialog() == DialogResult.OK)
                if((toImage = save.OpenFile()) != null)
                {
                    file.Save(toImage, System.Drawing.Imaging.ImageFormat.Png);
                    toImage.Close();
                }
            }
           
    }
}
