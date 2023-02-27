using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cloth_cutting_data_report
{
    public class ExportReport
    {
        public string PathCuttingReport = Environment.CurrentDirectory + @"\Resources\ExportCuttingForm.xlsx";

        public void ExportExcelCuttingReport(string PathSave, List<DetailInformation> details)
        {
            ToolSupport toolSupport = new ToolSupport();
            toolSupport.ExportData(details, PathSave, PathCuttingReport);
        }
    }
}
