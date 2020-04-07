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
    public partial class ReciptPrintForm : Form
    {
        Forms.FormRecipt rec;
        public ReciptPrintForm(Forms.FormRecipt rec)
        {
            InitializeComponent();
            this.rec = rec;
        }
        void reci()
        {
            ReciptPrintReport R = new ReciptPrintReport();
            R.SetParameterValue("Name", rec.nametb.Text);
            R.SetParameterValue("Date", rec.dateTP.Text);
            R.SetParameterValue("receivedFrom", rec.RfromCB.Text);
            R.SetParameterValue("Amount", rec.priceTb.Text);
            R.SetParameterValue("amountIW", rec.priceIWCB.Text);
            R.SetParameterValue("description", rec.discription.Text);
            R.SetParameterValue("cashCheque", rec.categoryCB.Text);
            crystalReportViewer1.ReportSource = R;
            crystalReportViewer1.Refresh();

        }

        private void ReciptPrintForm_Load(object sender, EventArgs e)
        {
            reci();

        }
    }
}
