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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            resources.ApplyResources(labelTimer, "labelTimer");
            labelTimer.Name = "labelTimer";
            // 
            // buttonNY
            // 
            resources.ApplyResources(buttonNY, "buttonNY");
            buttonNY.Name = "buttonNY";
            buttonNY.UseVisualStyleBackColor = true;
            buttonNY.Click += buttonNY_Click;
            // 
            // buttonBD
            // 
            resources.ApplyResources(buttonBD, "buttonBD");
            buttonBD.Name = "buttonBD";
            buttonBD.UseVisualStyleBackColor = true;
            buttonBD.Click += buttonBD_Click;
            // 
            // buttonWF
            // 
            resources.ApplyResources(buttonWF, "buttonWF");
            buttonWF.Name = "buttonWF";
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
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonWF);
            Controls.Add(buttonBD);
            Controls.Add(buttonNY);
            Controls.Add(labelTimer);
            Name = "Form1";
            InputLanguageChanged += Form1_InputLanguageChanged;
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