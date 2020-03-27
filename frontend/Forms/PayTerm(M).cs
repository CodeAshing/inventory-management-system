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
    public partial class PayTerm_M_ : Form
    {
        SqlCommand cmd;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HMI8KPC\SQL2019TEST;Initial Catalog=ALROUGI;Integrated Security=True");

        private MAINTENANCE ma;
        public PayTerm_M_(MAINTENANCE ma)
        {
            InitializeComponent();
            this.ma = ma;
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
        private void PayTerm_M__Load(object sender, EventArgs e)
        {
            LoadTheme();
            priceTD.Text = ma.amountO.ToString();
            dateTp.Text = ma.date_transfer;
            for (int i = 1; i <= 100; i++)
            {
                perCB.Items.Add(i);
            }
            if (ma.flag_new == "yes")
            {
                formloadN();
            }
            else
            {
                formloadO();
            }
        }
        void clearboxes()
        {
            discriptionTB.Text = null;
            dateTp.Text = null;
            perCB.Text = null;
        }
        void formloadN()
        {
            cmd = new SqlCommand("select * from MCpay union all select '', N'المبلغ الإجمالي', SUM(القسط), '', sum(النسبة_المئوية), '', '', '' from MCpay", con);
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
            cmd = new SqlCommand("select * from Mpay where رقم_العقد='" + ma.value_Update_add[1]+ "' union all select '', '', '', N'المبلغ الإجمالي', SUM(القسط), '', sum(النسبة_المئوية), '', '', '' from Mpay where رقم_العقد='" + ma.value_Update_add[1] + "'", con);
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
        int id = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            if (ma.flag_new == "yes")
            {
                if (id != 0)
                {
                    cmd = new SqlCommand("UPDATE  MCPAY SET مدفوع=N'نعم' WHERE رقم_الهوية=" + id, con);
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
                    cmd = new SqlCommand("UPDATE  MPAY SET مدفوع=N'نعم' WHERE رقم_الهوية=" + id, con);
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
                formloadO();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (perCB.Text != "")
            {

                if (ma.flag_new == "yes")
                {
                    cmd = new SqlCommand("insert into MCpay values(N'" + ma.name_transfer + "',N'" + ((int.Parse(perCB.Text) * ma.amountO) / 100) + "',N'" + ma.amountO + "',N'" + int.Parse(perCB.Text) + "',N'" + dateTp.Text + "','" + discriptionTB.Text + "',N'لا')", con);
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
                    cmd = new SqlCommand("insert into Mpay values('" + ma.value_Update_add[1] + "' ,N'" + ma.name_transfer + "',N'" + ma.ph_transfer + "','" + ((int.Parse(perCB.Text) * ma.amountO) / 100) + "',N'" + ma.amountO + "',N'" + int.Parse(perCB.Text) + "',N'" + dateTp.Text + "','" + discriptionTB.Text + "',N'لا')", con);
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (ma.flag_new == "yes")
            {
                if (id != 0)
                {
                    cmd = new SqlCommand("delete from MCpay where رقم_الهوية=" + id, con);
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
                    cmd = new SqlCommand("delete from Mpay where رقم_الهوية = " + id, con);
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
            ma.name_transfer = "";
            ma.ph_transfer = "";
            ma.amountO = 0;
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
    }
}
