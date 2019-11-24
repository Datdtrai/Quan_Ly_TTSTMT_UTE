namespace QuanLyTTSCMT.Model
{
    partial class FrmQuanLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLy));
            this.lblTenNguoiSuDung = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTenNguoiSuDung
            // 
            this.lblTenNguoiSuDung.AutoSize = true;
            this.lblTenNguoiSuDung.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNguoiSuDung.Location = new System.Drawing.Point(31, 21);
            this.lblTenNguoiSuDung.Name = "lblTenNguoiSuDung";
            this.lblTenNguoiSuDung.Size = new System.Drawing.Size(0, 22);
            this.lblTenNguoiSuDung.TabIndex = 0;
            // 
            // FrmQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyTTSCMT.Properties.Resources._74893009_1554392444708483_8093966096668819456_o;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(689, 537);
            this.Controls.Add(this.lblTenNguoiSuDung);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmQuanLy";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmQuanLy";
            this.Load += new System.EventHandler(this.FrmQuanLy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenNguoiSuDung;
    }
}