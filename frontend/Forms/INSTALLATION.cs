using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.Sql;
using System.Data.SqlClient;


namespace frontend.Forms
{
    public partial class INSTALLATION : Form
    {
        SqlCommand cmd;
        SqlConnection con= new SqlConnection(@"Data Source=DESKTOP-EU1SO11;Initial Catalog=ALROUGI;Integrated Security=True");       
        
        SqlDataReader rea;
        public INSTALLATION()
        {
            InitializeComponent();
            LoadTheme();
        }
        public string flag_new;
        private void Finstall_Load(object sender, EventArgs e)
        {
            LoadTheme();
            flag_new = "yes";
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
                    btn.FlatAppearance.BorderColor = Themecolor.SecondaryColor;
                }
            }
        }
    

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void cTextBox6_TextChanged(object sender, EventArgs e)
        {

        }
        public Int64 amountO;
        private void button5_Click(object sender, EventArgs e)
        {
            searchbutton.Visible = true;
            searchCB.Visible = true;
            nEwinsBT.Visible = true;
            update.Visible = true;
            delete.Visible = true;
            editBT.Visible = false;
            submitBT.Visible = false;
            fillcombo();
            clearboxes();
            flag_new="no";

        }
        void fillcombo()
        {
            searchCB.Items.Clear();
            try
            {
                searchCB.Items.Clear();
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select  * from التركيب";
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);
                
                foreach (DataRow dr in dt.Rows)
                {
                    string Sname = dr["ااسم_العميل"].ToString();
                    string sid = dr["رقم_العقد"].ToString();
                    string scategory = dr["نوع_المصعد"].ToString();
                    searchCB.Items.Add(string.Concat(Sname, "  |  ", sid, "  |  ", scategory));
                    
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

        private void nEwinsBT_Click(object sender, EventArgs e)
        {
            searchbutton.Visible = false;
            searchCB.Visible = false;
            nEwinsBT.Visible = false;
            update.Visible = false;
            delete.Visible = false;
            editBT.Visible = true;
            submitBT.Visible = true;
            flag_new = "yes";
            clearboxes();
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {

        }
        public string date_transfer;
        public string name_transfer;
        public string ph_transfer;
        private void button2_Click(object sender, EventArgs e)
        {
            if (searchCB.Text != "                حدد للتحرير         " || flag_new!="no")
            {

            if (pricetb.Text != "")
            {
                    amountO = Int64.Parse(pricetb.Text);
            }

            name_transfer= nametb.Text;
            ph_transfer = phonetb.Text;
            date_transfer = dateTP.Text;

            
            pay_term pt = new pay_term(this);
            pt.Show();

            }
            else
            {
                MessageBox.Show("Please select the record", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pricetb_TextChanged(object sender, EventArgs e)
        {
        }
        
		void Print()
		{
            print.instalPrintForm f = new print.instalPrintForm(this);
            f.Show();
        }
        private void submitBT_Click(object sender, EventArgs e)
        {
			//print form
            //installation page add new

            if (pricetb.Text != "")
            {
                Print();
                cmd = new SqlCommand("insert into التركيب values(N'" + nametb.Text + "',N'" + phonetb.Text + "',N'" + catCB.Text + "',N'" + dateTP.Text + "','" + Int64.Parse(pricetb.Text) + "',N'" + floortb.Text + "',N'" + Stopcb.Text + "',N'" + warrantyTB.Text + "',N'" + deliveryTB.Text + "',N'" + placetb.Text + "',N'" + noteCB.Text + "',N'" + machineTB.Text + "',N'" + doorTB.Text + "',N'" + flooringTB.Text + "',N'" + KOSTB.Text + "',N'" + cabinTB.Text + "',N'" + discriptionTB.Text + "')", con);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    clearboxes();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);

                }
                finally
                {

                    con.Close();
                }
                
                //convert all data from icpay to ipay

                cmd = new SqlCommand("INSERT INTO Ipay(  رقم_العقد,ااسم_العميل,التيليفون, القسط, قيمة_العقد, النسبة_المئوية, تاريخ, ديسكريبشن, مدفوع)  SELECT   التركيب.رقم_العقد, التركيب.ااسم_العميل, التركيب.التيليفون, ICpay.القسط ,	ICpay.قيمة_العقد, 	ICpay.النسبة_المئوية, ICpay.تاريخ,	ICpay.ديسكريبشن,	ICpay.مدفوع  FROM التركيب right join ICpay on التركيب.قيمة_العقد = ICpay.قيمة_العقد and التركيب.ااسم_العميل = ICpay.ااسم_العميل  ", con);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {

                    con.Close();
                }

                cmd = new SqlCommand("delete  from ICpay DBCC CHECKIDENT('ICpay', RESEED, 0)", con);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
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
            else
            {
                MessageBox.Show("Please fill the amount", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

           
        }
        public void clearboxes()
        {
            nametb.Text = null;
            phonetb.Text = null;
            catCB.Text = null;            
            dateTP.Text = null;
            pricetb.Text = null;
            floortb.Text = null;
            Stopcb.Text = null;
            warrantyTB.Text = null;
            deliveryTB.Text = null;
            placetb.Text = null;
            noteCB.Text = null;
            machineTB.Text = null;
            doorTB.Text = null;
            flooringTB.Text = null;
            KOSTB.Text = null;
            cabinTB.Text = null;
            discriptionTB.Text = null;
            searchCB.Text = "                حدد للتحرير         ";

        }

        private void delete_Click(object sender, EventArgs e)
        {
             if (searchCB.Text == "                حدد للتحرير         ")
            {
                MessageBox.Show("Please select the Record", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                string[] value = searchCB.Text.Split('|');

                //delete from Ipay
                cmd = new SqlCommand("delete from Ipay where رقم_العقد=" + int.Parse(value[1]), con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    clearboxes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {

                    con.Close();

                }
                //delete from installation
                cmd = new SqlCommand("delete from التركيب where رقم_العقد=" + int.Parse(value[1]), con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Record Deleted successfully ", "INFORMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    clearboxes();
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
            fillcombo();
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (pricetb.Text != "" && searchCB.Text!="")
            {
                string[] value = searchCB.Text.Split('|');
                cmd = new SqlCommand("UPDATE  التركيب SET ااسم_العميل=N'" + nametb.Text + "',التيليفون=N'" + phonetb.Text + "',نوع_المصعد=N'" + catCB.Text + "',تاريخ_توقيع_العقد=N'" + dateTP.Text + "',قيمة_العقد='" + Int32.Parse(pricetb.Text) + "',عدد_الطوابق=N'" + floortb.Text + "',عدد_الوقفات=N'" + Stopcb.Text + "',نهاية_الضمان=N'" + warrantyTB.Text + "',عقد_التسليم=N'" + deliveryTB.Text + "',الموقع=N'" + placetb.Text + "',ملاحظه=N'" + noteCB.Text + "',الماكينة=N'" + machineTB.Text + "',مقاس_وطبيعه_الابواب=N'" + doorTB.Text + "',الارضيه=N'" + flooringTB.Text + "',نوع_الاستيل=N'" + KOSTB.Text + "',لكابينة=N'" + cabinTB.Text + "',ديسكريبشن=N'" + discriptionTB.Text + "' WHERE رقم_العقد=" + Int32.Parse(value[1]), con);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Record Updated successfully ", "INFORMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    clearboxes();
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
            else if (searchCB.Text == "                حدد للتحرير         ")
            {
                MessageBox.Show("Please select the Record", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else 
            {
                MessageBox.Show("Please fill the amount", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            fillcombo();
        }

       public string[] value_Update_add;
        public void searchCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            value_Update_add = searchCB.Text.Split('|');
            string[] value = searchCB.Text.Split('|');
             try
             {
                 con.Open();
                 cmd = con.CreateCommand();
                 cmd.CommandType = CommandType.Text;
                 cmd.CommandText = "select  * from التركيب where رقم_العقد="+Int32.Parse(value[1]);
                 cmd.ExecuteNonQuery();
                SqlDataAdapter  da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                 foreach (DataRow dr in dt.Rows)
                 {
                     nametb.Text = dr["ااسم_العميل"].ToString(); 
                     phonetb.Text = dr["التيليفون"].ToString(); 
                     catCB.Text = dr["نوع_المصعد"].ToString(); 
                     dateTP.Text = dr["تاريخ_توقيع_العقد"].ToString();
                     pricetb.Text = dr["قيمة_العقد"].ToString(); 
                     floortb.Text = dr["عدد_الطوابق"].ToString(); 
                     Stopcb.Text = dr["عدد_الوقفات"].ToString(); 
                     warrantyTB.Text = dr["نهاية_الضمان"].ToString(); 
                     deliveryTB.Text = dr["عقد_التسليم"].ToString(); 
                     placetb.Text = dr["الموقع"].ToString(); 
                     noteCB.Text = dr["ملاحظه"].ToString(); 
                     machineTB.Text = dr["الماكينة"].ToString(); 
                     doorTB.Text = dr["مقاس_وطبيعه_الابواب"].ToString(); 
                     flooringTB.Text = dr["الارضيه"].ToString(); 
                     KOSTB.Text = dr["نوع_الاستيل"].ToString(); 
                     cabinTB.Text = dr["لكابينة"].ToString(); 
                     discriptionTB.Text = dr["ديسكريبشن"].ToString();

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

        private void dataGridView3_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pricetb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        }

        private void floortb_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void phonetb_TextChanged(object sender, EventArgs e)
        {

        }

        private void phonetb_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

		public void nametb_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
