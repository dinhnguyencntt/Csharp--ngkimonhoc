namespace Csharp_đăngkimonhoc
{
    partial class Form1
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
            this.btndangki = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.cbxNienkhoa = new System.Windows.Forms.ComboBox();
            this.cbxLop = new System.Windows.Forms.ComboBox();
            this.txtMssv = new System.Windows.Forms.TextBox();
            this.txtHovaten = new System.Windows.Forms.TextBox();
            this.cblmonhoc = new System.Windows.Forms.CheckedListBox();
            this.lblmssv = new System.Windows.Forms.Label();
            this.lblhovaten = new System.Windows.Forms.Label();
            this.blNienkhoal = new System.Windows.Forms.Label();
            this.lblLop = new System.Windows.Forms.Label();
            this.lblhocki = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rad1 = new System.Windows.Forms.RadioButton();
            this.rad2 = new System.Windows.Forms.RadioButton();
            this.rad3 = new System.Windows.Forms.RadioButton();
            this.rad4 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btndangki
            // 
            this.btndangki.Location = new System.Drawing.Point(232, 461);
            this.btndangki.Name = "btndangki";
            this.btndangki.Size = new System.Drawing.Size(75, 23);
            this.btndangki.TabIndex = 0;
            this.btndangki.Text = "Đăng Kí";
            this.btndangki.UseVisualStyleBackColor = true;
            this.btndangki.Click += new System.EventHandler(this.btndangki_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(454, 461);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(75, 23);
            this.btnhuy.TabIndex = 1;
            this.btnhuy.Text = "HỦY";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(717, 470);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 2;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // cbxNienkhoa
            // 
            this.cbxNienkhoa.FormattingEnabled = true;
            this.cbxNienkhoa.Location = new System.Drawing.Point(222, 183);
            this.cbxNienkhoa.Name = "cbxNienkhoa";
            this.cbxNienkhoa.Size = new System.Drawing.Size(121, 24);
            this.cbxNienkhoa.TabIndex = 3;
            // 
            // cbxLop
            // 
            this.cbxLop.FormattingEnabled = true;
            this.cbxLop.Location = new System.Drawing.Point(222, 224);
            this.cbxLop.Name = "cbxLop";
            this.cbxLop.Size = new System.Drawing.Size(121, 24);
            this.cbxLop.TabIndex = 4;
            // 
            // txtMssv
            // 
            this.txtMssv.Location = new System.Drawing.Point(222, 65);
            this.txtMssv.Name = "txtMssv";
            this.txtMssv.Size = new System.Drawing.Size(100, 22);
            this.txtMssv.TabIndex = 5;
            this.txtMssv.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtHovaten
            // 
            this.txtHovaten.Location = new System.Drawing.Point(222, 126);
            this.txtHovaten.Name = "txtHovaten";
            this.txtHovaten.Size = new System.Drawing.Size(100, 22);
            this.txtHovaten.TabIndex = 6;
            // 
            // cblmonhoc
            // 
            this.cblmonhoc.FormattingEnabled = true;
            this.cblmonhoc.Items.AddRange(new object[] {
            "LT WIN",
            "LT INTERNET",
            "Mạng Máy Tính",
            "UML"});
            this.cblmonhoc.Location = new System.Drawing.Point(222, 301);
            this.cblmonhoc.Name = "cblmonhoc";
            this.cblmonhoc.Size = new System.Drawing.Size(293, 89);
            this.cblmonhoc.TabIndex = 7;
            this.cblmonhoc.SelectedIndexChanged += new System.EventHandler(this.cblmonhoc_SelectedIndexChanged);
            // 
            // lblmssv
            // 
            this.lblmssv.AutoSize = true;
            this.lblmssv.Location = new System.Drawing.Point(149, 70);
            this.lblmssv.Name = "lblmssv";
            this.lblmssv.Size = new System.Drawing.Size(45, 16);
            this.lblmssv.TabIndex = 8;
            this.lblmssv.Text = "MSSV";
            // 
            // lblhovaten
            // 
            this.lblhovaten.AutoSize = true;
            this.lblhovaten.Location = new System.Drawing.Point(139, 132);
            this.lblhovaten.Name = "lblhovaten";
            this.lblhovaten.Size = new System.Drawing.Size(76, 16);
            this.lblhovaten.TabIndex = 9;
            this.lblhovaten.Text = "HỌ và TÊN";
            // 
            // blNienkhoal
            // 
            this.blNienkhoal.AutoSize = true;
            this.blNienkhoal.Location = new System.Drawing.Point(149, 191);
            this.blNienkhoal.Name = "blNienkhoal";
            this.blNienkhoal.Size = new System.Drawing.Size(69, 16);
            this.blNienkhoal.TabIndex = 10;
            this.blNienkhoal.Text = "Niên Khóa";
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(149, 232);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(33, 16);
            this.lblLop.TabIndex = 11;
            this.lblLop.Text = "LỚP";
            // 
            // lblhocki
            // 
            this.lblhocki.AutoSize = true;
            this.lblhocki.Location = new System.Drawing.Point(149, 264);
            this.lblhocki.Name = "lblhocki";
            this.lblhocki.Size = new System.Drawing.Size(50, 16);
            this.lblhocki.TabIndex = 12;
            this.lblhocki.Text = "HỌC KÌ";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(150, 331);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(70, 16);
            this.l.TabIndex = 13;
            this.l.Text = "MÔN HỌC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Wide Latin", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(635, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(649, 58);
            this.label7.TabIndex = 14;
            this.label7.Text = "Đăng Kí Môn Học";
            // 
            // rad1
            // 
            this.rad1.AutoSize = true;
            this.rad1.Location = new System.Drawing.Point(232, 264);
            this.rad1.Name = "rad1";
            this.rad1.Size = new System.Drawing.Size(31, 20);
            this.rad1.TabIndex = 15;
            this.rad1.TabStop = true;
            this.rad1.Text = "I";
            this.rad1.UseVisualStyleBackColor = true;
            // 
            // rad2
            // 
            this.rad2.AutoSize = true;
            this.rad2.Location = new System.Drawing.Point(276, 264);
            this.rad2.Name = "rad2";
            this.rad2.Size = new System.Drawing.Size(34, 20);
            this.rad2.TabIndex = 16;
            this.rad2.TabStop = true;
            this.rad2.Text = "II";
            this.rad2.UseVisualStyleBackColor = true;
            // 
            // rad3
            // 
            this.rad3.AutoSize = true;
            this.rad3.Location = new System.Drawing.Point(316, 264);
            this.rad3.Name = "rad3";
            this.rad3.Size = new System.Drawing.Size(37, 20);
            this.rad3.TabIndex = 17;
            this.rad3.TabStop = true;
            this.rad3.Text = "III";
            this.rad3.UseVisualStyleBackColor = true;
            // 
            // rad4
            // 
            this.rad4.AutoSize = true;
            this.rad4.Location = new System.Drawing.Point(359, 264);
            this.rad4.Name = "rad4";
            this.rad4.Size = new System.Drawing.Size(40, 20);
            this.rad4.TabIndex = 18;
            this.rad4.TabStop = true;
            this.rad4.Text = "IV";
            this.rad4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 526);
            this.Controls.Add(this.rad4);
            this.Controls.Add(this.rad3);
            this.Controls.Add(this.rad2);
            this.Controls.Add(this.rad1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.l);
            this.Controls.Add(this.lblhocki);
            this.Controls.Add(this.lblLop);
            this.Controls.Add(this.blNienkhoal);
            this.Controls.Add(this.lblhovaten);
            this.Controls.Add(this.lblmssv);
            this.Controls.Add(this.txtHovaten);
            this.Controls.Add(this.txtMssv);
            this.Controls.Add(this.cbxLop);
            this.Controls.Add(this.cbxNienkhoa);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btndangki);
            this.Controls.Add(this.cblmonhoc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndangki;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.ComboBox cbxNienkhoa;
        private System.Windows.Forms.ComboBox cbxLop;
        private System.Windows.Forms.TextBox txtMssv;
        private System.Windows.Forms.TextBox txtHovaten;
        private System.Windows.Forms.CheckedListBox cblmonhoc;
        private System.Windows.Forms.Label lblmssv;
        private System.Windows.Forms.Label lblhovaten;
        private System.Windows.Forms.Label blNienkhoal;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Label lblhocki;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rad1;
        private System.Windows.Forms.RadioButton rad2;
        private System.Windows.Forms.RadioButton rad3;
        private System.Windows.Forms.RadioButton rad4;
    }
}

