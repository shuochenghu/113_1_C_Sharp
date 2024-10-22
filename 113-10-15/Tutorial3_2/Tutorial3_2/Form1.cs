namespace Tutorial3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int kms;
            int liters;
            //double average;

            kms = int.Parse(txbKM.Text);
            liters = int.Parse(txbLiter.Text);
            //average = kms / liters;

            lblShow.Text = ( kms / (double)liters).ToString("n3");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
