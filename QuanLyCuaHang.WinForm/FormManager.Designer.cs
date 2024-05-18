﻿namespace QuanLyCuaHang.WinForm
{
    partial class FormManager
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
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.thôngTinTàiKhoảnToolStripMenuItem = new Guna.UI2.WinForms.Guna2Button();
            this.adminToolStripMenuItem = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nmFoodCount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btnAddFood = new Guna.UI2.WinForms.Guna2Button();
            this.cbFood = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbSwitchTable = new Guna.UI2.WinForms.Guna2ComboBox();
            this.nmDisCount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btnDiscount = new Guna.UI2.WinForms.Guna2Button();
            this.btnSwitchTable = new Guna.UI2.WinForms.Guna2Button();
            this.btnChenkOut = new Guna.UI2.WinForms.Guna2Button();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.txbTotalPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sidebar.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDisCount)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sidebar.Controls.Add(this.guna2Panel2);
            this.sidebar.Controls.Add(this.thôngTinTàiKhoảnToolStripMenuItem);
            this.sidebar.Controls.Add(this.adminToolStripMenuItem);
            this.sidebar.Controls.Add(this.guna2Button1);
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(136, 467);
            this.sidebar.MinimumSize = new System.Drawing.Size(52, 467);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(136, 467);
            this.sidebar.TabIndex = 2;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_Paint);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.guna2Panel1);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Controls.Add(this.menuButton);
            this.guna2Panel2.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(132, 85);
            this.guna2Panel2.TabIndex = 4;
            this.guna2Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Location = new System.Drawing.Point(0, 85);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(132, 42);
            this.guna2Panel1.TabIndex = 3;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(57, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuButton
            // 
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Image = global::QuanLyCuaHang.WinForm.Properties.Resources.menu;
            this.menuButton.Location = new System.Drawing.Point(0, 18);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(48, 38);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.menuButton.TabIndex = 0;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.thôngTinTàiKhoảnToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.thôngTinTàiKhoảnToolStripMenuItem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.thôngTinTàiKhoảnToolStripMenuItem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.thôngTinTàiKhoảnToolStripMenuItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.thôngTinTàiKhoảnToolStripMenuItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.thôngTinTàiKhoảnToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.thôngTinTàiKhoảnToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.thôngTinTàiKhoảnToolStripMenuItem.Image = global::QuanLyCuaHang.WinForm.Properties.Resources.user;
            this.thôngTinTàiKhoảnToolStripMenuItem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.thôngTinTàiKhoảnToolStripMenuItem.IndicateFocus = true;
            this.thôngTinTàiKhoảnToolStripMenuItem.Location = new System.Drawing.Point(3, 94);
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(135, 36);
            this.thôngTinTàiKhoảnToolStripMenuItem.TabIndex = 4;
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            this.thôngTinTàiKhoảnToolStripMenuItem.UseTransparentBackground = true;
            this.thôngTinTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.adminToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.adminToolStripMenuItem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.adminToolStripMenuItem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.adminToolStripMenuItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.adminToolStripMenuItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.adminToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.adminToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.adminToolStripMenuItem.Image = global::QuanLyCuaHang.WinForm.Properties.Resources.home;
            this.adminToolStripMenuItem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.adminToolStripMenuItem.Location = new System.Drawing.Point(3, 136);
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(132, 38);
            this.adminToolStripMenuItem.TabIndex = 5;
            this.adminToolStripMenuItem.Text = "Quản Lý";
            this.adminToolStripMenuItem.UseTransparentBackground = true;
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::QuanLyCuaHang.WinForm.Properties.Resources.power_off;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.Location = new System.Drawing.Point(3, 180);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.guna2Button1.Size = new System.Drawing.Size(132, 38);
            this.guna2Button1.TabIndex = 7;
            this.guna2Button1.Text = "Đăng xuất";
            this.guna2Button1.UseTransparentBackground = true;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer__Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsvBill);
            this.panel2.Location = new System.Drawing.Point(144, 224);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(519, 231);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.nmFoodCount);
            this.panel3.Controls.Add(this.btnAddFood);
            this.panel3.Controls.Add(this.cbFood);
            this.panel3.Controls.Add(this.cbCategory);
            this.panel3.Location = new System.Drawing.Point(669, 224);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(615, 100);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // nmFoodCount
            // 
            this.nmFoodCount.BackColor = System.Drawing.Color.Transparent;
            this.nmFoodCount.BorderRadius = 10;
            this.nmFoodCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nmFoodCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nmFoodCount.Location = new System.Drawing.Point(499, 9);
            this.nmFoodCount.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nmFoodCount.Minimum = new decimal(new int[] {
            99,
            0,
            0,
            -2147483648});
            this.nmFoodCount.Name = "nmFoodCount";
            this.nmFoodCount.Size = new System.Drawing.Size(100, 36);
            this.nmFoodCount.TabIndex = 3;
            this.nmFoodCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmFoodCount.ValueChanged += new System.EventHandler(this.guna2NumericUpDown1_ValueChanged);
            // 
            // btnAddFood
            // 
            this.btnAddFood.BorderRadius = 10;
            this.btnAddFood.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddFood.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddFood.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddFood.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddFood.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddFood.ForeColor = System.Drawing.Color.White;
            this.btnAddFood.Location = new System.Drawing.Point(499, 59);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(100, 27);
            this.btnAddFood.TabIndex = 2;
            this.btnAddFood.Text = "Thêm món";
            this.btnAddFood.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // cbFood
            // 
            this.cbFood.AutoRoundedCorners = true;
            this.cbFood.BackColor = System.Drawing.Color.Transparent;
            this.cbFood.BorderRadius = 17;
            this.cbFood.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFood.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFood.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFood.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFood.ItemHeight = 30;
            this.cbFood.Location = new System.Drawing.Point(3, 55);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(482, 36);
            this.cbFood.TabIndex = 1;
            this.cbFood.SelectedIndexChanged += new System.EventHandler(this.cbFood_SelectedIndexChanged);
            // 
            // cbCategory
            // 
            this.cbCategory.AutoRoundedCorners = true;
            this.cbCategory.BackColor = System.Drawing.Color.Transparent;
            this.cbCategory.BorderRadius = 17;
            this.cbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbCategory.ItemHeight = 30;
            this.cbCategory.Location = new System.Drawing.Point(3, 8);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(482, 36);
            this.cbCategory.TabIndex = 0;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txbTotalPrice);
            this.panel4.Controls.Add(this.cbSwitchTable);
            this.panel4.Controls.Add(this.nmDisCount);
            this.panel4.Controls.Add(this.btnDiscount);
            this.panel4.Controls.Add(this.btnSwitchTable);
            this.panel4.Controls.Add(this.btnChenkOut);
            this.panel4.Location = new System.Drawing.Point(669, 330);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(615, 125);
            this.panel4.TabIndex = 6;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // cbSwitchTable
            // 
            this.cbSwitchTable.AutoRoundedCorners = true;
            this.cbSwitchTable.BackColor = System.Drawing.Color.Transparent;
            this.cbSwitchTable.BorderRadius = 17;
            this.cbSwitchTable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSwitchTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSwitchTable.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSwitchTable.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSwitchTable.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSwitchTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSwitchTable.ItemHeight = 30;
            this.cbSwitchTable.Location = new System.Drawing.Point(27, 68);
            this.cbSwitchTable.Name = "cbSwitchTable";
            this.cbSwitchTable.Size = new System.Drawing.Size(153, 36);
            this.cbSwitchTable.TabIndex = 5;
            // 
            // nmDisCount
            // 
            this.nmDisCount.BackColor = System.Drawing.Color.Transparent;
            this.nmDisCount.BorderRadius = 10;
            this.nmDisCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nmDisCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nmDisCount.Location = new System.Drawing.Point(227, 68);
            this.nmDisCount.Name = "nmDisCount";
            this.nmDisCount.Size = new System.Drawing.Size(127, 36);
            this.nmDisCount.TabIndex = 4;
            this.nmDisCount.ValueChanged += new System.EventHandler(this.guna2NumericUpDown1_ValueChanged_1);
            // 
            // btnDiscount
            // 
            this.btnDiscount.BorderRadius = 10;
            this.btnDiscount.DefaultAutoSize = true;
            this.btnDiscount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDiscount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDiscount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDiscount.ForeColor = System.Drawing.Color.White;
            this.btnDiscount.Location = new System.Drawing.Point(227, 35);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(127, 27);
            this.btnDiscount.TabIndex = 2;
            this.btnDiscount.Text = "Áp dụng giảm giá";
            this.btnDiscount.Click += new System.EventHandler(this.guna2Button6_Click);
            // 
            // btnSwitchTable
            // 
            this.btnSwitchTable.BorderRadius = 10;
            this.btnSwitchTable.DefaultAutoSize = true;
            this.btnSwitchTable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSwitchTable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSwitchTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSwitchTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSwitchTable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSwitchTable.ForeColor = System.Drawing.Color.White;
            this.btnSwitchTable.Location = new System.Drawing.Point(27, 35);
            this.btnSwitchTable.Name = "btnSwitchTable";
            this.btnSwitchTable.Size = new System.Drawing.Size(153, 27);
            this.btnSwitchTable.TabIndex = 1;
            this.btnSwitchTable.Text = "Gộp bàn - Chuyển bàn";
            this.btnSwitchTable.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // btnChenkOut
            // 
            this.btnChenkOut.BorderRadius = 10;
            this.btnChenkOut.DefaultAutoSize = true;
            this.btnChenkOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChenkOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChenkOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChenkOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChenkOut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChenkOut.ForeColor = System.Drawing.Color.White;
            this.btnChenkOut.Location = new System.Drawing.Point(459, 35);
            this.btnChenkOut.Name = "btnChenkOut";
            this.btnChenkOut.Size = new System.Drawing.Size(140, 27);
            this.btnChenkOut.TabIndex = 0;
            this.btnChenkOut.Text = "Thanh toán hóa đơn";
            this.btnChenkOut.Click += new System.EventHandler(this.guna2Button4_Click_1);
            // 
            // flpTable
            // 
            this.flpTable.Location = new System.Drawing.Point(144, 3);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(1140, 215);
            this.flpTable.TabIndex = 7;
            this.flpTable.Paint += new System.Windows.Forms.PaintEventHandler(this.flpTable_Paint);
            // 
            // lsvBill
            // 
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(3, 3);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(513, 225);
            this.lsvBill.TabIndex = 0;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.SelectedIndexChanged += new System.EventHandler(this.lsvBill_SelectedIndexChanged);
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.BorderRadius = 15;
            this.txbTotalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbTotalPrice.DefaultText = "0";
            this.txbTotalPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbTotalPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbTotalPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbTotalPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbTotalPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbTotalPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbTotalPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbTotalPrice.Location = new System.Drawing.Point(479, 68);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.PasswordChar = '\0';
            this.txbTotalPrice.PlaceholderText = "";
            this.txbTotalPrice.SelectedText = "";
            this.txbTotalPrice.Size = new System.Drawing.Size(110, 36);
            this.txbTotalPrice.TabIndex = 6;
            this.txbTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbTotalPrice.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Mặt Hàng";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số Lượng";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn Giá";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành Tiền";
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 467);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.sidebar);
            this.Name = "FormManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.FormManager_Load);
            this.sidebar.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDisCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button thôngTinTàiKhoảnToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button adminToolStripMenuItem;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer sidebarTimer;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2ComboBox cbCategory;
        private Guna.UI2.WinForms.Guna2ComboBox cbFood;
        private Guna.UI2.WinForms.Guna2Button btnAddFood;
        private Guna.UI2.WinForms.Guna2NumericUpDown nmFoodCount;
        private Guna.UI2.WinForms.Guna2Button btnChenkOut;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private Guna.UI2.WinForms.Guna2Button btnDiscount;
        private Guna.UI2.WinForms.Guna2Button btnSwitchTable;
        private Guna.UI2.WinForms.Guna2NumericUpDown nmDisCount;
        private Guna.UI2.WinForms.Guna2ComboBox cbSwitchTable;
        private System.Windows.Forms.ListView lsvBill;
        private Guna.UI2.WinForms.Guna2TextBox txbTotalPrice;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}