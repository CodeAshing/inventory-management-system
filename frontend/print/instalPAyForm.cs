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
    public partial class instalPAyForm : Form
    {
        Forms.pay_term p;
        public instalPAyForm(Forms.pay_term p)
        {
            InitializeComponent();
            this.p = p;
        }


        void pay()
        {
            instalPayReport ipr = new instalPayReport();
            ipr.SetParameterValue("Name", p.namePrint);
            ipr.SetParameterValue("phone", p.phonePrint);
            ipr.SetParameterValue("Amount", p.amountPrint.ToString());
            ipr.SetParameterValue("contractValue", p.priceTD.Text);
            ipr.SetParameterValue("description", p.discriptionTB.Text);
            ipr.SetParameterValue("Date", p.dateTp.Text);
            crystalReportViewer1.ReportSource = ipr;
            crystalReportViewer1.Refresh();

        }

        private void instalPAyForm_Load(object sender, EventArgs e)
        {
            pay();
        }
    }
}
