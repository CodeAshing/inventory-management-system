namespace frontend.Forms
{
    partial class pay_term
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pay_term));
            this.discriptionTB = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTp = new System.Windows.Forms.DateTimePicker();
            this.priceTD = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.submitBT = new System.Windows.Forms.Button();
            this.perCB = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // discriptionTB
            // 
            resources.ApplyResources(this.discriptionTB, "discriptionTB");
            this.discriptionTB.Name = "discriptionTB";
            this.discriptionTB.WaterMark = "";
            this.discriptionTB.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.discriptionTB.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discriptionTB.WaterMarkForeColor = System.Drawing.Color.Black;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Name = "label3";
            // 
            // dateTp
            // 
            resources.ApplyResources(this.dateTp, "dateTp");
            this.dateTp.Name = "dateTp";
            // 
            // priceTD
            // 
            resources.ApplyResources(this.priceTD, "priceTD");
            this.priceTD.Name = "priceTD";
            this.priceTD.ReadOnly = true;
            this.priceTD.WaterMark = "Default Watermark...";
            this.priceTD.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.priceTD.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTD.WaterMarkForeColor = System.Drawing.Color.Black;
            this.priceTD.TextChanged += new System.EventHandler(this.price_TextChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Name = "label4";
            // 
            // submitBT
            // 
            this.submitBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.submitBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.submitBT.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.submitBT, "submitBT");
            this.submitBT.ForeColor = System.Drawing.Color.White;
            this.submitBT.Name = "submitBT";
            this.submitBT.UseVisualStyleBackColor = false;
            this.submitBT.Click += new System.EventHandler(this.submitBT_Click);
            // 
            // perCB
            // 
            this.perCB.FormattingEnabled = true;
            resources.ApplyResources(this.perCB, "perCB");
            this.perCB.Name = "perCB";
            this.perCB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.button1.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // datagrid
            // 
            this.datagrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.GridColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.datagrid, "datagrid");
            this.datagrid.Name = "datagrid";
            this.datagrid.RowTemplate.Height = 28;
            this.datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_CellContentClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.button2.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button2, "button2");
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.button3.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button3, "button3");
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pay_term
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.perCB);
            this.Controls.Add(this.submitBT);
            this.Controls.Add(this.priceTD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.discriptionTB);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "pay_term";
            this.Load += new System.EventHandler(this.pay_term_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ChreneLib.Controls.TextBoxes.CTextBox discriptionTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTp;
        private ChreneLib.Controls.TextBoxes.CTextBox priceTD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button submitBT;
        private System.Windows.Forms.ComboBox perCB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}