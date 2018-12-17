namespace Images_Haralick_Descriptor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sidepanel = new System.Windows.Forms.Panel();
            this.ListofImage = new System.Windows.Forms.ListView();
            this.img = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Borderpnl2 = new System.Windows.Forms.Panel();
            this.Borderpnl1 = new System.Windows.Forms.Panel();
            this.bordermenu = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Data_label = new System.Windows.Forms.TextBox();
            this.Label = new System.Windows.Forms.Label();
            this.underline = new System.Windows.Forms.Label();
            this.menubar = new System.Windows.Forms.Panel();
            this.Sidepanelright = new System.Windows.Forms.Panel();
            this.Datasets = new System.Windows.Forms.DataGridView();
            this.Extractbtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.NewDatabtn = new System.Windows.Forms.Button();
            this.Opendatasetbtn = new System.Windows.Forms.Button();
            this.Openfolderbtn = new System.Windows.Forms.Button();
            this.Openfilefolder = new System.Windows.Forms.Button();
            this.Minimizebtn = new System.Windows.Forms.Button();
            this.Closebtn = new System.Windows.Forms.Button();
            this.Gitpagebtn = new System.Windows.Forms.Panel();
            this.SelectedPict = new System.Windows.Forms.PictureBox();
            this.sidepanel.SuspendLayout();
            this.Borderpnl1.SuspendLayout();
            this.bordermenu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menubar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datasets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedPict)).BeginInit();
            this.SuspendLayout();
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sidepanel.Controls.Add(this.ListofImage);
            this.sidepanel.Controls.Add(this.Gitpagebtn);
            this.sidepanel.Controls.Add(this.SelectedPict);
            this.sidepanel.Controls.Add(this.Borderpnl2);
            this.sidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidepanel.Location = new System.Drawing.Point(0, 0);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(170, 596);
            this.sidepanel.TabIndex = 0;
            // 
            // ListofImage
            // 
            this.ListofImage.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.ListofImage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListofImage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.img});
            this.ListofImage.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListofImage.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ListofImage.Location = new System.Drawing.Point(12, 158);
            this.ListofImage.Name = "ListofImage";
            this.ListofImage.Size = new System.Drawing.Size(145, 322);
            this.ListofImage.TabIndex = 4;
            this.ListofImage.UseCompatibleStateImageBehavior = false;
            this.ListofImage.View = System.Windows.Forms.View.Details;
            this.ListofImage.SelectedIndexChanged += new System.EventHandler(this.ListofImage_SelectedIndexChanged);
            // 
            // img
            // 
            this.img.Text = "Images";
            this.img.Width = 150;
            // 
            // Borderpnl2
            // 
            this.Borderpnl2.BackColor = System.Drawing.Color.Gold;
            this.Borderpnl2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Borderpnl2.Location = new System.Drawing.Point(12, 0);
            this.Borderpnl2.Name = "Borderpnl2";
            this.Borderpnl2.Size = new System.Drawing.Size(158, 35);
            this.Borderpnl2.TabIndex = 1;
            this.Borderpnl2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Borderpnl2_MouseDown);
            this.Borderpnl2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Borderpnl2_MouseMove);
            this.Borderpnl2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Borderpnl2_MouseUp);
            // 
            // Borderpnl1
            // 
            this.Borderpnl1.BackColor = System.Drawing.Color.Gold;
            this.Borderpnl1.Controls.Add(this.bordermenu);
            this.Borderpnl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Borderpnl1.Location = new System.Drawing.Point(170, 0);
            this.Borderpnl1.Name = "Borderpnl1";
            this.Borderpnl1.Size = new System.Drawing.Size(694, 35);
            this.Borderpnl1.TabIndex = 1;
            this.Borderpnl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Borderpnl1_MouseDown);
            this.Borderpnl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Borderpnl1_MouseMove);
            this.Borderpnl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Borderpnl1_MouseUp);
            // 
            // bordermenu
            // 
            this.bordermenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bordermenu.Controls.Add(this.Minimizebtn);
            this.bordermenu.Controls.Add(this.Closebtn);
            this.bordermenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.bordermenu.Location = new System.Drawing.Point(593, 0);
            this.bordermenu.Name = "bordermenu";
            this.bordermenu.Size = new System.Drawing.Size(101, 35);
            this.bordermenu.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.Data_label);
            this.panel3.Controls.Add(this.Label);
            this.panel3.Controls.Add(this.underline);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(170, 480);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(694, 116);
            this.panel3.TabIndex = 2;
            // 
            // Data_label
            // 
            this.Data_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Data_label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Data_label.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data_label.ForeColor = System.Drawing.Color.Gold;
            this.Data_label.Location = new System.Drawing.Point(35, 61);
            this.Data_label.Name = "Data_label";
            this.Data_label.Size = new System.Drawing.Size(163, 19);
            this.Data_label.TabIndex = 1;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.ForeColor = System.Drawing.Color.Gold;
            this.Label.Location = new System.Drawing.Point(30, 21);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(78, 18);
            this.Label.TabIndex = 0;
            this.Label.Text = "Label :";
            // 
            // underline
            // 
            this.underline.AutoSize = true;
            this.underline.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underline.ForeColor = System.Drawing.Color.Gold;
            this.underline.Location = new System.Drawing.Point(30, 64);
            this.underline.Name = "underline";
            this.underline.Size = new System.Drawing.Size(179, 23);
            this.underline.TabIndex = 2;
            this.underline.Text = "_____________";
            // 
            // menubar
            // 
            this.menubar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menubar.Controls.Add(this.Extractbtn);
            this.menubar.Controls.Add(this.Savebtn);
            this.menubar.Controls.Add(this.NewDatabtn);
            this.menubar.Controls.Add(this.Opendatasetbtn);
            this.menubar.Controls.Add(this.Openfolderbtn);
            this.menubar.Controls.Add(this.Openfilefolder);
            this.menubar.Dock = System.Windows.Forms.DockStyle.Top;
            this.menubar.Location = new System.Drawing.Point(170, 35);
            this.menubar.Name = "menubar";
            this.menubar.Size = new System.Drawing.Size(694, 50);
            this.menubar.TabIndex = 5;
            // 
            // Sidepanelright
            // 
            this.Sidepanelright.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Sidepanelright.Dock = System.Windows.Forms.DockStyle.Right;
            this.Sidepanelright.Location = new System.Drawing.Point(854, 85);
            this.Sidepanelright.Name = "Sidepanelright";
            this.Sidepanelright.Size = new System.Drawing.Size(10, 395);
            this.Sidepanelright.TabIndex = 6;
            // 
            // Datasets
            // 
            this.Datasets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Datasets.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.Datasets.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Datasets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.Datasets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Datasets.DefaultCellStyle = dataGridViewCellStyle8;
            this.Datasets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Datasets.EnableHeadersVisualStyles = false;
            this.Datasets.Location = new System.Drawing.Point(170, 85);
            this.Datasets.Name = "Datasets";
            this.Datasets.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Datasets.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.Datasets.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Datasets.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Datasets.Size = new System.Drawing.Size(684, 395);
            this.Datasets.TabIndex = 7;
            // 
            // Extractbtn
            // 
            this.Extractbtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.Extractbtn.FlatAppearance.BorderSize = 0;
            this.Extractbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Extractbtn.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Extractbtn.ForeColor = System.Drawing.Color.White;
            this.Extractbtn.Image = global::Images_Haralick_Descriptor.Properties.Resources._25pxArtboard_8;
            this.Extractbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Extractbtn.Location = new System.Drawing.Point(567, 0);
            this.Extractbtn.Name = "Extractbtn";
            this.Extractbtn.Size = new System.Drawing.Size(111, 50);
            this.Extractbtn.TabIndex = 9;
            this.Extractbtn.Text = "Extract";
            this.Extractbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Extractbtn.UseVisualStyleBackColor = true;
            this.Extractbtn.Click += new System.EventHandler(this.Extractbtn_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.Savebtn.FlatAppearance.BorderSize = 0;
            this.Savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Savebtn.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savebtn.ForeColor = System.Drawing.Color.White;
            this.Savebtn.Image = global::Images_Haralick_Descriptor.Properties.Resources._25pxArtboard_5;
            this.Savebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Savebtn.Location = new System.Drawing.Point(498, 0);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(69, 50);
            this.Savebtn.TabIndex = 7;
            this.Savebtn.Text = "Save";
            this.Savebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // NewDatabtn
            // 
            this.NewDatabtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.NewDatabtn.FlatAppearance.BorderSize = 0;
            this.NewDatabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewDatabtn.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewDatabtn.ForeColor = System.Drawing.Color.White;
            this.NewDatabtn.Image = global::Images_Haralick_Descriptor.Properties.Resources._25pxArtboard_6;
            this.NewDatabtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewDatabtn.Location = new System.Drawing.Point(370, 0);
            this.NewDatabtn.Name = "NewDatabtn";
            this.NewDatabtn.Size = new System.Drawing.Size(128, 50);
            this.NewDatabtn.TabIndex = 8;
            this.NewDatabtn.Text = "New Datasets";
            this.NewDatabtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NewDatabtn.UseVisualStyleBackColor = true;
            this.NewDatabtn.Click += new System.EventHandler(this.NewDatabtn_Click);
            // 
            // Opendatasetbtn
            // 
            this.Opendatasetbtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.Opendatasetbtn.FlatAppearance.BorderSize = 0;
            this.Opendatasetbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Opendatasetbtn.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Opendatasetbtn.ForeColor = System.Drawing.Color.White;
            this.Opendatasetbtn.Image = global::Images_Haralick_Descriptor.Properties.Resources._25pxArtboard_4;
            this.Opendatasetbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Opendatasetbtn.Location = new System.Drawing.Point(230, 0);
            this.Opendatasetbtn.Name = "Opendatasetbtn";
            this.Opendatasetbtn.Size = new System.Drawing.Size(140, 50);
            this.Opendatasetbtn.TabIndex = 2;
            this.Opendatasetbtn.Text = "Open Datasets";
            this.Opendatasetbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Opendatasetbtn.UseVisualStyleBackColor = true;
            this.Opendatasetbtn.Click += new System.EventHandler(this.Opendatasetbtn_Click);
            // 
            // Openfolderbtn
            // 
            this.Openfolderbtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.Openfolderbtn.FlatAppearance.BorderSize = 0;
            this.Openfolderbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Openfolderbtn.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Openfolderbtn.ForeColor = System.Drawing.Color.White;
            this.Openfolderbtn.Image = global::Images_Haralick_Descriptor.Properties.Resources._25pxArtboard_3;
            this.Openfolderbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Openfolderbtn.Location = new System.Drawing.Point(112, 0);
            this.Openfolderbtn.Name = "Openfolderbtn";
            this.Openfolderbtn.Size = new System.Drawing.Size(118, 50);
            this.Openfolderbtn.TabIndex = 1;
            this.Openfolderbtn.Text = "Open Folder";
            this.Openfolderbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Openfolderbtn.UseVisualStyleBackColor = true;
            this.Openfolderbtn.Click += new System.EventHandler(this.Openfolderbtn_Click);
            // 
            // Openfilefolder
            // 
            this.Openfilefolder.Dock = System.Windows.Forms.DockStyle.Left;
            this.Openfilefolder.FlatAppearance.BorderSize = 0;
            this.Openfilefolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Openfilefolder.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Openfilefolder.ForeColor = System.Drawing.Color.White;
            this.Openfilefolder.Image = global::Images_Haralick_Descriptor.Properties.Resources._25pxArtboard_2;
            this.Openfilefolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Openfilefolder.Location = new System.Drawing.Point(0, 0);
            this.Openfilefolder.Name = "Openfilefolder";
            this.Openfilefolder.Size = new System.Drawing.Size(112, 50);
            this.Openfilefolder.TabIndex = 1;
            this.Openfilefolder.Text = "Open File";
            this.Openfilefolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Openfilefolder.UseVisualStyleBackColor = true;
            this.Openfilefolder.Click += new System.EventHandler(this.Openfilefolder_Click);
            // 
            // Minimizebtn
            // 
            this.Minimizebtn.BackgroundImage = global::Images_Haralick_Descriptor.Properties.Resources._25pxArtboard_7;
            this.Minimizebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Minimizebtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Minimizebtn.FlatAppearance.BorderSize = 0;
            this.Minimizebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimizebtn.Location = new System.Drawing.Point(3, 0);
            this.Minimizebtn.Name = "Minimizebtn";
            this.Minimizebtn.Size = new System.Drawing.Size(49, 35);
            this.Minimizebtn.TabIndex = 1;
            this.Minimizebtn.UseVisualStyleBackColor = true;
            this.Minimizebtn.Click += new System.EventHandler(this.Minimizebtn_Click);
            // 
            // Closebtn
            // 
            this.Closebtn.BackgroundImage = global::Images_Haralick_Descriptor.Properties.Resources._25pxArtboard_1;
            this.Closebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Closebtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Closebtn.FlatAppearance.BorderSize = 0;
            this.Closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Closebtn.Location = new System.Drawing.Point(52, 0);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(49, 35);
            this.Closebtn.TabIndex = 0;
            this.Closebtn.UseVisualStyleBackColor = true;
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // Gitpagebtn
            // 
            this.Gitpagebtn.BackColor = System.Drawing.Color.Gold;
            this.Gitpagebtn.BackgroundImage = global::Images_Haralick_Descriptor.Properties.Resources._512pxArtboard_7;
            this.Gitpagebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Gitpagebtn.Location = new System.Drawing.Point(12, 35);
            this.Gitpagebtn.Name = "Gitpagebtn";
            this.Gitpagebtn.Size = new System.Drawing.Size(145, 117);
            this.Gitpagebtn.TabIndex = 3;
            // 
            // SelectedPict
            // 
            this.SelectedPict.Location = new System.Drawing.Point(12, 490);
            this.SelectedPict.Name = "SelectedPict";
            this.SelectedPict.Size = new System.Drawing.Size(145, 98);
            this.SelectedPict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SelectedPict.TabIndex = 2;
            this.SelectedPict.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(864, 596);
            this.Controls.Add(this.Datasets);
            this.Controls.Add(this.Sidepanelright);
            this.Controls.Add(this.menubar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Borderpnl1);
            this.Controls.Add(this.sidepanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Haralick Image Descriptor";
            this.sidepanel.ResumeLayout(false);
            this.Borderpnl1.ResumeLayout(false);
            this.bordermenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menubar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Datasets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedPict)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Button Opendatasetbtn;
        private System.Windows.Forms.Button Openfilefolder;
        private System.Windows.Forms.Button Openfolderbtn;
        private System.Windows.Forms.Panel Borderpnl1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel menubar;
        private System.Windows.Forms.PictureBox SelectedPict;
        private System.Windows.Forms.Panel Sidepanelright;
        private System.Windows.Forms.TextBox Data_label;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label underline;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button Closebtn;
        private System.Windows.Forms.Panel bordermenu;
        private System.Windows.Forms.Button Minimizebtn;
        private System.Windows.Forms.Panel Borderpnl2;
        private System.Windows.Forms.Panel Gitpagebtn;
        private System.Windows.Forms.DataGridView Datasets;
        private System.Windows.Forms.Button NewDatabtn;
        private System.Windows.Forms.ListView ListofImage;
        private System.Windows.Forms.ColumnHeader img;
        private System.Windows.Forms.Button Extractbtn;
    }
}

