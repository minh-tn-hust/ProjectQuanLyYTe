
namespace QuanLyYTe
{
    partial class PhuNuTreEm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhuNuTreEm));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.searchField = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnPhunu = new Guna.UI2.WinForms.Guna2Button();
            this.btnTreem = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.searchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.loading = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2ImageButton1);
            this.guna2Panel1.Controls.Add(this.searchField);
            this.guna2Panel1.Controls.Add(this.btnPhunu);
            this.guna2Panel1.Controls.Add(this.btnTreem);
            this.guna2Panel1.Controls.Add(this.btnSearch);
            this.guna2Panel1.Controls.Add(this.searchTextBox);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1070, 73);
            this.guna2Panel1.TabIndex = 0;
            // 
            // searchField
            // 
            this.searchField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchField.BackColor = System.Drawing.Color.Transparent;
            this.searchField.BorderRadius = 10;
            this.searchField.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.searchField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchField.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchField.FocusedState.Parent = this.searchField;
            this.searchField.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.searchField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.searchField.HoverState.Parent = this.searchField;
            this.searchField.ItemHeight = 30;
            this.searchField.Items.AddRange(new object[] {
            "Số CMND",
            "Họ và tên",
            "Số điện thoại"});
            this.searchField.ItemsAppearance.Parent = this.searchField;
            this.searchField.Location = new System.Drawing.Point(584, 18);
            this.searchField.Name = "searchField";
            this.searchField.ShadowDecoration.Parent = this.searchField;
            this.searchField.Size = new System.Drawing.Size(146, 36);
            this.searchField.TabIndex = 0;
            this.searchField.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // btnPhunu
            // 
            this.btnPhunu.AutoRoundedCorners = true;
            this.btnPhunu.BackColor = System.Drawing.Color.Transparent;
            this.btnPhunu.BorderRadius = 17;
            this.btnPhunu.CheckedState.Parent = this.btnPhunu;
            this.btnPhunu.CustomImages.Parent = this.btnPhunu;
            this.btnPhunu.FillColor = System.Drawing.Color.Silver;
            this.btnPhunu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPhunu.ForeColor = System.Drawing.Color.White;
            this.btnPhunu.HoverState.Parent = this.btnPhunu;
            this.btnPhunu.Location = new System.Drawing.Point(199, 18);
            this.btnPhunu.Name = "btnPhunu";
            this.btnPhunu.ShadowDecoration.Parent = this.btnPhunu;
            this.btnPhunu.Size = new System.Drawing.Size(180, 36);
            this.btnPhunu.TabIndex = 4;
            this.btnPhunu.Text = "Danh sách phụ nữ mang thai";
            this.btnPhunu.UseTransparentBackground = true;
            this.btnPhunu.Click += new System.EventHandler(this.btnPhunu_Click);
            // 
            // btnTreem
            // 
            this.btnTreem.AutoRoundedCorners = true;
            this.btnTreem.BackColor = System.Drawing.Color.Transparent;
            this.btnTreem.BorderRadius = 17;
            this.btnTreem.CheckedState.Parent = this.btnTreem;
            this.btnTreem.CustomImages.Parent = this.btnTreem;
            this.btnTreem.FillColor = System.Drawing.Color.Silver;
            this.btnTreem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTreem.ForeColor = System.Drawing.Color.White;
            this.btnTreem.HoverState.Parent = this.btnTreem;
            this.btnTreem.Location = new System.Drawing.Point(12, 18);
            this.btnTreem.Name = "btnTreem";
            this.btnTreem.ShadowDecoration.Parent = this.btnTreem;
            this.btnTreem.Size = new System.Drawing.Size(180, 36);
            this.btnTreem.TabIndex = 3;
            this.btnTreem.Text = "Danh sách trẻ em";
            this.btnTreem.UseTransparentBackground = true;
            this.btnTreem.Click += new System.EventHandler(this.btnTreem_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Animated = true;
            this.btnSearch.BorderRadius = 10;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Location = new System.Drawing.Point(974, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(86, 36);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.BorderRadius = 10;
            this.searchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTextBox.DefaultText = "";
            this.searchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTextBox.DisabledState.Parent = this.searchTextBox;
            this.searchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTextBox.FocusedState.Parent = this.searchTextBox;
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTextBox.HoverState.Parent = this.searchTextBox;
            this.searchTextBox.Location = new System.Drawing.Point(736, 18);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PasswordChar = '\0';
            this.searchTextBox.PlaceholderText = "";
            this.searchTextBox.SelectedText = "";
            this.searchTextBox.ShadowDecoration.Parent = this.searchTextBox;
            this.searchTextBox.Size = new System.Drawing.Size(232, 36);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderRadius = 10;
            this.guna2Panel2.Controls.Add(this.loading);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 73);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(1070, 502);
            this.guna2Panel2.TabIndex = 1;
            // 
            // loading
            // 
            this.loading.AllowUserToDeleteRows = false;
            this.loading.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.loading.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.loading.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.loading.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.loading.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loading.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.loading.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.loading.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.loading.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.loading.DefaultCellStyle = dataGridViewCellStyle3;
            this.loading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loading.EnableHeadersVisualStyles = false;
            this.loading.GridColor = System.Drawing.Color.White;
            this.loading.Location = new System.Drawing.Point(10, 0);
            this.loading.Name = "loading";
            this.loading.RowHeadersVisible = false;
            this.loading.RowTemplate.Height = 30;
            this.loading.RowTemplate.ReadOnly = true;
            this.loading.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.loading.Size = new System.Drawing.Size(1050, 502);
            this.loading.TabIndex = 0;
            this.loading.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.loading.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.loading.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.loading.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.loading.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.loading.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.loading.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.loading.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.loading.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.loading.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.loading.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.loading.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.loading.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.loading.ThemeStyle.HeaderStyle.Height = 40;
            this.loading.ThemeStyle.ReadOnly = false;
            this.loading.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.loading.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.loading.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.loading.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.loading.ThemeStyle.RowsStyle.Height = 30;
            this.loading.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.loading.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.loading.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loading_CellClick);
            this.loading.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loading_CellContentClick);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(36, 36);
            this.guna2ImageButton1.IndicateFocus = true;
            this.guna2ImageButton1.Location = new System.Drawing.Point(385, 15);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(44, 44);
            this.guna2ImageButton1.TabIndex = 11;
            this.guna2ImageButton1.UseTransparentBackground = true;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // PhuNuTreEm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 575);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "PhuNuTreEm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CausesValidationChanged += new System.EventHandler(this.Form1_CausesValidationChanged);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox searchTextBox;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2DataGridView loading;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnPhunu;
        private Guna.UI2.WinForms.Guna2Button btnTreem;
        private Guna.UI2.WinForms.Guna2ComboBox searchField;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
    }
}