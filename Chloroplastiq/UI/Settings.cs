/*******************************************************
 * Brandon Lucas
 * 30 December 2011
 * Chloroplastiq (Mono-port)
*******************************************************/

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Chloroplastiq.UI
{
    public partial class Settings : Form
    {
        Display parent;

        public Settings(Display parent)
        {
            InitializeComponent();
            this.parent = parent;
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
            ConfigurationManager.Axiom = txtAxiom.Text;
            parent.Redraw();
        }

        private void numIterations_ValueChanged(object sender, EventArgs e)
        {
            ConfigurationManager.Iteration = (ushort)numIterations.Value;
            parent.Redraw();
        }

        private void txtStartingAngle_TextChanged(object sender, EventArgs e)
        {
            ConfigurationManager.StartAngle = (float)Double.Parse(txtStartingAngle.Text);
            parent.Redraw();
        }

        private void txtRotationAngle_TextChanged(object sender, EventArgs e)
        {
            ConfigurationManager.RotationAngle = (float)Double.Parse(txtRotationAngle.Text);
            parent.Redraw();
        }

        private void txtLength_TextChanged(object sender, EventArgs e)
        {
            ConfigurationManager.InitialLength = (float)Double.Parse(txtLength.Text);
            parent.Redraw();
        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {
            ConfigurationManager.InitialWidth = (float)Double.Parse(txtWidth.Text);
            parent.Redraw();
        }

        private void txtScale_TextChanged(object sender, EventArgs e)
        {
            ConfigurationManager.Scaling = (float)Double.Parse(txtScale.Text);
            parent.Redraw();
        }

        private void radTopLeft_CheckedChanged(object sender, EventArgs e)
        {
            if (radTopLeft.Checked == true)
            {
                ConfigurationManager.Origin = new PointF(0, 0);
            }
            parent.Redraw();
        }

        private void radTopMid_CheckedChanged(object sender, EventArgs e)
        {
            if (radTopMid.Checked == true)
            {
                ConfigurationManager.Origin = new PointF(parent.Size.Width / 2, 0);
            }
            parent.Redraw();
        }

        private void radTopRight_CheckedChanged(object sender, EventArgs e)
        {
            if (radTopRight.Checked == true)
            {
                ConfigurationManager.Origin = new PointF(parent.Size.Width, 0);
            }
            parent.Redraw();
        }

        private void radMidLeft_CheckedChanged(object sender, EventArgs e)
        {
            if (radMidLeft.Checked == true)
            {
                ConfigurationManager.Origin = new PointF(0, parent.Size.Height / 2);
            }
            parent.Redraw();
        }

        private void radMid_CheckedChanged(object sender, EventArgs e)
        {
            if (radMid.Checked == true)
            {
                ConfigurationManager.Origin = new PointF(parent.Size.Width / 2, parent.Size.Height / 2);
            }
            parent.Redraw();
        }

        private void radMidRight_CheckedChanged(object sender, EventArgs e)
        {
            if (radMidRight.Checked == true)
            {
                ConfigurationManager.Origin = new PointF(parent.Size.Width, parent.Size.Height / 2);
            }
            parent.Redraw();
        }

        private void radBottomLeft_CheckedChanged(object sender, EventArgs e)
        {
            if (radBottomLeft.Checked == true)
            {
                ConfigurationManager.Origin = new PointF(0, parent.Size.Height);
            }
            parent.Redraw();
        }

        private void radBottomMid_CheckedChanged(object sender, EventArgs e)
        {
            if (radBottomMid.Checked == true)
            {
                ConfigurationManager.Origin = new PointF(parent.Size.Width / 2, parent.Size.Height);
            }
            parent.Redraw();
        }

        private void radBottomRight_CheckedChanged(object sender, EventArgs e)
        {
            if (radBottomRight.Checked == true)
            {
                ConfigurationManager.Origin = new PointF(parent.Size.Width, parent.Size.Height);
            }
            parent.Redraw();
        }

        private void btnRuleChange_Click(object sender, EventArgs e)
        {
            ConfigurationManager.Rules.Clear();
            string[] ruleArray = txtRules.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string r in ruleArray)
            {
                string[] ps = r.Split(':');
                if (ps.Length != 2)
                    MessageBox.Show("Invalid Rule Syntax.");
                else
                    ConfigurationManager.Rules.Add(ps[0][0], ps[1]);
            }
            parent.Redraw();
        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {
            if (chkAcceptingInput.Checked == true)
                parent.lsystem.Render(txtPath.Text);
        }
    }
}