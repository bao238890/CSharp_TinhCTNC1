namespace CSharp_TinhCTNC1
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
            this.btntinhtong = new System.Windows.Forms.Button();
            this.lblso1 = new System.Windows.Forms.Label();
            this.txtso1 = new System.Windows.Forms.TextBox();
            this.txtso2 = new System.Windows.Forms.TextBox();
            this.lblso2 = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.lblKQ = new System.Windows.Forms.Label();
            this.btntinhhieu = new System.Windows.Forms.Button();
            this.btntinhtich = new System.Windows.Forms.Button();
            this.btntinhthuong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btntinhtong
            // 
            this.btntinhtong.Location = new System.Drawing.Point(190, 202);
            this.btntinhtong.Name = "btntinhtong";
            this.btntinhtong.Size = new System.Drawing.Size(75, 23);
            this.btntinhtong.TabIndex = 0;
            this.btntinhtong.Text = "TỔNG";
            this.btntinhtong.UseVisualStyleBackColor = true;
            this.btntinhtong.Click += new System.EventHandler(this.btntinhtong_Click);
            // 
            // lblso1
            // 
            this.lblso1.AutoSize = true;
            this.lblso1.Location = new System.Drawing.Point(304, 42);
            this.lblso1.Name = "lblso1";
            this.lblso1.Size = new System.Drawing.Size(29, 13);
            this.lblso1.TabIndex = 1;
            this.lblso1.Text = "Số 1";
            // 
            // txtso1
            // 
            this.txtso1.Location = new System.Drawing.Point(382, 35);
            this.txtso1.Name = "txtso1";
            this.txtso1.Size = new System.Drawing.Size(100, 20);
            this.txtso1.TabIndex = 2;
            // 
            // txtso2
            // 
            this.txtso2.Location = new System.Drawing.Point(382, 82);
            this.txtso2.Name = "txtso2";
            this.txtso2.Size = new System.Drawing.Size(100, 20);
            this.txtso2.TabIndex = 4;
            // 
            // lblso2
            // 
            this.lblso2.AutoSize = true;
            this.lblso2.Location = new System.Drawing.Point(304, 85);
            this.lblso2.Name = "lblso2";
            this.lblso2.Size = new System.Drawing.Size(29, 13);
            this.lblso2.TabIndex = 3;
            this.lblso2.Text = "Số 2";
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(382, 127);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(100, 20);
            this.txtKQ.TabIndex = 5;
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Location = new System.Drawing.Point(379, 173);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(54, 13);
            this.lblKQ.TabIndex = 6;
            this.lblKQ.Text = "KẾT QUẢ";
            // 
            // btntinhhieu
            // 
            this.btntinhhieu.Location = new System.Drawing.Point(307, 202);
            this.btntinhhieu.Name = "btntinhhieu";
            this.btntinhhieu.Size = new System.Drawing.Size(75, 23);
            this.btntinhhieu.TabIndex = 7;
            this.btntinhhieu.Text = "HIỆU";
            this.btntinhhieu.UseVisualStyleBackColor = true;
            this.btntinhhieu.Click += new System.EventHandler(this.btntinhhieu_Click);
            // 
            // btntinhtich
            // 
            this.btntinhtich.Location = new System.Drawing.Point(437, 202);
            this.btntinhtich.Name = "btntinhtich";
            this.btntinhtich.Size = new System.Drawing.Size(75, 23);
            this.btntinhtich.TabIndex = 8;
            this.btntinhtich.Text = "TÍCH";
            this.btntinhtich.UseVisualStyleBackColor = true;
            this.btntinhtich.Click += new System.EventHandler(this.btntinhtich_Click);
            // 
            // btntinhthuong
            // 
            this.btntinhthuong.Location = new System.Drawing.Point(558, 202);
            this.btntinhthuong.Name = "btntinhthuong";
            this.btntinhthuong.Size = new System.Drawing.Size(75, 23);
            this.btntinhthuong.TabIndex = 9;
            this.btntinhthuong.Text = "THƯƠNG";
            this.btntinhthuong.UseVisualStyleBackColor = true;
            this.btntinhthuong.Click += new System.EventHandler(this.btntinhthuong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btntinhthuong);
            this.Controls.Add(this.btntinhtich);
            this.Controls.Add(this.btntinhhieu);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtso2);
            this.Controls.Add(this.lblso2);
            this.Controls.Add(this.txtso1);
            this.Controls.Add(this.lblso1);
            this.Controls.Add(this.btntinhtong);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntinhtong;
        private System.Windows.Forms.Label lblso1;
        private System.Windows.Forms.TextBox txtso1;
        private System.Windows.Forms.TextBox txtso2;
        private System.Windows.Forms.Label lblso2;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.Button btntinhhieu;
        private System.Windows.Forms.Button btntinhtich;
        private System.Windows.Forms.Button btntinhthuong;
    }
}

