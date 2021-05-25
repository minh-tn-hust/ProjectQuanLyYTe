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
            Guna.UI2.AnimatorNS.Animation animation5 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CuaNhanVien));
            this.mainMenuPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.vacxinButton = new Guna.UI2.WinForms.Guna2Button();
            this.booklichButton = new Guna.UI2.WinForms.Guna2Button();
            this.treemButton = new Guna.UI2.WinForms.Guna2Button();
            this.MouseDetect = new System.Windows.Forms.Timer(this.components);
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.loadingFormPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.mainMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuPanel
            // 
            this.mainMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.mainMenuPanel.Controls.Add(this.label1);
            this.mainMenuPanel.Controls.Add(this.guna2ImageButton1);
            this.mainMenuPanel.Controls.Add(this.vacxinButton);
            this.mainMenuPanel.Controls.Add(this.booklichButton);
            this.mainMenuPanel.Controls.Add(this.treemButton);
            this.guna2Transition1.SetDecoration(this.mainMenuPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.mainMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.mainMenuPanel.Name = "mainMenuPanel";
            this.mainMenuPanel.ShadowDecoration.Parent = this.mainMenuPanel;
            this.mainMenuPanel.Size = new System.Drawing.Size(1037, 47);
            this.mainMenuPanel.TabIndex = 5;
            this.mainMenuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2Transition1.SetDecoration(this.guna2ImageButton1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(45, 45);
            this.guna2ImageButton1.IndicateFocus = true;
            this.guna2ImageButton1.Location = new System.Drawing.Point(986, 0);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(44, 44);
            this.guna2ImageButton1.TabIndex = 10;
            this.guna2ImageButton1.UseTransparentBackground = true;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Xin chào Trần Nhật Minh";
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
            this.vacxinButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vacxinButton.ForeColor = System.Drawing.Color.White;
            this.vacxinButton.HoverState.Parent = this.vacxinButton;
            this.vacxinButton.Location = new System.Drawing.Point(415, 1);
            this.vacxinButton.Name = "vacxinButton";
            this.vacxinButton.ShadowDecoration.Parent = this.vacxinButton;
            this.vacxinButton.Size = new System.Drawing.Size(180, 45);
            this.vacxinButton.TabIndex = 8;
            this.vacxinButton.Text = "Tiêm Vắc Xin";
            this.vacxinButton.Click += new System.EventHandler(this.guna2Button1_Click);
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
            this.booklichButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booklichButton.ForeColor = System.Drawing.Color.White;
            this.booklichButton.HoverState.Parent = this.booklichButton;
            this.booklichButton.Location = new System.Drawing.Point(803, 0);
            this.booklichButton.Name = "booklichButton";
            this.booklichButton.ShadowDecoration.Parent = this.booklichButton;
            this.booklichButton.Size = new System.Drawing.Size(180, 45);
            this.booklichButton.TabIndex = 7;
            this.booklichButton.Text = "Đặt lịch khám";
            this.booklichButton.Click += new System.EventHandler(this.booklichButton_Click);
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
            this.treemButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treemButton.ForeColor = System.Drawing.Color.White;
            this.treemButton.HoverState.Parent = this.treemButton;
            this.treemButton.Location = new System.Drawing.Point(609, 0);
            this.treemButton.Name = "treemButton";
            this.treemButton.ShadowDecoration.Parent = this.treemButton;
            this.treemButton.Size = new System.Drawing.Size(180, 45);
            this.treemButton.TabIndex = 5;
            this.treemButton.Text = "Trẻ em và Phụ nữ";
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
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(0);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation5;
            this.guna2Transition1.MaxAnimationTime = 500;
            this.guna2Transition1.TimeStep = 0.1F;
            // 
            // loadingFormPanel
            // 
            this.loadingFormPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2Transition1.SetDecoration(this.loadingFormPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.loadingFormPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loadingFormPanel.Location = new System.Drawing.Point(0, 45);
            this.loadingFormPanel.Name = "loadingFormPanel";
            this.loadingFormPanel.ShadowDecoration.Parent = this.loadingFormPanel;
            this.loadingFormPanel.Size = new System.Drawing.Size(1037, 504);
            this.loadingFormPanel.TabIndex = 6;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // CuaNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 549);
            this.Controls.Add(this.loadingFormPanel);
            this.Controls.Add(this.mainMenuPanel);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "CuaNhanVien";
            this.Text = "Dành cho nhân viên y tế";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MaximizedBoundsChanged += new System.EventHandler(this.CuaNhanVien_MaximizedBoundsChanged);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CuaNhanVien_FormClosed);
            this.Load += new System.EventHandler(this.CuaNhanVien_Load);
            this.Resize += new System.EventHandler(this.CuaNhanVien_Resize);
            this.mainMenuPanel.ResumeLayout(false);
            this.mainMenuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel mainMenuPanel;
        private System.Windows.Forms.Timer MouseDetect;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel loadingFormPanel;
        private Guna.UI2.WinForms.Guna2Button booklichButton;
        private Guna.UI2.WinForms.Guna2Button vacxinButton;
        private Guna.UI2.WinForms.Guna2Button treemButton;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
    }
}