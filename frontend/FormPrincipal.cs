using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using common.Cache;
using System.Runtime.InteropServices;

namespace frontend
{
    public partial class FormPrincipal : Form
    {
        private Button currentButton;
        private Random random;
        private int tempindex;
        private Form activeForm;
        private Form preF;
        public FormPrincipal()
        {
            InitializeComponent();
            random = new Random();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(Themecolor.colorlist.Count);
            while (tempindex == index)
            {
                index = random.Next(Themecolor.colorlist.Count);
            }
            tempindex = index;
            string color = Themecolor.colorlist[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelbar.BackColor = color;
                    paneldetail.BackColor = Themecolor.ChangeColorBrightness(color, -0.3);
                    logoutbt.BackColor = Themecolor.ChangeColorBrightness(color, -0.3);
                    panellogo.BackColor = Themecolor.ChangeColorBrightness(color, -0.3);                
                    Themecolor.PrimaryColor = color;
                    Themecolor.SecondaryColor = Themecolor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
           
            ActivateButton(btnSender);
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.Desktopane.Controls.Add(childForm);
            this.Desktopane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            LBtittle.Text = childForm.Text;
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
        }
        private void Reset()
        {
            DisableButton();
            LBtittle.Text = "HOME";
            panelbar.BackColor = Color.FromArgb(0, 150, 136);
            panellogo.BackColor = Color.FromArgb(39, 39, 58);
            logoutbt.BackColor = Color.FromArgb(39, 39, 58);
            paneldetail.BackColor = Color.FromArgb(39, 39, 58);

            currentButton = null;
            btnCloseChildForm.Visible = false;
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in menupan.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void panelcontrol_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            loaduserdata();

            Timer time = new Timer();
            time.Interval = 10000 / 2;
            time.Tick += new EventHandler(timer1_Tick);
            time.Start();
        }
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 5;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e); 
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelcontrol.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void loaduserdata()
        {
           name.Text = userlogincache.FirstNAme+" , "+userlogincache.LastNAme;
            position.Text = userlogincache.Position;
            
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure to log out", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void position_Click(object sender, EventArgs e)
        {

        }
        
        private void Installationbt_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.INSTALLATION(), sender);
        }

        private void mantainbt_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.MAINTENANCE(), sender);
        }

        private void sparebt_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FSpare(), sender);
        }

        private void reciptbt_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormRecipt(), sender);
        }

        private void paybt_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FPayment(), sender);
        }

        private void searchbt_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.SEARCH(), sender);
        }

        private void btnClosedChildForm_Click(object sender, EventArgs e)
        {
            
            if (activeForm != null)
                activeForm.Close();
            Reset();

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelbar_Paint(object sender, PaintEventArgs e)
        {
             
        }

        private void email_Click(object sender, EventArgs e)
        {

        }

        private void panelbar_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void menupan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menupan_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;
            maxi.Visible = false;
            resstore.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }

        private void LBtittle_Click(object sender, EventArgs e)
        {

        }

        private void resstore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;

            maxi.Visible = true;
            resstore.Visible = false;
        }

        private void Desktopane_Paint(object sender, PaintEventArgs e)
        {

        }

        public int imageno = 0; 
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (imageno == 30)
            {
                imageno = 0;
            }
            List<Bitmap> back = new List<Bitmap>();

            back.Add(Properties.Resources._16117405071_9875ab6f20_b);
            back.Add(Properties.Resources.lobby_on_pinterest_elevator_lobby_lobbies_and_hotel_lobby);
            back.Add(Properties.Resources._11686ad6feb0ff1a715482d0396c1896_700);
            back.Add(Properties.Resources.videoblocks_modern_hotel_office_skyscraper_building_elevator_lift_moving_up_b3y0p58rx_thumbnail_full04);
           back.Add(Properties.Resources._3);
            back.Add(Properties.Resources.building_interior_architecture_147081_2560x1440);
            back.Add(Properties.Resources.wp2303787a);
            back.Add(Properties.Resources.ADAM_elevator_3ed);
            back.Add(Properties.Resources.f3rf);
            back.Add(Properties.Resources.erq);
            back.Add(Properties.Resources.maxresdefault);
            back.Add(Properties.Resources.qddq);
            back.Add(Properties.Resources._7OTIiJ);
            back.Add(Properties.Resources.ede);
            back.Add(Properties.Resources.maxresdefaultjh);
            back.Add(Properties.Resources.wp2303645);
            back.Add(Properties.Resources.EMS_Elevator_Building_w);
            back.Add(Properties.Resources.external_content_duckduckgo_com);
            back.Add(Properties.Resources._75945);
            back.Add(Properties.Resources.elevator_core);
            back.Add(Properties.Resources.unnamed);
            back.Add(Properties.Resources.observationlift);
            back.Add(Properties.Resources.photo_1565417814737_6b4097de8a3a);
            back.Add(Properties.Resources.eded);
            back.Add(Properties.Resources.Elevator_Lobby_reduced);
            back.Add(Properties.Resources.London_underground_Oxford_Circus_train_station_elevator_1457679);
            back.Add(Properties.Resources._13e);
            back.Add(Properties.Resources.dirty_elevator_buttons);
            back.Add(Properties.Resources.elevator_cabin);
            back.Add(Properties.Resources.elevator_modern_architecture_motion_blur_wallpaper_preview);
            back.Add(Properties.Resources.Hotel_Elevator_Hall_INTmasthead);
            Desktopane.BackgroundImage = back[imageno];
            imageno++;
        }

        private void employbt_Click(object sender, EventArgs e)
        {

            OpenChildForm(new Forms.Employee(), sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
