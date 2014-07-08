/*******************************************************
 * Brandon Lucas
 * 30 December 2011
 * Chloroplastiq (Mono-port)
*******************************************************/

namespace Chloroplastiq.UI
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class Settings : Form
    {
        private readonly Display _parent;

        public Settings(Display parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public String LsystemPath
        {
            get { return txtPath.Text; }
            set { txtPath.Text = value; }
        }

        public void DrawnEventHandler(object sender, String grammar)
        {
            txtPath.Text = grammar;
        }

        private void txtAxiom_TextChanged(object sender, EventArgs e)
        {
            var config = ConfigurationManager.Instance;
            config.Axiom = txtAxiom.Text;
            _parent.Redraw();
        }

        private void numIterations_ValueChanged(object sender, EventArgs e)
        {
            var config = ConfigurationManager.Instance;
            config.Iteration = (ushort)numIterations.Value;
            _parent.Redraw();
        }

        private void txtStartingAngle_TextChanged(object sender, EventArgs e)
        {

            var config = ConfigurationManager.Instance;
            config.StartAngle = (float)Double.Parse(txtStartingAngle.Text);
            _parent.Redraw();
        }

        private void txtRotationAngle_TextChanged(object sender, EventArgs e)
        {
            var config = ConfigurationManager.Instance;
            config.RotationAngle = (float)Double.Parse(txtRotationAngle.Text);
            _parent.Redraw();
        }

        private void txtLength_TextChanged(object sender, EventArgs e)
        {

            var config = ConfigurationManager.Instance;
            config.InitialLength = (float)Double.Parse(txtLength.Text);
            _parent.Redraw();
        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {

            var config = ConfigurationManager.Instance;
            config.InitialWidth = (float)Double.Parse(txtWidth.Text);
            _parent.Redraw();
        }

        private void txtScale_TextChanged(object sender, EventArgs e)
        {

            var config = ConfigurationManager.Instance;
            config.Scaling = (float)Double.Parse(txtScale.Text);
            _parent.Redraw();
        }

        private void radTopLeft_CheckedChanged(object sender, EventArgs e)
        {
            if (radTopLeft.Checked)
            {
                var config = ConfigurationManager.Instance;
                config.Origin = new PointF(0, 0);
            }
            _parent.Redraw();
        }

        private void radTopMid_CheckedChanged(object sender, EventArgs e)
        {
            if (radTopMid.Checked)
            {

                var config = ConfigurationManager.Instance;
                config.Origin = new PointF(_parent.Size.Width / 2, 0);
            }

            _parent.Redraw();
        }

        private void radTopRight_CheckedChanged(object sender, EventArgs e)
        {
            if (radTopRight.Checked)
            {
                var config = ConfigurationManager.Instance;
                config.Origin = new PointF(_parent.Size.Width, 0);
            }
            _parent.Redraw();
        }

        private void radMidLeft_CheckedChanged(object sender, EventArgs e)
        {
            if (radMidLeft.Checked)
            {
                var config = ConfigurationManager.Instance;
                config.Origin = new PointF(0, _parent.Size.Height / 2);
            }
            _parent.Redraw();
        }

        private void radMid_CheckedChanged(object sender, EventArgs e)
        {
            if (radMid.Checked)
            {
                var config = ConfigurationManager.Instance;
                config.Origin = new PointF(_parent.Size.Width / 2, _parent.Size.Height / 2);
            }
            _parent.Redraw();
        }

        private void radMidRight_CheckedChanged(object sender, EventArgs e)
        {
            if (radMidRight.Checked)
            {
                var config = ConfigurationManager.Instance;
                config.Origin = new PointF(_parent.Size.Width, _parent.Size.Height / 2);
            }
            _parent.Redraw();
        }

        private void radBottomLeft_CheckedChanged(object sender, EventArgs e)
        {
            if (radBottomLeft.Checked)
            {
                var config = ConfigurationManager.Instance;
                config.Origin = new PointF(0, _parent.Size.Height);
            }
            _parent.Redraw();
        }

        private void radBottomMid_CheckedChanged(object sender, EventArgs e)
        {
            if (radBottomMid.Checked)
            {
                var config = ConfigurationManager.Instance;
                config.Origin = new PointF(_parent.Size.Width / 2, _parent.Size.Height);
            }

            _parent.Redraw();
        }

        private void radBottomRight_CheckedChanged(object sender, EventArgs e)
        {
            if (radBottomRight.Checked)
            {
                var config = ConfigurationManager.Instance;
                config.Origin = new PointF(_parent.Size.Width, _parent.Size.Height);
            }
            _parent.Redraw();
        }

        private void btnRuleChange_Click(object sender, EventArgs e)
        {
            var config = ConfigurationManager.Instance;
            config.Rules.Clear();

            var ruleArray = txtRules.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

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
                _parent.Redraw();
            }
        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {
            if (chkAcceptingInput.Checked)
                _parent.Lsystem.Render();
        }
    }
}