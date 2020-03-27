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
using Domain;
using common.Cache;

namespace frontend
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd,int wmsg,int wparam, int lparam);


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (usert.Text == "USERNAME")
            {
                usert.Text = "";
                usert.ForeColor = Color.LightGray;


            }
        }

        private void usert_Leave(object sender, EventArgs e)
        {
            if (usert.Text=="")
            {
                usert.Text = "USERNAME";
                usert.ForeColor = Color.DimGray;
            }
        }

        private void passt_Enter(object sender, EventArgs e)
        {
            if (passt.Text == "PASSWORD")
            {
                passt.Text = "";
                passt.ForeColor = Color.LightGray;
                passt.UseSystemPasswordChar = true;


            }
        }

        private void passt_Leave(object sender, EventArgs e)
        {
            if (passt.Text == "")
            {
                passt.Text = "PASSWORD";
                passt.ForeColor = Color.DimGray;
                passt.UseSystemPasswordChar = false;
            }
        }

        private void login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void msgError(string msg)
        {

            error.Text = "  " + msg;
            error.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (usert.Text != "USERNAME"&&usert.TextLength>2)
            {
                if (passt.Text != "PASSWORD")
                {
                    UserModel user = new UserModel();
                    var validlogin = user.LoginUser(usert.Text,passt.Text);
                    if (validlogin == true)
                    {
                        FormPrincipal mainmenu = new FormPrincipal();
                        mainmenu.Show();
                        mainmenu.FormClosed += logout;
                        this.Hide();
                    }
                    else
                    {
                        msgError("   Invalid username or password.\n     Please try again");
                        passt.Text = "PASSWORD";

                        passt.UseSystemPasswordChar = false;
                        usert.Focus();

                    }
                }
                else msgError("   Please enter password");
            }
            else msgError("   Please enter user name");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void passt_TextChanged(object sender, EventArgs e)
        {

        }

        private void error_Click(object sender, EventArgs e)
        {

        }
        private void logout(object sender,FormClosedEventArgs e)
        {
            passt.Text="PASSWORD";
            passt.UseSystemPasswordChar = false;

            usert.Text= "USERNAME";
            error.Visible = false;
            this.Show();
            usert.Focus();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
