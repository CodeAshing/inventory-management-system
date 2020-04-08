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
    public partial class mainPayForm : Form
    {
        Forms.PayTerm_M_ p;
        public mainPayForm(Forms.PayTerm_M_ p)
        {
            InitializeComponent();
            this.p = p;
        }
        void pay()
        {
            mainpayReport pr =  new mainpayReport();
            pr.SetParameterValue("Name", p.namePrint);
            pr.SetParameterValue("phone", p.phonePrint);
            pr.SetParameterValue("Amount", p.amountPrint.ToString());
            pr.SetParameterValue("contractValue", p.priceTD.Text);
            pr.SetParameterValue("description", p.discriptionTB.Text);
            pr.SetParameterValue("Date", p.dateTp.Text);
            crystalReportViewer1.ReportSource = pr;
            crystalReportViewer1.Refresh();
            
        }
        private void mainPayForm_Load(object sender, EventArgs e)
        {
            pay();

        }
    }
}
