namespace CT_GT1
{
    partial class fm_phieunhap
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
            this.button6 = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bnttim = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvPN = new System.Windows.Forms.DataGridView();
            this.txttim = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbncc = new System.Windows.Forms.ComboBox();
            this.dtpngaynhap = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtma = new System.Windows.Forms.TextBox();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.nudthanhtien = new System.Windows.Forms.NumericUpDown();
            this.btn_cậpnhật = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPN)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudthanhtien)).BeginInit();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(684, 365);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 45);
            this.button6.TabIndex = 16;
            this.button6.Text = "thoát";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(318, 365);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 45);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(218, 365);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 45);
            this.button3.TabIndex = 15;
            this.button3.Text = "sửa ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(113, 365);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 45);
            this.btnthem.TabIndex = 14;
            this.btnthem.Text = "thêm ";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bnttim);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dgvPN);
            this.groupBox2.Controls.Add(this.txttim);
            this.groupBox2.Location = new System.Drawing.Point(322, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 315);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // bnttim
            // 
            this.bnttim.Location = new System.Drawing.Point(234, 6);
            this.bnttim.Name = "bnttim";
            this.bnttim.Size = new System.Drawing.Size(75, 45);
            this.bnttim.TabIndex = 18;
            this.bnttim.Text = "tim ";
            this.bnttim.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mã PN";
            // 
            // dgvPN
            // 
            this.dgvPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPN.Location = new System.Drawing.Point(6, 60);
            this.dgvPN.Name = "dgvPN";
            this.dgvPN.Size = new System.Drawing.Size(532, 249);
            this.dgvPN.TabIndex = 11;
            this.dgvPN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPN_CellClick);
            // 
            // txttim
            // 
            this.txttim.Location = new System.Drawing.Point(117, 19);
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(100, 20);
            this.txttim.TabIndex = 9;
            this.txttim.TextChanged += new System.EventHandler(this.txttim_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_cậpnhật);
            this.groupBox1.Controls.Add(this.nudthanhtien);
            this.groupBox1.Controls.Add(this.cmbncc);
            this.groupBox1.Controls.Add(this.dtpngaynhap);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtma);
            this.groupBox1.Location = new System.Drawing.Point(48, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 315);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // cmbncc
            // 
            this.cmbncc.FormattingEnabled = true;
            this.cmbncc.Location = new System.Drawing.Point(116, 127);
            this.cmbncc.Name = "cmbncc";
            this.cmbncc.Size = new System.Drawing.Size(111, 21);
            this.cmbncc.TabIndex = 9;
            // 
            // dtpngaynhap
            // 
            this.dtpngaynhap.CustomFormat = "MM/dd/yyyy";
            this.dtpngaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpngaynhap.Location = new System.Drawing.Point(116, 92);
            this.dtpngaynhap.Name = "dtpngaynhap";
            this.dtpngaynhap.Size = new System.Drawing.Size(111, 20);
            this.dtpngaynhap.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Thanh tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã NCC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ngày nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã PN";
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(116, 54);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(100, 20);
            this.txtma.TabIndex = 0;
            // 
            // btnlammoi
            // 
            this.btnlammoi.Location = new System.Drawing.Point(12, 365);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(75, 45);
            this.btnlammoi.TabIndex = 8;
            this.btnlammoi.Text = "làm mới";
            this.btnlammoi.UseVisualStyleBackColor = true;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // nudthanhtien
            // 
            this.nudthanhtien.Location = new System.Drawing.Point(116, 171);
            this.nudthanhtien.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudthanhtien.Name = "nudthanhtien";
            this.nudthanhtien.Size = new System.Drawing.Size(120, 20);
            this.nudthanhtien.TabIndex = 10;
            // 
            // btn_cậpnhật
            // 
            this.btn_cậpnhật.Location = new System.Drawing.Point(6, 242);
            this.btn_cậpnhật.Name = "btn_cậpnhật";
            this.btn_cậpnhật.Size = new System.Drawing.Size(75, 45);
            this.btn_cậpnhật.TabIndex = 18;
            this.btn_cậpnhật.Text = "Cập nhật";
            this.btn_cậpnhật.UseVisualStyleBackColor = true;
            this.btn_cậpnhật.Click += new System.EventHandler(this.btn_cậpnhật_Click);
            // 
            // fm_phieunhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 435);
            this.Controls.Add(this.btnlammoi);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fm_phieunhap";
            this.Text = "fm_phieunhap";
            this.Load += new System.EventHandler(this.fm_phieunhap_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPN)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudthanhtien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Button bnttim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttim;
        private System.Windows.Forms.DateTimePicker dtpngaynhap;
        private System.Windows.Forms.ComboBox cmbncc;
        private System.Windows.Forms.NumericUpDown nudthanhtien;
        private System.Windows.Forms.Button btn_cậpnhật;
    }
}