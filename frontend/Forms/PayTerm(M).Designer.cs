namespace frontend.Forms
{
    partial class PayTerm_M_
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
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.perCB = new System.Windows.Forms.ComboBox();
            this.submitBT = new System.Windows.Forms.Button();
            this.priceTD = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTp = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.discriptionTB = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid
            // 
            this.datagrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.GridColor = System.Drawing.Color.Gray;
            this.datagrid.Location = new System.Drawing.Point(34, 246);
            this.datagrid.Name = "datagrid";
            this.datagrid.RowTemplate.Height = 28;
            this.datagrid.Size = new System.Drawing.Size(1028, 330);
            this.datagrid.TabIndex = 83;
            this.datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 13F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(67, 128);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 51);
            this.button1.TabIndex = 82;
            this.button1.Text = "إزالة";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // perCB
            // 
            this.perCB.FormattingEnabled = true;
            this.perCB.Location = new System.Drawing.Point(456, 130);
            this.perCB.Name = "perCB";
            this.perCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.perCB.Size = new System.Drawing.Size(121, 28);
            this.perCB.TabIndex = 81;
            // 
            // submitBT
            // 
            this.submitBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.submitBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.submitBT.FlatAppearance.BorderSize = 0;
            this.submitBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitBT.Font = new System.Drawing.Font("MS Reference Sans Serif", 13F);
            this.submitBT.ForeColor = System.Drawing.Color.White;
            this.submitBT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.submitBT.Location = new System.Drawing.Point(67, 189);
            this.submitBT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.submitBT.Name = "submitBT";
            this.submitBT.Size = new System.Drawing.Size(175, 51);
            this.submitBT.TabIndex = 80;
            this.submitBT.Text = "إرسال";
            this.submitBT.UseVisualStyleBackColor = false;
            this.submitBT.Click += new System.EventHandler(this.submitBT_Click);
            // 
            // priceTD
            // 
            this.priceTD.Location = new System.Drawing.Point(422, 68);
            this.priceTD.Name = "priceTD";
            this.priceTD.ReadOnly = true;
            this.priceTD.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.priceTD.Size = new System.Drawing.Size(155, 26);
            this.priceTD.TabIndex = 79;
            this.priceTD.WaterMark = "Default Watermark...";
            this.priceTD.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.priceTD.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTD.WaterMarkForeColor = System.Drawing.Color.Black;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(585, 56);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(121, 82);
            this.label4.TabIndex = 78;
            this.label4.Text = ":قيمة العقد ";
            // 
            // dateTp
            // 
            this.dateTp.Location = new System.Drawing.Point(82, 68);
            this.dateTp.Name = "dateTp";
            this.dateTp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTp.Size = new System.Drawing.Size(200, 26);
            this.dateTp.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(288, 58);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(112, 78);
            this.label3.TabIndex = 76;
            this.label3.Text = ": تاريخ";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(597, 127);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(109, 78);
            this.label2.TabIndex = 75;
            this.label2.Text = ": %";
            // 
            // discriptionTB
            // 
            this.discriptionTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discriptionTB.Location = new System.Drawing.Point(722, 56);
            this.discriptionTB.Multiline = true;
            this.discriptionTB.Name = "discriptionTB";
            this.discriptionTB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.discriptionTB.Size = new System.Drawing.Size(258, 125);
            this.discriptionTB.TabIndex = 74;
            this.discriptionTB.WaterMark = "";
            this.discriptionTB.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.discriptionTB.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discriptionTB.WaterMarkForeColor = System.Drawing.Color.Black;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(986, 60);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(130, 78);
            this.label1.TabIndex = 73;
            this.label1.Text = ":وصف";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("MS Reference Sans Serif", 13F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(263, 189);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 51);
            this.button3.TabIndex = 85;
            this.button3.Text = "دفعت";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("MS Reference Sans Serif", 13F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(263, 128);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 51);
            this.button2.TabIndex = 84;
            this.button2.Text = "أضف";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PayTerm_M_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 620);
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
            this.MaximumSize = new System.Drawing.Size(1150, 676);
            this.MinimumSize = new System.Drawing.Size(1150, 676);
            this.Name = "PayTerm_M_";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PayTerm_M_";
            this.Load += new System.EventHandler(this.PayTerm_M__Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox perCB;
        private System.Windows.Forms.Button submitBT;
        private ChreneLib.Controls.TextBoxes.CTextBox priceTD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private ChreneLib.Controls.TextBoxes.CTextBox discriptionTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}