namespace GUI
{
    partial class NhapDiemGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxMaSo = new System.Windows.Forms.ComboBox();
            this.cbxHoTen = new System.Windows.Forms.ComboBox();
            this.cbxMaMon = new System.Windows.Forms.ComboBox();
            this.cbxTenMon = new System.Windows.Forms.ComboBox();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã môn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên môn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Điểm";
            // 
            // cbxMaSo
            // 
            this.cbxMaSo.FormattingEnabled = true;
            this.cbxMaSo.Location = new System.Drawing.Point(190, 80);
            this.cbxMaSo.Name = "cbxMaSo";
            this.cbxMaSo.Size = new System.Drawing.Size(121, 24);
            this.cbxMaSo.TabIndex = 5;
            // 
            // cbxHoTen
            // 
            this.cbxHoTen.FormattingEnabled = true;
            this.cbxHoTen.Location = new System.Drawing.Point(190, 146);
            this.cbxHoTen.Name = "cbxHoTen";
            this.cbxHoTen.Size = new System.Drawing.Size(121, 24);
            this.cbxHoTen.TabIndex = 6;
            // 
            // cbxMaMon
            // 
            this.cbxMaMon.FormattingEnabled = true;
            this.cbxMaMon.Location = new System.Drawing.Point(190, 201);
            this.cbxMaMon.Name = "cbxMaMon";
            this.cbxMaMon.Size = new System.Drawing.Size(121, 24);
            this.cbxMaMon.TabIndex = 7;
            // 
            // cbxTenMon
            // 
            this.cbxTenMon.FormattingEnabled = true;
            this.cbxTenMon.Location = new System.Drawing.Point(190, 264);
            this.cbxTenMon.Name = "cbxTenMon";
            this.cbxTenMon.Size = new System.Drawing.Size(121, 24);
            this.cbxTenMon.TabIndex = 8;
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(190, 322);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(121, 22);
            this.txtDiem.TabIndex = 9;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(301, 386);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(84, 35);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Nhập";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // NhapDiemGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 450);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtDiem);
            this.Controls.Add(this.cbxTenMon);
            this.Controls.Add(this.cbxMaMon);
            this.Controls.Add(this.cbxHoTen);
            this.Controls.Add(this.cbxMaSo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NhapDiemGUI";
            this.Text = "Nhập điểm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxMaSo;
        private System.Windows.Forms.ComboBox cbxHoTen;
        private System.Windows.Forms.ComboBox cbxMaMon;
        private System.Windows.Forms.ComboBox cbxTenMon;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.Button btnThem;
    }
}