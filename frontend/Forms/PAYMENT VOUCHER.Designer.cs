namespace frontend.Forms
{
    partial class FPayment
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
            this.discription = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.submitBT = new System.Windows.Forms.Button();
            this.category = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.priceTb = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.amountypeCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.priceIWCB = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTP = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.nametb = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reciveCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // discription
            // 
            this.discription.Location = new System.Drawing.Point(544, 260);
            this.discription.Multiline = true;
            this.discription.Name = "discription";
            this.discription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.discription.Size = new System.Drawing.Size(184, 56);
            this.discription.TabIndex = 93;
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
            this.label7.Location = new System.Drawing.Point(734, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 78);
            this.label7.TabIndex = 92;
            this.label7.Text = ":وصف";
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
            this.submitBT.Location = new System.Drawing.Point(543, 412);
            this.submitBT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.submitBT.Name = "submitBT";
            this.submitBT.Size = new System.Drawing.Size(251, 77);
            this.submitBT.TabIndex = 91;
            this.submitBT.Text = "إرسال";
            this.submitBT.UseVisualStyleBackColor = false;
            this.submitBT.Click += new System.EventHandler(this.submitBT_Click_1);
            // 
            // category
            // 
            this.category.FormattingEnabled = true;
            this.category.Items.AddRange(new object[] {
            "الراتب مقدما",
            "امتداد",
            "حضانة الموظف"});
            this.category.Location = new System.Drawing.Point(8, 45);
            this.category.Name = "category";
            this.category.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.category.Size = new System.Drawing.Size(184, 28);
            this.category.TabIndex = 90;
            this.category.Text = "الراتب مقدما";
            this.category.SelectedIndexChanged += new System.EventHandler(this.category_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(198, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 78);
            this.label6.TabIndex = 89;
            this.label6.Text = ":الفئة";
            // 
            // priceTb
            // 
            this.priceTb.Location = new System.Drawing.Point(280, 167);
            this.priceTb.Name = "priceTb";
            this.priceTb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.priceTb.Size = new System.Drawing.Size(184, 26);
            this.priceTb.TabIndex = 88;
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
            this.label5.Location = new System.Drawing.Point(470, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 64);
            this.label5.TabIndex = 87;
            this.label5.Text = ":كمية";
            // 
            // amountypeCB
            // 
            this.amountypeCB.FormattingEnabled = true;
            this.amountypeCB.Items.AddRange(new object[] {
            "السيولة النقدية",
            "التحقق من"});
            this.amountypeCB.Location = new System.Drawing.Point(544, 167);
            this.amountypeCB.Name = "amountypeCB";
            this.amountypeCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.amountypeCB.Size = new System.Drawing.Size(184, 28);
            this.amountypeCB.TabIndex = 86;
            this.amountypeCB.Text = "السيولة النقدية";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(734, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 78);
            this.label3.TabIndex = 85;
            this.label3.Text = ":نوع الدفع";
            // 
            // priceIWCB
            // 
            this.priceIWCB.Location = new System.Drawing.Point(8, 161);
            this.priceIWCB.Multiline = true;
            this.priceIWCB.Name = "priceIWCB";
            this.priceIWCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.priceIWCB.Size = new System.Drawing.Size(184, 56);
            this.priceIWCB.TabIndex = 84;
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
            this.label2.Location = new System.Drawing.Point(189, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 73);
            this.label2.TabIndex = 83;
            this.label2.Text = ":المبلغ بالكلمات";
            // 
            // dateTP
            // 
            this.dateTP.Location = new System.Drawing.Point(280, 43);
            this.dateTP.Name = "dateTP";
            this.dateTP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTP.Size = new System.Drawing.Size(184, 26);
            this.dateTP.TabIndex = 82;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(475, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 78);
            this.label4.TabIndex = 81;
            this.label4.Text = ":تاريخ";
            // 
            // nametb
            // 
            this.nametb.Location = new System.Drawing.Point(544, 43);
            this.nametb.Name = "nametb";
            this.nametb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nametb.Size = new System.Drawing.Size(184, 26);
            this.nametb.TabIndex = 80;
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
            this.label1.Location = new System.Drawing.Point(734, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 78);
            this.label1.TabIndex = 79;
            this.label1.Text = ":اسم العميل";
            // 
            // reciveCheck
            // 
            this.reciveCheck.AutoSize = true;
            this.reciveCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reciveCheck.Location = new System.Drawing.Point(8, -1);
            this.reciveCheck.Name = "reciveCheck";
            this.reciveCheck.Size = new System.Drawing.Size(147, 40);
            this.reciveCheck.TabIndex = 94;
            this.reciveCheck.Text = ":تم الاستلام";
            this.reciveCheck.UseVisualStyleBackColor = true;
            // 
            // FPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(812, 520);
            this.Controls.Add(this.reciveCheck);
            this.Controls.Add(this.discription);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.submitBT);
            this.Controls.Add(this.category);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.priceTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.amountypeCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.priceIWCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nametb);
            this.Controls.Add(this.label1);
            this.Name = "FPayment";
            this.Text = "PAYMENT VOUCHER";
            this.Load += new System.EventHandler(this.FPayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ChreneLib.Controls.TextBoxes.CTextBox discription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button submitBT;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.Label label6;
        private ChreneLib.Controls.TextBoxes.CTextBox priceTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox amountypeCB;
        private System.Windows.Forms.Label label3;
        private ChreneLib.Controls.TextBoxes.CTextBox priceIWCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTP;
        private System.Windows.Forms.Label label4;
        private ChreneLib.Controls.TextBoxes.CTextBox nametb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox reciveCheck;
    }
}