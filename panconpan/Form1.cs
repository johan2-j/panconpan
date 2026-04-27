namespace panconpan
{
    public partial class Form1 : Form
    {
        int i;
        public Form1()
        {
            InitializeComponent();
            i = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                i = 2;
                mundo.BackColor = Color.Red;
            }
            else
            {
                i = 1;
                mundo.BackColor = Color.Blue;
            }
        }
    }
}
