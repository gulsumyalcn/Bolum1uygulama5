namespace uygulama5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool secim;
            secim = checkBox1.Checked; //Checked �zelli�i True veya False de�erleri al�r.
            label2.Text = secim.ToString();
        }
    }
}