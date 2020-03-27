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
    public partial class Employee : Form
    {
        SqlCommand cmd;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HMI8KPC\SQL2019TEST;Initial Catalog=ALROUGI;Integrated Security=True");

        public Employee()
        {
            InitializeComponent();
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
        private void nEwinsBT_Click(object sender, EventArgs e)
        {

            searchbutton.Visible = false;
            searchCB.Visible = false;
            nEwinsBT.Visible = false;
            update.Visible = false;
            delete.Visible = false;
            editBT.Visible = true;
            submitBT.Visible = true;
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void cTextBox6_TextChanged(object sender, EventArgs e)
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
                cmd.CommandText = "select  * from موظف";
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    string Sname = dr["ااسم_العميل"].ToString();
                    string sid = dr["رقم_العقد"].ToString();
                    string scategory = dr["الجنسية"].ToString();
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

        private void submitBT_Click(object sender, EventArgs e)
        {
            if(basicTB.Text=="")
            {
                basicTB.Text = "0";
            }
            if (rentTB.Text == "")
            {
                rentTB.Text = "0";
            }
            if (foodTB.Text == "")
            {
                foodTB.Text = "0";
            }
            if (otherallow.Text == "")
            {
                otherallow.Text = "0";
            }

            cmd = new SqlCommand("insert into موظف values(N'" + nameTB.Text + "',N'" + nationTB.Text + "',N'" + dateTP.Text + "',N'" + designationTB.Text + "','" + int.Parse(basicTB.Text) + "',N'" + CNICTB.Text + "','" + int.Parse(rentTB.Text )+ "','" + int.Parse(foodTB.Text) + "','" + int.Parse(otherallow.Text) + "',N'" + adressTB.Text + "',N'" + genderTB.Text + "',N'" + phoneTB.Text + "',N'" + discriptionTB.Text + "')", con);
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
        }
        public void clearboxes()
        {
            nameTB.Text = null;
            nationTB.Text = null;
            dateTP.Text = null;
            designationTB.Text = null;
            basicTB.Text = null;
            CNICTB.Text = null;
            rentTB.Text = null;
            foodTB.Text = null;
            otherallow.Text = null;
            adressTB.Text = null;
            genderTB.Text = null;
            phoneTB.Text = null;
            discriptionTB.Text = null;
            searchCB.Text = "                حدد للتحرير         ";

        }

        private void searchCB_SelectedIndexChanged(object sender, EventArgs e)
        {

            string[] value = searchCB.Text.Split('|');
            try
            {
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select  * from موظف where رقم_العقد=" + int.Parse(value[1]);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    nameTB.Text = dr["ااسم_العميل"].ToString();                    
                    nationTB.Text = dr["الجنسية"].ToString();
                    dateTP.Text = dr["تاريخ_الولادة"].ToString();
                    designationTB.Text = dr["تعيين"].ToString();
                    basicTB.Text = dr["راتب_اساسي"].ToString();
                    CNICTB.Text = dr["أكاما"].ToString();
                    rentTB.Text = dr["بدل_الإيجار"].ToString();
                    foodTB.Text = dr["بدل_طعام"].ToString();
                    otherallow.Text = dr["البدلات_الأخرى"].ToString();
                    adressTB.Text = dr["عنوان"].ToString();
                    genderTB.Text = dr["جنس"].ToString();
                    phoneTB.Text = dr["التيليفون"].ToString();
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

        private void delete_Click(object sender, EventArgs e)
        {
            if (searchCB.Text == "                حدد للتحرير         ")
            {
                MessageBox.Show("Please select the Record", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                string[] value = searchCB.Text.Split('|');

                cmd = new SqlCommand("delete from موظف where رقم_العقد=" + int.Parse(value[1]), con);
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


            if (searchCB.Text == "                حدد للتحرير         ")
            {
                MessageBox.Show("Please select the Record", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }else
            {
                if (basicTB.Text == "")
                {
                    basicTB.Text = "0";
                }
                if (rentTB.Text == "")
                {
                    rentTB.Text = "0";
                }
                if (foodTB.Text == "")
                {
                    foodTB.Text = "0";
                }
                if (otherallow.Text == "")
                {
                    otherallow.Text = "0";
                }

                    string[] value = searchCB.Text.Split('|');

                cmd = new SqlCommand("update موظف set ااسم_العميل=N'" + nameTB.Text + "',الجنسية=N'" + nationTB.Text + "',تاريخ_الولادة=N'" + dateTP.Text + "',تعيين=N'" + designationTB.Text + "',راتب_اساسي='" + int.Parse(basicTB.Text) + "',أكاما=N'" + CNICTB.Text + "',بدل_الإيجار='" + int.Parse(rentTB.Text) + "',بدل_طعام='" + int.Parse(foodTB.Text) + "',البدلات_الأخرى='" + int.Parse(otherallow.Text) + "',عنوان=N'" + adressTB.Text + "',جنس=N'" + genderTB.Text + "',التيليفون=N'" + phoneTB.Text + "',ديسكريبشن=N'" + discriptionTB.Text + "'WHERE رقم_العقد=" + int.Parse(value[1]), con);

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
            fillcombo();
        }

        private void cTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void basicTB_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        }

        private void CNICTB_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void foodTB_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void rentTB_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        }

        private void otherallow_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        }

        private void phoneTB_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
