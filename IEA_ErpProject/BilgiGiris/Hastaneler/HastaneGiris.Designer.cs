namespace IEA_ErpProject.BilgiGiris.Hastaneler
{
    partial class HastaneGiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnKapat = new System.Windows.Forms.Button();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.ScHastane = new System.Windows.Forms.SplitContainer();
            this.TxtVergiNo = new System.Windows.Forms.MaskedTextBox();
            this.txtVergiDairesi = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.TxtAdres = new System.Windows.Forms.RichTextBox();
            this.TxtSehir = new System.Windows.Forms.ComboBox();
            this.TxtTipAdi = new System.Windows.Forms.ComboBox();
            this.TxtCariHadi = new System.Windows.Forms.TextBox();
            this.TxtHadi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sehir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ScHastane)).BeginInit();
            this.ScHastane.Panel1.SuspendLayout();
            this.ScHastane.Panel2.SuspendLayout();
            this.ScHastane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SlateBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1058, 77);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hastane Giris";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnKapat
            // 
            this.BtnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnKapat.BackgroundImage = global::IEA_ErpProject.Properties.Resources.exit_64;
            this.BtnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnKapat.Location = new System.Drawing.Point(966, 9);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(59, 53);
            this.BtnKapat.TabIndex = 4;
            this.BtnKapat.UseVisualStyleBackColor = true;
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.BackgroundImage = global::IEA_ErpProject.Properties.Resources._45_452586_cleaning_icon_clipart_escoba_icon;
            this.BtnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnTemizle.Location = new System.Drawing.Point(270, 9);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(59, 53);
            this.BtnTemizle.TabIndex = 3;
            this.BtnTemizle.UseVisualStyleBackColor = true;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.BackgroundImage = global::IEA_ErpProject.Properties.Resources.cop24x24;
            this.BtnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSil.Location = new System.Drawing.Point(184, 9);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(59, 53);
            this.BtnSil.TabIndex = 2;
            this.BtnSil.UseVisualStyleBackColor = true;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackgroundImage = global::IEA_ErpProject.Properties.Resources.Update32x32;
            this.BtnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGuncelle.Location = new System.Drawing.Point(98, 9);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(59, 53);
            this.BtnGuncelle.TabIndex = 1;
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackgroundImage = global::IEA_ErpProject.Properties.Resources.Save_icon64x64;
            this.BtnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnKaydet.Location = new System.Drawing.Point(12, 9);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(59, 53);
            this.BtnKaydet.TabIndex = 0;
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // ScHastane
            // 
            this.ScHastane.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ScHastane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScHastane.Location = new System.Drawing.Point(0, 77);
            this.ScHastane.Name = "ScHastane";
            this.ScHastane.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ScHastane.Panel1
            // 
            this.ScHastane.Panel1.Controls.Add(this.TxtVergiNo);
            this.ScHastane.Panel1.Controls.Add(this.txtVergiDairesi);
            this.ScHastane.Panel1.Controls.Add(this.txtTelefon);
            this.ScHastane.Panel1.Controls.Add(this.TxtAdres);
            this.ScHastane.Panel1.Controls.Add(this.TxtSehir);
            this.ScHastane.Panel1.Controls.Add(this.TxtTipAdi);
            this.ScHastane.Panel1.Controls.Add(this.TxtCariHadi);
            this.ScHastane.Panel1.Controls.Add(this.TxtHadi);
            this.ScHastane.Panel1.Controls.Add(this.label9);
            this.ScHastane.Panel1.Controls.Add(this.label5);
            this.ScHastane.Panel1.Controls.Add(this.label8);
            this.ScHastane.Panel1.Controls.Add(this.label3);
            this.ScHastane.Panel1.Controls.Add(this.label7);
            this.ScHastane.Panel1.Controls.Add(this.label4);
            this.ScHastane.Panel1.Controls.Add(this.label6);
            this.ScHastane.Panel1.Controls.Add(this.label2);
            // 
            // ScHastane.Panel2
            // 
            this.ScHastane.Panel2.Controls.Add(this.dataGridView1);
            this.ScHastane.Size = new System.Drawing.Size(1058, 528);
            this.ScHastane.SplitterDistance = 304;
            this.ScHastane.TabIndex = 5;
            // 
            // TxtVergiNo
            // 
            this.TxtVergiNo.Location = new System.Drawing.Point(861, 100);
            this.TxtVergiNo.Mask = "0000000000";
            this.TxtVergiNo.Name = "TxtVergiNo";
            this.TxtVergiNo.Size = new System.Drawing.Size(139, 22);
            this.TxtVergiNo.TabIndex = 7;
            // 
            // txtVergiDairesi
            // 
            this.txtVergiDairesi.Location = new System.Drawing.Point(861, 31);
            this.txtVergiDairesi.Name = "txtVergiDairesi";
            this.txtVergiDairesi.Size = new System.Drawing.Size(139, 22);
            this.txtVergiDairesi.TabIndex = 6;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(524, 85);
            this.txtTelefon.Mask = "(999) 000-0000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(172, 22);
            this.txtTelefon.TabIndex = 5;
            // 
            // TxtAdres
            // 
            this.TxtAdres.Location = new System.Drawing.Point(110, 166);
            this.TxtAdres.Name = "TxtAdres";
            this.TxtAdres.Size = new System.Drawing.Size(322, 80);
            this.TxtAdres.TabIndex = 3;
            this.TxtAdres.Text = "";
            // 
            // TxtSehir
            // 
            this.TxtSehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtSehir.FormattingEnabled = true;
            this.TxtSehir.Location = new System.Drawing.Point(524, 31);
            this.TxtSehir.Name = "TxtSehir";
            this.TxtSehir.Size = new System.Drawing.Size(172, 24);
            this.TxtSehir.TabIndex = 4;
            // 
            // TxtTipAdi
            // 
            this.TxtTipAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtTipAdi.FormattingEnabled = true;
            this.TxtTipAdi.Location = new System.Drawing.Point(110, 121);
            this.TxtTipAdi.Name = "TxtTipAdi";
            this.TxtTipAdi.Size = new System.Drawing.Size(172, 24);
            this.TxtTipAdi.TabIndex = 2;
            // 
            // TxtCariHadi
            // 
            this.TxtCariHadi.Location = new System.Drawing.Point(110, 72);
            this.TxtCariHadi.Name = "TxtCariHadi";
            this.TxtCariHadi.Size = new System.Drawing.Size(322, 22);
            this.TxtCariHadi.TabIndex = 1;
            // 
            // TxtHadi
            // 
            this.TxtHadi.Location = new System.Drawing.Point(110, 22);
            this.TxtHadi.Name = "TxtHadi";
            this.TxtHadi.Size = new System.Drawing.Size(322, 22);
            this.TxtHadi.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Location = new System.Drawing.Point(453, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 40);
            this.label9.TabIndex = 0;
            this.label9.Text = "Telefon :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(755, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 40);
            this.label5.TabIndex = 0;
            this.label5.Text = "Vergi No :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(3, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 40);
            this.label8.TabIndex = 0;
            this.label8.Text = "Adres :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(3, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 40);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hastane Tipi :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(3, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 40);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cari Adi :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(755, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 40);
            this.label4.TabIndex = 0;
            this.label4.Text = "Vergi Dairesi :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(453, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 40);
            this.label6.TabIndex = 0;
            this.label6.Text = "Şehir :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hastane Adi :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Adi,
            this.TipId,
            this.Sehir});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1054, 216);
            this.dataGridView1.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 47;
            // 
            // Adi
            // 
            this.Adi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Adi.HeaderText = "Hastane Adi";
            this.Adi.MinimumWidth = 6;
            this.Adi.Name = "Adi";
            // 
            // TipId
            // 
            this.TipId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TipId.HeaderText = "Hastane Tipi";
            this.TipId.MinimumWidth = 6;
            this.TipId.Name = "TipId";
            this.TipId.Width = 113;
            // 
            // Sehir
            // 
            this.Sehir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sehir.HeaderText = "Şehir";
            this.Sehir.MinimumWidth = 6;
            this.Sehir.Name = "Sehir";
            this.Sehir.Width = 67;
            // 
            // HastaneGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 605);
            this.Controls.Add(this.ScHastane);
            this.Controls.Add(this.BtnKapat);
            this.Controls.Add(this.BtnTemizle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.label1);
            this.Name = "HastaneGiris";
            this.Text = "HastaneGiris";
            this.Load += new System.EventHandler(this.HastaneGiris_Load);
            this.ScHastane.Panel1.ResumeLayout(false);
            this.ScHastane.Panel1.PerformLayout();
            this.ScHastane.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScHastane)).EndInit();
            this.ScHastane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.Button BtnKapat;
        private System.Windows.Forms.SplitContainer ScHastane;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sehir;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.RichTextBox TxtAdres;
        private System.Windows.Forms.ComboBox TxtSehir;
        private System.Windows.Forms.ComboBox TxtTipAdi;
        private System.Windows.Forms.TextBox TxtCariHadi;
        private System.Windows.Forms.TextBox TxtHadi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox TxtVergiNo;
        private System.Windows.Forms.TextBox txtVergiDairesi;
    }
}