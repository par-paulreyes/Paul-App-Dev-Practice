namespace DartPracticeApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtProblemDescription = new System.Windows.Forms.TextBox();
            this.txtCodeInput = new System.Windows.Forms.TextBox();
            this.btnRunCode = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.comboBoxProblems = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodeDisplay = new System.Windows.Forms.TextBox();
            this.btnShowCode = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxLevel = new System.Windows.Forms.ComboBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtProblemDescription
            // 
            this.txtProblemDescription.Enabled = false;
            this.txtProblemDescription.Location = new System.Drawing.Point(15, 39);
            this.txtProblemDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProblemDescription.Multiline = true;
            this.txtProblemDescription.Name = "txtProblemDescription";
            this.txtProblemDescription.ReadOnly = true;
            this.txtProblemDescription.Size = new System.Drawing.Size(454, 168);
            this.txtProblemDescription.TabIndex = 0;
            // 
            // txtCodeInput
            // 
            this.txtCodeInput.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodeInput.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txtCodeInput.Location = new System.Drawing.Point(489, 52);
            this.txtCodeInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodeInput.Multiline = true;
            this.txtCodeInput.Name = "txtCodeInput";
            this.txtCodeInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCodeInput.Size = new System.Drawing.Size(760, 543);
            this.txtCodeInput.TabIndex = 1;
            // 
            // btnRunCode
            // 
            this.btnRunCode.ForeColor = System.Drawing.Color.Black;
            this.btnRunCode.Location = new System.Drawing.Point(1142, 609);
            this.btnRunCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRunCode.Name = "btnRunCode";
            this.btnRunCode.Size = new System.Drawing.Size(107, 44);
            this.btnRunCode.TabIndex = 2;
            this.btnRunCode.Text = "Run Code";
            this.btnRunCode.UseVisualStyleBackColor = true;
            this.btnRunCode.Click += new System.EventHandler(this.btnRunCode_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(15, 528);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(454, 125);
            this.txtOutput.TabIndex = 3;
            // 
            // comboBoxProblems
            // 
            this.comboBoxProblems.FormattingEnabled = true;
            this.comboBoxProblems.Location = new System.Drawing.Point(654, 21);
            this.comboBoxProblems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxProblems.Name = "comboBoxProblems";
            this.comboBoxProblems.Size = new System.Drawing.Size(501, 24);
            this.comboBoxProblems.TabIndex = 4;
            this.comboBoxProblems.SelectedIndexChanged += new System.EventHandler(this.comboBoxProblems_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(482, 614);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "PAUL DART PRACTICE APP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(651, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select Problem";
            // 
            // txtCodeDisplay
            // 
            this.txtCodeDisplay.Location = new System.Drawing.Point(15, 253);
            this.txtCodeDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodeDisplay.Multiline = true;
            this.txtCodeDisplay.Name = "txtCodeDisplay";
            this.txtCodeDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCodeDisplay.ReadOnly = true;
            this.txtCodeDisplay.Size = new System.Drawing.Size(454, 234);
            this.txtCodeDisplay.TabIndex = 7;
            // 
            // btnShowCode
            // 
            this.btnShowCode.ForeColor = System.Drawing.Color.Black;
            this.btnShowCode.Location = new System.Drawing.Point(377, 217);
            this.btnShowCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowCode.Name = "btnShowCode";
            this.btnShowCode.Size = new System.Drawing.Size(92, 27);
            this.btnShowCode.TabIndex = 8;
            this.btnShowCode.Text = "Show Code";
            this.btnShowCode.UseVisualStyleBackColor = true;
            this.btnShowCode.Click += new System.EventHandler(this.btnShowCode_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(486, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Code Editor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Problem Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(567, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Level";
            // 
            // comboBoxLevel
            // 
            this.comboBoxLevel.FormattingEnabled = true;
            this.comboBoxLevel.Location = new System.Drawing.Point(570, 21);
            this.comboBoxLevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxLevel.Name = "comboBoxLevel";
            this.comboBoxLevel.Size = new System.Drawing.Size(78, 24);
            this.comboBoxLevel.TabIndex = 12;
            this.comboBoxLevel.SelectedIndexChanged += new System.EventHandler(this.comboBoxLevel_SelectedIndexChanged);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(1161, 20);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(43, 16);
            this.lblScore.TabIndex = 16;
            this.lblScore.Text = "Score";
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.Color.Lime;
            this.txtScore.Location = new System.Drawing.Point(1210, 11);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(28, 31);
            this.txtScore.TabIndex = 17;
            this.txtScore.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Solution";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 499);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.comboBoxLevel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnShowCode);
            this.Controls.Add(this.txtCodeDisplay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxProblems);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnRunCode);
            this.Controls.Add(this.txtCodeInput);
            this.Controls.Add(this.txtProblemDescription);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paul Dart Practice App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtProblemDescription;
        private System.Windows.Forms.TextBox txtCodeInput;
        private System.Windows.Forms.Button btnRunCode;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.ComboBox comboBoxProblems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodeDisplay;
        private System.Windows.Forms.Button btnShowCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxLevel;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
