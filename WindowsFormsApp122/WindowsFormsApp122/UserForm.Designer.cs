using System.Windows.Forms;

namespace WindowsFormsApp122
{
    partial class UserForm
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
            this.components = new System.ComponentModel.Container();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnSignOut = new System.Windows.Forms.Panel();
            this.picSignOut = new System.Windows.Forms.PictureBox();
            this.lbSignOut = new System.Windows.Forms.Label();
            this.pnAboutUs = new System.Windows.Forms.Panel();
            this.picAboutUs = new System.Windows.Forms.PictureBox();
            this.lbAboutUs = new System.Windows.Forms.Label();
            this.pnAccount = new System.Windows.Forms.Panel();
            this.picAccount = new System.Windows.Forms.PictureBox();
            this.lbAccount = new System.Windows.Forms.Label();
            this.pnInvoice = new System.Windows.Forms.Panel();
            this.picInvoice = new System.Windows.Forms.PictureBox();
            this.lbInvoice = new System.Windows.Forms.Label();
            this.pnMyOrders = new System.Windows.Forms.Panel();
            this.picMyOrders = new System.Windows.Forms.PictureBox();
            this.lbMyOrders = new System.Windows.Forms.Label();
            this.pnShoppingCart = new System.Windows.Forms.Panel();
            this.picShoppingCart = new System.Windows.Forms.PictureBox();
            this.lbShoppingCart = new System.Windows.Forms.Label();
            this.pnDashboard = new System.Windows.Forms.Panel();
            this.picDashboard = new System.Windows.Forms.PictureBox();
            this.lbDashboard = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnSignOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSignOut)).BeginInit();
            this.pnAboutUs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAboutUs)).BeginInit();
            this.pnAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAccount)).BeginInit();
            this.pnInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInvoice)).BeginInit();
            this.pnMyOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMyOrders)).BeginInit();
            this.pnShoppingCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShoppingCart)).BeginInit();
            this.pnDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDashboard)).BeginInit();
            this.pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pnSignOut);
            this.panel1.Controls.Add(this.pnAboutUs);
            this.panel1.Controls.Add(this.pnAccount);
            this.panel1.Controls.Add(this.pnInvoice);
            this.panel1.Controls.Add(this.pnMyOrders);
            this.panel1.Controls.Add(this.pnShoppingCart);
            this.panel1.Controls.Add(this.pnDashboard);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(26, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 796);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp122.Properties.Resources.LogoAppleWhite;
            this.pictureBox1.Location = new System.Drawing.Point(104, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pnSignOut
            // 
            this.pnSignOut.BackColor = System.Drawing.Color.White;
            this.pnSignOut.Controls.Add(this.picSignOut);
            this.pnSignOut.Controls.Add(this.lbSignOut);
            this.pnSignOut.Location = new System.Drawing.Point(26, 693);
            this.pnSignOut.Name = "pnSignOut";
            this.pnSignOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnSignOut.Size = new System.Drawing.Size(258, 53);
            this.pnSignOut.TabIndex = 15;
            this.pnSignOut.Click += new System.EventHandler(this.pnSignOut_Click);
            // 
            // picSignOut
            // 
            this.picSignOut.Image = global::WindowsFormsApp122.Properties.Resources.iconSignOut;
            this.picSignOut.Location = new System.Drawing.Point(20, 8);
            this.picSignOut.Name = "picSignOut";
            this.picSignOut.Size = new System.Drawing.Size(35, 35);
            this.picSignOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSignOut.TabIndex = 0;
            this.picSignOut.TabStop = false;
            this.picSignOut.Click += new System.EventHandler(this.picSignOut_Click);
            // 
            // lbSignOut
            // 
            this.lbSignOut.AutoSize = true;
            this.lbSignOut.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSignOut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbSignOut.Location = new System.Drawing.Point(75, 13);
            this.lbSignOut.Name = "lbSignOut";
            this.lbSignOut.Size = new System.Drawing.Size(93, 29);
            this.lbSignOut.TabIndex = 0;
            this.lbSignOut.Text = "Sign Out";
            this.lbSignOut.Click += new System.EventHandler(this.lbSignOut_Click);
            // 
            // pnAboutUs
            // 
            this.pnAboutUs.BackColor = System.Drawing.Color.White;
            this.pnAboutUs.Controls.Add(this.picAboutUs);
            this.pnAboutUs.Controls.Add(this.lbAboutUs);
            this.pnAboutUs.Location = new System.Drawing.Point(24, 622);
            this.pnAboutUs.Name = "pnAboutUs";
            this.pnAboutUs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnAboutUs.Size = new System.Drawing.Size(258, 53);
            this.pnAboutUs.TabIndex = 14;
            this.pnAboutUs.Click += new System.EventHandler(this.pnAboutUs_Click);
            // 
            // picAboutUs
            // 
            this.picAboutUs.Image = global::WindowsFormsApp122.Properties.Resources.iconAboutUsOff;
            this.picAboutUs.Location = new System.Drawing.Point(20, 8);
            this.picAboutUs.Name = "picAboutUs";
            this.picAboutUs.Size = new System.Drawing.Size(35, 35);
            this.picAboutUs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAboutUs.TabIndex = 0;
            this.picAboutUs.TabStop = false;
            this.picAboutUs.Click += new System.EventHandler(this.picAboutUs_Click);
            // 
            // lbAboutUs
            // 
            this.lbAboutUs.AutoSize = true;
            this.lbAboutUs.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAboutUs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbAboutUs.Location = new System.Drawing.Point(75, 13);
            this.lbAboutUs.Name = "lbAboutUs";
            this.lbAboutUs.Size = new System.Drawing.Size(101, 29);
            this.lbAboutUs.TabIndex = 0;
            this.lbAboutUs.Text = "About Us";
            this.lbAboutUs.Click += new System.EventHandler(this.lbAboutUs_Click);
            // 
            // pnAccount
            // 
            this.pnAccount.BackColor = System.Drawing.Color.White;
            this.pnAccount.Controls.Add(this.picAccount);
            this.pnAccount.Controls.Add(this.lbAccount);
            this.pnAccount.Location = new System.Drawing.Point(26, 497);
            this.pnAccount.Name = "pnAccount";
            this.pnAccount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnAccount.Size = new System.Drawing.Size(258, 53);
            this.pnAccount.TabIndex = 13;
            this.pnAccount.Click += new System.EventHandler(this.pnAccount_Click);
            // 
            // picAccount
            // 
            this.picAccount.Image = global::WindowsFormsApp122.Properties.Resources.iconAccountOff;
            this.picAccount.Location = new System.Drawing.Point(20, 8);
            this.picAccount.Name = "picAccount";
            this.picAccount.Size = new System.Drawing.Size(35, 35);
            this.picAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAccount.TabIndex = 0;
            this.picAccount.TabStop = false;
            this.picAccount.Click += new System.EventHandler(this.picAccount_Click);
            // 
            // lbAccount
            // 
            this.lbAccount.AutoSize = true;
            this.lbAccount.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbAccount.Location = new System.Drawing.Point(75, 13);
            this.lbAccount.Name = "lbAccount";
            this.lbAccount.Size = new System.Drawing.Size(92, 29);
            this.lbAccount.TabIndex = 0;
            this.lbAccount.Text = "Account";
            this.lbAccount.Click += new System.EventHandler(this.lbAccount_Click);
            // 
            // pnInvoice
            // 
            this.pnInvoice.BackColor = System.Drawing.Color.White;
            this.pnInvoice.Controls.Add(this.picInvoice);
            this.pnInvoice.Controls.Add(this.lbInvoice);
            this.pnInvoice.Location = new System.Drawing.Point(26, 426);
            this.pnInvoice.Name = "pnInvoice";
            this.pnInvoice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnInvoice.Size = new System.Drawing.Size(258, 53);
            this.pnInvoice.TabIndex = 12;
            this.pnInvoice.Click += new System.EventHandler(this.pnInvoice_Click);
            // 
            // picInvoice
            // 
            this.picInvoice.Image = global::WindowsFormsApp122.Properties.Resources.iconInvoiceOff;
            this.picInvoice.Location = new System.Drawing.Point(20, 8);
            this.picInvoice.Name = "picInvoice";
            this.picInvoice.Size = new System.Drawing.Size(35, 35);
            this.picInvoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picInvoice.TabIndex = 0;
            this.picInvoice.TabStop = false;
            this.picInvoice.Click += new System.EventHandler(this.picInvoice_Click);
            // 
            // lbInvoice
            // 
            this.lbInvoice.AutoSize = true;
            this.lbInvoice.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInvoice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbInvoice.Location = new System.Drawing.Point(75, 13);
            this.lbInvoice.Name = "lbInvoice";
            this.lbInvoice.Size = new System.Drawing.Size(82, 29);
            this.lbInvoice.TabIndex = 0;
            this.lbInvoice.Text = "Invoice";
            this.lbInvoice.Click += new System.EventHandler(this.lbInvoice_Click);
            // 
            // pnMyOrders
            // 
            this.pnMyOrders.BackColor = System.Drawing.Color.White;
            this.pnMyOrders.Controls.Add(this.picMyOrders);
            this.pnMyOrders.Controls.Add(this.lbMyOrders);
            this.pnMyOrders.Location = new System.Drawing.Point(24, 358);
            this.pnMyOrders.Name = "pnMyOrders";
            this.pnMyOrders.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnMyOrders.Size = new System.Drawing.Size(258, 53);
            this.pnMyOrders.TabIndex = 11;
            this.pnMyOrders.Click += new System.EventHandler(this.pnMyOrders_Click);
            // 
            // picMyOrders
            // 
            this.picMyOrders.Image = global::WindowsFormsApp122.Properties.Resources.IconMyOrdersOff;
            this.picMyOrders.Location = new System.Drawing.Point(20, 8);
            this.picMyOrders.Name = "picMyOrders";
            this.picMyOrders.Size = new System.Drawing.Size(35, 35);
            this.picMyOrders.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMyOrders.TabIndex = 0;
            this.picMyOrders.TabStop = false;
            this.picMyOrders.Click += new System.EventHandler(this.picMyOrders_Click);
            // 
            // lbMyOrders
            // 
            this.lbMyOrders.AutoSize = true;
            this.lbMyOrders.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMyOrders.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbMyOrders.Location = new System.Drawing.Point(75, 13);
            this.lbMyOrders.Name = "lbMyOrders";
            this.lbMyOrders.Size = new System.Drawing.Size(114, 29);
            this.lbMyOrders.TabIndex = 0;
            this.lbMyOrders.Text = "My Orders";
            this.lbMyOrders.Click += new System.EventHandler(this.lbMyOrders_Click);
            // 
            // pnShoppingCart
            // 
            this.pnShoppingCart.BackColor = System.Drawing.Color.White;
            this.pnShoppingCart.Controls.Add(this.picShoppingCart);
            this.pnShoppingCart.Controls.Add(this.lbShoppingCart);
            this.pnShoppingCart.Location = new System.Drawing.Point(24, 287);
            this.pnShoppingCart.Name = "pnShoppingCart";
            this.pnShoppingCart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnShoppingCart.Size = new System.Drawing.Size(258, 53);
            this.pnShoppingCart.TabIndex = 10;
            this.pnShoppingCart.Click += new System.EventHandler(this.pnShoppingCart_Click);
            // 
            // picShoppingCart
            // 
            this.picShoppingCart.Image = global::WindowsFormsApp122.Properties.Resources.iconShoppingCartOff;
            this.picShoppingCart.Location = new System.Drawing.Point(20, 8);
            this.picShoppingCart.Name = "picShoppingCart";
            this.picShoppingCart.Size = new System.Drawing.Size(35, 35);
            this.picShoppingCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShoppingCart.TabIndex = 0;
            this.picShoppingCart.TabStop = false;
            this.picShoppingCart.Click += new System.EventHandler(this.picShoppingCart_Click);
            // 
            // lbShoppingCart
            // 
            this.lbShoppingCart.AutoSize = true;
            this.lbShoppingCart.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShoppingCart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbShoppingCart.Location = new System.Drawing.Point(75, 13);
            this.lbShoppingCart.Name = "lbShoppingCart";
            this.lbShoppingCart.Size = new System.Drawing.Size(146, 29);
            this.lbShoppingCart.TabIndex = 0;
            this.lbShoppingCart.Text = "Shopping Cart";
            this.lbShoppingCart.Click += new System.EventHandler(this.lbShoppingCart_Click);
            // 
            // pnDashboard
            // 
            this.pnDashboard.BackColor = System.Drawing.Color.White;
            this.pnDashboard.Controls.Add(this.picDashboard);
            this.pnDashboard.Controls.Add(this.lbDashboard);
            this.pnDashboard.Location = new System.Drawing.Point(24, 217);
            this.pnDashboard.Name = "pnDashboard";
            this.pnDashboard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnDashboard.Size = new System.Drawing.Size(258, 53);
            this.pnDashboard.TabIndex = 1;
            this.pnDashboard.Click += new System.EventHandler(this.pnDashboard_Click);
            this.pnDashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnDashboard_Paint);
            // 
            // picDashboard
            // 
            this.picDashboard.Image = global::WindowsFormsApp122.Properties.Resources.iconDashboardOn;
            this.picDashboard.Location = new System.Drawing.Point(20, 8);
            this.picDashboard.Name = "picDashboard";
            this.picDashboard.Size = new System.Drawing.Size(35, 35);
            this.picDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDashboard.TabIndex = 1;
            this.picDashboard.TabStop = false;
            this.picDashboard.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbDashboard
            // 
            this.lbDashboard.AutoSize = true;
            this.lbDashboard.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDashboard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbDashboard.Location = new System.Drawing.Point(75, 13);
            this.lbDashboard.Name = "lbDashboard";
            this.lbDashboard.Size = new System.Drawing.Size(116, 29);
            this.lbDashboard.TabIndex = 0;
            this.lbDashboard.Text = "Dashboard";
            this.lbDashboard.Click += new System.EventHandler(this.lbDashboard_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 581);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Help";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Main";
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.DimGray;
            this.pnHeader.Controls.Add(this.label9);
            this.pnHeader.Controls.Add(this.label8);
            this.pnHeader.Controls.Add(this.label7);
            this.pnHeader.Controls.Add(this.label6);
            this.pnHeader.Controls.Add(this.label5);
            this.pnHeader.Controls.Add(this.label4);
            this.pnHeader.Controls.Add(this.label1);
            this.pnHeader.Controls.Add(this.pictureBox2);
            this.pnHeader.Location = new System.Drawing.Point(384, 28);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1154, 78);
            this.pnHeader.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(944, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 29);
            this.label9.TabIndex = 8;
            this.label9.Text = "Accessories";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(759, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 29);
            this.label8.TabIndex = 7;
            this.label8.Text = "TV and Home";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(636, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "AirPods";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(501, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Watch";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(364, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "iPhone";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(251, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "iPad";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(140, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mac";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp122.Properties.Resources.Apple_logo_white;
            this.pictureBox2.Location = new System.Drawing.Point(23, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.pnHeader);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnSignOut.ResumeLayout(false);
            this.pnSignOut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSignOut)).EndInit();
            this.pnAboutUs.ResumeLayout(false);
            this.pnAboutUs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAboutUs)).EndInit();
            this.pnAccount.ResumeLayout(false);
            this.pnAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAccount)).EndInit();
            this.pnInvoice.ResumeLayout(false);
            this.pnInvoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInvoice)).EndInit();
            this.pnMyOrders.ResumeLayout(false);
            this.pnMyOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMyOrders)).EndInit();
            this.pnShoppingCart.ResumeLayout(false);
            this.pnShoppingCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShoppingCart)).EndInit();
            this.pnDashboard.ResumeLayout(false);
            this.pnDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDashboard)).EndInit();
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private ImageList imageList;
        private Panel pnAboutUs;
        private PictureBox picAboutUs;
        private Label lbAboutUs;
        private Panel pnAccount;
        private PictureBox picAccount;
        private Label lbAccount;
        private Panel pnInvoice;
        private PictureBox picInvoice;
        private Label lbInvoice;
        private Panel pnMyOrders;
        private PictureBox picMyOrders;
        private Label lbMyOrders;
        private Panel pnShoppingCart;
        private PictureBox picShoppingCart;
        private Label lbShoppingCart;
        private Panel pnDashboard;
        private PictureBox picDashboard;
        private Label lbDashboard;
        private Panel pnSignOut;
        private PictureBox picSignOut;
        private Label lbSignOut;
        private PictureBox pictureBox1;
        private Panel pnHeader;
        private PictureBox pictureBox2;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label1;
    }
}