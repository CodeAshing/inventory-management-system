namespace frontend.Forms
{
    partial class SEARCH
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searPAY = new System.Windows.Forms.Button();
            this.searREC = new System.Windows.Forms.Button();
            this.searEMP = new System.Windows.Forms.Button();
            this.searSPARE = new System.Windows.Forms.Button();
            this.searMAIN = new System.Windows.Forms.Button();
            this.searINS = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PRS_date = new System.Windows.Forms.Label();
            this.PRS_name = new System.Windows.Forms.Label();
            this.PRS_cat = new System.Windows.Forms.Label();
            this.prs_DateTP = new System.Windows.Forms.DateTimePicker();
            this.PRS_catCB = new System.Windows.Forms.ComboBox();
            this.PRS_NCB = new System.Windows.Forms.ComboBox();
            this.endDTP = new System.Windows.Forms.DateTimePicker();
            this.dateEmpLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searPAY
            // 
            this.searPAY.BackColor = System.Drawing.Color.Black;
            this.searPAY.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.searPAY.FlatAppearance.BorderSize = 0;
            this.searPAY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searPAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.searPAY.ForeColor = System.Drawing.Color.White;
            this.searPAY.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.searPAY.Location = new System.Drawing.Point(12, 10);
            this.searPAY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searPAY.Name = "searPAY";
            this.searPAY.Size = new System.Drawing.Size(124, 37);
            this.searPAY.TabIndex = 67;
            this.searPAY.Text = "دفع القسيمة";
            this.searPAY.UseVisualStyleBackColor = false;
            this.searPAY.Click += new System.EventHandler(this.searPAY_Click);
            // 
            // searREC
            // 
            this.searREC.BackColor = System.Drawing.Color.Black;
            this.searREC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.searREC.FlatAppearance.BorderSize = 0;
            this.searREC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searREC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.searREC.ForeColor = System.Drawing.Color.White;
            this.searREC.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.searREC.Location = new System.Drawing.Point(144, 10);
            this.searREC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searREC.Name = "searREC";
            this.searREC.Size = new System.Drawing.Size(124, 37);
            this.searREC.TabIndex = 68;
            this.searREC.Text = "سند القبض";
            this.searREC.UseVisualStyleBackColor = false;
            this.searREC.Click += new System.EventHandler(this.searREC_Click);
            // 
            // searEMP
            // 
            this.searEMP.BackColor = System.Drawing.Color.Black;
            this.searEMP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.searEMP.FlatAppearance.BorderSize = 0;
            this.searEMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searEMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.searEMP.ForeColor = System.Drawing.Color.White;
            this.searEMP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.searEMP.Location = new System.Drawing.Point(276, 10);
            this.searEMP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searEMP.Name = "searEMP";
            this.searEMP.Size = new System.Drawing.Size(124, 37);
            this.searEMP.TabIndex = 69;
            this.searEMP.Text = "موظف";
            this.searEMP.UseVisualStyleBackColor = false;
            this.searEMP.Click += new System.EventHandler(this.searEMP_Click);
            // 
            // searSPARE
            // 
            this.searSPARE.BackColor = System.Drawing.Color.Black;
            this.searSPARE.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.searSPARE.FlatAppearance.BorderSize = 0;
            this.searSPARE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searSPARE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.searSPARE.ForeColor = System.Drawing.Color.White;
            this.searSPARE.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.searSPARE.Location = new System.Drawing.Point(408, 10);
            this.searSPARE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searSPARE.Name = "searSPARE";
            this.searSPARE.Size = new System.Drawing.Size(124, 37);
            this.searSPARE.TabIndex = 70;
            this.searSPARE.Text = "قطع غيار ";
            this.searSPARE.UseVisualStyleBackColor = false;
            this.searSPARE.Click += new System.EventHandler(this.searSPARE_Click);
            // 
            // searMAIN
            // 
            this.searMAIN.BackColor = System.Drawing.Color.Black;
            this.searMAIN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.searMAIN.FlatAppearance.BorderSize = 0;
            this.searMAIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searMAIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.searMAIN.ForeColor = System.Drawing.Color.White;
            this.searMAIN.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.searMAIN.Location = new System.Drawing.Point(540, 10);
            this.searMAIN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searMAIN.Name = "searMAIN";
            this.searMAIN.Size = new System.Drawing.Size(124, 37);
            this.searMAIN.TabIndex = 71;
            this.searMAIN.Text = "صيانة ";
            this.searMAIN.UseVisualStyleBackColor = false;
            this.searMAIN.Click += new System.EventHandler(this.searMAIN_Click);
            // 
            // searINS
            // 
            this.searINS.BackColor = System.Drawing.Color.Black;
            this.searINS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.searINS.FlatAppearance.BorderSize = 0;
            this.searINS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searINS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.searINS.ForeColor = System.Drawing.Color.White;
            this.searINS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.searINS.Location = new System.Drawing.Point(672, 10);
            this.searINS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searINS.Name = "searINS";
            this.searINS.Size = new System.Drawing.Size(124, 37);
            this.searINS.TabIndex = 72;
            this.searINS.Text = "التركيب";
            this.searINS.UseVisualStyleBackColor = false;
            this.searINS.Click += new System.EventHandler(this.searINS_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Location = new System.Drawing.Point(672, 10);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(124, 5);
            this.panel.TabIndex = 73;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(5, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersWidth = 22;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(800, 334);
            this.dataGridView1.TabIndex = 74;
            // 
            // PRS_date
            // 
            this.PRS_date.BackColor = System.Drawing.SystemColors.Control;
            this.PRS_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRS_date.ForeColor = System.Drawing.Color.Black;
            this.PRS_date.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PRS_date.Location = new System.Drawing.Point(374, 67);
            this.PRS_date.Name = "PRS_date";
            this.PRS_date.Size = new System.Drawing.Size(91, 48);
            this.PRS_date.TabIndex = 76;
            this.PRS_date.Text = ": تاريخ";
            // 
            // PRS_name
            // 
            this.PRS_name.BackColor = System.Drawing.SystemColors.Control;
            this.PRS_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRS_name.ForeColor = System.Drawing.Color.Black;
            this.PRS_name.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PRS_name.Location = new System.Drawing.Point(564, 67);
            this.PRS_name.Name = "PRS_name";
            this.PRS_name.Size = new System.Drawing.Size(71, 46);
            this.PRS_name.TabIndex = 77;
            this.PRS_name.Text = ":اسم";
            // 
            // PRS_cat
            // 
            this.PRS_cat.BackColor = System.Drawing.SystemColors.Control;
            this.PRS_cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRS_cat.ForeColor = System.Drawing.Color.Black;
            this.PRS_cat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PRS_cat.Location = new System.Drawing.Point(750, 67);
            this.PRS_cat.Name = "PRS_cat";
            this.PRS_cat.Size = new System.Drawing.Size(71, 38);
            this.PRS_cat.TabIndex = 79;
            this.PRS_cat.Text = ": الفئة";
            this.PRS_cat.Click += new System.EventHandler(this.label2_Click);
            // 
            // prs_DateTP
            // 
            this.prs_DateTP.Location = new System.Drawing.Point(233, 69);
            this.prs_DateTP.Name = "prs_DateTP";
            this.prs_DateTP.Size = new System.Drawing.Size(135, 26);
            this.prs_DateTP.TabIndex = 82;
            this.prs_DateTP.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // PRS_catCB
            // 
            this.PRS_catCB.FormattingEnabled = true;
            this.PRS_catCB.Location = new System.Drawing.Point(623, 67);
            this.PRS_catCB.Name = "PRS_catCB";
            this.PRS_catCB.Size = new System.Drawing.Size(121, 28);
            this.PRS_catCB.TabIndex = 84;
            this.PRS_catCB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // PRS_NCB
            // 
            this.PRS_NCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.PRS_NCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.PRS_NCB.FormattingEnabled = true;
            this.PRS_NCB.Location = new System.Drawing.Point(444, 67);
            this.PRS_NCB.Name = "PRS_NCB";
            this.PRS_NCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PRS_NCB.Size = new System.Drawing.Size(110, 28);
            this.PRS_NCB.TabIndex = 85;
            this.PRS_NCB.SelectedIndexChanged += new System.EventHandler(this.namepayCB_SelectedIndexChanged);
            // 
            // endDTP
            // 
            this.endDTP.Location = new System.Drawing.Point(17, 69);
            this.endDTP.Name = "endDTP";
            this.endDTP.Size = new System.Drawing.Size(135, 26);
            this.endDTP.TabIndex = 87;
            this.endDTP.ValueChanged += new System.EventHandler(this.endDTP_ValueChanged);
            // 
            // dateEmpLabel
            // 
            this.dateEmpLabel.BackColor = System.Drawing.SystemColors.Control;
            this.dateEmpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEmpLabel.ForeColor = System.Drawing.Color.Black;
            this.dateEmpLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateEmpLabel.Location = new System.Drawing.Point(158, 72);
            this.dateEmpLabel.Name = "dateEmpLabel";
            this.dateEmpLabel.Size = new System.Drawing.Size(69, 37);
            this.dateEmpLabel.TabIndex = 86;
            this.dateEmpLabel.Text = ":تاريخ الانتهاء";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(5, 468);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 27);
            this.button1.TabIndex = 81;
            this.button1.Text = "طباعة";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SEARCH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(812, 520);
            this.Controls.Add(this.endDTP);
            this.Controls.Add(this.dateEmpLabel);
            this.Controls.Add(this.PRS_NCB);
            this.Controls.Add(this.PRS_catCB);
            this.Controls.Add(this.prs_DateTP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PRS_cat);
            this.Controls.Add(this.PRS_name);
            this.Controls.Add(this.PRS_date);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.searINS);
            this.Controls.Add(this.searMAIN);
            this.Controls.Add(this.searSPARE);
            this.Controls.Add(this.searEMP);
            this.Controls.Add(this.searREC);
            this.Controls.Add(this.searPAY);
            this.Name = "SEARCH";
            this.Text = "بحث";
            this.Load += new System.EventHandler(this.SEARCH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button searPAY;
        private System.Windows.Forms.Button searREC;
        private System.Windows.Forms.Button searEMP;
        private System.Windows.Forms.Button searSPARE;
        private System.Windows.Forms.Button searMAIN;
        private System.Windows.Forms.Button searINS;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label PRS_date;
        private System.Windows.Forms.Label PRS_name;
        private System.Windows.Forms.Label PRS_cat;
        private System.Windows.Forms.DateTimePicker prs_DateTP;
        private System.Windows.Forms.ComboBox PRS_catCB;
        private System.Windows.Forms.ComboBox PRS_NCB;
        private System.Windows.Forms.DateTimePicker endDTP;
        private System.Windows.Forms.Label dateEmpLabel;
        private System.Windows.Forms.Button button1;
    }
}