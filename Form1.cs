namespace WF_Timer
{
    public partial class Form1 : Form
    {
        static DateTime[] _day = new DateTime[3] { new DateTime(2024, 1, 1), new DateTime(2023, 12, 13), new DateTime(2023, 11, 27) };
        DateTime _selected = _day[0];

        public Form1()
        {
            InitializeComponent();
            this.Text = "0";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan temp = _selected - DateTime.Now;
            labelTimer.Text = $"{temp.Days} Days {temp.Hours} Hours {temp.Minutes} Minutes {temp.Seconds} Seconds";
        }

        private void buttonNY_Click(object sender, EventArgs e)
        {
            buttonNY.Enabled = false;
            buttonBD.Enabled = true;
            buttonWF.Enabled = true;

            _selected = _day[0];
        }

        private void buttonBD_Click(object sender, EventArgs e)
        {
            buttonNY.Enabled = true;
            buttonBD.Enabled = false;
            buttonWF.Enabled = true;

            _selected = _day[1];
        }

        private void buttonWF_Click(object sender, EventArgs e)
        {
            buttonNY.Enabled = true;
            buttonBD.Enabled = true;
            buttonWF.Enabled = false;

            _selected = _day[2];
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Text = (Convert.ToInt32(this.Text) + timer2.Interval).ToString();
        }
    }
}