using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frontend.print
{
    public partial class MaintanPrintForm : Form
    {
        Forms.MAINTENANCE main;
        public MaintanPrintForm(Forms.MAINTENANCE main)
        {
            InitializeComponent();
            this.main = main;
        }
        void mantain()
        {
            MaintanPrintReport M = new MaintanPrintReport();
            M.SetParameterValue("Name", main.nameTB.Text);
            crystalReportViewer1.ReportSource = M;
            crystalReportViewer1.Refresh();

        }
        private void MaintanPrintForm_Load(object sender, EventArgs e)
        {
            mantain();
        }
    }
}
