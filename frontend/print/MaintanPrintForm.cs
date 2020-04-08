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
    public partial class MaintanPrintForm : Form
    {
        SqlCommand cmd;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EU1SO11;Initial Catalog=ALROUGI;Integrated Security=True");
        


        Forms.MAINTENANCE main;
        public MaintanPrintForm(Forms.MAINTENANCE main)
        {
            InitializeComponent();
            this.main = main;
        }
        void mantain()
        {
            MaintanPrintReport M = new MaintanPrintReport();



            cmd = new SqlCommand("select * from MCpay ", con);
            con.Open();
            cmd.ExecuteNonQuery();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "MCpay");
            DataTable dt = ds.Tables["MCpay"];
            M.SetDataSource(ds.Tables["MCpay"]);

            M.SetParameterValue("Name", main.nameTB.Text);
            M.SetParameterValue("category", main.CategoryCB.Text);
            M.SetParameterValue("phone", main.PhoneTB.Text);
            M.SetParameterValue("startDate", main.dateSTP.Text);
            M.SetParameterValue("endDate", main.dateETP.Text);
            M.SetParameterValue("floor", main.floorTB.Text);
            M.SetParameterValue("stop", main.stopCB.Text);
            M.SetParameterValue("deliveryContract", main.DeliveryTB.Text);
            M.SetParameterValue("place", main.placetb.Text);
            M.SetParameterValue("amount", main.priceTB.Text);
            M.SetParameterValue("note", main.noteCB.Text);
            M.SetParameterValue("flooring", main.FlooringTB.Text);
            M.SetParameterValue("discription", main.discriptionTB.Text);

            crystalReportViewer1.ReportSource = M;
            crystalReportViewer1.Refresh();

            con.Close();
        }

        
        private void MaintanPrintForm_Load(object sender, EventArgs e)
        {            
            mantain();
        }
    }
}
