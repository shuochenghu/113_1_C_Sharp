/*-----------------------------------------------------
    �Z��:��ޤ@��
    �Ǹ�:A113838538
    �m�W:��J��
-------------------------------------------------------*/

namespace Tutorial2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //��ܼ��J�P�I��
        private void btnShowBack_Click(object sender, EventArgs e)
        {
            ptxBack.Visible = true;  //�]�wvisible�ݩʬ���
            ptxFront.Visible = false;
        }
        //��ܼ��J�P����
        private void btnShowFront_Click(object sender, EventArgs e)
        {
            ptxBack.Visible = false;
            ptxFront.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
