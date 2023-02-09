using System.Windows.Forms;

namespace cloth_cutting_data_report
{
    public partial class PersCutData : UserControl
    {
        public PersCutData(string lb1, string lb2, string lb3, string lb4, string lb5)
        {
            InitializeComponent();
            lbReceiver.Text = lb1;
            lbMatCode.Text = lb2;
            lbQuantity.Text = lb3;
            lbSender.Text = lb4;
            lbDate.Text = lb5;
        }
    }
}
