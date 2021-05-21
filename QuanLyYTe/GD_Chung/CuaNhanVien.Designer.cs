namespace QuanLyYTe.GD_Chung
{
    partial class CuaNhanVien
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
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CuaNhanVien));
            this.mainMenuPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.MouseDetect = new System.Windows.Forms.Timer(this.components);
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.loadingFormPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.treemButton = new Guna.UI2.WinForms.Guna2Button();
            this.phunuButton = new Guna.UI2.WinForms.Guna2Button();
            this.booklichButton = new Guna.UI2.WinForms.Guna2Button();
            this.vacxinButton = new Guna.UI2.WinForms.Guna2Button();
            this.mainMenuPanel.SuspendLayout();
            this.loadingFormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuPanel
            // 
            this.mainMenuPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mainMenuPanel.Controls.Add(this.linkLabel1);
            this.mainMenuPanel.Controls.Add(this.label1);
            this.mainMenuPanel.Controls.Add(this.vacxinButton);
            this.mainMenuPanel.Controls.Add(this.booklichButton);
            this.mainMenuPanel.Controls.Add(this.phunuButton);
            this.mainMenuPanel.Controls.Add(this.treemButton);
            this.guna2Transition1.SetDecoration(this.mainMenuPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.mainMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.mainMenuPanel.Name = "mainMenuPanel";
            this.mainMenuPanel.ShadowDecoration.Parent = this.mainMenuPanel;
            this.mainMenuPanel.Size = new System.Drawing.Size(1122, 47);
            this.mainMenuPanel.TabIndex = 5;
            this.mainMenuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.linkLabel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.linkLabel1.Location = new System.Drawing.Point(14, 26);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(56, 13);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Đăng xuất";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Xin chào Trần Nhật Minh";
            // 
            // MouseDetect
            // 
            this.MouseDetect.Enabled = true;
            this.MouseDetect.Tick += new System.EventHandler(this.MouseDetect_Tick);
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation2;
            this.guna2Transition1.MaxAnimationTime = 500;
            this.guna2Transition1.TimeStep = 0.1F;
            // 
            // loadingFormPanel
            // 
            this.loadingFormPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loadingFormPanel.Controls.Add(this.guna2Button1);
            this.guna2Transition1.SetDecoration(this.loadingFormPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.loadingFormPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loadingFormPanel.Location = new System.Drawing.Point(0, 46);
            this.loadingFormPanel.Name = "loadingFormPanel";
            this.loadingFormPanel.ShadowDecoration.Parent = this.loadingFormPanel;
            this.loadingFormPanel.Size = new System.Drawing.Size(1122, 504);
            this.loadingFormPanel.TabIndex = 6;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Transition1.SetDecoration(this.guna2Button1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(461, 197);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "guna2Button1";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // treemButton
            // 
            this.treemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.treemButton.Animated = true;
            this.treemButton.BackColor = System.Drawing.Color.Transparent;
            this.treemButton.CheckedState.Parent = this.treemButton;
            this.treemButton.CustomImages.Parent = this.treemButton;
            this.guna2Transition1.SetDecoration(this.treemButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.treemButton.FillColor = System.Drawing.Color.Transparent;
            this.treemButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.treemButton.ForeColor = System.Drawing.Color.Black;
            this.treemButton.HoverState.Parent = this.treemButton;
            this.treemButton.Location = new System.Drawing.Point(562, 1);
            this.treemButton.Name = "treemButton";
            this.treemButton.ShadowDecoration.Parent = this.treemButton;
            this.treemButton.Size = new System.Drawing.Size(180, 45);
            this.treemButton.TabIndex = 5;
            this.treemButton.Text = "Trẻ em";
            this.treemButton.Click += new System.EventHandler(this.treemButton_Click);
            // 
            // phunuButton
            // 
            this.phunuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phunuButton.Animated = true;
            this.phunuButton.BackColor = System.Drawing.Color.Transparent;
            this.phunuButton.CheckedState.Parent = this.phunuButton;
            this.phunuButton.CustomImages.Parent = this.phunuButton;
            this.guna2Transition1.SetDecoration(this.phunuButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.phunuButton.FillColor = System.Drawing.Color.Transparent;
            this.phunuButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.phunuButton.ForeColor = System.Drawing.Color.Black;
            this.phunuButton.HoverState.Parent = this.phunuButton;
            this.phunuButton.Location = new System.Drawing.Point(748, 1);
            this.phunuButton.Name = "phunuButton";
            this.phunuButton.ShadowDecoration.Parent = this.phunuButton;
            this.phunuButton.Size = new System.Drawing.Size(180, 45);
            this.phunuButton.TabIndex = 6;
            this.phunuButton.Text = "Phụ nữ mang thai";
            this.phunuButton.Click += new System.EventHandler(this.phunuButton_Click);
            // 
            // booklichButton
            // 
            this.booklichButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.booklichButton.Animated = true;
            this.booklichButton.BackColor = System.Drawing.Color.Transparent;
            this.booklichButton.CheckedState.Parent = this.booklichButton;
            this.booklichButton.CustomImages.Parent = this.booklichButton;
            this.guna2Transition1.SetDecoration(this.booklichButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.booklichButton.FillColor = System.Drawing.Color.Transparent;
            this.booklichButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.booklichButton.ForeColor = System.Drawing.Color.Black;
            this.booklichButton.HoverState.Parent = this.booklichButton;
            this.booklichButton.Location = new System.Drawing.Point(934, 1);
            this.booklichButton.Name = "booklichButton";
            this.booklichButton.ShadowDecoration.Parent = this.booklichButton;
            this.booklichButton.Size = new System.Drawing.Size(180, 45);
            this.booklichButton.TabIndex = 7;
            this.booklichButton.Text = "Đặt lịch khám";
            this.booklichButton.Click += new System.EventHandler(this.booklichButton_Click);
            // 
            // vacxinButton
            // 
            this.vacxinButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vacxinButton.Animated = true;
            this.vacxinButton.BackColor = System.Drawing.Color.Transparent;
            this.vacxinButton.CheckedState.Parent = this.vacxinButton;
            this.vacxinButton.CustomImages.Parent = this.vacxinButton;
            this.guna2Transition1.SetDecoration(this.vacxinButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.vacxinButton.FillColor = System.Drawing.Color.Transparent;
            this.vacxinButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.vacxinButton.ForeColor = System.Drawing.Color.Black;
            this.vacxinButton.HoverState.Parent = this.vacxinButton;
            this.vacxinButton.Location = new System.Drawing.Point(376, 1);
            this.vacxinButton.Name = "vacxinButton";
            this.vacxinButton.ShadowDecoration.Parent = this.vacxinButton;
            this.vacxinButton.Size = new System.Drawing.Size(180, 45);
            this.vacxinButton.TabIndex = 8;
            this.vacxinButton.Text = "Tiêm Vắc Xin";
            this.vacxinButton.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // CuaNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 550);
            this.Controls.Add(this.loadingFormPanel);
            this.Controls.Add(this.mainMenuPanel);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Name = "CuaNhanVien";
            this.Text = "CuaNhanVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MaximizedBoundsChanged += new System.EventHandler(this.CuaNhanVien_MaximizedBoundsChanged);
            this.Load += new System.EventHandler(this.CuaNhanVien_Load);
            this.Resize += new System.EventHandler(this.CuaNhanVien_Resize);
            this.mainMenuPanel.ResumeLayout(false);
            this.mainMenuPanel.PerformLayout();
            this.loadingFormPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel mainMenuPanel;
        private System.Windows.Forms.Timer MouseDetect;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel loadingFormPanel;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button booklichButton;
        private Guna.UI2.WinForms.Guna2Button phunuButton;
        private Guna.UI2.WinForms.Guna2Button vacxinButton;
        private Guna.UI2.WinForms.Guna2Button treemButton;
    }
}