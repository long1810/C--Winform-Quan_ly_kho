namespace CT_GT1
{
    partial class fmnhaphang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvpn = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.nubsoluong = new System.Windows.Forms.NumericUpDown();
            this.ccc = new System.Windows.Forms.Label();
            this.txtmapn = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvctpn = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnnhap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmactpn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbhang = new System.Windows.Forms.ComboBox();
            this.gia = new System.Windows.Forms.Label();
            this.nubgia = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubsoluong)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvctpn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubgia)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvpn);
            this.groupBox1.Controls.Add(this.ccc);
            this.groupBox1.Controls.Add(this.txtmapn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 334);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "phiếu nhập";
            // 
            // dgvpn
            // 
            this.dgvpn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpn.Location = new System.Drawing.Point(6, 95);
            this.dgvpn.Name = "dgvpn";
            this.dgvpn.Size = new System.Drawing.Size(419, 233);
            this.dgvpn.TabIndex = 4;
            this.dgvpn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpn_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số lượng";
            // 
            // nubsoluong
            // 
            this.nubsoluong.Location = new System.Drawing.Point(370, 35);
            this.nubsoluong.Name = "nubsoluong";
            this.nubsoluong.Size = new System.Drawing.Size(120, 20);
            this.nubsoluong.TabIndex = 2;
            // 
            // ccc
            // 
            this.ccc.AutoSize = true;
            this.ccc.Location = new System.Drawing.Point(59, 45);
            this.ccc.Name = "ccc";
            this.ccc.Size = new System.Drawing.Size(39, 13);
            this.ccc.TabIndex = 1;
            this.ccc.Text = "ma PN";
            // 
            // txtmapn
            // 
            this.txtmapn.Location = new System.Drawing.Point(121, 42);
            this.txtmapn.Name = "txtmapn";
            this.txtmapn.Size = new System.Drawing.Size(100, 20);
            this.txtmapn.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.gia);
            this.groupBox2.Controls.Add(this.nubgia);
            this.groupBox2.Controls.Add(this.cmbhang);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dgvctpn);
            this.groupBox2.Controls.Add(this.txtmactpn);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.nubsoluong);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(574, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(539, 334);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết phiếu nhập";
            // 
            // dgvctpn
            // 
            this.dgvctpn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvctpn.Location = new System.Drawing.Point(9, 95);
            this.dgvctpn.Name = "dgvctpn";
            this.dgvctpn.Size = new System.Drawing.Size(524, 233);
            this.dgvctpn.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(475, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "chon phiếu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnnhap
            // 
            this.btnnhap.Location = new System.Drawing.Point(624, 390);
            this.btnnhap.Name = "btnnhap";
            this.btnnhap.Size = new System.Drawing.Size(255, 55);
            this.btnnhap.TabIndex = 3;
            this.btnnhap.Text = "Nhập Hàng";
            this.btnnhap.UseVisualStyleBackColor = true;
            this.btnnhap.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ma PN";
            // 
            // txtmactpn
            // 
            this.txtmactpn.AcceptsReturn = true;
            this.txtmactpn.Location = new System.Drawing.Point(82, 19);
            this.txtmactpn.Name = "txtmactpn";
            this.txtmactpn.Size = new System.Drawing.Size(100, 20);
            this.txtmactpn.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "mã hàng";
            // 
            // cmbhang
            // 
            this.cmbhang.FormattingEnabled = true;
            this.cmbhang.Location = new System.Drawing.Point(82, 63);
            this.cmbhang.Name = "cmbhang";
            this.cmbhang.Size = new System.Drawing.Size(121, 21);
            this.cmbhang.TabIndex = 9;
            // 
            // gia
            // 
            this.gia.AutoSize = true;
            this.gia.Location = new System.Drawing.Point(302, 70);
            this.gia.Name = "gia";
            this.gia.Size = new System.Drawing.Size(21, 13);
            this.gia.TabIndex = 11;
            this.gia.Text = "gia";
            // 
            // nubgia
            // 
            this.nubgia.Location = new System.Drawing.Point(370, 63);
            this.nubgia.Name = "nubgia";
            this.nubgia.Size = new System.Drawing.Size(120, 20);
            this.nubgia.TabIndex = 10;
            // 
            // fmnhaphang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 472);
            this.Controls.Add(this.btnnhap);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fmnhaphang";
            this.Text = "fmnhaphang";
            this.Load += new System.EventHandler(this.fmnhaphang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubsoluong)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvctpn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubgia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvpn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nubsoluong;
        private System.Windows.Forms.Label ccc;
        private System.Windows.Forms.TextBox txtmapn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvctpn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnnhap;
        private System.Windows.Forms.ComboBox cmbhang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmactpn;
        private System.Windows.Forms.Label gia;
        private System.Windows.Forms.NumericUpDown nubgia;
    }
}