using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    partial class Admin
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
            this.panelNoiDung = new System.Windows.Forms.Panel();
            this.btKhachHang = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btSuaKhachHang = new System.Windows.Forms.Button();
            this.btXoaKhachHang = new System.Windows.Forms.Button();
            this.btThemKhachHang = new System.Windows.Forms.Button();
            this.panelKhachHang = new System.Windows.Forms.Panel();
            this.btXoaSanPham = new System.Windows.Forms.Button();
            this.btChinhSuaSanPham = new System.Windows.Forms.Button();
            this.btSanPham = new System.Windows.Forms.Button();
            this.btThemSanPham = new System.Windows.Forms.Button();
            this.btHoaDon = new System.Windows.Forms.Button();
            this.panelSanPham = new System.Windows.Forms.Panel();
            this.btXoaHoaDon = new System.Windows.Forms.Button();
            this.btSuaHoaDon = new System.Windows.Forms.Button();
            this.btThemHoaDon = new System.Windows.Forms.Button();
            this.panelHoaDon = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelKhachHang.SuspendLayout();
            this.panelSanPham.SuspendLayout();
            this.panelHoaDon.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNoiDung
            // 
            this.panelNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNoiDung.Location = new System.Drawing.Point(175, 93);
            this.panelNoiDung.Name = "panelNoiDung";
            this.panelNoiDung.Size = new System.Drawing.Size(1040, 600);
            this.panelNoiDung.TabIndex = 5;
            // 
            // btKhachHang
            // 
            this.btKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btKhachHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btKhachHang.Location = new System.Drawing.Point(0, 93);
            this.btKhachHang.Name = "btKhachHang";
            this.btKhachHang.Size = new System.Drawing.Size(175, 49);
            this.btKhachHang.TabIndex = 1;
            this.btKhachHang.Text = "Khách hàng";
            this.btKhachHang.UseVisualStyleBackColor = true;
            this.btKhachHang.Click += new System.EventHandler(this.btKhachHang_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(175, 93);
            this.panel4.TabIndex = 0;
            // 
            // btSuaKhachHang
            // 
            this.btSuaKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btSuaKhachHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btSuaKhachHang.Location = new System.Drawing.Point(0, 98);
            this.btSuaKhachHang.Name = "btSuaKhachHang";
            this.btSuaKhachHang.Size = new System.Drawing.Size(175, 50);
            this.btSuaKhachHang.TabIndex = 4;
            this.btSuaKhachHang.Text = "Sửa";
            this.btSuaKhachHang.UseVisualStyleBackColor = true;
            this.btSuaKhachHang.Click += new System.EventHandler(this.btSuaKhachHang_Click);
            // 
            // btXoaKhachHang
            // 
            this.btXoaKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btXoaKhachHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btXoaKhachHang.Location = new System.Drawing.Point(0, 49);
            this.btXoaKhachHang.Name = "btXoaKhachHang";
            this.btXoaKhachHang.Size = new System.Drawing.Size(175, 49);
            this.btXoaKhachHang.TabIndex = 3;
            this.btXoaKhachHang.Text = "Xóa";
            this.btXoaKhachHang.UseVisualStyleBackColor = true;
            this.btXoaKhachHang.Click += new System.EventHandler(this.btXoaKhachHang_Click);
            // 
            // btThemKhachHang
            // 
            this.btThemKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btThemKhachHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btThemKhachHang.Location = new System.Drawing.Point(0, 0);
            this.btThemKhachHang.Name = "btThemKhachHang";
            this.btThemKhachHang.Size = new System.Drawing.Size(175, 49);
            this.btThemKhachHang.TabIndex = 2;
            this.btThemKhachHang.Text = "Thêm";
            this.btThemKhachHang.UseVisualStyleBackColor = true;
            this.btThemKhachHang.Click += new System.EventHandler(this.btThemKhachHang_Click);
            // 
            // panelKhachHang
            // 
            this.panelKhachHang.Controls.Add(this.btSuaKhachHang);
            this.panelKhachHang.Controls.Add(this.btXoaKhachHang);
            this.panelKhachHang.Controls.Add(this.btThemKhachHang);
            this.panelKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelKhachHang.Location = new System.Drawing.Point(0, 142);
            this.panelKhachHang.Name = "panelKhachHang";
            this.panelKhachHang.Size = new System.Drawing.Size(175, 148);
            this.panelKhachHang.TabIndex = 2;
            // 
            // btXoaSanPham
            // 
            this.btXoaSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.btXoaSanPham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btXoaSanPham.Location = new System.Drawing.Point(0, 98);
            this.btXoaSanPham.Name = "btXoaSanPham";
            this.btXoaSanPham.Size = new System.Drawing.Size(175, 50);
            this.btXoaSanPham.TabIndex = 4;
            this.btXoaSanPham.Text = "Xóa sản phẩm";
            this.btXoaSanPham.UseVisualStyleBackColor = true;
            this.btXoaSanPham.Click += new System.EventHandler(this.btXoaSanPham_Click);
            // 
            // btChinhSuaSanPham
            // 
            this.btChinhSuaSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.btChinhSuaSanPham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btChinhSuaSanPham.Location = new System.Drawing.Point(0, 49);
            this.btChinhSuaSanPham.Name = "btChinhSuaSanPham";
            this.btChinhSuaSanPham.Size = new System.Drawing.Size(175, 49);
            this.btChinhSuaSanPham.TabIndex = 3;
            this.btChinhSuaSanPham.Text = "Chỉnh sửa";
            this.btChinhSuaSanPham.UseVisualStyleBackColor = true;
            this.btChinhSuaSanPham.Click += new System.EventHandler(this.btChinhSuaSanPham_Click);
            // 
            // btSanPham
            // 
            this.btSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.btSanPham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btSanPham.Location = new System.Drawing.Point(0, 290);
            this.btSanPham.Name = "btSanPham";
            this.btSanPham.Size = new System.Drawing.Size(175, 49);
            this.btSanPham.TabIndex = 3;
            this.btSanPham.Text = "Sản phẩm";
            this.btSanPham.UseVisualStyleBackColor = true;
            this.btSanPham.Click += new System.EventHandler(this.btSanPham_Click);
            // 
            // btThemSanPham
            // 
            this.btThemSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.btThemSanPham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btThemSanPham.Location = new System.Drawing.Point(0, 0);
            this.btThemSanPham.Name = "btThemSanPham";
            this.btThemSanPham.Size = new System.Drawing.Size(175, 49);
            this.btThemSanPham.TabIndex = 2;
            this.btThemSanPham.Text = "Thêm sản phẩm";
            this.btThemSanPham.UseVisualStyleBackColor = true;
            this.btThemSanPham.Click += new System.EventHandler(this.btThemSanPham_Click);
            // 
            // btHoaDon
            // 
            this.btHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btHoaDon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btHoaDon.Location = new System.Drawing.Point(0, 487);
            this.btHoaDon.Name = "btHoaDon";
            this.btHoaDon.Size = new System.Drawing.Size(175, 49);
            this.btHoaDon.TabIndex = 5;
            this.btHoaDon.Text = "Hóa đơn";
            this.btHoaDon.UseVisualStyleBackColor = true;
            this.btHoaDon.Click += new System.EventHandler(this.btHoaDon_Click);
            // 
            // panelSanPham
            // 
            this.panelSanPham.Controls.Add(this.btXoaSanPham);
            this.panelSanPham.Controls.Add(this.btChinhSuaSanPham);
            this.panelSanPham.Controls.Add(this.btThemSanPham);
            this.panelSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSanPham.Location = new System.Drawing.Point(0, 339);
            this.panelSanPham.Name = "panelSanPham";
            this.panelSanPham.Size = new System.Drawing.Size(175, 148);
            this.panelSanPham.TabIndex = 4;
            // 
            // btXoaHoaDon
            // 
            this.btXoaHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btXoaHoaDon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btXoaHoaDon.Location = new System.Drawing.Point(0, 98);
            this.btXoaHoaDon.Name = "btXoaHoaDon";
            this.btXoaHoaDon.Size = new System.Drawing.Size(175, 50);
            this.btXoaHoaDon.TabIndex = 4;
            this.btXoaHoaDon.Text = "Xóa hóa đơn";
            this.btXoaHoaDon.UseVisualStyleBackColor = true;
            this.btXoaHoaDon.Click += new System.EventHandler(this.btXoaHoaDon_Click);
            // 
            // btSuaHoaDon
            // 
            this.btSuaHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btSuaHoaDon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btSuaHoaDon.Location = new System.Drawing.Point(0, 49);
            this.btSuaHoaDon.Name = "btSuaHoaDon";
            this.btSuaHoaDon.Size = new System.Drawing.Size(175, 49);
            this.btSuaHoaDon.TabIndex = 3;
            this.btSuaHoaDon.Text = "Sửa hóa đơn";
            this.btSuaHoaDon.UseVisualStyleBackColor = true;
            this.btSuaHoaDon.Click += new System.EventHandler(this.btSuaHoaDon_Click);
            // 
            // btThemHoaDon
            // 
            this.btThemHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btThemHoaDon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btThemHoaDon.Location = new System.Drawing.Point(0, 0);
            this.btThemHoaDon.Name = "btThemHoaDon";
            this.btThemHoaDon.Size = new System.Drawing.Size(175, 49);
            this.btThemHoaDon.TabIndex = 2;
            this.btThemHoaDon.Text = "Thêm hóa đơn";
            this.btThemHoaDon.UseVisualStyleBackColor = true;
            this.btThemHoaDon.Click += new System.EventHandler(this.btThemHoaDon_Click);
            // 
            // panelHoaDon
            // 
            this.panelHoaDon.Controls.Add(this.btXoaHoaDon);
            this.panelHoaDon.Controls.Add(this.btSuaHoaDon);
            this.panelHoaDon.Controls.Add(this.btThemHoaDon);
            this.panelHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHoaDon.Location = new System.Drawing.Point(0, 536);
            this.panelHoaDon.Name = "panelHoaDon";
            this.panelHoaDon.Size = new System.Drawing.Size(175, 148);
            this.panelHoaDon.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(175, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1040, 93);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.panelHoaDon);
            this.panel1.Controls.Add(this.btHoaDon);
            this.panel1.Controls.Add(this.panelSanPham);
            this.panel1.Controls.Add(this.btSanPham);
            this.panel1.Controls.Add(this.panelKhachHang);
            this.panel1.Controls.Add(this.btKhachHang);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 693);
            this.panel1.TabIndex = 3;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 693);
            this.Controls.Add(this.panelNoiDung);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1233, 740);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1233, 740);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panelKhachHang.ResumeLayout(false);
            this.panelSanPham.ResumeLayout(false);
            this.panelHoaDon.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelNoiDung;
        private Button btKhachHang;
        private Panel panel4;
        private Button btSuaKhachHang;
        private Button btXoaKhachHang;
        private Button btThemKhachHang;
        private Panel panelKhachHang;
        private Button btXoaSanPham;
        private Button btChinhSuaSanPham;
        private Button btSanPham;
        private Button btThemSanPham;
        private Button btHoaDon;
        private Panel panelSanPham;
        private Button btXoaHoaDon;
        private Button btSuaHoaDon;
        private Button btThemHoaDon;
        private Panel panelHoaDon;
        private Panel panel2;
        private Panel panel1;
    }
}