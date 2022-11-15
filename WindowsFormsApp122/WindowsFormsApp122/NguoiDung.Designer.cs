using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
namespace WinFormsApp2
{
    partial class NguoiDung
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
            this.panelHoaDon = new System.Windows.Forms.Panel();
            this.btDaGiao = new System.Windows.Forms.Button();
            this.btDangGiao = new System.Windows.Forms.Button();
            this.btChoXacNhan = new System.Windows.Forms.Button();
            this.btHoaDon = new System.Windows.Forms.Button();
            this.panelGioHang = new System.Windows.Forms.Panel();
            this.btThanhToan = new System.Windows.Forms.Button();
            this.btChinhSua = new System.Windows.Forms.Button();
            this.btThemVaoGio = new System.Windows.Forms.Button();
            this.btGioHang = new System.Windows.Forms.Button();
            this.panelThongTin = new System.Windows.Forms.Panel();
            this.btSuaThongTinCaNha = new System.Windows.Forms.Button();
            this.btXoaThongTInCaNhan = new System.Windows.Forms.Button();
            this.btThemThongTinCaNhan = new System.Windows.Forms.Button();
            this.btThongTin = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelNoiDung = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelHoaDon.SuspendLayout();
            this.panelGioHang.SuspendLayout();
            this.panelThongTin.SuspendLayout();
            this.panelNoiDung.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.panelHoaDon);
            this.panel1.Controls.Add(this.btHoaDon);
            this.panel1.Controls.Add(this.panelGioHang);
            this.panel1.Controls.Add(this.btGioHang);
            this.panel1.Controls.Add(this.panelThongTin);
            this.panel1.Controls.Add(this.btThongTin);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 653);
            this.panel1.TabIndex = 0;
            // 
            // panelHoaDon
            // 
            this.panelHoaDon.Controls.Add(this.btDaGiao);
            this.panelHoaDon.Controls.Add(this.btDangGiao);
            this.panelHoaDon.Controls.Add(this.btChoXacNhan);
            this.panelHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHoaDon.Location = new System.Drawing.Point(0, 544);
            this.panelHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHoaDon.Name = "panelHoaDon";
            this.panelHoaDon.Size = new System.Drawing.Size(175, 155);
            this.panelHoaDon.TabIndex = 6;
            // 
            // btDaGiao
            // 
            this.btDaGiao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btDaGiao.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btDaGiao.Location = new System.Drawing.Point(0, 100);
            this.btDaGiao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDaGiao.Name = "btDaGiao";
            this.btDaGiao.Size = new System.Drawing.Size(175, 50);
            this.btDaGiao.TabIndex = 4;
            this.btDaGiao.Text = "Đã giao";
            this.btDaGiao.UseVisualStyleBackColor = true;
            this.btDaGiao.Click += new System.EventHandler(this.btDaGiao_Click);
            // 
            // btDangGiao
            // 
            this.btDangGiao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btDangGiao.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btDangGiao.Location = new System.Drawing.Point(0, 50);
            this.btDangGiao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDangGiao.Name = "btDangGiao";
            this.btDangGiao.Size = new System.Drawing.Size(175, 50);
            this.btDangGiao.TabIndex = 3;
            this.btDangGiao.Text = "Đang giao";
            this.btDangGiao.UseVisualStyleBackColor = true;
            this.btDangGiao.Click += new System.EventHandler(this.btDangGiao_Click);
            // 
            // btChoXacNhan
            // 
            this.btChoXacNhan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btChoXacNhan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btChoXacNhan.Location = new System.Drawing.Point(0, 0);
            this.btChoXacNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btChoXacNhan.Name = "btChoXacNhan";
            this.btChoXacNhan.Size = new System.Drawing.Size(175, 50);
            this.btChoXacNhan.TabIndex = 2;
            this.btChoXacNhan.Text = "Chờ xác nhận";
            this.btChoXacNhan.UseVisualStyleBackColor = true;
            this.btChoXacNhan.Click += new System.EventHandler(this.btChoXacNhan_Click);
            // 
            // btHoaDon
            // 
            this.btHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btHoaDon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btHoaDon.Location = new System.Drawing.Point(0, 494);
            this.btHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btHoaDon.Name = "btHoaDon";
            this.btHoaDon.Size = new System.Drawing.Size(175, 50);
            this.btHoaDon.TabIndex = 5;
            this.btHoaDon.Text = "Hóa đơn";
            this.btHoaDon.UseVisualStyleBackColor = true;
            this.btHoaDon.Click += new System.EventHandler(this.btHoaDon_Click);
            // 
            // panelGioHang
            // 
            this.panelGioHang.Controls.Add(this.btThanhToan);
            this.panelGioHang.Controls.Add(this.btChinhSua);
            this.panelGioHang.Controls.Add(this.btThemVaoGio);
            this.panelGioHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGioHang.Location = new System.Drawing.Point(0, 344);
            this.panelGioHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelGioHang.Name = "panelGioHang";
            this.panelGioHang.Size = new System.Drawing.Size(175, 150);
            this.panelGioHang.TabIndex = 4;
            // 
            // btThanhToan
            // 
            this.btThanhToan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btThanhToan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btThanhToan.Location = new System.Drawing.Point(0, 100);
            this.btThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btThanhToan.Name = "btThanhToan";
            this.btThanhToan.Size = new System.Drawing.Size(175, 50);
            this.btThanhToan.TabIndex = 4;
            this.btThanhToan.Text = "Thanh toán";
            this.btThanhToan.UseVisualStyleBackColor = true;
            this.btThanhToan.Click += new System.EventHandler(this.btThanhToan_Click);
            // 
            // btChinhSua
            // 
            this.btChinhSua.Dock = System.Windows.Forms.DockStyle.Top;
            this.btChinhSua.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btChinhSua.Location = new System.Drawing.Point(0, 50);
            this.btChinhSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btChinhSua.Name = "btChinhSua";
            this.btChinhSua.Size = new System.Drawing.Size(175, 50);
            this.btChinhSua.TabIndex = 3;
            this.btChinhSua.Text = "Chỉnh sửa";
            this.btChinhSua.UseVisualStyleBackColor = true;
            this.btChinhSua.Click += new System.EventHandler(this.btChinhSua_Click);
            // 
            // btThemVaoGio
            // 
            this.btThemVaoGio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btThemVaoGio.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btThemVaoGio.Location = new System.Drawing.Point(0, 0);
            this.btThemVaoGio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btThemVaoGio.Name = "btThemVaoGio";
            this.btThemVaoGio.Size = new System.Drawing.Size(175, 50);
            this.btThemVaoGio.TabIndex = 2;
            this.btThemVaoGio.Text = "Thêm vào giỏ";
            this.btThemVaoGio.UseVisualStyleBackColor = true;
            this.btThemVaoGio.Click += new System.EventHandler(this.btThemVaoGio_Click);
            // 
            // btGioHang
            // 
            this.btGioHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btGioHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btGioHang.Location = new System.Drawing.Point(0, 294);
            this.btGioHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btGioHang.Name = "btGioHang";
            this.btGioHang.Size = new System.Drawing.Size(175, 50);
            this.btGioHang.TabIndex = 3;
            this.btGioHang.Text = "Giỏ hàng";
            this.btGioHang.UseVisualStyleBackColor = true;
            this.btGioHang.Click += new System.EventHandler(this.btGioHang_Click);
            // 
            // panelThongTin
            // 
            this.panelThongTin.Controls.Add(this.btSuaThongTinCaNha);
            this.panelThongTin.Controls.Add(this.btXoaThongTInCaNhan);
            this.panelThongTin.Controls.Add(this.btThemThongTinCaNhan);
            this.panelThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelThongTin.Location = new System.Drawing.Point(0, 143);
            this.panelThongTin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelThongTin.Name = "panelThongTin";
            this.panelThongTin.Size = new System.Drawing.Size(175, 151);
            this.panelThongTin.TabIndex = 2;
            // 
            // btSuaThongTinCaNha
            // 
            this.btSuaThongTinCaNha.Dock = System.Windows.Forms.DockStyle.Top;
            this.btSuaThongTinCaNha.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btSuaThongTinCaNha.Location = new System.Drawing.Point(0, 100);
            this.btSuaThongTinCaNha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSuaThongTinCaNha.Name = "btSuaThongTinCaNha";
            this.btSuaThongTinCaNha.Size = new System.Drawing.Size(175, 50);
            this.btSuaThongTinCaNha.TabIndex = 4;
            this.btSuaThongTinCaNha.Text = "Sửa";
            this.btSuaThongTinCaNha.UseVisualStyleBackColor = true;
            this.btSuaThongTinCaNha.Click += new System.EventHandler(this.btSuaThongTinCaNha_Click);
            // 
            // btXoaThongTInCaNhan
            // 
            this.btXoaThongTInCaNhan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btXoaThongTInCaNhan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btXoaThongTInCaNhan.Location = new System.Drawing.Point(0, 50);
            this.btXoaThongTInCaNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btXoaThongTInCaNhan.Name = "btXoaThongTInCaNhan";
            this.btXoaThongTInCaNhan.Size = new System.Drawing.Size(175, 50);
            this.btXoaThongTInCaNhan.TabIndex = 3;
            this.btXoaThongTInCaNhan.Text = "Xóa";
            this.btXoaThongTInCaNhan.UseVisualStyleBackColor = true;
            this.btXoaThongTInCaNhan.Click += new System.EventHandler(this.btXoaThongTInCaNhan_Click);
            // 
            // btThemThongTinCaNhan
            // 
            this.btThemThongTinCaNhan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btThemThongTinCaNhan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btThemThongTinCaNhan.Location = new System.Drawing.Point(0, 0);
            this.btThemThongTinCaNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btThemThongTinCaNhan.Name = "btThemThongTinCaNhan";
            this.btThemThongTinCaNhan.Size = new System.Drawing.Size(175, 50);
            this.btThemThongTinCaNhan.TabIndex = 2;
            this.btThemThongTinCaNhan.Text = "Thêm";
            this.btThemThongTinCaNhan.UseVisualStyleBackColor = true;
            this.btThemThongTinCaNhan.Click += new System.EventHandler(this.btThemThongTinCaNhan_Click);
            // 
            // btThongTin
            // 
            this.btThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btThongTin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btThongTin.Location = new System.Drawing.Point(0, 93);
            this.btThongTin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btThongTin.Name = "btThongTin";
            this.btThongTin.Size = new System.Drawing.Size(175, 50);
            this.btThongTin.TabIndex = 1;
            this.btThongTin.Text = "Thông tin";
            this.btThongTin.UseVisualStyleBackColor = true;
            this.btThongTin.Click += new System.EventHandler(this.btThongTin_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(175, 93);
            this.panel4.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(175, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1087, 93);
            this.panel2.TabIndex = 1;
            // 
            // panelNoiDung
            // 
            this.panelNoiDung.Controls.Add(this.panel3);
            this.panelNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNoiDung.Location = new System.Drawing.Point(175, 93);
            this.panelNoiDung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelNoiDung.Name = "panelNoiDung";
            this.panelNoiDung.Size = new System.Drawing.Size(1087, 560);
            this.panelNoiDung.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 488);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1087, 72);
            this.panel3.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(180, 16);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 45);
            this.button3.TabIndex = 2;
            this.button3.Text = "Sau";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(21, 16);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "Trước";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // NguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 653);
            this.Controls.Add(this.panelNoiDung);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NguoiDung";
            this.Load += new System.EventHandler(this.NguoiDung_Load);
            this.panel1.ResumeLayout(false);
            this.panelHoaDon.ResumeLayout(false);
            this.panelGioHang.ResumeLayout(false);
            this.panelThongTin.ResumeLayout(false);
            this.panelNoiDung.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panelHoaDon;
        private Button btDaGiao;
        private Button btDangGiao;
        private Button btChoXacNhan;
        private Button btHoaDon;
        private Panel panelGioHang;
        private Button btThanhToan;
        private Button btChinhSua;
        private Button btThemVaoGio;
        private Button btGioHang;
        private Panel panelThongTin;
        private Button btSuaThongTinCaNha;
        private Button btXoaThongTInCaNhan;
        private Button btThemThongTinCaNhan;
        private Button btThongTin;
        private Panel panel4;
        private Panel panel2;
        private Panel panelNoiDung;
        private Panel panel3;
        private Button button3;
        private Button button2;
    }
}