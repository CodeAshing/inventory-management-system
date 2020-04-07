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
    public partial class instalPrintForm : Form
    {
        Forms.INSTALLATION ins;
        public instalPrintForm(Forms.INSTALLATION ins)
        {
            InitializeComponent();
            this.ins = ins;
        }
        void install()
        {
            instalPrintReport p = new instalPrintReport();
            p.SetParameterValue("Name", ins.nametb.Text);
            crystalReportViewer1.ReportSource = p;
            crystalReportViewer1.Refresh();

        }

        private void instalPrintForm_Load(object sender, EventArgs e)
        {
            install();
        }
    }
}
