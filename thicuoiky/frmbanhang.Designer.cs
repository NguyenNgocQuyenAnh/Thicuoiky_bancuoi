namespace thicuoiky
{
    partial class frmbanhang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvsp = new System.Windows.Forms.DataGridView();
            this.tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magiay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tengiay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a = new System.Windows.Forms.Label();
            this.txtmg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnThemhd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbtenkh = new System.Windows.Forms.ComboBox();
            this.cmbmakh = new System.Windows.Forms.ComboBox();
            this.dgvhd = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmhd = new System.Windows.Forms.TextBox();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhd)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbmakh);
            this.panel1.Controls.Add(this.cmbtenkh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtgia);
            this.panel1.Controls.Add(this.txtmhd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtsl);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtg);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtmg);
            this.panel1.Controls.Add(this.a);
            this.panel1.Location = new System.Drawing.Point(1, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 179);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.dgvhd);
            this.panel2.Controls.Add(this.dgvsp);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.btnThemhd);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(1, 192);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(987, 429);
            this.panel2.TabIndex = 1;
            // 
            // dgvsp
            // 
            this.dgvsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tt,
            this.magiay,
            this.maloai,
            this.tengiay,
            this.gia,
            this.soluong});
            this.dgvsp.Location = new System.Drawing.Point(3, 3);
            this.dgvsp.Name = "dgvsp";
            this.dgvsp.RowTemplate.Height = 28;
            this.dgvsp.Size = new System.Drawing.Size(779, 352);
            this.dgvsp.TabIndex = 18;
            this.dgvsp.Click += new System.EventHandler(this.dgvsp_Click);
            // 
            // tt
            // 
            this.tt.DataPropertyName = "tt";
            this.tt.HeaderText = "TT";
            this.tt.Name = "tt";
            // 
            // magiay
            // 
            this.magiay.DataPropertyName = "magiay";
            this.magiay.HeaderText = "Mã Giày";
            this.magiay.Name = "magiay";
            // 
            // maloai
            // 
            this.maloai.DataPropertyName = "maloai";
            this.maloai.HeaderText = "Mã Loại";
            this.maloai.Name = "maloai";
            this.maloai.Visible = false;
            // 
            // tengiay
            // 
            this.tengiay.DataPropertyName = "tengiay";
            this.tengiay.HeaderText = "Tên Giày";
            this.tengiay.Name = "tengiay";
            this.tengiay.Width = 300;
            // 
            // gia
            // 
            this.gia.DataPropertyName = "gia";
            this.gia.HeaderText = "Giá";
            this.gia.Name = "gia";
            this.gia.Width = 200;
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số Lượng";
            this.soluong.Name = "soluong";
            this.soluong.Width = 200;
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(43, 17);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(67, 20);
            this.a.TabIndex = 0;
            this.a.Text = "Mã Giày";
            // 
            // txtmg
            // 
            this.txtmg.Location = new System.Drawing.Point(123, 17);
            this.txtmg.Name = "txtmg";
            this.txtmg.Size = new System.Drawing.Size(248, 26);
            this.txtmg.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Giày";
            // 
            // txtg
            // 
            this.txtg.Location = new System.Drawing.Point(123, 62);
            this.txtg.Name = "txtg";
            this.txtg.Size = new System.Drawing.Size(248, 26);
            this.txtg.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số Lượng";
            // 
            // txtsl
            // 
            this.txtsl.Location = new System.Drawing.Point(123, 101);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(248, 26);
            this.txtsl.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Quản lý khách";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnThemhd
            // 
            this.btnThemhd.Location = new System.Drawing.Point(227, 375);
            this.btnThemhd.Name = "btnThemhd";
            this.btnThemhd.Size = new System.Drawing.Size(145, 39);
            this.btnThemhd.TabIndex = 19;
            this.btnThemhd.Text = "Thêm Hóa Đơn";
            this.btnThemhd.UseVisualStyleBackColor = true;
            this.btnThemhd.Click += new System.EventHandler(this.btnThemhd_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(410, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 39);
            this.button2.TabIndex = 20;
            this.button2.Text = "Thanh Toán";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(595, 372);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 40);
            this.button4.TabIndex = 20;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(462, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn Tên khách hàng :";
            // 
            // cmbtenkh
            // 
            this.cmbtenkh.FormattingEnabled = true;
            this.cmbtenkh.Location = new System.Drawing.Point(641, 14);
            this.cmbtenkh.Name = "cmbtenkh";
            this.cmbtenkh.Size = new System.Drawing.Size(200, 28);
            this.cmbtenkh.TabIndex = 3;
            this.cmbtenkh.SelectedIndexChanged += new System.EventHandler(this.cmbtenkh_SelectedIndexChanged);
            // 
            // cmbmakh
            // 
            this.cmbmakh.FormattingEnabled = true;
            this.cmbmakh.Location = new System.Drawing.Point(641, 53);
            this.cmbmakh.Name = "cmbmakh";
            this.cmbmakh.Size = new System.Drawing.Size(200, 28);
            this.cmbmakh.TabIndex = 4;
            // 
            // dgvhd
            // 
            this.dgvhd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhd.Location = new System.Drawing.Point(781, 3);
            this.dgvhd.Name = "dgvhd";
            this.dgvhd.RowTemplate.Height = 28;
            this.dgvhd.Size = new System.Drawing.Size(201, 352);
            this.dgvhd.TabIndex = 19;
            this.dgvhd.Click += new System.EventHandler(this.dgvhd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã Hóa đơn";
            // 
            // txtmhd
            // 
            this.txtmhd.Location = new System.Drawing.Point(124, 136);
            this.txtmhd.Name = "txtmhd";
            this.txtmhd.Size = new System.Drawing.Size(248, 26);
            this.txtmhd.TabIndex = 1;
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(377, 17);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(45, 26);
            this.txtgia.TabIndex = 1;
            // 
            // frmbanhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 636);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmbanhang";
            this.Text = "Quản Lý Bán Hàng";
            this.Load += new System.EventHandler(this.frmbanhang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmg;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.DataGridView dgvsp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn magiay;
        private System.Windows.Forms.DataGridViewTextBoxColumn maloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn tengiay;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnThemhd;
        private System.Windows.Forms.ComboBox cmbtenkh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbmakh;
        private System.Windows.Forms.DataGridView dgvhd;
        private System.Windows.Forms.TextBox txtmhd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtgia;
    }
}