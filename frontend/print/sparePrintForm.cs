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
    public partial class sparePrintForm : Form
    {
        Forms.FSpare spar;
        public sparePrintForm(Forms.FSpare spar)
        {
            InitializeComponent();
            this.spar = spar;
        }
        void spare()
        {
            sparePrintReport s = new sparePrintReport();
            s.SetParameterValue("Name", spar.nameTB.Text);
            crystalReportViewer1.ReportSource = s;
            crystalReportViewer1.Refresh();

        }

        private void sparePrintForm_Load(object sender, EventArgs e)
        {
            spare();
        }
    }
}
