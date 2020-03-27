namespace frontend
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panelcontrol = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Desktopane = new System.Windows.Forms.Panel();
            this.panelbar = new System.Windows.Forms.Panel();
            this.resstore = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.maxi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.LBtittle = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.menupan = new System.Windows.Forms.Panel();
            this.employbt = new System.Windows.Forms.Button();
            this.panellogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.paneldetail = new System.Windows.Forms.Panel();
            this.name = new System.Windows.Forms.Label();
            this.position = new System.Windows.Forms.Label();
            this.logoutbt = new System.Windows.Forms.Button();
            this.searchbt = new System.Windows.Forms.Button();
            this.paybt = new System.Windows.Forms.Button();
            this.reciptbt = new System.Windows.Forms.Button();
            this.sparebt = new System.Windows.Forms.Button();
            this.mantainbt = new System.Windows.Forms.Button();
            this.Installationbt = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelcontrol.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelbar.SuspendLayout();
            this.menupan.SuspendLayout();
            this.panellogo.SuspendLayout();
            this.paneldetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelcontrol
            // 
            this.panelcontrol.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelcontrol.Controls.Add(this.panel3);
            this.panelcontrol.Controls.Add(this.menupan);
            this.panelcontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontrol.Location = new System.Drawing.Point(0, 0);
            this.panelcontrol.Name = "panelcontrol";
            this.panelcontrol.Size = new System.Drawing.Size(1012, 1000);
            this.panelcontrol.TabIndex = 0;
            this.panelcontrol.Paint += new System.Windows.Forms.PaintEventHandler(this.panelcontrol_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.Desktopane);
            this.panel3.Controls.Add(this.panelbar);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(714, 1000);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Desktopane
            // 
            this.Desktopane.BackgroundImage = global::frontend.Properties.Resources.claudio_de_sat_architecture_modern_elevator_wallpaper_preview;
            this.Desktopane.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Desktopane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Desktopane.Location = new System.Drawing.Point(0, 91);
            this.Desktopane.Name = "Desktopane";
            this.Desktopane.Size = new System.Drawing.Size(714, 909);
            this.Desktopane.TabIndex = 4;
            this.Desktopane.Paint += new System.Windows.Forms.PaintEventHandler(this.Desktopane_Paint);
            // 
            // panelbar
            // 
            this.panelbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelbar.Controls.Add(this.resstore);
            this.panelbar.Controls.Add(this.button3);
            this.panelbar.Controls.Add(this.maxi);
            this.panelbar.Controls.Add(this.button1);
            this.panelbar.Controls.Add(this.btnCloseChildForm);
            this.panelbar.Controls.Add(this.LBtittle);
            this.panelbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelbar.Location = new System.Drawing.Point(0, 11);
            this.panelbar.Name = "panelbar";
            this.panelbar.Size = new System.Drawing.Size(714, 80);
            this.panelbar.TabIndex = 3;
            this.panelbar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelbar_Paint);
            this.panelbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelbar_MouseDown);
            // 
            // resstore
            // 
            this.resstore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resstore.FlatAppearance.BorderSize = 0;
            this.resstore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resstore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resstore.ForeColor = System.Drawing.Color.White;
            this.resstore.Location = new System.Drawing.Point(26, 1);
            this.resstore.Name = "resstore";
            this.resstore.Size = new System.Drawing.Size(26, 37);
            this.resstore.TabIndex = 15;
            this.resstore.Text = "O";
            this.resstore.UseVisualStyleBackColor = true;
            this.resstore.Visible = false;
            this.resstore.Click += new System.EventHandler(this.resstore_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(48, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 37);
            this.button3.TabIndex = 14;
            this.button3.Text = "O";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // maxi
            // 
            this.maxi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.maxi.FlatAppearance.BorderSize = 0;
            this.maxi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maxi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxi.ForeColor = System.Drawing.Color.White;
            this.maxi.Location = new System.Drawing.Point(26, 1);
            this.maxi.Name = "maxi";
            this.maxi.Size = new System.Drawing.Size(26, 37);
            this.maxi.TabIndex = 14;
            this.maxi.Text = "O";
            this.maxi.UseVisualStyleBackColor = true;
            this.maxi.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(4, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 37);
            this.button1.TabIndex = 13;
            this.button1.Text = "O";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.AutoSize = true;
            this.btnCloseChildForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.ForeColor = System.Drawing.Color.White;
            this.btnCloseChildForm.Location = new System.Drawing.Point(666, 0);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(48, 80);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.Text = "X";
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Visible = false;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnClosedChildForm_Click);
            // 
            // LBtittle
            // 
            this.LBtittle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LBtittle.AutoSize = true;
            this.LBtittle.ForeColor = System.Drawing.Color.White;
            this.LBtittle.Location = new System.Drawing.Point(296, 20);
            this.LBtittle.Name = "LBtittle";
            this.LBtittle.Size = new System.Drawing.Size(112, 37);
            this.LBtittle.TabIndex = 0;
            this.LBtittle.Text = "HOME";
            this.LBtittle.Click += new System.EventHandler(this.LBtittle_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(714, 11);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown);
            // 
            // menupan
            // 
            this.menupan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.menupan.Controls.Add(this.employbt);
            this.menupan.Controls.Add(this.panellogo);
            this.menupan.Controls.Add(this.panel1);
            this.menupan.Controls.Add(this.paneldetail);
            this.menupan.Controls.Add(this.searchbt);
            this.menupan.Controls.Add(this.paybt);
            this.menupan.Controls.Add(this.reciptbt);
            this.menupan.Controls.Add(this.sparebt);
            this.menupan.Controls.Add(this.mantainbt);
            this.menupan.Controls.Add(this.Installationbt);
            this.menupan.Dock = System.Windows.Forms.DockStyle.Right;
            this.menupan.Location = new System.Drawing.Point(714, 0);
            this.menupan.Name = "menupan";
            this.menupan.Size = new System.Drawing.Size(298, 1000);
            this.menupan.TabIndex = 1;
            this.menupan.Paint += new System.Windows.Forms.PaintEventHandler(this.menupan_Paint);
            this.menupan.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menupan_MouseDown);
            // 
            // employbt
            // 
            this.employbt.FlatAppearance.BorderSize = 0;
            this.employbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employbt.ForeColor = System.Drawing.Color.Gainsboro;
            this.employbt.Location = new System.Drawing.Point(3, 495);
            this.employbt.Name = "employbt";
            this.employbt.Size = new System.Drawing.Size(295, 70);
            this.employbt.TabIndex = 13;
            this.employbt.Text = "موظف";
            this.employbt.UseVisualStyleBackColor = true;
            this.employbt.Click += new System.EventHandler(this.employbt_Click);
            // 
            // panellogo
            // 
            this.panellogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panellogo.Controls.Add(this.label1);
            this.panellogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panellogo.Location = new System.Drawing.Point(0, 11);
            this.panellogo.Name = "panellogo";
            this.panellogo.Size = new System.Drawing.Size(298, 128);
            this.panellogo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 70);
            this.label1.TabIndex = 15;
            this.label1.Text = "RAUGI \r\n    ELEVATOR";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 11);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // paneldetail
            // 
            this.paneldetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.paneldetail.Controls.Add(this.name);
            this.paneldetail.Controls.Add(this.position);
            this.paneldetail.Controls.Add(this.logoutbt);
            this.paneldetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paneldetail.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paneldetail.Location = new System.Drawing.Point(0, 888);
            this.paneldetail.Name = "paneldetail";
            this.paneldetail.Size = new System.Drawing.Size(298, 112);
            this.paneldetail.TabIndex = 2;
            this.paneldetail.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.Gainsboro;
            this.name.Location = new System.Drawing.Point(6, 11);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(59, 20);
            this.name.TabIndex = 6;
            this.name.Text = "label2";
            // 
            // position
            // 
            this.position.AutoSize = true;
            this.position.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.position.ForeColor = System.Drawing.Color.Gainsboro;
            this.position.Location = new System.Drawing.Point(6, 48);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(59, 20);
            this.position.TabIndex = 5;
            this.position.Text = "label1";
            this.position.Click += new System.EventHandler(this.position_Click);
            // 
            // logoutbt
            // 
            this.logoutbt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.logoutbt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoutbt.BackgroundImage")));
            this.logoutbt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoutbt.Dock = System.Windows.Forms.DockStyle.Right;
            this.logoutbt.FlatAppearance.BorderSize = 0;
            this.logoutbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutbt.Location = new System.Drawing.Point(201, 0);
            this.logoutbt.Name = "logoutbt";
            this.logoutbt.Size = new System.Drawing.Size(97, 112);
            this.logoutbt.TabIndex = 4;
            this.logoutbt.UseVisualStyleBackColor = false;
            this.logoutbt.Click += new System.EventHandler(this.button4_Click);
            // 
            // searchbt
            // 
            this.searchbt.FlatAppearance.BorderSize = 0;
            this.searchbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbt.ForeColor = System.Drawing.Color.Gainsboro;
            this.searchbt.Location = new System.Drawing.Point(3, 787);
            this.searchbt.Name = "searchbt";
            this.searchbt.Size = new System.Drawing.Size(295, 70);
            this.searchbt.TabIndex = 12;
            this.searchbt.Text = "بحث";
            this.searchbt.UseVisualStyleBackColor = true;
            this.searchbt.Click += new System.EventHandler(this.searchbt_Click);
            // 
            // paybt
            // 
            this.paybt.FlatAppearance.BorderSize = 0;
            this.paybt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paybt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paybt.ForeColor = System.Drawing.Color.Gainsboro;
            this.paybt.Location = new System.Drawing.Point(3, 699);
            this.paybt.Name = "paybt";
            this.paybt.Size = new System.Drawing.Size(295, 70);
            this.paybt.TabIndex = 11;
            this.paybt.Text = "دفع القسيمة";
            this.paybt.UseVisualStyleBackColor = true;
            this.paybt.Click += new System.EventHandler(this.paybt_Click);
            // 
            // reciptbt
            // 
            this.reciptbt.FlatAppearance.BorderSize = 0;
            this.reciptbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reciptbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reciptbt.ForeColor = System.Drawing.Color.Gainsboro;
            this.reciptbt.Location = new System.Drawing.Point(3, 597);
            this.reciptbt.Name = "reciptbt";
            this.reciptbt.Size = new System.Drawing.Size(295, 70);
            this.reciptbt.TabIndex = 10;
            this.reciptbt.Text = "سند القبض";
            this.reciptbt.UseVisualStyleBackColor = true;
            this.reciptbt.Click += new System.EventHandler(this.reciptbt_Click);
            // 
            // sparebt
            // 
            this.sparebt.FlatAppearance.BorderSize = 0;
            this.sparebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sparebt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sparebt.ForeColor = System.Drawing.Color.Gainsboro;
            this.sparebt.Location = new System.Drawing.Point(3, 396);
            this.sparebt.Name = "sparebt";
            this.sparebt.Size = new System.Drawing.Size(295, 70);
            this.sparebt.TabIndex = 9;
            this.sparebt.Text = "قطع غيار ";
            this.sparebt.UseVisualStyleBackColor = true;
            this.sparebt.Click += new System.EventHandler(this.sparebt_Click);
            // 
            // mantainbt
            // 
            this.mantainbt.FlatAppearance.BorderSize = 0;
            this.mantainbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mantainbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mantainbt.ForeColor = System.Drawing.Color.Gainsboro;
            this.mantainbt.Location = new System.Drawing.Point(3, 304);
            this.mantainbt.Name = "mantainbt";
            this.mantainbt.Size = new System.Drawing.Size(295, 70);
            this.mantainbt.TabIndex = 8;
            this.mantainbt.Text = "صيانة ";
            this.mantainbt.UseVisualStyleBackColor = true;
            this.mantainbt.Click += new System.EventHandler(this.mantainbt_Click);
            // 
            // Installationbt
            // 
            this.Installationbt.FlatAppearance.BorderSize = 0;
            this.Installationbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Installationbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Installationbt.ForeColor = System.Drawing.Color.Gainsboro;
            this.Installationbt.Location = new System.Drawing.Point(3, 202);
            this.Installationbt.Name = "Installationbt";
            this.Installationbt.Size = new System.Drawing.Size(295, 70);
            this.Installationbt.TabIndex = 3;
            this.Installationbt.Text = "التركيب";
            this.Installationbt.UseVisualStyleBackColor = true;
            this.Installationbt.Click += new System.EventHandler(this.Installationbt_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 1000);
            this.Controls.Add(this.panelcontrol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(650, 400);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panelcontrol.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelbar.ResumeLayout(false);
            this.panelbar.PerformLayout();
            this.menupan.ResumeLayout(false);
            this.panellogo.ResumeLayout(false);
            this.panellogo.PerformLayout();
            this.paneldetail.ResumeLayout(false);
            this.paneldetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelcontrol;
        private System.Windows.Forms.Panel menupan;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Installationbt;
        private System.Windows.Forms.Button logoutbt;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label position;
        private System.Windows.Forms.Button paybt;
        private System.Windows.Forms.Button reciptbt;
        private System.Windows.Forms.Button sparebt;
        private System.Windows.Forms.Button mantainbt;
        private System.Windows.Forms.Panel paneldetail;
        private System.Windows.Forms.Button searchbt;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelbar;
        private System.Windows.Forms.Panel panellogo;
        private System.Windows.Forms.Label LBtittle;
        private System.Windows.Forms.Panel Desktopane;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button maxi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button resstore;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button employbt;
    }
}

