namespace bookcity
{
    partial class frm_index
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
       /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_index));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mnu_system = new System.Windows.Forms.ToolStripDropDownButton();
            this.코드관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.코드관리2단계ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.코드관리3단계ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.우편번호관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.상담결과코드ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.우편번호관리ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_system});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(972, 119);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(157, 184);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(642, 429);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // mnu_system
            // 
            this.mnu_system.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnu_system.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.코드관리ToolStripMenuItem,
            this.우편번호관리ToolStripMenuItem});
            this.mnu_system.Image = ((System.Drawing.Image)(resources.GetObject("mnu_system.Image")));
            this.mnu_system.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnu_system.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnu_system.Name = "mnu_system";
            this.mnu_system.Size = new System.Drawing.Size(158, 116);
            this.mnu_system.Text = "시스템관리";
            // 
            // 코드관리ToolStripMenuItem
            // 
            this.코드관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.코드관리2단계ToolStripMenuItem,
            this.코드관리3단계ToolStripMenuItem,
            this.상담결과코드ToolStripMenuItem});
            this.코드관리ToolStripMenuItem.Name = "코드관리ToolStripMenuItem";
            this.코드관리ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.코드관리ToolStripMenuItem.Text = "코드관리";
            // 
            // 코드관리2단계ToolStripMenuItem
            // 
            this.코드관리2단계ToolStripMenuItem.Name = "코드관리2단계ToolStripMenuItem";
            this.코드관리2단계ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.코드관리2단계ToolStripMenuItem.Text = "코드관리2단계";
            this.코드관리2단계ToolStripMenuItem.Click += new System.EventHandler(this.코드관리2단계ToolStripMenuItem_Click);
            // 
            // 코드관리3단계ToolStripMenuItem
            // 
            this.코드관리3단계ToolStripMenuItem.Name = "코드관리3단계ToolStripMenuItem";
            this.코드관리3단계ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.코드관리3단계ToolStripMenuItem.Text = "코드관리3단계";
            this.코드관리3단계ToolStripMenuItem.Click += new System.EventHandler(this.코드관리3단계ToolStripMenuItem_Click);
            // 
            // 우편번호관리ToolStripMenuItem
            // 
            this.우편번호관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.우편번호관리ToolStripMenuItem1});
            this.우편번호관리ToolStripMenuItem.Name = "우편번호관리ToolStripMenuItem";
            this.우편번호관리ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.우편번호관리ToolStripMenuItem.Text = "우편번호관리";
            // 
            // 상담결과코드ToolStripMenuItem
            // 
            this.상담결과코드ToolStripMenuItem.Name = "상담결과코드ToolStripMenuItem";
            this.상담결과코드ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.상담결과코드ToolStripMenuItem.Text = "상담결과코드";
            // 
            // 우편번호관리ToolStripMenuItem1
            // 
            this.우편번호관리ToolStripMenuItem1.Name = "우편번호관리ToolStripMenuItem1";
            this.우편번호관리ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.우편번호관리ToolStripMenuItem1.Text = "우편번호관리";
            this.우편번호관리ToolStripMenuItem1.Click += new System.EventHandler(this.우편번호관리ToolStripMenuItem1_Click);
            // 
            // frm_index
            // 
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(972, 678);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frm_index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "파주출판도시 안내센터 프로그램";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripDropDownButton mnu_system;
        private System.Windows.Forms.ToolStripMenuItem 코드관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 코드관리2단계ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 코드관리3단계ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 상담결과코드ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 우편번호관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 우편번호관리ToolStripMenuItem1;
    }
}