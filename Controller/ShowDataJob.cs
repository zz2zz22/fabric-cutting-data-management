using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quartz;

namespace cloth_cutting_data_report
{
    public class ShowDataJob : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            
            //MessageBox.Show(DateTime.Now.ToString());
            //Replace with send mail logic ?? // should check on if have data but shudown the program early ?
            return null;
        }
    }
}
