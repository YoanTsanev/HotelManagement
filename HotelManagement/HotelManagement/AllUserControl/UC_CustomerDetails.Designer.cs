namespace HotelManagement.AllUserControl
{
    partial class UC_CustomerDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            label1 = new Label();
            txtSearchBy = new Guna.UI2.WinForms.Guna2ComboBox();
            label11 = new Label();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            label16 = new Label();
            label15 = new Label();
            label13 = new Label();
            label12 = new Label();
            label2 = new Label();
            label5 = new Label();
            label10 = new Label();
            label4 = new Label();
            label8 = new Label();
            label6 = new Label();
            label3 = new Label();
            label9 = new Label();
            label14 = new Label();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(292, 40);
            label1.TabIndex = 12;
            label1.Text = "Customer Details";
            // 
            // txtSearchBy
            // 
            txtSearchBy.BackColor = Color.Transparent;
            txtSearchBy.CustomizableEdges = customizableEdges1;
            txtSearchBy.DrawMode = DrawMode.OwnerDrawFixed;
            txtSearchBy.DropDownStyle = ComboBoxStyle.DropDownList;
            txtSearchBy.FocusedColor = Color.FromArgb(94, 148, 255);
            txtSearchBy.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearchBy.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearchBy.ForeColor = Color.FromArgb(64, 64, 64);
            txtSearchBy.ItemHeight = 30;
            txtSearchBy.Items.AddRange(new object[] { "All customer Details", "At the Hotel", "Checked Out Customers" });
            txtSearchBy.Location = new Point(520, 63);
            txtSearchBy.Name = "txtSearchBy";
            txtSearchBy.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtSearchBy.Size = new Size(330, 36);
            txtSearchBy.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtSearchBy.TabIndex = 25;
            txtSearchBy.SelectedIndexChanged += txtRoomType_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(520, 39);
            label11.Name = "label11";
            label11.Size = new Size(97, 21);
            label11.TabIndex = 24;
            label11.Text = "Serach By";
            label11.Click += label11_Click;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            guna2DataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView1.ColumnHeadersHeight = 4;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(20, 146);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowHeadersWidth = 51;
            guna2DataGridView1.RowTemplate.Height = 29;
            guna2DataGridView1.Size = new Size(1231, 406);
            guna2DataGridView1.TabIndex = 26;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            guna2DataGridView1.ThemeStyle.ReadOnly = false;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 29;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(1061, 123);
            label16.Name = "label16";
            label16.Size = new Size(50, 21);
            label16.TabIndex = 52;
            label16.Text = "Beds";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.Orange;
            label15.Location = new Point(771, 123);
            label15.Name = "label15";
            label15.Size = new Size(98, 21);
            label15.TabIndex = 51;
            label15.Text = "Check out";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(495, 122);
            label13.Name = "label13";
            label13.Size = new Size(52, 21);
            label13.TabIndex = 50;
            label13.Text = "ID №";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(401, 123);
            label12.Name = "label12";
            label12.Size = new Size(52, 21);
            label12.TabIndex = 49;
            label12.Text = "Bday";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(304, 122);
            label2.Name = "label2";
            label2.Size = new Size(74, 21);
            label2.TabIndex = 48;
            label2.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(202, 122);
            label5.Name = "label5";
            label5.Size = new Size(99, 21);
            label5.TabIndex = 47;
            label5.Text = "Nationality";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(585, 123);
            label10.Name = "label10";
            label10.Size = new Size(77, 21);
            label10.TabIndex = 46;
            label10.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(1154, 123);
            label4.Name = "label4";
            label4.Size = new Size(86, 21);
            label4.TabIndex = 45;
            label4.Text = "Fee Total";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(117, 123);
            label8.Name = "label8";
            label8.Size = new Size(67, 21);
            label8.TabIndex = 44;
            label8.Text = "Mobile";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(20, 122);
            label6.Name = "label6";
            label6.Size = new Size(61, 21);
            label6.TabIndex = 42;
            label6.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Green;
            label3.Location = new Point(683, 123);
            label3.Name = "label3";
            label3.Size = new Size(83, 21);
            label3.TabIndex = 53;
            label3.Text = "Check in";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(871, 122);
            label9.Name = "label9";
            label9.Size = new Size(81, 21);
            label9.TabIndex = 54;
            label9.Text = "Room №";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(966, 122);
            label14.Name = "label14";
            label14.Size = new Size(50, 21);
            label14.TabIndex = 55;
            label14.Text = "Price";
            // 
            // UC_CustomerDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label14);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label10);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(guna2DataGridView1);
            Controls.Add(txtSearchBy);
            Controls.Add(label11);
            Controls.Add(label1);
            Name = "UC_CustomerDetails";
            Size = new Size(1368, 648);
            Load += UC_CustomerDetails_Load;
            MouseClick += UC_CustomerDetails_MouseClick;
            MouseMove += UC_CustomerDetails_MouseMove;
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox txtSearchBy;
        private Label label11;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Label label16;
        private Label label15;
        private Label label13;
        private Label label12;
        private Label label2;
        private Label label5;
        private Label label10;
        private Label label4;
        private Label label8;
        private Label label6;
        private Label label3;
        private Label label14;
        private Label label9;
    }
}
