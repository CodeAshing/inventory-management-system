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
    public partial class pay_term : Form
    {
        SqlCommand cmd;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EU1SO11;Initial Catalog=ALROUGI;Integrated Security=True");

        private INSTALLATION ins;
        public pay_term(INSTALLATION ins)
        {
            InitializeComponent();
            this.ins = ins;
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
                    datagrid.BackgroundColor = Themecolor.PrimaryColor;
                    btn.FlatAppearance.BorderColor = Themecolor.SecondaryColor;
                }
            }
        }
        void formloadN()
        {
            cmd = new SqlCommand("select * from ICpay union all select '', N'المبلغ الإجمالي', SUM(القسط), '', sum(النسبة_المئوية), '', '', '' from ICpay", con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable tb = new DataTable();
                da.Fill(tb);
                datagrid.DataSource = tb;
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

        void formloadO()
        {
            cmd = new SqlCommand("select * from Ipay where رقم_العقد='"+ins.value_Update_add[1]+ "' union all select '', '', '', N'المبلغ الإجمالي', SUM(القسط), '', sum(النسبة_المئوية), '', '', '' from Ipay where رقم_العقد='" + ins.value_Update_add[1] + "' ", con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable tb = new DataTable();
                da.Fill(tb);
                datagrid.DataSource = tb;
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
        //assign variable to pass the report

        public string namePrint,phonePrint;
        public int amountPrint;
        private void pay_term_Load(object sender, EventArgs e)
        {
            LoadTheme();
            dateTp.Text=ins.date_transfer;
            priceTD.Text = ins.amountO.ToString();
            for (int i = 1; i <= 100; i++)
            {
                perCB.Items.Add(i);
            }
            if (ins.flag_new == "yes")
            {
                formloadN();
            }
            else
            {
                formloadO();
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void price_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (perCB.Text != "")
            {

                if (ins.flag_new == "yes")
                {
                        cmd = new SqlCommand("insert into ICpay values(N'"+ins.name_transfer+"',N'" + ((int.Parse(perCB.Text) * ins.amountO) / 100) + "',N'" + ins.amountO + "',N'" + int.Parse(perCB.Text) + "',N'" + dateTp.Text + "','" + discriptionTB.Text + "',N'لا')", con);
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
                        formloadN();

                }
                else
                {
                    cmd = new SqlCommand("insert into Ipay values('" + ins.value_Update_add[1] + "' ,N'" + ins.name_transfer + "',N'" + ins.ph_transfer + "','" + ((int.Parse(perCB.Text) * ins.amountO) / 100) + "',N'" + ins.amountO + "',N'" + int.Parse(perCB.Text) + "',N'" + dateTp.Text + "','" + discriptionTB.Text + "',N'لا')", con);
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
                    formloadO();
                }
            }
            else
            {
                MessageBox.Show("Select Percentage", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
         void clearboxes()
        {
            discriptionTB.Text = null;
            perCB.Text = "0";
            dateTp.Text = null;
        }

        void Print()
        {

            namePrint = ins.name_transfer;
            amountPrint= (int.Parse(perCB.Text) * ins.amountO) / 100;
            phonePrint=ins.phonetb.Text;
            print.instalPAyForm f = new print.instalPAyForm(this);
            f.Show();
        }
        int id=0;
        private void button3_Click(object sender, EventArgs e)
        {
            if (ins.flag_new == "yes")
            {
                if (id != 0)
                {
                    Print();
                    cmd = new SqlCommand("UPDATE  ICPAY SET مدفوع=N'نعم' WHERE رقم_الهوية=" + id, con);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        clearboxes();
                        id = 0;
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
                    MessageBox.Show("Select record", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                formloadN();
            }
            else
            {
                if (id != 0)
                {
                    Print();
                    cmd = new SqlCommand("UPDATE  IPAY SET مدفوع=N'نعم' WHERE رقم_الهوية=" + id, con);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        clearboxes();
                        id = 0;
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
                    MessageBox.Show("Select record", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }formloadO();
            }
        }

        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.datagrid.Rows[e.RowIndex];

                discriptionTB.Text = row.Cells["ديسكريبشن"].Value.ToString();
                perCB.Text = row.Cells["النسبة_المئوية"].Value.ToString();
                priceTD.Text = row.Cells["قيمة_العقد"].Value.ToString();
                dateTp.Text = row.Cells["تاريخ"].Value.ToString();
                id = int.Parse(row.Cells["رقم_الهوية"].Value.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ins.flag_new == "yes")
            {
                if (id != 0)
                {
                    cmd = new SqlCommand("delete from ICpay where رقم_الهوية=" + id, con);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        clearboxes();
                        id = 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {

                        con.Close();
                    }
                    formloadN();
                }
                else
                {
                    MessageBox.Show("Select record", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                if (id != 0)
                {
                    cmd = new SqlCommand("delete from Ipay where رقم_الهوية = " + id, con);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        clearboxes();
                        id = 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {

                        con.Close();
                    }
                    formloadO();
                }
                else
                {
                    MessageBox.Show("Select record", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            
        }

        private void submitBT_Click(object sender, EventArgs e)
        {
            clearboxes();
            this.Close();
            ins.name_transfer = "";
            ins.ph_transfer = "";
            ins.amountO = 0;
        }
    }
}
