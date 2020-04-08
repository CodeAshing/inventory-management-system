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
    public partial class sparePrintForm : Form
    {

        SqlCommand cmd;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EU1SO11;Initial Catalog=ALROUGI;Integrated Security=True");


        Forms.FSpare spar;
        public sparePrintForm(Forms.FSpare spar)
        {
            InitializeComponent();
            this.spar = spar;
        }
        void spare()
        {
            sparePrintReport s = new sparePrintReport();            

            cmd = new SqlCommand("select * from Spare  ", con);
            con.Open();
            cmd.ExecuteNonQuery();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Spare");
            DataTable dt = ds.Tables["Spare"];
            s.SetDataSource(ds.Tables["Spare"]);    

            s.SetParameterValue("Name", spar.nameTB.Text);
            s.SetParameterValue("Date", spar.dateTP.Text);
            s.SetParameterValue("category", spar.categoryCB.Text);

            //add value as sum
            string total="";
            cmd = new SqlCommand("select  sum(cast(مجموع as int)) as total from Spare ", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                 total = dr.GetValue(0).ToString();
            }

            s.SetParameterValue("total", total);

            crystalReportViewer1.ReportSource = s;
            crystalReportViewer1.Refresh();
            con.Close();
        }

        private void sparePrintForm_Load(object sender, EventArgs e)
        {
            spare();
        }
    }
}
