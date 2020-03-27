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
    public partial class list : Form
    {
        SqlCommand cmd;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HMI8KPC\SQL2019TEST;Initial Catalog=ALROUGI;Integrated Security=True");
        FSpare sp;
        public list(FSpare sp)
        {
            InitializeComponent();
            this.sp = sp;
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
        private void list_Load(object sender, EventArgs e)
        {
            LoadTheme();
            formload();
        }
        void formload()
        {

            SqlCommand cmd = new SqlCommand("select * from قائمة", con);
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void clearboxes()
        {
            nameTB.Text = null;
            priceTB.Text = null;
            idTB.Text = null;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (priceTB.Text != "")
            {

                cmd = new SqlCommand("insert into قائمة values(N'" + nameTB.Text + "','" + int.Parse(priceTB.Text )+"')", con);
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
            }
            else
            {
                MessageBox.Show("Please fill the amount", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            formload();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (priceTB.Text != "")
            {
                cmd = new SqlCommand("delete from قائمة where رقم_العقد=" + int.Parse(idTB.Text), con);
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
            }
            else
            {
                MessageBox.Show("Please select the item", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            formload();
        }

        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.datagrid.Rows[e.RowIndex];

                idTB.Text = row.Cells["رقم_العقد"].Value.ToString();
                nameTB.Text = row.Cells["اسم_العنصر"].Value.ToString();
                priceTB.Text = row.Cells["السعر"].Value.ToString();
            }
        }

        private void submitBT_Click(object sender, EventArgs e)
        {
            sp.fillcombo();
            this.Close();
        }

        private void priceTB_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        }
    }
}
