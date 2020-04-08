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
    public partial class FPayment : Form
    {
        SqlCommand cmd;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EU1SO11;Initial Catalog=ALROUGI;Integrated Security=True");

        public FPayment()
        {
            InitializeComponent();
        }
        public void clearboxes()
        {
            nametb.Text = null;
            dateTP.Text = null;
            amountypeCB.Text = "السيولة النقدية";
            category.Text = "الراتب مقدما";
            priceIWCB.Text = null;
            priceTb.Text = null;
            discription.Text = null;
            reciveCheck.CheckState =CheckState.Unchecked;

        }
        private void FPayment_Load(object sender, EventArgs e)
        {
            LoadTheme();
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

        private void submitBT_Click(object sender, EventArgs e)
        {

        }
        void Print()
        {
            print.payPrintForm f = new print.payPrintForm(this);
            f.Show();
        }
        private void submitBT_Click_1(object sender, EventArgs e)
        {
            if (priceTb.Text != "")
            {
                Print();
                if (reciveCheck.CheckState == CheckState.Unchecked)
                {
                    int rec_value = 0;

                    cmd = new SqlCommand("insert into payment values(N'" + nametb.Text + "',N'" + dateTP.Text + "',N'" + category.Text + "',N'" + amountypeCB.Text + "',N'" + discription.Text + "',N'" + priceIWCB.Text + "',N'" + Int32.Parse(priceTb.Text) + "',N'" + rec_value + "')", con);

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
                    int pay_value = 0;

                    cmd = new SqlCommand("insert into payment values(N'" + nametb.Text + "',N'" + dateTP.Text + "',N'" + category.Text + "',N'" + amountypeCB.Text + "',N'" + discription.Text + "',N'" + priceIWCB.Text + "',N'" + pay_value + "',N'" + int.Parse(priceTb.Text) + "')", con);

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
            }
            else
            {
                MessageBox.Show("Insert Amount", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

}

        private void category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void priceTb_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        }
    }
}
