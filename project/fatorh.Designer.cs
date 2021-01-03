namespace project
{
    partial class fatorh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fatorh));
            this.f_id = new System.Windows.Forms.TextBox();
            this.f_sar = new System.Windows.Forms.TextBox();
            this.f_md = new System.Windows.Forms.TextBox();
            this.f_ba = new System.Windows.Forms.TextBox();
            this.f_month = new System.Windows.Forms.DateTimePicker();
            this.c_id = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // f_id
            // 
            this.f_id.BackColor = System.Drawing.Color.WhiteSmoke;
            this.f_id.ForeColor = System.Drawing.Color.Brown;
            this.f_id.Location = new System.Drawing.Point(334, 61);
            this.f_id.Name = "f_id";
            this.f_id.ReadOnly = true;
            this.f_id.Size = new System.Drawing.Size(238, 20);
            this.f_id.TabIndex = 0;
            // 
            // f_sar
            // 
            this.f_sar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.f_sar.ForeColor = System.Drawing.Color.Brown;
            this.f_sar.Location = new System.Drawing.Point(334, 92);
            this.f_sar.Name = "f_sar";
            this.f_sar.Size = new System.Drawing.Size(238, 20);
            this.f_sar.TabIndex = 1;
            // 
            // f_md
            // 
            this.f_md.ForeColor = System.Drawing.Color.Brown;
            this.f_md.Location = new System.Drawing.Point(12, 88);
            this.f_md.Name = "f_md";
            this.f_md.Size = new System.Drawing.Size(214, 20);
            this.f_md.TabIndex = 2;
            // 
            // f_ba
            // 
            this.f_ba.ForeColor = System.Drawing.Color.Brown;
            this.f_ba.Location = new System.Drawing.Point(12, 124);
            this.f_ba.Name = "f_ba";
            this.f_ba.ReadOnly = true;
            this.f_ba.Size = new System.Drawing.Size(214, 20);
            this.f_ba.TabIndex = 3;
            this.f_ba.Click += new System.EventHandler(this.f_ba_Click);
            // 
            // f_month
            // 
            this.f_month.CalendarForeColor = System.Drawing.Color.Brown;
            this.f_month.Location = new System.Drawing.Point(319, 124);
            this.f_month.Name = "f_month";
            this.f_month.Size = new System.Drawing.Size(253, 20);
            this.f_month.TabIndex = 4;
            // 
            // c_id
            // 
            this.c_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.c_id.ForeColor = System.Drawing.Color.Brown;
            this.c_id.FormattingEnabled = true;
            this.c_id.Location = new System.Drawing.Point(12, 56);
            this.c_id.Name = "c_id";
            this.c_id.Size = new System.Drawing.Size(214, 21);
            this.c_id.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(575, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "رقم السلعة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(246, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "اسم العميل";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(597, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "السعر";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(259, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "المدفوع";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(259, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "الباقي";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Brown;
            this.label6.Location = new System.Drawing.Point(592, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "التاريخ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(630, 196);
            this.dataGridView1.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(190, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(249, 35);
            this.label7.TabIndex = 131;
            this.label7.Text = "فاتورة المشتريات";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button13);
            this.groupBox1.Controls.Add(this.button14);
            this.groupBox1.Controls.Add(this.button15);
            this.groupBox1.Controls.Add(this.button16);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(124, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 38);
            this.groupBox1.TabIndex = 147;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(289, -1);
            this.button8.Margin = new System.Windows.Forms.Padding(0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(51, 35);
            this.button8.TabIndex = 135;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.Location = new System.Drawing.Point(347, -1);
            this.button9.Margin = new System.Windows.Forms.Padding(0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(50, 35);
            this.button9.TabIndex = 136;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Highlight;
            this.button6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(124, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(53, 34);
            this.button6.TabIndex = 128;
            this.button6.Text = "اضافة";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.Highlight;
            this.button13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(6, 0);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(60, 34);
            this.button13.TabIndex = 129;
            this.button13.Text = "حذف";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button14.Location = new System.Drawing.Point(183, 0);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(49, 34);
            this.button14.TabIndex = 133;
            this.button14.Text = "<<";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.Highlight;
            this.button15.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(72, 0);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(49, 34);
            this.button15.TabIndex = 130;
            this.button15.Text = "تعديل";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button16.Location = new System.Drawing.Point(238, 0);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(49, 34);
            this.button16.TabIndex = 132;
            this.button16.Text = ">>";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Crimson;
            this.button17.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(70, 162);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(50, 34);
            this.button17.TabIndex = 146;
            this.button17.Text = "الغاء";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.PapayaWhip;
            this.button18.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(12, 162);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(52, 34);
            this.button18.TabIndex = 145;
            this.button18.Text = "حفظ";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // fatorh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 403);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.c_id);
            this.Controls.Add(this.f_month);
            this.Controls.Add(this.f_ba);
            this.Controls.Add(this.f_md);
            this.Controls.Add(this.f_sar);
            this.Controls.Add(this.f_id);
            this.Name = "fatorh";
            this.Text = "fatorh";
            this.Load += new System.EventHandler(this.fatorh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox f_id;
        private System.Windows.Forms.TextBox f_sar;
        private System.Windows.Forms.TextBox f_md;
        private System.Windows.Forms.TextBox f_ba;
        private System.Windows.Forms.DateTimePicker f_month;
        private System.Windows.Forms.ComboBox c_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
    }
}