namespace RestaurantManagerment
{
    partial class Tab1_3OrderMonAn
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flplistNhomMon = new System.Windows.Forms.FlowLayoutPanel();
            this.flplistMonAn = new System.Windows.Forms.FlowLayoutPanel();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flplistNhomMon
            // 
            this.flplistNhomMon.BackColor = System.Drawing.Color.Moccasin;
            this.flplistNhomMon.Dock = System.Windows.Forms.DockStyle.Top;
            this.flplistNhomMon.Location = new System.Drawing.Point(0, 0);
            this.flplistNhomMon.Name = "flplistNhomMon";
            this.flplistNhomMon.Size = new System.Drawing.Size(497, 41);
            this.flplistNhomMon.TabIndex = 0;
            // 
            // flplistMonAn
            // 
            this.flplistMonAn.Location = new System.Drawing.Point(3, 51);
            this.flplistMonAn.Name = "flplistMonAn";
            this.flplistMonAn.Size = new System.Drawing.Size(491, 374);
            this.flplistMonAn.TabIndex = 1;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(6, 430);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(75, 27);
            this.btnQuayLai.TabIndex = 61;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // Tab1_3OrderMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.flplistMonAn);
            this.Controls.Add(this.flplistNhomMon);
            this.Name = "Tab1_3OrderMonAn";
            this.Size = new System.Drawing.Size(497, 458);
            this.Load += new System.EventHandler(this.Tab1_3OrderMonAn_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flplistNhomMon;
        private System.Windows.Forms.FlowLayoutPanel flplistMonAn;
        private System.Windows.Forms.Button btnQuayLai;
    }
}
