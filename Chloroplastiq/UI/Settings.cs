// <summary>
//   The Class managing the Settings WinForm.
// </summary>
namespace Chloroplastiq.UI
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// The settings.
    /// </summary>
    public partial class Settings : Form
    {
        /// <summary>
        /// The _parent.
        /// </summary>
        private readonly Display parent;

        /// <summary>
        /// Initializes a new instance of the <see cref="Settings"/> class.
        /// </summary>
        /// <param name="parent">
        /// The parent.
        /// </param>
        public Settings(Display parent)
        {
            this.InitializeComponent();
            this.parent = parent;
        }

        /// <summary>
        /// Gets or sets the L-system path.
        /// </summary>
        public string LsystemPath
        {
            get { return this.txtPath.Text; }
            set { this.txtPath.Text = value; }
        }

        /// <summary>
        /// The drawn event handler.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="grammar">
        /// The grammar.
        /// </param>
        public void DrawnEventHandler(object sender, string grammar)
        {
            this.txtPath.Text = grammar;
        }

        /// <summary>
        /// The txt axiom_ text changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void TxtAxiomTextChanged(object sender, EventArgs e)
        {
            var config = ConfigurationManager.Instance;
            config.Axiom = this.txtAxiom.Text;
            this.parent.Redraw();
        }

        /// <summary>
        /// The number iterations value changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void NumIterationsValueChanged(object sender, EventArgs e)
        {
            var config = ConfigurationManager.Instance;
            config.Iteration = (ushort)this.numIterations.Value;
            this.parent.Redraw();
        }

        /// <summary>
        /// The txt starting angle_ text changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void TxtStartingAngleTextChanged(object sender, EventArgs e)
        {
            var config = ConfigurationManager.Instance;
            config.StartAngle = (float)double.Parse(this.txtStartingAngle.Text);
            this.parent.Redraw();
        }

        /// <summary>
        /// The txt rotation angle_ text changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void TxtRotationAngleTextChanged(object sender, EventArgs e)
        {
            var config = ConfigurationManager.Instance;
            config.RotationAngle = (float)double.Parse(this.txtRotationAngle.Text);
            this.parent.Redraw();
        }

        /// <summary>
        /// The txt length_ text changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void TxtLengthTextChanged(object sender, EventArgs e)
        {
            var config = ConfigurationManager.Instance;
            config.InitialLength = (float)double.Parse(this.txtLength.Text);
            this.parent.Redraw();
        }

        /// <summary>
        /// The txt width_ text changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void TxtWidthTextChanged(object sender, EventArgs e)
        {
            var config = ConfigurationManager.Instance;
            config.InitialWidth = (float)double.Parse(this.txtWidth.Text);
            this.parent.Redraw();
        }

        /// <summary>
        /// The txt scale_ text changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void TxtScaleTextChanged(object sender, EventArgs e)
        {
            var config = ConfigurationManager.Instance;
            config.Scaling = (float)double.Parse(this.txtScale.Text);
            this.parent.Redraw();
        }

        /// <summary>
        /// The rad top left_ checked changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void RadTopLeftCheckedChanged(object sender, EventArgs e)
        {
            if (this.radTopLeft.Checked)
            {
                var config = ConfigurationManager.Instance;
                config.Origin = new PointF(0, 0);
            }

            this.parent.Redraw();
        }

        /// <summary>
        /// The rad top mid_ checked changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void RadTopMidCheckedChanged(object sender, EventArgs e)
        {
            if (this.radTopMid.Checked)
            {
                var config = ConfigurationManager.Instance;
                config.Origin = new PointF(this.parent.Size.Width / 2f, 0);
            }

            this.parent.Redraw();
        }

        /// <summary>
        /// The rad top right_ checked changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void RadTopRightCheckedChanged(object sender, EventArgs e)
        {
            if (this.radTopRight.Checked)
            {
                var config = ConfigurationManager.Instance;
                config.Origin = new PointF(this.parent.Size.Width, 0);
            }

            this.parent.Redraw();
        }

        /// <summary>
        /// The rad mid left_ checked changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void RadMidLeftCheckedChanged(object sender, EventArgs e)
        {
            if (this.radMidLeft.Checked)
            {
                var config = ConfigurationManager.Instance;
                config.Origin = new PointF(0, this.parent.Size.Height / 2f);
            }

            this.parent.Redraw();
        }

        /// <summary>
        /// The rad mid_ checked changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void RadMidCheckedChanged(object sender, EventArgs e)
        {
            if (this.radMid.Checked)
            {
                var config = ConfigurationManager.Instance;
                config.Origin = new PointF(this.parent.Size.Width / 2f, this.parent.Size.Height / 2f);
            }

            this.parent.Redraw();
        }

        /// <summary>
        /// The rad mid right_ checked changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void RadMidRightCheckedChanged(object sender, EventArgs e)
        {
            if (this.radMidRight.Checked)
            {
                var config = ConfigurationManager.Instance;
                config.Origin = new PointF(this.parent.Size.Width, this.parent.Size.Height / 2f);
            }

            this.parent.Redraw();
        }

        /// <summary>
        /// The rad bottom left_ checked changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void RadBottomLeftCheckedChanged(object sender, EventArgs e)
        {
            if (this.radBottomLeft.Checked)
            {
                var config = ConfigurationManager.Instance;
                config.Origin = new PointF(0, this.parent.Size.Height);
            }

            this.parent.Redraw();
        }

        /// <summary>
        /// The rad bottom mid_ checked changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void RadBottomMidCheckedChanged(object sender, EventArgs e)
        {
            if (this.radBottomMid.Checked)
            {
                var config = ConfigurationManager.Instance;
                config.Origin = new PointF(this.parent.Size.Width / 2f, this.parent.Size.Height);
            }

            this.parent.Redraw();
        }

        /// <summary>
        /// The rad bottom right_ checked changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void RadBottomRightCheckedChanged(object sender, EventArgs e)
        {
            if (this.radBottomRight.Checked)
            {
                var config = ConfigurationManager.Instance;
                config.Origin = new PointF(this.parent.Size.Width, this.parent.Size.Height);
            }

            this.parent.Redraw();
        }

        /// <summary>
        /// The button rule change_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void BtnRuleChangeClick(object sender, EventArgs e)
        {
            var config = ConfigurationManager.Instance;
            config.Rules.Clear();

            var ruleArray = this.txtRules.Text.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var r in ruleArray)
            {
                var ps = r.Split(':');
                if (ps.Length != 2)
                {
                    MessageBox.Show(@"Invalid Rule Syntax.");
                }
                else
                {
                    config.Rules.Add(ps[0][0], ps[1]);
                }

                this.parent.Redraw();
            }
        }

        /// <summary>
        /// The txt path_ text changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void TxtPathTextChanged(object sender, EventArgs e)
        {
            if (this.chkAcceptingInput.Checked)
            {
                this.parent.Lsystem.Render();
            }
        }
    }
}