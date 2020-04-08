using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace frontend.print
{
    public partial class instalPrintForm : Form
    {

        SqlCommand cmd;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EU1SO11;Initial Catalog=ALROUGI;Integrated Security=True");


        Forms.INSTALLATION ins;
        public instalPrintForm(Forms.INSTALLATION ins)
        {
            InitializeComponent();
            this.ins = ins;
        }
        void install()
        {
            instalPrintReport p = new instalPrintReport();


            cmd = new SqlCommand("select * from ICpay ", con);
            con.Open();
            cmd.ExecuteNonQuery();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "ICpay");
            DataTable dt = ds.Tables["ICpay"];
            p.SetDataSource(ds.Tables["ICpay"]);

            p.SetParameterValue("Name", ins.nametb.Text);
            p.SetParameterValue("phone", ins.phonetb.Text);
            p.SetParameterValue("category", ins.catCB.Text);
            p.SetParameterValue("Date", ins.dateTP.Text);
            p.SetParameterValue("amount", ins.pricetb.Text);
            p.SetParameterValue("floor", ins.floortb.Text);
            p.SetParameterValue("stop", ins.Stopcb.Text);
            p.SetParameterValue("warranty", ins.warrantyTB.Text);
            p.SetParameterValue("deliveryContract", ins.deliveryTB.Text);
            p.SetParameterValue("place", ins.placetb.Text);
            p.SetParameterValue("note", ins.noteCB.Text);
            p.SetParameterValue("machine", ins.machineTB.Text);
            p.SetParameterValue("doorQuality", ins.doorTB.Text);
            p.SetParameterValue("flooring", ins.flooringTB.Text);
            p.SetParameterValue("KOSteel", ins.KOSTB.Text);
            p.SetParameterValue("cabin", ins.cabinTB.Text);
            p.SetParameterValue("discription", ins.discriptionTB.Text);

            crystalReportViewer1.ReportSource = p;
            crystalReportViewer1.Refresh();

        }

        private void instalPrintForm_Load(object sender, EventArgs e)
        {
            install();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
