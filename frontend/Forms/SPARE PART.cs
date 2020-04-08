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
    public partial class FSpare : Form
    {
        SqlCommand cmd;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EU1SO11;Initial Catalog=ALROUGI;Integrated Security=True");

        public FSpare()
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
                    datagrid.BackgroundColor = Themecolor.PrimaryColor;
                    btn.FlatAppearance.BorderColor = Themecolor.SecondaryColor;
                }
            }
        }
        public void fillcombo()
        {
            listCB.Items.Clear();
            try
            {
                listCB.Items.Clear();
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select  * from قائمة";
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    string Sname = dr["اسم_العنصر"].ToString();
                    string amount = dr["السعر"].ToString();
                    listCB.Items.Add(string.Concat(Sname, "  |  ", amount));

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

        void formload()
        {

            SqlCommand cmd = new SqlCommand("select * from Spare union all	select ' ', '', N'المبلغ الإجمالي', '', sum(cast(سعر_السلعة as int)), '', sum(cast(مجموع as int)), '' from Spare ORDER BY رقم_العقد DESC", con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter da;
                da = new SqlDataAdapter(cmd);
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
        private void FSpare_Load(object sender, EventArgs e)
        {
            LoadTheme();
            fillcombo();
            formload();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            list li = new list(this);
            li.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void clearboxesadd()
        {
            listCB.Text = null;
            qtyCB.Text = "1";
        }
        public void clearboxes_submit()
        {
            listCB.Text = null;
            qtyCB.Text = "1";
            nameTB.Text = null;
            dateTP.Text = null;
            categoryCB.Text = null;
        }

        int qty;
        private void button2_Click(object sender, EventArgs e)
        {
            if (listCB.Text != "" && qtyCB.Text != "" )
            {

                qty = int.Parse(qtyCB.Text);
                string[] value = listCB.Text.Split('|');
                cmd = new SqlCommand("insert into Spare values(N'" + nameTB.Text + "',N'" + categoryCB.Text + "',N'" + value[0]+ "',N'" + value[1] + "',N'" + qty.ToString() + "',N'" + (Int32.Parse(value[1]) * qty).ToString() +"', N'" + dateTP.Text + "')", con);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    clearboxesadd();
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
            else if(listCB.Text == "")
            {
                MessageBox.Show("Please select the Item", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Please select the quantity", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            formload();
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                cmd = new SqlCommand("delete from Spare where رقم_العقد=" + id, con);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    clearboxes_submit();
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
                MessageBox.Show("Please select the item", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            formload();
        }
        void Print()
        {
            print.sparePrintForm f = new print.sparePrintForm(this);
            f.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Print();
            cmd = new SqlCommand("INSERT INTO  قطع_غيار  (ااسم_العميل, الفئة ,  اسم_العنصر , سعر_السلعة , كمية , مجموع , تاريخ)  SELECT ااسم_العميل , الفئة ,  اسم_العنصر , سعر_السلعة , كمية , مجموع , تاريخ  FROM Spare DBCC CHECKIDENT('Spare', RESEED, 0)", con);
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

            cmd = new SqlCommand("delete from spare", con);
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
            clearboxes_submit();
            formload();
        }
        int id = 0;
        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.datagrid.Rows[e.RowIndex];

                id = int.Parse(row.Cells["رقم_العقد"].Value.ToString());
                nameTB.Text = row.Cells["ااسم_العميل"].Value.ToString();
                qtyCB.Text = row.Cells["كمية"].Value.ToString();
                dateTP.Text = row.Cells["تاريخ"].Value.ToString();
                categoryCB.Text = row.Cells["الفئة"].Value.ToString();
            }
        }

        private void qtyCB_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        }
    }
}
