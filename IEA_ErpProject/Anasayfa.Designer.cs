namespace IEA_ErpProject
{
    partial class Anasayfa
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
            this.tabPGenel = new System.Windows.Forms.TabControl();
            this.tapPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlSol = new System.Windows.Forms.Panel();
            this.scMenu = new System.Windows.Forms.SplitContainer();
            this.tvMenu = new System.Windows.Forms.TreeView();
            this.btnUrunGiris = new System.Windows.Forms.Button();
            this.btnBilgiGiris = new System.Windows.Forms.Button();
            this.pnlSolÜst = new System.Windows.Forms.Panel();
            this.btnSolÜstCollapse = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnSolÜstAra = new System.Windows.Forms.Button();
            this.txtSolÜstAra = new System.Windows.Forms.TextBox();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.tabPGenel.SuspendLayout();
            this.pnlSol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMenu)).BeginInit();
            this.scMenu.Panel1.SuspendLayout();
            this.scMenu.Panel2.SuspendLayout();
            this.scMenu.SuspendLayout();
            this.pnlSolÜst.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPGenel
            // 
            this.tabPGenel.Controls.Add(this.tapPage1);
            this.tabPGenel.Controls.Add(this.tabPage2);
            this.tabPGenel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabPGenel.Location = new System.Drawing.Point(0, 0);
            this.tabPGenel.Name = "tabPGenel";
            this.tabPGenel.SelectedIndex = 0;
            this.tabPGenel.Size = new System.Drawing.Size(1438, 156);
            this.tabPGenel.TabIndex = 0;
            // 
            // tapPage1
            // 
            this.tapPage1.BackColor = System.Drawing.SystemColors.Info;
            this.tapPage1.Location = new System.Drawing.Point(4, 25);
            this.tapPage1.Name = "tapPage1";
            this.tapPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tapPage1.Size = new System.Drawing.Size(1430, 127);
            this.tapPage1.TabIndex = 0;
            this.tapPage1.Text = "Genel";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1430, 122);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Yönetim";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 156);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1438, 5);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // pnlSol
            // 
            this.pnlSol.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlSol.Controls.Add(this.scMenu);
            this.pnlSol.Controls.Add(this.pnlSolÜst);
            this.pnlSol.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSol.Location = new System.Drawing.Point(0, 161);
            this.pnlSol.Name = "pnlSol";
            this.pnlSol.Size = new System.Drawing.Size(343, 576);
            this.pnlSol.TabIndex = 2;
            // 
            // scMenu
            // 
            this.scMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.scMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMenu.Location = new System.Drawing.Point(0, 57);
            this.scMenu.Name = "scMenu";
            this.scMenu.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMenu.Panel1
            // 
            this.scMenu.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.scMenu.Panel1.Controls.Add(this.tvMenu);
            // 
            // scMenu.Panel2
            // 
            this.scMenu.Panel2.BackColor = System.Drawing.SystemColors.Info;
            this.scMenu.Panel2.Controls.Add(this.btnUrunGiris);
            this.scMenu.Panel2.Controls.Add(this.btnBilgiGiris);
            this.scMenu.Size = new System.Drawing.Size(343, 519);
            this.scMenu.SplitterDistance = 264;
            this.scMenu.TabIndex = 4;
            // 
            // tvMenu
            // 
            this.tvMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvMenu.Location = new System.Drawing.Point(0, 0);
            this.tvMenu.Name = "tvMenu";
            this.tvMenu.Size = new System.Drawing.Size(343, 264);
            this.tvMenu.TabIndex = 0;
            this.tvMenu.DoubleClick += new System.EventHandler(this.tvMenu_DoubleClick);
            // 
            // btnUrunGiris
            // 
            this.btnUrunGiris.Location = new System.Drawing.Point(101, 20);
            this.btnUrunGiris.Name = "btnUrunGiris";
            this.btnUrunGiris.Size = new System.Drawing.Size(83, 59);
            this.btnUrunGiris.TabIndex = 1;
            this.btnUrunGiris.Text = "Ürün  İşlemleri";
            this.btnUrunGiris.UseVisualStyleBackColor = true;
            this.btnUrunGiris.Click += new System.EventHandler(this.btnUrunGiris_Click);
            // 
            // btnBilgiGiris
            // 
            this.btnBilgiGiris.Location = new System.Drawing.Point(12, 20);
            this.btnBilgiGiris.Name = "btnBilgiGiris";
            this.btnBilgiGiris.Size = new System.Drawing.Size(83, 59);
            this.btnBilgiGiris.TabIndex = 0;
            this.btnBilgiGiris.Text = "Bilgi Giriş İşlemleri";
            this.btnBilgiGiris.UseVisualStyleBackColor = true;
            this.btnBilgiGiris.Click += new System.EventHandler(this.btnBilgiGiris_Click);
            // 
            // pnlSolÜst
            // 
            this.pnlSolÜst.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlSolÜst.Controls.Add(this.btnSolÜstCollapse);
            this.pnlSolÜst.Controls.Add(this.lblMenu);
            this.pnlSolÜst.Controls.Add(this.btnSolÜstAra);
            this.pnlSolÜst.Controls.Add(this.txtSolÜstAra);
            this.pnlSolÜst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSolÜst.Location = new System.Drawing.Point(0, 0);
            this.pnlSolÜst.Name = "pnlSolÜst";
            this.pnlSolÜst.Size = new System.Drawing.Size(343, 57);
            this.pnlSolÜst.TabIndex = 4;
            // 
            // btnSolÜstCollapse
            // 
            this.btnSolÜstCollapse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSolÜstCollapse.BackgroundImage = global::IEA_ErpProject.Properties.Resources.RightLeft2Red;
            this.btnSolÜstCollapse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSolÜstCollapse.Location = new System.Drawing.Point(312, 26);
            this.btnSolÜstCollapse.Name = "btnSolÜstCollapse";
            this.btnSolÜstCollapse.Size = new System.Drawing.Size(28, 26);
            this.btnSolÜstCollapse.TabIndex = 3;
            this.btnSolÜstCollapse.UseVisualStyleBackColor = true;
            // 
            // lblMenu
            // 
            this.lblMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMenu.BackColor = System.Drawing.SystemColors.Control;
            this.lblMenu.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMenu.Location = new System.Drawing.Point(3, 28);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(308, 22);
            this.lblMenu.TabIndex = 2;
            this.lblMenu.Text = "****";
            this.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSolÜstAra
            // 
            this.btnSolÜstAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSolÜstAra.BackgroundImage = global::IEA_ErpProject.Properties.Resources.Ara32x32;
            this.btnSolÜstAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSolÜstAra.Location = new System.Drawing.Point(312, 0);
            this.btnSolÜstAra.Name = "btnSolÜstAra";
            this.btnSolÜstAra.Size = new System.Drawing.Size(28, 26);
            this.btnSolÜstAra.TabIndex = 1;
            this.btnSolÜstAra.UseVisualStyleBackColor = true;
            // 
            // txtSolÜstAra
            // 
            this.txtSolÜstAra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSolÜstAra.Location = new System.Drawing.Point(3, 3);
            this.txtSolÜstAra.Name = "txtSolÜstAra";
            this.txtSolÜstAra.Size = new System.Drawing.Size(308, 22);
            this.txtSolÜstAra.TabIndex = 0;
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitter2.Location = new System.Drawing.Point(343, 161);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(5, 576);
            this.splitter2.TabIndex = 3;
            this.splitter2.TabStop = false;
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 737);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.pnlSol);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tabPGenel);
            this.IsMdiContainer = true;
            this.Name = "Anasayfa";
            this.Text = "AnaSayfa";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.tabPGenel.ResumeLayout(false);
            this.pnlSol.ResumeLayout(false);
            this.scMenu.Panel1.ResumeLayout(false);
            this.scMenu.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMenu)).EndInit();
            this.scMenu.ResumeLayout(false);
            this.pnlSolÜst.ResumeLayout(false);
            this.pnlSolÜst.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPGenel;
        private System.Windows.Forms.TabPage tapPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel pnlSol;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel pnlSolÜst;
        private System.Windows.Forms.Button btnSolÜstAra;
        private System.Windows.Forms.TextBox txtSolÜstAra;
        private System.Windows.Forms.Button btnSolÜstCollapse;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.SplitContainer scMenu;
        private System.Windows.Forms.TreeView tvMenu;
        private System.Windows.Forms.Button btnBilgiGiris;
        private System.Windows.Forms.Button btnUrunGiris;
    }
}

