namespace QLTV
{
    partial class ThongTInThuVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTInThuVien));
            this.txtThongTinThuVien = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtThongTinThuVien
            // 
            this.txtThongTinThuVien.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtThongTinThuVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThongTinThuVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtThongTinThuVien.Location = new System.Drawing.Point(0, 0);
            this.txtThongTinThuVien.Margin = new System.Windows.Forms.Padding(4);
            this.txtThongTinThuVien.Multiline = true;
            this.txtThongTinThuVien.Name = "txtThongTinThuVien";
            this.txtThongTinThuVien.ReadOnly = true;
            this.txtThongTinThuVien.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtThongTinThuVien.Size = new System.Drawing.Size(1118, 700);
            this.txtThongTinThuVien.TabIndex = 1;
            this.txtThongTinThuVien.Text = resources.GetString("txtThongTinThuVien.Text");
            // 
            // ThongTInThuVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 700);
            this.Controls.Add(this.txtThongTinThuVien);
            this.Name = "ThongTInThuVien";
            this.Text = "ThongTInThuVien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtThongTinThuVien;
    }
}