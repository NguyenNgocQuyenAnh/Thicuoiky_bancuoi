namespace thicuoiky
{
    partial class frmDoiMk
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
            this.btndoimk = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpassnew = new System.Windows.Forms.Label();
            this.txtmkm = new System.Windows.Forms.TextBox();
            this.txttk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btndoimk
            // 
            this.btndoimk.Location = new System.Drawing.Point(261, 232);
            this.btndoimk.Name = "btndoimk";
            this.btndoimk.Size = new System.Drawing.Size(141, 52);
            this.btndoimk.TabIndex = 13;
            this.btndoimk.Text = "Đổi Mât Khẩu";
            this.btndoimk.UseVisualStyleBackColor = true;
            this.btndoimk.Click += new System.EventHandler(this.btndoimk_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(474, 232);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(141, 52);
            this.BtnCancel.TabIndex = 14;
            this.BtnCancel.Text = "Thoát";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(261, 90);
            this.txtmk.Name = "txtmk";
            this.txtmk.PasswordChar = '*';
            this.txtmk.Size = new System.Drawing.Size(398, 26);
            this.txtmk.TabIndex = 11;
            this.txtmk.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "mật khẩu cũ";
            // 
            // txtpassnew
            // 
            this.txtpassnew.AutoSize = true;
            this.txtpassnew.Location = new System.Drawing.Point(120, 161);
            this.txtpassnew.Name = "txtpassnew";
            this.txtpassnew.Size = new System.Drawing.Size(104, 20);
            this.txtpassnew.TabIndex = 9;
            this.txtpassnew.Text = "mật khẩu mới";
            // 
            // txtmkm
            // 
            this.txtmkm.Location = new System.Drawing.Point(261, 158);
            this.txtmkm.Name = "txtmkm";
            this.txtmkm.PasswordChar = '*';
            this.txtmkm.Size = new System.Drawing.Size(398, 26);
            this.txtmkm.TabIndex = 11;
            // 
            // txttk
            // 
            this.txttk.Location = new System.Drawing.Point(261, 36);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(398, 26);
            this.txttk.TabIndex = 12;
            this.txttk.Text = "quyenanh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "tài khoản";
            // 
            // frmDoiMk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 325);
            this.Controls.Add(this.btndoimk);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.txtmkm);
            this.Controls.Add(this.txtmk);
            this.Controls.Add(this.txttk);
            this.Controls.Add(this.txtpassnew);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDoiMk";
            this.Text = "Đổi Mật Khẩu";
            this.Load += new System.EventHandler(this.frmDoiMk_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndoimk;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtpassnew;
        private System.Windows.Forms.TextBox txtmkm;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.Label label1;
    }
}