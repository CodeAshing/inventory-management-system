namespace frontend.Forms
{
    partial class FormRecipt
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
            this.nametb = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTP = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.priceIWCB = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.categoryCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.priceTb = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RfromCB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.submitBT = new System.Windows.Forms.Button();
            this.discription = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nametb
            // 
            this.nametb.Location = new System.Drawing.Point(548, 35);
            this.nametb.Name = "nametb";
            this.nametb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nametb.Size = new System.Drawing.Size(184, 26);
            this.nametb.TabIndex = 62;
            this.nametb.WaterMark = "عبدالله\t";
            this.nametb.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.nametb.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametb.WaterMarkForeColor = System.Drawing.Color.Black;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(738, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 78);
            this.label1.TabIndex = 61;
            this.label1.Text = ":اسم العميل";
            // 
            // dateTP
            // 
            this.dateTP.Location = new System.Drawing.Point(284, 35);
            this.dateTP.Name = "dateTP";
            this.dateTP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTP.Size = new System.Drawing.Size(184, 26);
            this.dateTP.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(479, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 78);
            this.label4.TabIndex = 63;
            this.label4.Text = ":تاريخ";
            // 
            // priceIWCB
            // 
            this.priceIWCB.Location = new System.Drawing.Point(12, 153);
            this.priceIWCB.Multiline = true;
            this.priceIWCB.Name = "priceIWCB";
            this.priceIWCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.priceIWCB.Size = new System.Drawing.Size(184, 56);
            this.priceIWCB.TabIndex = 66;
            this.priceIWCB.WaterMark = "ألف لاك ألف ومائة";
            this.priceIWCB.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.priceIWCB.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceIWCB.WaterMarkForeColor = System.Drawing.Color.Black;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(193, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 73);
            this.label2.TabIndex = 65;
            this.label2.Text = ":المبلغ بالكلمات";
            // 
            // categoryCB
            // 
            this.categoryCB.FormattingEnabled = true;
            this.categoryCB.Items.AddRange(new object[] {
            "السيولة النقدية",
            "التحقق من"});
            this.categoryCB.Location = new System.Drawing.Point(548, 159);
            this.categoryCB.Name = "categoryCB";
            this.categoryCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.categoryCB.Size = new System.Drawing.Size(184, 28);
            this.categoryCB.TabIndex = 71;
            this.categoryCB.Text = "السيولة النقدية";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(738, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 78);
            this.label3.TabIndex = 70;
            this.label3.Text = ":نوع الدفع";
            // 
            // priceTb
            // 
            this.priceTb.Location = new System.Drawing.Point(284, 159);
            this.priceTb.Name = "priceTb";
            this.priceTb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.priceTb.Size = new System.Drawing.Size(184, 26);
            this.priceTb.TabIndex = 73;
            this.priceTb.WaterMark = "######";
            this.priceTb.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.priceTb.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTb.WaterMarkForeColor = System.Drawing.Color.Black;
            this.priceTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceTb_KeyPress);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(474, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 64);
            this.label5.TabIndex = 72;
            this.label5.Text = ":كمية";
            // 
            // RfromCB
            // 
            this.RfromCB.FormattingEnabled = true;
            this.RfromCB.Items.AddRange(new object[] {
            "مدير",
            "الزبون",
            "الآخرين"});
            this.RfromCB.Location = new System.Drawing.Point(12, 37);
            this.RfromCB.Name = "RfromCB";
            this.RfromCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RfromCB.Size = new System.Drawing.Size(184, 28);
            this.RfromCB.TabIndex = 75;
            this.RfromCB.Text = "مدير";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(202, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 78);
            this.label6.TabIndex = 74;
            this.label6.Text = ":مستلم من";
            // 
            // submitBT
            // 
            this.submitBT.BackColor = System.Drawing.Color.Black;
            this.submitBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.submitBT.FlatAppearance.BorderSize = 0;
            this.submitBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBT.ForeColor = System.Drawing.Color.White;
            this.submitBT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.submitBT.Location = new System.Drawing.Point(547, 404);
            this.submitBT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.submitBT.Name = "submitBT";
            this.submitBT.Size = new System.Drawing.Size(251, 77);
            this.submitBT.TabIndex = 76;
            this.submitBT.Text = "إرسال";
            this.submitBT.UseVisualStyleBackColor = false;
            this.submitBT.Click += new System.EventHandler(this.submitBT_Click);
            // 
            // discription
            // 
            this.discription.Location = new System.Drawing.Point(548, 252);
            this.discription.Multiline = true;
            this.discription.Name = "discription";
            this.discription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.discription.Size = new System.Drawing.Size(184, 56);
            this.discription.TabIndex = 78;
            this.discription.WaterMark = "";
            this.discription.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.discription.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discription.WaterMarkForeColor = System.Drawing.Color.Black;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(738, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 78);
            this.label7.TabIndex = 77;
            this.label7.Text = ":وصف";
            // 
            // FormRecipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(812, 520);
            this.Controls.Add(this.discription);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.submitBT);
            this.Controls.Add(this.RfromCB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.priceTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.categoryCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.priceIWCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nametb);
            this.Controls.Add(this.label1);
            this.Name = "FormRecipt";
            this.Text = "سند القبض";
            this.Load += new System.EventHandler(this.FormRecipt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ChreneLib.Controls.TextBoxes.CTextBox nametb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTP;
        private System.Windows.Forms.Label label4;
        private ChreneLib.Controls.TextBoxes.CTextBox priceIWCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox categoryCB;
        private System.Windows.Forms.Label label3;
        private ChreneLib.Controls.TextBoxes.CTextBox priceTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox RfromCB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button submitBT;
        private ChreneLib.Controls.TextBoxes.CTextBox discription;
        private System.Windows.Forms.Label label7;
    }
}