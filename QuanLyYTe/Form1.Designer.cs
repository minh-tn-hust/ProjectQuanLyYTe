
namespace QuanLyYTe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.loading = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btnTreem = new Guna.UI2.WinForms.Guna2Button();
            this.btnPhunu = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnPhunu);
            this.guna2Panel1.Controls.Add(this.btnTreem);
            this.guna2Panel1.Controls.Add(this.btnSearch);
            this.guna2Panel1.Controls.Add(this.guna2TextBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1070, 70);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TextBox1.BorderRadius = 20;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(567, 13);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(401, 45);
            this.guna2TextBox1.TabIndex = 1;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderRadius = 10;
            this.guna2Panel2.Controls.Add(this.loading);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 70);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(1070, 520);
            this.guna2Panel2.TabIndex = 1;
            // 
            // loading
            // 
            this.loading.AllowUserToDeleteRows = false;
            this.loading.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.loading.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.loading.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.loading.BackgroundColor = System.Drawing.Color.White;
            this.loading.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loading.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
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
            this.loading.Size = new System.Drawing.Size(1050, 520);
            this.loading.TabIndex = 0;
            this.loading.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.loading.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.loading.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.loading.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.loading.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.loading.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.loading.ThemeStyle.BackColor = System.Drawing.Color.White;
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
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Animated = true;
            this.btnSearch.BorderRadius = 20;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Location = new System.Drawing.Point(974, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(86, 45);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            // 
            // btnTreem
            // 
            this.btnTreem.AutoRoundedCorners = true;
            this.btnTreem.BackColor = System.Drawing.Color.Transparent;
            this.btnTreem.BorderRadius = 21;
            this.btnTreem.CheckedState.Parent = this.btnTreem;
            this.btnTreem.CustomImages.Parent = this.btnTreem;
            this.btnTreem.FillColor = System.Drawing.Color.Silver;
            this.btnTreem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTreem.ForeColor = System.Drawing.Color.White;
            this.btnTreem.HoverState.Parent = this.btnTreem;
            this.btnTreem.Location = new System.Drawing.Point(13, 12);
            this.btnTreem.Name = "btnTreem";
            this.btnTreem.ShadowDecoration.Parent = this.btnTreem;
            this.btnTreem.Size = new System.Drawing.Size(180, 45);
            this.btnTreem.TabIndex = 3;
            this.btnTreem.Text = "Danh sách trẻ em";
            this.btnTreem.UseTransparentBackground = true;
            this.btnTreem.Click += new System.EventHandler(this.btnTreem_Click);
            // 
            // btnPhunu
            // 
            this.btnPhunu.AutoRoundedCorners = true;
            this.btnPhunu.BackColor = System.Drawing.Color.Transparent;
            this.btnPhunu.BorderRadius = 21;
            this.btnPhunu.CheckedState.Parent = this.btnPhunu;
            this.btnPhunu.CustomImages.Parent = this.btnPhunu;
            this.btnPhunu.FillColor = System.Drawing.Color.Silver;
            this.btnPhunu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPhunu.ForeColor = System.Drawing.Color.White;
            this.btnPhunu.HoverState.Parent = this.btnPhunu;
            this.btnPhunu.Location = new System.Drawing.Point(200, 13);
            this.btnPhunu.Name = "btnPhunu";
            this.btnPhunu.ShadowDecoration.Parent = this.btnPhunu;
            this.btnPhunu.Size = new System.Drawing.Size(180, 45);
            this.btnPhunu.TabIndex = 4;
            this.btnPhunu.Text = "Danh sách phụ nữ mang thai";
            this.btnPhunu.UseTransparentBackground = true;
            this.btnPhunu.Click += new System.EventHandler(this.btnPhunu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 590);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2DataGridView loading;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnPhunu;
        private Guna.UI2.WinForms.Guna2Button btnTreem;
    }
}