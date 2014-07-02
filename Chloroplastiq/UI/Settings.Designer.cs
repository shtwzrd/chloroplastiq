namespace Chloroplastiq.UI
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControlBar = new System.Windows.Forms.TabControl();
            this.ControlsTab = new System.Windows.Forms.TabPage();
            this.numIterations = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtScale = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpOrigin = new System.Windows.Forms.GroupBox();
            this.radBottomMid = new System.Windows.Forms.RadioButton();
            this.radTopMid = new System.Windows.Forms.RadioButton();
            this.radBottomLeft = new System.Windows.Forms.RadioButton();
            this.radMidRight = new System.Windows.Forms.RadioButton();
            this.radBottomRight = new System.Windows.Forms.RadioButton();
            this.radMid = new System.Windows.Forms.RadioButton();
            this.radMidLeft = new System.Windows.Forms.RadioButton();
            this.radTopRight = new System.Windows.Forms.RadioButton();
            this.radTopLeft = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtRotationAngle = new System.Windows.Forms.TextBox();
            this.txtStartingAngle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAxiom = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRuleChange = new System.Windows.Forms.Button();
            this.txtRules = new System.Windows.Forms.TextBox();
            this.PathTab = new System.Windows.Forms.TabPage();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.chkAcceptingInput = new System.Windows.Forms.CheckBox();
            this.TabControlBar.SuspendLayout();
            this.ControlsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIterations)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.grpOrigin.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.PathTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControlBar
            // 
            this.TabControlBar.Controls.Add(this.ControlsTab);
            this.TabControlBar.Controls.Add(this.PathTab);
            this.TabControlBar.Location = new System.Drawing.Point(12, 12);
            this.TabControlBar.Name = "TabControlBar";
            this.TabControlBar.SelectedIndex = 0;
            this.TabControlBar.Size = new System.Drawing.Size(390, 258);
            this.TabControlBar.TabIndex = 0;
            // 
            // ControlsTab
            // 
            this.ControlsTab.Controls.Add(this.numIterations);
            this.ControlsTab.Controls.Add(this.label6);
            this.ControlsTab.Controls.Add(this.groupBox5);
            this.ControlsTab.Controls.Add(this.grpOrigin);
            this.ControlsTab.Controls.Add(this.groupBox3);
            this.ControlsTab.Controls.Add(this.groupBox2);
            this.ControlsTab.Controls.Add(this.groupBox1);
            this.ControlsTab.Location = new System.Drawing.Point(4, 22);
            this.ControlsTab.Name = "ControlsTab";
            this.ControlsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ControlsTab.Size = new System.Drawing.Size(382, 232);
            this.ControlsTab.TabIndex = 0;
            this.ControlsTab.Text = "Controls";
            this.ControlsTab.UseVisualStyleBackColor = true;
            // 
            // numIterations
            // 
            this.numIterations.Location = new System.Drawing.Point(265, 23);
            this.numIterations.Name = "numIterations";
            this.numIterations.Size = new System.Drawing.Size(110, 20);
            this.numIterations.TabIndex = 9;
            this.numIterations.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numIterations.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numIterations.ValueChanged += new System.EventHandler(this.numIterations_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Iterations:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.txtScale);
            this.groupBox5.Controls.Add(this.txtWidth);
            this.groupBox5.Controls.Add(this.txtLength);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(150, 138);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(153, 87);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Scaling:";
            // 
            // txtScale
            // 
            this.txtScale.Location = new System.Drawing.Point(104, 61);
            this.txtScale.Name = "txtScale";
            this.txtScale.Size = new System.Drawing.Size(43, 20);
            this.txtScale.TabIndex = 5;
            this.txtScale.Text = "50";
            this.txtScale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtScale.TextChanged += new System.EventHandler(this.txtScale_TextChanged);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(104, 38);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(43, 20);
            this.txtWidth.TabIndex = 4;
            this.txtWidth.Text = "3";
            this.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtWidth.TextChanged += new System.EventHandler(this.txtWidth_TextChanged);
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(104, 12);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(43, 20);
            this.txtLength.TabIndex = 3;
            this.txtLength.Text = "1";
            this.txtLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLength.TextChanged += new System.EventHandler(this.txtLength_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Initial Width:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Initial Length:";
            // 
            // grpOrigin
            // 
            this.grpOrigin.Controls.Add(this.radBottomMid);
            this.grpOrigin.Controls.Add(this.radTopMid);
            this.grpOrigin.Controls.Add(this.radBottomLeft);
            this.grpOrigin.Controls.Add(this.radMidRight);
            this.grpOrigin.Controls.Add(this.radBottomRight);
            this.grpOrigin.Controls.Add(this.radMid);
            this.grpOrigin.Controls.Add(this.radMidLeft);
            this.grpOrigin.Controls.Add(this.radTopRight);
            this.grpOrigin.Controls.Add(this.radTopLeft);
            this.grpOrigin.Location = new System.Drawing.Point(309, 138);
            this.grpOrigin.Name = "grpOrigin";
            this.grpOrigin.Size = new System.Drawing.Size(66, 87);
            this.grpOrigin.TabIndex = 5;
            this.grpOrigin.TabStop = false;
            this.grpOrigin.Text = "Origin";
            // 
            // radBottomMid
            // 
            this.radBottomMid.AutoSize = true;
            this.radBottomMid.Checked = true;
            this.radBottomMid.Location = new System.Drawing.Point(26, 57);
            this.radBottomMid.Name = "radBottomMid";
            this.radBottomMid.Size = new System.Drawing.Size(14, 13);
            this.radBottomMid.TabIndex = 8;
            this.radBottomMid.TabStop = true;
            this.radBottomMid.UseVisualStyleBackColor = true;
            this.radBottomMid.CheckedChanged += new System.EventHandler(this.radBottomMid_CheckedChanged);
            // 
            // radTopMid
            // 
            this.radTopMid.AutoSize = true;
            this.radTopMid.Location = new System.Drawing.Point(26, 19);
            this.radTopMid.Name = "radTopMid";
            this.radTopMid.Size = new System.Drawing.Size(14, 13);
            this.radTopMid.TabIndex = 7;
            this.radTopMid.UseVisualStyleBackColor = true;
            this.radTopMid.CheckedChanged += new System.EventHandler(this.radTopMid_CheckedChanged);
            // 
            // radBottomLeft
            // 
            this.radBottomLeft.AutoSize = true;
            this.radBottomLeft.Location = new System.Drawing.Point(6, 57);
            this.radBottomLeft.Name = "radBottomLeft";
            this.radBottomLeft.Size = new System.Drawing.Size(14, 13);
            this.radBottomLeft.TabIndex = 6;
            this.radBottomLeft.UseVisualStyleBackColor = true;
            this.radBottomLeft.CheckedChanged += new System.EventHandler(this.radBottomLeft_CheckedChanged);
            // 
            // radMidRight
            // 
            this.radMidRight.AutoSize = true;
            this.radMidRight.Location = new System.Drawing.Point(46, 38);
            this.radMidRight.Name = "radMidRight";
            this.radMidRight.Size = new System.Drawing.Size(14, 13);
            this.radMidRight.TabIndex = 5;
            this.radMidRight.UseVisualStyleBackColor = true;
            this.radMidRight.CheckedChanged += new System.EventHandler(this.radMidRight_CheckedChanged);
            // 
            // radBottomRight
            // 
            this.radBottomRight.AutoSize = true;
            this.radBottomRight.Location = new System.Drawing.Point(46, 57);
            this.radBottomRight.Name = "radBottomRight";
            this.radBottomRight.Size = new System.Drawing.Size(14, 13);
            this.radBottomRight.TabIndex = 1;
            this.radBottomRight.UseVisualStyleBackColor = true;
            this.radBottomRight.CheckedChanged += new System.EventHandler(this.radBottomRight_CheckedChanged);
            // 
            // radMid
            // 
            this.radMid.AutoSize = true;
            this.radMid.Location = new System.Drawing.Point(26, 38);
            this.radMid.Name = "radMid";
            this.radMid.Size = new System.Drawing.Size(14, 13);
            this.radMid.TabIndex = 4;
            this.radMid.UseVisualStyleBackColor = true;
            this.radMid.CheckedChanged += new System.EventHandler(this.radMid_CheckedChanged);
            // 
            // radMidLeft
            // 
            this.radMidLeft.AutoSize = true;
            this.radMidLeft.Location = new System.Drawing.Point(6, 38);
            this.radMidLeft.Name = "radMidLeft";
            this.radMidLeft.Size = new System.Drawing.Size(14, 13);
            this.radMidLeft.TabIndex = 3;
            this.radMidLeft.UseVisualStyleBackColor = true;
            this.radMidLeft.CheckedChanged += new System.EventHandler(this.radMidLeft_CheckedChanged);
            // 
            // radTopRight
            // 
            this.radTopRight.AutoSize = true;
            this.radTopRight.Location = new System.Drawing.Point(46, 19);
            this.radTopRight.Name = "radTopRight";
            this.radTopRight.Size = new System.Drawing.Size(14, 13);
            this.radTopRight.TabIndex = 2;
            this.radTopRight.UseVisualStyleBackColor = true;
            this.radTopRight.CheckedChanged += new System.EventHandler(this.radTopRight_CheckedChanged);
            // 
            // radTopLeft
            // 
            this.radTopLeft.AutoSize = true;
            this.radTopLeft.Location = new System.Drawing.Point(6, 19);
            this.radTopLeft.Name = "radTopLeft";
            this.radTopLeft.Size = new System.Drawing.Size(14, 13);
            this.radTopLeft.TabIndex = 0;
            this.radTopLeft.UseVisualStyleBackColor = true;
            this.radTopLeft.CheckedChanged += new System.EventHandler(this.radTopLeft_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtRotationAngle);
            this.groupBox3.Controls.Add(this.txtStartingAngle);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(7, 138);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(136, 88);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Angle";
            // 
            // txtRotationAngle
            // 
            this.txtRotationAngle.Location = new System.Drawing.Point(87, 50);
            this.txtRotationAngle.Name = "txtRotationAngle";
            this.txtRotationAngle.Size = new System.Drawing.Size(43, 20);
            this.txtRotationAngle.TabIndex = 6;
            this.txtRotationAngle.Text = "25";
            this.txtRotationAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRotationAngle.TextChanged += new System.EventHandler(this.txtRotationAngle_TextChanged);
            // 
            // txtStartingAngle
            // 
            this.txtStartingAngle.Location = new System.Drawing.Point(87, 12);
            this.txtStartingAngle.Name = "txtStartingAngle";
            this.txtStartingAngle.Size = new System.Drawing.Size(43, 20);
            this.txtStartingAngle.TabIndex = 2;
            this.txtStartingAngle.Text = "90";
            this.txtStartingAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtStartingAngle.TextChanged += new System.EventHandler(this.txtStartingAngle_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rotation angle:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Starting angle:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAxiom);
            this.groupBox2.Location = new System.Drawing.Point(6, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 41);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Axiom";
            // 
            // txtAxiom
            // 
            this.txtAxiom.Location = new System.Drawing.Point(6, 15);
            this.txtAxiom.Name = "txtAxiom";
            this.txtAxiom.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAxiom.Size = new System.Drawing.Size(173, 20);
            this.txtAxiom.TabIndex = 2;
            this.txtAxiom.Text = "X";
            this.txtAxiom.TextChanged += new System.EventHandler(this.txtAxiom_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRuleChange);
            this.groupBox1.Controls.Add(this.txtRules);
            this.groupBox1.Location = new System.Drawing.Point(6, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 81);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rules";
            // 
            // btnRuleChange
            // 
            this.btnRuleChange.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRuleChange.Location = new System.Drawing.Point(303, 19);
            this.btnRuleChange.Name = "btnRuleChange";
            this.btnRuleChange.Size = new System.Drawing.Size(60, 56);
            this.btnRuleChange.TabIndex = 2;
            this.btnRuleChange.Text = "Commit Rule Change";
            this.btnRuleChange.UseVisualStyleBackColor = false;
            this.btnRuleChange.Click += new System.EventHandler(this.btnRuleChange_Click);
            // 
            // txtRules
            // 
            this.txtRules.Location = new System.Drawing.Point(6, 19);
            this.txtRules.Multiline = true;
            this.txtRules.Name = "txtRules";
            this.txtRules.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRules.Size = new System.Drawing.Size(291, 59);
            this.txtRules.TabIndex = 1;
            this.txtRules.Text = "X : F-[[X]+X]+F[+FX]-X\r\nF : FF";
            // 
            // PathTab
            // 
            this.PathTab.Controls.Add(this.chkAcceptingInput);
            this.PathTab.Controls.Add(this.txtPath);
            this.PathTab.Location = new System.Drawing.Point(4, 22);
            this.PathTab.Name = "PathTab";
            this.PathTab.Padding = new System.Windows.Forms.Padding(3);
            this.PathTab.Size = new System.Drawing.Size(382, 232);
            this.PathTab.TabIndex = 1;
            this.PathTab.Text = "Path";
            this.PathTab.UseVisualStyleBackColor = true;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(6, 24);
            this.txtPath.Multiline = true;
            this.txtPath.Name = "txtPath";
            this.txtPath.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPath.Size = new System.Drawing.Size(370, 202);
            this.txtPath.TabIndex = 0;
            this.txtPath.TextChanged += new System.EventHandler(this.txtPath_TextChanged);
            // 
            // chkAcceptingInput
            // 
            this.chkAcceptingInput.AutoSize = true;
            this.chkAcceptingInput.Location = new System.Drawing.Point(275, 3);
            this.chkAcceptingInput.Name = "chkAcceptingInput";
            this.chkAcceptingInput.Size = new System.Drawing.Size(101, 17);
            this.chkAcceptingInput.TabIndex = 1;
            this.chkAcceptingInput.Text = "Accepting Input";
            this.chkAcceptingInput.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 282);
            this.Controls.Add(this.TabControlBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.Text = "Controls";
            this.TabControlBar.ResumeLayout(false);
            this.ControlsTab.ResumeLayout(false);
            this.ControlsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIterations)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.grpOrigin.ResumeLayout(false);
            this.grpOrigin.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PathTab.ResumeLayout(false);
            this.PathTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControlBar;
        private System.Windows.Forms.TabPage ControlsTab;
        private System.Windows.Forms.TabPage PathTab;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAxiom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRules;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpOrigin;
        private System.Windows.Forms.RadioButton radBottomMid;
        private System.Windows.Forms.RadioButton radTopMid;
        private System.Windows.Forms.RadioButton radBottomLeft;
        private System.Windows.Forms.RadioButton radMidRight;
        private System.Windows.Forms.RadioButton radBottomRight;
        private System.Windows.Forms.RadioButton radMid;
        private System.Windows.Forms.RadioButton radMidLeft;
        private System.Windows.Forms.RadioButton radTopRight;
        private System.Windows.Forms.RadioButton radTopLeft;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtRotationAngle;
        private System.Windows.Forms.TextBox txtStartingAngle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtScale;
        private System.Windows.Forms.NumericUpDown numIterations;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRuleChange;
        private System.Windows.Forms.CheckBox chkAcceptingInput;
    }
}