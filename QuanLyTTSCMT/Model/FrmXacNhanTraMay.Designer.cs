namespace QuanLyTTSCMT.Model
{
    partial class FrmXacNhanTraMay
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
            this.lblIdMay = new System.Windows.Forms.Label();
            this.txtIdMayNhan = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbTraMay = new System.Windows.Forms.CheckBox();
            this.btnLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdMay
            // 
            this.lblIdMay.AutoSize = true;
            this.lblIdMay.Location = new System.Drawing.Point(19, 34);
            this.lblIdMay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdMay.Name = "lblIdMay";
            this.lblIdMay.Size = new System.Drawing.Size(77, 15);
            this.lblIdMay.TabIndex = 1;
            this.lblIdMay.Text = "Nhập Id máy:";
            // 
            // txtIdMayNhan
            // 
            this.txtIdMayNhan.Location = new System.Drawing.Point(134, 29);
            this.txtIdMayNhan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdMayNhan.Name = "txtIdMayNhan";
            this.txtIdMayNhan.Size = new System.Drawing.Size(174, 22);
            this.txtIdMayNhan.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(410, 31);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(87, 22);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 77);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(373, 116);
            this.dataGridView1.TabIndex = 4;
            // 
            // cbTraMay
            // 
            this.cbTraMay.AutoSize = true;
            this.cbTraMay.Location = new System.Drawing.Point(23, 237);
            this.cbTraMay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTraMay.Name = "cbTraMay";
            this.cbTraMay.Size = new System.Drawing.Size(136, 19);
            this.cbTraMay.TabIndex = 5;
            this.cbTraMay.Text = "Xác nhận đã trả máy";
            this.cbTraMay.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(439, 228);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(58, 22);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // FrmXacNhanTraMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 289);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.cbTraMay);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtIdMayNhan);
            this.Controls.Add(this.lblIdMay);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmXacNhanTraMay";
            this.Text = "FrmXacNhanTraMay";
            this.Load += new System.EventHandler(this.FrmXacNhanTraMay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblIdMay;
        private System.Windows.Forms.TextBox txtIdMayNhan;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox cbTraMay;
        private System.Windows.Forms.Button btnLuu;
    }
}