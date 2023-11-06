namespace WF_Timer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            labelTimer = new Label();
            buttonNY = new Button();
            buttonBD = new Button();
            buttonWF = new Button();
            timer2 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // labelTimer
            // 
            labelTimer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTimer.Location = new Point(9, 0);
            labelTimer.Margin = new Padding(10, 0, 10, 0);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(432, 59);
            labelTimer.TabIndex = 1;
            labelTimer.Text = "labelTimer";
            labelTimer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonNY
            // 
            buttonNY.Enabled = false;
            buttonNY.Location = new Point(12, 62);
            buttonNY.Name = "buttonNY";
            buttonNY.Size = new Size(139, 52);
            buttonNY.TabIndex = 2;
            buttonNY.Text = "New Year";
            buttonNY.UseVisualStyleBackColor = true;
            buttonNY.Click += buttonNY_Click;
            // 
            // buttonBD
            // 
            buttonBD.Location = new Point(157, 62);
            buttonBD.Name = "buttonBD";
            buttonBD.Size = new Size(139, 52);
            buttonBD.TabIndex = 3;
            buttonBD.Text = "Birthday";
            buttonBD.UseVisualStyleBackColor = true;
            buttonBD.Click += buttonBD_Click;
            // 
            // buttonWF
            // 
            buttonWF.Location = new Point(302, 62);
            buttonWF.Name = "buttonWF";
            buttonWF.Size = new Size(139, 52);
            buttonWF.TabIndex = 4;
            buttonWF.Text = "WinForms";
            buttonWF.UseVisualStyleBackColor = true;
            buttonWF.Click += buttonWF_Click;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 10;
            timer2.Tick += timer2_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 126);
            Controls.Add(buttonWF);
            Controls.Add(buttonBD);
            Controls.Add(buttonNY);
            Controls.Add(labelTimer);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label labelTimer;
        private Button buttonNY;
        private Button buttonBD;
        private Button buttonWF;
        private System.Windows.Forms.Timer timer2;
    }
}