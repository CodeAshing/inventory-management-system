namespace frontend.Forms
{
    partial class list
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
            this.button1 = new System.Windows.Forms.Button();
            this.submitBT = new System.Windows.Forms.Button();
            this.priceTB = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTB = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.idTB = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.datagrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
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
            this.button1.Location = new System.Drawing.Point(668, 250);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 51);
            this.button1.TabIndex = 84;
            this.button1.Text = "إزالة";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.submitBT.Location = new System.Drawing.Point(793, 336);
            this.submitBT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.submitBT.Name = "submitBT";
            this.submitBT.Size = new System.Drawing.Size(175, 51);
            this.submitBT.TabIndex = 82;
            this.submitBT.Text = "إرسال";
            this.submitBT.UseVisualStyleBackColor = false;
            this.submitBT.Click += new System.EventHandler(this.submitBT_Click);
            // 
            // priceTB
            // 
            this.priceTB.Location = new System.Drawing.Point(723, 160);
            this.priceTB.Name = "priceTB";
            this.priceTB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.priceTB.Size = new System.Drawing.Size(184, 26);
            this.priceTB.TabIndex = 88;
            this.priceTB.WaterMark = "####";
            this.priceTB.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.priceTB.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTB.WaterMarkForeColor = System.Drawing.Color.Black;
            this.priceTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceTB_KeyPress);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(926, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 51);
            this.label2.TabIndex = 75;
            this.label2.Text = ":اسم العنصر";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(930, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 53);
            this.label3.TabIndex = 80;
            this.label3.Text = ":السعر";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(723, 101);
            this.nameTB.Name = "nameTB";
            this.nameTB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nameTB.Size = new System.Drawing.Size(184, 26);
            this.nameTB.TabIndex = 89;
            this.nameTB.WaterMark = "";
            this.nameTB.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.nameTB.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTB.WaterMarkForeColor = System.Drawing.Color.Black;
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
            this.button3.Location = new System.Drawing.Point(899, 250);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 51);
            this.button3.TabIndex = 86;
            this.button3.Text = "أضف";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(752, 29);
            this.idTB.Name = "idTB";
            this.idTB.ReadOnly = true;
            this.idTB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.idTB.Size = new System.Drawing.Size(155, 26);
            this.idTB.TabIndex = 91;
            this.idTB.WaterMark = "####";
            this.idTB.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.idTB.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTB.WaterMarkForeColor = System.Drawing.Color.Black;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(925, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 78);
            this.label4.TabIndex = 90;
            this.label4.Text = ":رقم_العقد";
            // 
            // datagrid
            // 
            this.datagrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.GridColor = System.Drawing.Color.Gray;
            this.datagrid.Location = new System.Drawing.Point(27, 12);
            this.datagrid.Name = "datagrid";
            this.datagrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.datagrid.RowTemplate.Height = 28;
            this.datagrid.Size = new System.Drawing.Size(515, 558);
            this.datagrid.TabIndex = 85;
            this.datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_CellContentClick);
            // 
            // list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 620);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.priceTB);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.submitBT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1150, 676);
            this.MinimumSize = new System.Drawing.Size(1150, 676);
            this.Name = "list";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قائمة";
            this.Load += new System.EventHandler(this.list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button submitBT;
        private ChreneLib.Controls.TextBoxes.CTextBox priceTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ChreneLib.Controls.TextBoxes.CTextBox nameTB;
        private System.Windows.Forms.Button button3;
        private ChreneLib.Controls.TextBoxes.CTextBox idTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView datagrid;
    }
}