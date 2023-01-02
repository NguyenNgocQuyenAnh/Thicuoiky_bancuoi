namespace thicuoiky
{
    partial class frmDangnhapNv
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
            this.btnDnnv = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.txtmknv = new System.Windows.Forms.TextBox();
            this.txttknv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDnnv
            // 
            this.btnDnnv.Location = new System.Drawing.Point(316, 300);
            this.btnDnnv.Name = "btnDnnv";
            this.btnDnnv.Size = new System.Drawing.Size(141, 65);
            this.btnDnnv.TabIndex = 13;
            this.btnDnnv.Text = "Đăng nhập";
            this.btnDnnv.UseVisualStyleBackColor = true;
            this.btnDnnv.Click += new System.EventHandler(this.btnDn_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(543, 300);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(141, 65);
            this.BtnCancel.TabIndex = 14;
            this.BtnCancel.Text = "Thoát";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // txtmknv
            // 
            this.txtmknv.Location = new System.Drawing.Point(326, 219);
            this.txtmknv.Name = "txtmknv";
            this.txtmknv.PasswordChar = '*';
            this.txtmknv.Size = new System.Drawing.Size(398, 26);
            this.txtmknv.TabIndex = 11;
            this.txtmknv.Text = "1";
            // 
            // txttknv
            // 
            this.txttknv.Location = new System.Drawing.Point(326, 165);
            this.txttknv.Name = "txttknv";
            this.txttknv.Size = new System.Drawing.Size(398, 26);
            this.txttknv.TabIndex = 12;
            this.txttknv.Text = "trung";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "tài khoản";
            // 
            // frmDangnhapNv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 582);
            this.Controls.Add(this.btnDnnv);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.txtmknv);
            this.Controls.Add(this.txttknv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDangnhapNv";
            this.Text = "Trang đăng nhập nhân viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDnnv;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox txtmknv;
        private System.Windows.Forms.TextBox txttknv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}