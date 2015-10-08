namespace QLTV
{
    partial class TimKiem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxTenNXBTK = new System.Windows.Forms.ComboBox();
            this.cbxTenTLTK = new System.Windows.Forms.ComboBox();
            this.cbxTenTacGiaTK = new System.Windows.Forms.ComboBox();
            this.cbxTenSachTK = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewTimKiem = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.cbxTenNXBTK);
            this.groupBox1.Controls.Add(this.cbxTenTLTK);
            this.groupBox1.Controls.Add(this.cbxTenTacGiaTK);
            this.groupBox1.Controls.Add(this.cbxTenSachTK);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(875, 324);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Các Mục Tìm Kiếm";
            // 
            // cbxTenNXBTK
            // 
            this.cbxTenNXBTK.FormattingEnabled = true;
            this.cbxTenNXBTK.Location = new System.Drawing.Point(218, 259);
            this.cbxTenNXBTK.Name = "cbxTenNXBTK";
            this.cbxTenNXBTK.Size = new System.Drawing.Size(496, 24);
            this.cbxTenNXBTK.TabIndex = 7;
            this.cbxTenNXBTK.SelectedIndexChanged += new System.EventHandler(this.cbxTenNXBTK_SelectedIndexChanged_1);
            // 
            // cbxTenTLTK
            // 
            this.cbxTenTLTK.FormattingEnabled = true;
            this.cbxTenTLTK.Location = new System.Drawing.Point(218, 190);
            this.cbxTenTLTK.Name = "cbxTenTLTK";
            this.cbxTenTLTK.Size = new System.Drawing.Size(496, 24);
            this.cbxTenTLTK.TabIndex = 6;
            this.cbxTenTLTK.SelectedIndexChanged += new System.EventHandler(this.cbxTenTLTK_SelectedIndexChanged_1);
            // 
            // cbxTenTacGiaTK
            // 
            this.cbxTenTacGiaTK.FormattingEnabled = true;
            this.cbxTenTacGiaTK.Location = new System.Drawing.Point(218, 131);
            this.cbxTenTacGiaTK.Name = "cbxTenTacGiaTK";
            this.cbxTenTacGiaTK.Size = new System.Drawing.Size(496, 24);
            this.cbxTenTacGiaTK.TabIndex = 5;
            this.cbxTenTacGiaTK.SelectedIndexChanged += new System.EventHandler(this.cbxTenTacGiaTK_SelectedIndexChanged_1);
            // 
            // cbxTenSachTK
            // 
            this.cbxTenSachTK.FormattingEnabled = true;
            this.cbxTenSachTK.Location = new System.Drawing.Point(218, 58);
            this.cbxTenSachTK.Name = "cbxTenSachTK";
            this.cbxTenSachTK.Size = new System.Drawing.Size(496, 24);
            this.cbxTenSachTK.TabIndex = 4;
            this.cbxTenSachTK.SelectedIndexChanged += new System.EventHandler(this.cbxTenSachTK_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên Nhà Xuất Bản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Thể Loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Tác Giả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Sách";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.dataGridViewTimKiem);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(12, 344);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(875, 324);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hiển Thị";
            // 
            // dataGridViewTimKiem
            // 
            this.dataGridViewTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTimKiem.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewTimKiem.Name = "dataGridViewTimKiem";
            this.dataGridViewTimKiem.RowTemplate.Height = 24;
            this.dataGridViewTimKiem.Size = new System.Drawing.Size(849, 297);
            this.dataGridViewTimKiem.TabIndex = 0;
            // 
            // TimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 680);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TimKiem";
            this.Text = "TimKiem";
            this.Load += new System.EventHandler(this.TimKiem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimKiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxTenNXBTK;
        private System.Windows.Forms.ComboBox cbxTenTLTK;
        private System.Windows.Forms.ComboBox cbxTenTacGiaTK;
        private System.Windows.Forms.ComboBox cbxTenSachTK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewTimKiem;
    }
}