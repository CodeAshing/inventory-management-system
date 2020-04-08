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
    public partial class MAINTENANCE : Form
    {
        SqlCommand cmd;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EU1SO11;Initial Catalog=ALROUGI;Integrated Security=True");

        public MAINTENANCE()
        {
            InitializeComponent();
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

        private void editBT_Click(object sender, EventArgs e)
        {
            fillcombo();
            searchbutton.Visible = true;
            searchCB.Visible = true;
            nEwinsBT.Visible = true;
            update.Visible = true;
            delete.Visible = true;
            editBT.Visible = false;
            submitBT.Visible = false;
            flag_new = "no";
            clearboxes();
        }
        public int amountO;
        public string name_transfer;
        public string ph_transfer;
        public string date_transfer;
        private void button2_Click(object sender, EventArgs e)
        {
            if (searchCB.Text != "                حدد للتحرير         " || flag_new != "no")
            {
                if (priceTB.Text != "")
                {
                    amountO = int.Parse(priceTB.Text);
                }
                PayTerm_M_ pay = new PayTerm_M_(this);
                pay.Show(this);
                name_transfer = nameTB.Text;
                ph_transfer = PhoneTB.Text;
                date_transfer = dateSTP.Text;
            }
            else
            {
                MessageBox.Show("Please select the record", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
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
        public string flag_new;
        private void MAINTENANCE_Load(object sender, EventArgs e)
        {
            LoadTheme();
            flag_new = "yes";
        }
        public void clearboxes()
        {
            nameTB.Text = null;
            CategoryCB.Text = null;
            PhoneTB.Text = null;
            dateSTP.Text = null;
            dateETP.Text = null;
            floorTB.Text = null;
            stopCB.Text = null;
            DeliveryTB.Text = null;
            placetb.Text = null;
            priceTB.Text = null;
            noteCB.Text = null;
            FlooringTB.Text = null;
            discriptionTB.Text = null;
            searchCB.Text = "                حدد للتحرير         ";

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

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
                cmd.CommandText = "select  * from صيانة";
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
        void Print()
        {
            print.MaintanPrintForm f = new print.MaintanPrintForm(this);
            f.Show();
        }
        private void submitBT_Click(object sender, EventArgs e)
        {

            //print form
            Print();


            if (priceTB.Text != "")
            {

                cmd = new SqlCommand("insert into صيانة values(N'" + nameTB.Text + "',N'" + CategoryCB.Text + "',N'" + PhoneTB.Text + "',N'" + dateSTP.Text+ "',N'" + dateETP.Text + "',N'" + floorTB.Text + "',N'" + stopCB.Text + "',N'" + DeliveryTB.Text + "',N'" + placetb.Text + "','" + int.Parse(priceTB.Text )+ "',N'" + noteCB.Text + "',N'" + FlooringTB.Text + "',N'" + discriptionTB.Text + "')", con);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Record Successfully Inserted", "INFORMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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


                //convert all data from Mcpay to Mpay

                cmd = new SqlCommand("INSERT INTO Mpay(  رقم_العقد,ااسم_العميل,التيليفون, القسط, قيمة_العقد, النسبة_المئوية, تاريخ, ديسكريبشن, مدفوع)  SELECT   صيانة.رقم_العقد, صيانة.ااسم_العميل, صيانة.التيليفون, MCpay.القسط ,	MCpay.قيمة_العقد, 	MCpay.النسبة_المئوية, MCpay.تاريخ,	MCpay.ديسكريبشن,	MCpay.مدفوع  FROM صيانة right join MCpay on صيانة.قيمة_العقد = MCpay.قيمة_العقد and صيانة.ااسم_العميل = MCpay.ااسم_العميل  ", con);
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

                cmd = new SqlCommand("delete  from MCpay", con);
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

        private void delete_Click(object sender, EventArgs e)
        {
            if (searchCB.Text == "                حدد للتحرير         ")
            {
                MessageBox.Show("Please select the Record", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                string[] value = searchCB.Text.Split('|');

                //delete all from Mpay

                cmd = new SqlCommand("delete from Mpay where رقم_العقد=" + int.Parse(value[1]), con);


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

                //delete maintances record
                cmd = new SqlCommand("delete from صيانة where رقم_العقد=" + int.Parse(value[1]), con);

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

        public string[] value_Update_add;
        private void searchCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            value_Update_add = searchCB.Text.Split('|');
            string[] value = searchCB.Text.Split('|');
            try
            {
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select  * from صيانة where رقم_العقد=" + int.Parse(value[1]);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    nameTB.Text = dr["ااسم_العميل"].ToString();
                    CategoryCB.Text = dr["نوع_المصعد"].ToString();
                    PhoneTB.Text = dr["التيليفون"].ToString();
                    dateSTP.Text = dr["تاريخ_البدء"].ToString();
                    dateETP.Text = dr["تاريخ_الانتهاء"].ToString();
                    floorTB.Text = dr["عدد_الطوابق"].ToString();
                    stopCB.Text = dr["عدد_الوقفات"].ToString();
                    DeliveryTB.Text = dr["عقد_التسليم"].ToString();
                    placetb.Text = dr["الموقع"].ToString();
                    priceTB.Text = dr["قيمة_العقد"].ToString();
                    noteCB.Text = dr["ملاحظه"].ToString();
                    FlooringTB.Text = dr["نوع_الاستيل"].ToString();
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

        private void update_Click(object sender, EventArgs e)
        {

            if (priceTB.Text != "" && searchCB.Text != "")
            {
                string[] value = searchCB.Text.Split('|');
                cmd = new SqlCommand("UPDATE  صيانة SET ااسم_العميل=N'" + nameTB.Text + "',نوع_المصعد=N'" + CategoryCB.Text + "',التيليفون=N'" + PhoneTB.Text + "',تاريخ_البدء=N'" + dateSTP.Text + "',تاريخ_الانتهاء='" + dateETP.Text + "',عدد_الطوابق=N'" + floorTB.Text + "',عدد_الوقفات=N'" + stopCB.Text + "',عقد_التسليم=N'" + DeliveryTB.Text + "',الموقع=N'" + placetb.Text + "',قيمة_العقد='" + int.Parse(priceTB.Text )+ "',ملاحظه=N'" + noteCB.Text + "',نوع_الاستيل=N'" + FlooringTB.Text + "',ديسكريبشن=N'" + discriptionTB.Text + "' WHERE رقم_العقد=" + int.Parse(value[1]), con);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void priceTB_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PhoneTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhoneTB_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void floorTB_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
