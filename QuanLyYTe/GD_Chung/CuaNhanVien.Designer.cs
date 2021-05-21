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
            Guna.UI2.AnimatorNS.Animation animation8 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CuaNhanVien));
            this.mainMenuPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.vacxinButton = new Guna.UI2.WinForms.Guna2Button();
            this.booklichButton = new Guna.UI2.WinForms.Guna2Button();
            this.phunuButton = new Guna.UI2.WinForms.Guna2Button();
            this.treemButton = new Guna.UI2.WinForms.Guna2Button();
            this.MouseDetect = new System.Windows.Forms.Timer(this.components);
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.loadingFormPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.mainMenuPanel.SuspendLayout();
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
            // vacxinButton
            // 
            this.vacxinButton.Animated = true;
            this.vacxinButton.BackColor = System.Drawing.Color.Transparent;
            this.vacxinButton.CheckedState.Parent = this.vacxinButton;
            this.vacxinButton.CustomImages.Parent = this.vacxinButton;
            this.guna2Transition1.SetDecoration(this.vacxinButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.vacxinButton.FillColor = System.Drawing.Color.Transparent;
            this.vacxinButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.vacxinButton.ForeColor = System.Drawing.Color.Black;
            this.vacxinButton.HoverState.Parent = this.vacxinButton;
            this.vacxinButton.Location = new System.Drawing.Point(341, 1);
            this.vacxinButton.Name = "vacxinButton";
            this.vacxinButton.ShadowDecoration.Parent = this.vacxinButton;
            this.vacxinButton.Size = new System.Drawing.Size(180, 45);
            this.vacxinButton.TabIndex = 8;
            this.vacxinButton.Text = "Tiêm Vắc Xin";
            this.vacxinButton.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // booklichButton
            // 
            this.booklichButton.Animated = true;
            this.booklichButton.BackColor = System.Drawing.Color.Transparent;
            this.booklichButton.CheckedState.Parent = this.booklichButton;
            this.booklichButton.CustomImages.Parent = this.booklichButton;
            this.guna2Transition1.SetDecoration(this.booklichButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.booklichButton.FillColor = System.Drawing.Color.Transparent;
            this.booklichButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.booklichButton.ForeColor = System.Drawing.Color.Black;
            this.booklichButton.HoverState.Parent = this.booklichButton;
            this.booklichButton.Location = new System.Drawing.Point(899, 1);
            this.booklichButton.Name = "booklichButton";
            this.booklichButton.ShadowDecoration.Parent = this.booklichButton;
            this.booklichButton.Size = new System.Drawing.Size(180, 45);
            this.booklichButton.TabIndex = 7;
            this.booklichButton.Text = "Đặt lịch khám";
            this.booklichButton.Click += new System.EventHandler(this.booklichButton_Click);
            // 
            // phunuButton
            // 
            this.phunuButton.Animated = true;
            this.phunuButton.BackColor = System.Drawing.Color.Transparent;
            this.phunuButton.CheckedState.Parent = this.phunuButton;
            this.phunuButton.CustomImages.Parent = this.phunuButton;
            this.guna2Transition1.SetDecoration(this.phunuButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.phunuButton.FillColor = System.Drawing.Color.Transparent;
            this.phunuButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.phunuButton.ForeColor = System.Drawing.Color.Black;
            this.phunuButton.HoverState.Parent = this.phunuButton;
            this.phunuButton.Location = new System.Drawing.Point(713, 1);
            this.phunuButton.Name = "phunuButton";
            this.phunuButton.ShadowDecoration.Parent = this.phunuButton;
            this.phunuButton.Size = new System.Drawing.Size(180, 45);
            this.phunuButton.TabIndex = 6;
            this.phunuButton.Text = "Phụ nữ mang thai";
            this.phunuButton.Click += new System.EventHandler(this.phunuButton_Click);
            // 
            // treemButton
            // 
            this.treemButton.Animated = true;
            this.treemButton.BackColor = System.Drawing.Color.Transparent;
            this.treemButton.CheckedState.Parent = this.treemButton;
            this.treemButton.CustomImages.Parent = this.treemButton;
            this.guna2Transition1.SetDecoration(this.treemButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.treemButton.FillColor = System.Drawing.Color.Transparent;
            this.treemButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.treemButton.ForeColor = System.Drawing.Color.Black;
            this.treemButton.HoverState.Parent = this.treemButton;
            this.treemButton.Location = new System.Drawing.Point(527, 1);
            this.treemButton.Name = "treemButton";
            this.treemButton.ShadowDecoration.Parent = this.treemButton;
            this.treemButton.Size = new System.Drawing.Size(180, 45);
            this.treemButton.TabIndex = 5;
            this.treemButton.Text = "Trẻ em";
            this.treemButton.Click += new System.EventHandler(this.treemButton_Click);
            // 
            // MouseDetect
            // 
            this.MouseDetect.Enabled = true;
            this.MouseDetect.Tick += new System.EventHandler(this.MouseDetect_Tick);
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.Cursor = null;
            animation8.AnimateOnlyDifferences = true;
            animation8.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.BlindCoeff")));
            animation8.LeafCoeff = 0F;
            animation8.MaxTime = 1F;
            animation8.MinTime = 0F;
            animation8.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.MosaicCoeff")));
            animation8.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation8.MosaicShift")));
            animation8.MosaicSize = 0;
            animation8.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation8.RotateCoeff = 0F;
            animation8.RotateLimit = 0F;
            animation8.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.ScaleCoeff")));
            animation8.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.SlideCoeff")));
            animation8.TimeCoeff = 0F;
            animation8.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation8;
            this.guna2Transition1.MaxAnimationTime = 500;
            this.guna2Transition1.TimeStep = 0.1F;
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
            // 
            // loadingFormPanel
            // 
            this.guna2Transition1.SetDecoration(this.loadingFormPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.loadingFormPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loadingFormPanel.Location = new System.Drawing.Point(0, 52);
            this.loadingFormPanel.Name = "loadingFormPanel";
            this.loadingFormPanel.ShadowDecoration.Parent = this.loadingFormPanel;
            this.loadingFormPanel.Size = new System.Drawing.Size(1122, 498);
            this.loadingFormPanel.TabIndex = 6;
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
            this.Load += new System.EventHandler(this.CuaNhanVien_Load);
            this.mainMenuPanel.ResumeLayout(false);
            this.mainMenuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel mainMenuPanel;
        private Guna.UI2.WinForms.Guna2Button vacxinButton;
        private Guna.UI2.WinForms.Guna2Button booklichButton;
        private Guna.UI2.WinForms.Guna2Button phunuButton;
        private Guna.UI2.WinForms.Guna2Button treemButton;
        private System.Windows.Forms.Timer MouseDetect;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel loadingFormPanel;
    }
}