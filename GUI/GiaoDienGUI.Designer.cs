namespace GUI
{
    partial class GiaoDienGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiaoDienGUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnOpenSinhVien = new System.Windows.Forms.ToolStripButton();
            this.btnXemDiem = new System.Windows.Forms.ToolStripButton();
            this.btnNhapDiem = new System.Windows.Forms.ToolStripButton();
            this.btnMonHoc = new System.Windows.Forms.ToolStripButton();
            this.btnKhoa = new System.Windows.Forms.ToolStripButton();
            this.btnThongKeKhoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 561);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.toolStrip1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(984, 166);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpenSinhVien,
            this.btnKhoa,
            this.btnMonHoc,
            this.btnNhapDiem,
            this.btnXemDiem,
            this.toolStripButton1,
            this.btnThongKeKhoa});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(603, 40);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "Sinh viên";
            // 
            // btnOpenSinhVien
            // 
            this.btnOpenSinhVien.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnOpenSinhVien.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenSinhVien.Image")));
            this.btnOpenSinhVien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenSinhVien.Name = "btnOpenSinhVien";
            this.btnOpenSinhVien.Size = new System.Drawing.Size(59, 37);
            this.btnOpenSinhVien.Text = "Sinh viên";
            // 
            // btnXemDiem
            // 
            this.btnXemDiem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnXemDiem.Image = ((System.Drawing.Image)(resources.GetObject("btnXemDiem.Image")));
            this.btnXemDiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXemDiem.Name = "btnXemDiem";
            this.btnXemDiem.Size = new System.Drawing.Size(65, 37);
            this.btnXemDiem.Text = "Xem điểm";
            // 
            // btnNhapDiem
            // 
            this.btnNhapDiem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnNhapDiem.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapDiem.Image")));
            this.btnNhapDiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNhapDiem.Name = "btnNhapDiem";
            this.btnNhapDiem.Size = new System.Drawing.Size(70, 37);
            this.btnNhapDiem.Text = "Nhập điểm";
            // 
            // btnMonHoc
            // 
            this.btnMonHoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnMonHoc.Image = ((System.Drawing.Image)(resources.GetObject("btnMonHoc.Image")));
            this.btnMonHoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMonHoc.Name = "btnMonHoc";
            this.btnMonHoc.Size = new System.Drawing.Size(59, 37);
            this.btnMonHoc.Text = "Môn học";
            // 
            // btnKhoa
            // 
            this.btnKhoa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnKhoa.Image = ((System.Drawing.Image)(resources.GetObject("btnKhoa.Image")));
            this.btnKhoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKhoa.Name = "btnKhoa";
            this.btnKhoa.Size = new System.Drawing.Size(38, 37);
            this.btnKhoa.Text = "Khoa";
            // 
            // btnThongKeKhoa
            // 
            this.btnThongKeKhoa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnThongKeKhoa.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKeKhoa.Image")));
            this.btnThongKeKhoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThongKeKhoa.Name = "btnThongKeKhoa";
            this.btnThongKeKhoa.Size = new System.Drawing.Size(41, 37);
            this.btnThongKeKhoa.Text = "Thoát";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(89, 37);
            this.toolStripButton1.Text = "Thống kê khoa";
            // 
            // GiaoDienGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panel1);
            this.Name = "GiaoDienGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sinh viên";
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnOpenSinhVien;
        private System.Windows.Forms.ToolStripButton btnXemDiem;
        private System.Windows.Forms.ToolStripButton btnMonHoc;
        private System.Windows.Forms.ToolStripButton btnNhapDiem;
        private System.Windows.Forms.ToolStripButton btnKhoa;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btnThongKeKhoa;
    }
}