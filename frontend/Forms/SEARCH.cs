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

namespace frontend.Forms
{
    public partial class SEARCH : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EU1SO11;Initial Catalog=ALROUGI;Integrated Security=True");
        
        public SEARCH()
        {
            InitializeComponent();
        }
        private void LoadTheme()
        {

            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = Themecolor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    dataGridView1.BackgroundColor = Themecolor.PrimaryColor;
                    btn.FlatAppearance.BorderColor = Themecolor.SecondaryColor;
                }
            }
        }
      void pay_rec_fillCat()
        {
            PRS_catCB.Items.Clear();
            if (flag == "payment")
            {
                PRS_catCB.Items.Add("امتداد");
                PRS_catCB.Items.Add("حضانة الموظف");
            }
            else if (flag == "receipt")
            {
                PRS_catCB.Items.Add("مدير");
                PRS_catCB.Items.Add("الزبون");
                PRS_catCB.Items.Add("الآخرين");
            }
            else if (flag == "install")
            {
                PRS_catCB.Items.Add("التركيب");
                PRS_catCB.Items.Add("دفع");
            }
            else if (flag == "maintan")
            {
                PRS_catCB.Items.Add("صيانة");
                PRS_catCB.Items.Add("دفع");
            }
            else if (flag == "emp")
            {
                PRS_catCB.Items.Add("موظف");
                PRS_catCB.Items.Add("الراتب مقدما");
            }
        }

        // bind data in gridview
        void formload()
        {

            SqlCommand cmd;

            if (flag == "payment")
            {
                cmd = new SqlCommand("select  t1.ااسم_العميل, t1.تاريخ,  t1.الفئة , t1.نوع_الدفع, t1.وصف, t1.المبلغ_بالكلمات, t1.مدفوع, t1.تسلم, SUM(t2.المجموع) as المجموع from payment t1 inner join payment t2 on t1.رقم_العقد >= t2.رقم_العقد and t1.ااسم_العميل = t2.ااسم_العميل group by t1.رقم_العقد, t1.المجموع, t1.ااسم_العميل, t1.تاريخ, t1.الفئة, t1.نوع_الدفع, t1.وصف, t1.المبلغ_بالكلمات, t1.مدفوع, t1.تسلم", con);

            }
            else if (flag == "receipt")
            {
                cmd = new SqlCommand("select * from recived union all select '', '', '', '', N'المبلغ الإجمالي', sum(كمية), '', '' from recived", con);
            }
            else if (flag == "install")
            {
                 cmd = new SqlCommand("select * from التركيب", con);
            }
            else if (flag == "maintan")
            {
                 cmd = new SqlCommand("select * from صيانة", con);
            }
            else if (flag == "emp")
            {
                 cmd = new SqlCommand("select * from موظف", con);
            }else 
            {
                 cmd = new SqlCommand("select * from قطع_غيار union all select ' ', '', N'المبلغ الإجمالي', '', sum(cast(سعر_السلعة as int)), '', sum(cast(مجموع as int)), '' from قطع_غيار", con);
            }

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable tb = new DataTable();
                da.Fill(tb);
                dataGridView1.DataSource = tb;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                con.Close();
            }
        }
        
        private void SEARCH_Load(object sender, EventArgs e)
        {
            flag = "install";
            PRS_catCB.Text = "التركيب";
            PRS_fillnameCB();
            pay_rec_fillCat();
            LoadTheme();
            formload();
            hide_search();

        }
       
       
      
        void formloadI_P()
        {

            SqlCommand  cmd = new SqlCommand("select * from Ipay", con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter da;
                da = new SqlDataAdapter(cmd);
                DataTable tb = new DataTable();
                da.Fill(tb);
                dataGridView1.DataSource = tb;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                con.Close();
            }
        }
        void formloadM_P()
        {

            SqlCommand cmd = new SqlCommand("select * from Mpay", con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter da;
                da = new SqlDataAdapter(cmd);
                DataTable tb = new DataTable();
                da.Fill(tb);
                dataGridView1.DataSource = tb;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                con.Close();
            }
        }

       
       
       void PRS_fillnameCB()
        {

            PRS_NCB.Items.Clear();
            SqlCommand cmd;
            if (flag == "payment")
            {
                cmd = new SqlCommand("select   DISTINCT ااسم_العميل from payment", con);
            }
            else if (flag == "receipt")
            {
                cmd = new SqlCommand("select   DISTINCT ااسم_العميل from recived", con);
            }
            else if (flag == "spare")
            {
                cmd = new SqlCommand("select  DISTINCT ااسم_العميل from قطع_غيار", con);
            }
            else if (flag == "install")
            {
                cmd = new SqlCommand("select   DISTINCT ااسم_العميل from التركيب", con);
            }
            else if (flag == "maintan")
            {
                cmd = new SqlCommand("select   DISTINCT ااسم_العميل from صيانة", con);
            }
            else
            {
                cmd = new SqlCommand("select  DISTINCT ااسم_العميل from موظف", con);
            }
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    PRS_NCB.Items.Add(dr["ااسم_العميل"].ToString());

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                con.Close();
            }
        }

        
        private void searMAIN_Click(object sender, EventArgs e)
        {
            flag = "maintan";

            PRS_fillnameCB();
            pay_rec_fillCat();

            panel.Width = searMAIN.Width;
            panel.Location = searMAIN.Location;
            formload();
            hide_search();
            PRS_textclear();
            PRS_catCB.Text = "صيانة";
        }

        private void searSPARE_Click(object sender, EventArgs e)
        {
            flag = "spare";
            PRS_fillnameCB();            
            panel.Width = searSPARE.Width;
            panel.Location = searSPARE.Location;            
            PRS_textclear();
            hide_search();
            formload();
        }

        private void searEMP_Click(object sender, EventArgs e)
        {
            flag = "emp";
            PRS_catCB.Text = "موظف";

            PRS_fillnameCB();
            pay_rec_fillCat();

            formload();
            panel.Width = searEMP.Width;
            panel.Location = searEMP.Location;
            hide_search();
            PRS_textclear();

            PRS_catCB.Text = "موظف";
        }
        string flag;
        void PRS_textclear()
        {
            PRS_catCB.Text = null;
            PRS_NCB.Text = null;
        }
        private void searREC_Click(object sender, EventArgs e)
        {

            flag = "receipt";

            formload();

            PRS_fillnameCB();
            pay_rec_fillCat();

            panel.Width = searREC.Width;
            panel.Location = searREC.Location;
            PRS_textclear();
            hide_search();
        }

        private void searPAY_Click(object sender, EventArgs e)
        {

            flag = "payment";

            formload();

            PRS_fillnameCB();
            pay_rec_fillCat();

            panel.Width = searPAY.Width;
            panel.Location = searPAY.Location;
            PRS_textclear();
            hide_search();
        }
        

        private void searINS_Click(object sender, EventArgs e)
        {
            flag = "install";


            PRS_fillnameCB();
            pay_rec_fillCat();

            formload();
            panel.Width = searINS.Width;
            panel.Location = searINS.Location;
            hide_search();
            PRS_textclear();

            PRS_catCB.Text = "التركيب";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void perC_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd;
            if (flag == "payment")
            {
                cmd = new SqlCommand("select  t1.ااسم_العميل, t1.تاريخ, t1.الفئة, t1.نوع_الدفع, t1.وصف, t1.المبلغ_بالكلمات, t1.مدفوع, t1.تسلم, SUM(t2.المجموع) as المجموع from payment t1 inner join payment t2 on t1.رقم_العقد >= t2.رقم_العقد and t1.ااسم_العميل = t2.ااسم_العميل and t1.الفئة=N'" + PRS_catCB.Text + "' group by t1.رقم_العقد, t1.المجموع, t1.ااسم_العميل, t1.تاريخ, t1.الفئة, t1.نوع_الدفع, t1.وصف, t1.المبلغ_بالكلمات, t1.مدفوع, t1.تسلم ", con);
            }
            else if (flag == "receipt")
            {
                cmd = new SqlCommand("select  * from recived where مستلم_من=N'" + PRS_catCB.Text + "' union all select '', '', '', '', N'المبلغ الإجمالي', sum(كمية), '', '' from recived where مستلم_من=N'" + PRS_catCB.Text + "' ", con);
            }
            else if (flag == "install")
            {
                if (PRS_catCB.Text== "التركيب")
                {

                    cmd = new SqlCommand("select  * from التركيب", con);
                }
                else
                {
                    cmd = new SqlCommand("select  * from Ipay union all select '', '', '', N'المبلغ الإجمالي', SUM(القسط), '',sum(النسبة_المئوية), '', '', '' from Ipay", con);
                }
            }
            else if (flag == "maintan")
            {
                if (PRS_catCB.Text == "صيانة")
                {

                    cmd = new SqlCommand("select  * from صيانة ", con);
                }
                else
                {
                    cmd = new SqlCommand("select  * from Mpay union all select '', '', '', N'المبلغ الإجمالي', SUM(القسط), '', sum(النسبة_المئوية), '', '', '' from Mpay", con);
                }
            }
            else
            {
                if (PRS_catCB.Text == "موظف")
                {
                    endDTP.Hide();
                    dateEmpLabel.Hide();
                    cmd = new SqlCommand("select  * from موظف ", con);
                }
                else
                {

                    endDTP.Show();
                    dateEmpLabel.Show();
                    cmd = new SqlCommand("select  t1.ااسم_العميل , t1.تاريخ , t1.الفئة, t1.نوع_الدفع , t1.وصف ,t1.المبلغ_بالكلمات  , t1.مدفوع  , t1.تسلم  ,SUM(t2.المجموع) as المجموع from payment t1 inner join payment t2 on t1.رقم_العقد >= t2.رقم_العقد and t1.ااسم_العميل = t2.ااسم_العميل and t1.الفئة=N'" + PRS_catCB.Text + "' group by t1.رقم_العقد, t1.المجموع, t1.ااسم_العميل, t1.تاريخ, t1.الفئة, t1.نوع_الدفع, t1.وصف, t1.المبلغ_بالكلمات, t1.مدفوع, t1.تسلم"  , con);
                }
            }
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter da;
                da = new SqlDataAdapter(cmd);
                DataTable tb = new DataTable();
                da.Fill(tb);
                dataGridView1.DataSource = tb;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                con.Close();
            }
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

            SqlCommand cmd;
            if (flag == "payment")
            {
                cmd = new SqlCommand("select  t1.ااسم_العميل, t1.تاريخ, t1.الفئة, t1.نوع_الدفع, t1.وصف, t1.المبلغ_بالكلمات, t1.مدفوع, t1.تسلم, SUM(t2.المجموع) as المجموع from payment t1 inner join payment t2 on t1.رقم_العقد >= t2.رقم_العقد and t1.ااسم_العميل =N'" + PRS_NCB.Text + "' and t1.الفئة=N'" + PRS_catCB.Text + "' and t1.تاريخ=N'" + prs_DateTP.Text + "' group by t1.رقم_العقد, t1.المجموع, t1.ااسم_العميل, t1.تاريخ, t1.الفئة, t1.نوع_الدفع, t1.وصف, t1.المبلغ_بالكلمات, t1.مدفوع, t1.تسلم ", con);
            }
            else if (flag == "receipt")
            {
                cmd = new SqlCommand("select  * from recived where ااسم_العميل =N'" + PRS_NCB.Text + "' and مستلم_من=N'" + PRS_catCB.Text + "' and تاريخ=N'" + prs_DateTP.Text + "' union all select '', '', '', '', N'المبلغ الإجمالي', sum(كمية), '', '' from recived where ااسم_العميل =N'" + PRS_NCB.Text + "' and مستلم_من=N'" + PRS_catCB.Text + "' and تاريخ=N'" + prs_DateTP.Text + "'", con);
            }
            else if (flag == "spare")
            {
                cmd = new SqlCommand("select  * from قطع_غيار where ااسم_العميل =N'" + PRS_NCB.Text + "' and تاريخ=N'" + prs_DateTP.Text + "' union all	select ' ', '', N'المبلغ الإجمالي', '', sum(cast(سعر_السلعة as int)), '', sum(cast(مجموع as int)), '' from قطع_غيار where ااسم_العميل =N'" + PRS_NCB.Text + "' and تاريخ=N'" + prs_DateTP.Text + "' ", con);
            }
            else if (flag == "install")
            {
                if (PRS_catCB.Text == "التركيب")
                {

                    cmd = new SqlCommand("select  * from التركيب where ااسم_العميل =N'" + PRS_NCB.Text + "' and تاريخ_توقيع_العقد=N'" + prs_DateTP.Text + "' ", con);
                }
                else
                {
                    cmd = new SqlCommand("select  * from Ipay where ااسم_العميل =N'" + PRS_NCB.Text + "' and تاريخ>='" + prs_DateTP.Text + "' union all select '', '', '', N'المبلغ الإجمالي', SUM(القسط), '', sum(النسبة_المئوية), '', '', '' from Ipay where ااسم_العميل =N'" + PRS_NCB.Text + "' and تاريخ>='" + prs_DateTP.Text + "'  ", con);
                }
            }
            else if (flag == "maintan")
            {
                if (PRS_catCB.Text == "صيانة")
                {

                    cmd = new SqlCommand("select  * from صيانة where ااسم_العميل =N'" + PRS_NCB.Text + "' and تاريخ_البدء=N'" + prs_DateTP.Text + "'  ", con);
                }
                else
                {
                    cmd = new SqlCommand("select  * from Mpay where ااسم_العميل =N'" + PRS_NCB.Text + "' and تاريخ>='" + prs_DateTP.Text + "' union all select '', '', '', N'المبلغ الإجمالي', SUM(القسط), '', sum(النسبة_المئوية), '', '', '' from Mpay where ااسم_العميل =N'" + PRS_NCB.Text + "' and تاريخ>='" + prs_DateTP.Text + "' ", con);
                }
            }
            else
            {
                if (PRS_catCB.Text == "موظف")
                {

                    cmd = new SqlCommand("select  * from موظف where ااسم_العميل =N'" + PRS_NCB.Text + "' and تاريخ_الولادة=N'" + prs_DateTP.Text + "' ", con);
                }
                else
                {
                    cmd = new SqlCommand("select  t1.ااسم_العميل , t1.تاريخ , t1.الفئة, t1.نوع_الدفع , t1.وصف ,t1.المبلغ_بالكلمات  , t1.مدفوع  , t1.تسلم  ,SUM(t2.المجموع) as المجموع  from payment t1 inner join payment t2 on t1.الفئة=N'" + PRS_catCB.Text + "' and  t1.ااسم_العميل =N'" + PRS_NCB.Text + "' and  t1.تاريخ>=N'" + prs_DateTP.Text + "'  group by t1.رقم_العقد, t1.المجموع, t1.ااسم_العميل, t1.تاريخ, t1.الفئة, t1.نوع_الدفع, t1.وصف, t1.المبلغ_بالكلمات, t1.مدفوع, t1.تسلم ", con);
                }
            }
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter da;
                da = new SqlDataAdapter(cmd);
                DataTable tb = new DataTable();
                da.Fill(tb);
                dataGridView1.DataSource = tb;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                con.Close();
            }
        }

        private void nametb_TextChanged(object sender, EventArgs e)
        {

        }

        private void namepayCB_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlCommand cmd;
            if (flag == "payment")
            {
                cmd = new SqlCommand("select  t1.ااسم_العميل, t1.تاريخ, t1.الفئة, t1.نوع_الدفع, t1.وصف, t1.المبلغ_بالكلمات, t1.مدفوع, t1.تسلم, SUM(t2.المجموع) as المجموع from payment t1 inner join payment t2 on t1.رقم_العقد >= t2.رقم_العقد and t1.ااسم_العميل =N'" + PRS_NCB.Text + "' and t1.الفئة=N'" + PRS_catCB.Text + "' group by t1.رقم_العقد, t1.المجموع, t1.ااسم_العميل, t1.تاريخ, t1.الفئة, t1.نوع_الدفع, t1.وصف, t1.المبلغ_بالكلمات, t1.مدفوع, t1.تسلم ", con);
            }
            else if (flag == "receipt")
            {
                cmd = new SqlCommand("select * from recived where ااسم_العميل =N'" + PRS_NCB.Text + "' and مستلم_من=N'" + PRS_catCB.Text + "' union all select '', '', '', '', N'المبلغ الإجمالي', sum(كمية), '', '' from recived where ااسم_العميل =N'" + PRS_NCB.Text + "' and مستلم_من=N'" + PRS_catCB.Text + "'", con);
            }
            else if (flag == "spare")
            {
                cmd = new SqlCommand("select * from قطع_غيار where ااسم_العميل =N'" + PRS_NCB.Text + "' union all	select ' ', '', N'المبلغ الإجمالي', '', sum(cast(سعر_السلعة as int)), '', sum(cast(مجموع as int)), '' from قطع_غيار where ااسم_العميل =N'" + PRS_NCB.Text + "'", con);
            }
            else if (flag == "install")
            {
                if (PRS_catCB.Text == "التركيب")
                {

                    cmd = new SqlCommand("select  * from التركيب where ااسم_العميل =N'" + PRS_NCB.Text + "' ", con);
                }
                else
                {
                    cmd = new SqlCommand("select  * from Ipay where ااسم_العميل =N'" + PRS_NCB.Text + "'  union all select '', '', '', N'المبلغ الإجمالي', SUM(القسط), '', sum(النسبة_المئوية), '', '', '' from Ipay where ااسم_العميل =N'" + PRS_NCB.Text + "' ", con);
                }
            }
            else if (flag == "maintan")
            {
                if (PRS_catCB.Text == "صيانة")
                {

                    cmd = new SqlCommand("select  * from صيانة where ااسم_العميل =N'" + PRS_NCB.Text + "' ", con);
                }
                else
                {
                    cmd = new SqlCommand("select  * from Mpay where ااسم_العميل =N'" + PRS_NCB.Text + "' union all select '', '', '', N'المبلغ الإجمالي', SUM(القسط), '', sum(النسبة_المئوية), '', '', '' from Mpay where ااسم_العميل =N'" + PRS_NCB.Text + "' ", con);
                }
            }
            else
            {
                if (PRS_catCB.Text == "موظف")
                {

                    cmd = new SqlCommand("select  * from موظف where ااسم_العميل =N'" + PRS_NCB.Text + "' ", con);
                }
                else
                {
                    cmd = new SqlCommand("select  t1.ااسم_العميل , t1.تاريخ , t1.الفئة, t1.نوع_الدفع , t1.وصف ,t1.المبلغ_بالكلمات  , t1.مدفوع  , t1.تسلم  ,SUM(t2.المجموع) as المجموع from payment t1 inner join payment t2 on t1.رقم_العقد >= t2.رقم_العقد and t1.ااسم_العميل = t2.ااسم_العميل and t1.الفئة=N'" + PRS_catCB.Text + "' and  t1.ااسم_العميل =N'" + PRS_NCB.Text + "' group by t1.رقم_العقد, t1.المجموع, t1.ااسم_العميل, t1.تاريخ, t1.الفئة, t1.نوع_الدفع, t1.وصف, t1.المبلغ_بالكلمات, t1.مدفوع, t1.تسلم  ", con);
                }
            }

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter da;
                da = new SqlDataAdapter(cmd);
                DataTable tb = new DataTable();
                da.Fill(tb);
                dataGridView1.DataSource = tb;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                con.Close();
            }
        }
        void hide_search()
        {
            PRS_date.Hide();
            prs_DateTP.Hide();
            PRS_NCB.Hide();
            PRS_name.Hide();
            PRS_catCB.Hide();
            PRS_cat.Hide();
            endDTP.Hide();
            dateEmpLabel.Hide();

            if (flag == "payment" || flag == "receipt"|| flag == "install"|| flag == "maintan")
            {

                PRS_date.Show();
                prs_DateTP.Show();
                PRS_NCB.Show();
                PRS_name.Show();
                PRS_catCB.Show();
                PRS_cat.Show();
            }
            else if (flag == "spare")
            {
                PRS_date.Show();
                prs_DateTP.Show();
                PRS_NCB.Show();
                PRS_name.Show();
            }
            else if(flag == "emp")
            {
                PRS_date.Show();
                prs_DateTP.Show();
                PRS_NCB.Show();
                PRS_name.Show();
                PRS_catCB.Show();
                PRS_cat.Show();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        /*
        void print()
        {
            if (flag == "payment")
            {
            }
            else if (flag == "receipt")
            {
            }
            else if (flag == "install")
            {
                if (PRS_catCB.Text == "التركيب")
                {
                    
                }
                else
                {
                }
            }
            else if (flag == "maintan")
            {
                if (PRS_catCB.Text == "صيانة")
                {
                    
                }
                else
                {
                }
            }
            else
            {
                if (PRS_catCB.Text == "موظف")
                {
                }
                else
                {
                }
            }
        }*/


        private void endDTP_ValueChanged(object sender, EventArgs e)
        {
            SqlCommand cmd;
            cmd = new SqlCommand("select  t1.ااسم_العميل , t1.تاريخ , t1.الفئة, t1.نوع_الدفع , t1.وصف ,t1.المبلغ_بالكلمات  , t1.مدفوع  , t1.تسلم  ,SUM(t2.المجموع) as المجموع from payment t1  inner join payment t2 on t1.رقم_العقد >= t2.رقم_العقد and t1.ااسم_العميل = t2.ااسم_العميل  where t1.الفئة=N'" + PRS_catCB.Text + "' and  t2.ااسم_العميل =N'" + PRS_NCB.Text + "' and  t2.تاريخ >=N'" + prs_DateTP.Text + "' and  t1.تاريخ <=N'" + endDTP.Text + "'  group by t1.رقم_العقد, t1.المجموع, t1.ااسم_العميل, t1.تاريخ, t1.الفئة, t1.نوع_الدفع, t1.وصف, t1.المبلغ_بالكلمات, t1.مدفوع, t1.تسلم  ", con);
            

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter da;
                da = new SqlDataAdapter(cmd);
                DataTable tb = new DataTable();
                da.Fill(tb);
                dataGridView1.DataSource = tb;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                con.Close();
            }
        }
    }
}
