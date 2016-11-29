namespace AutoSellGoodsMachine
{
    partial class QRCodeTestForm
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
            this.txt_QRCode = new System.Windows.Forms.TextBox();
            this.img_QRCode = new System.Windows.Forms.PictureBox();
            this.txt_Sign = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_QRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_QRCode
            // 
            this.txt_QRCode.Location = new System.Drawing.Point(13, 13);
            this.txt_QRCode.Multiline = true;
            this.txt_QRCode.Name = "txt_QRCode";
            this.txt_QRCode.Size = new System.Drawing.Size(285, 125);
            this.txt_QRCode.TabIndex = 3;
            // 
            // img_QRCode
            // 
            this.img_QRCode.Location = new System.Drawing.Point(12, 294);
            this.img_QRCode.Name = "img_QRCode";
            this.img_QRCode.Size = new System.Drawing.Size(285, 288);
            this.img_QRCode.TabIndex = 4;
            this.img_QRCode.TabStop = false;
            // 
            // txt_Sign
            // 
            this.txt_Sign.Location = new System.Drawing.Point(12, 153);
            this.txt_Sign.Multiline = true;
            this.txt_Sign.Name = "txt_Sign";
            this.txt_Sign.Size = new System.Drawing.Size(285, 125);
            this.txt_Sign.TabIndex = 5;
            // 
            // QRCodeTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 594);
            this.Controls.Add(this.txt_Sign);
            this.Controls.Add(this.img_QRCode);
            this.Controls.Add(this.txt_QRCode);
            this.Name = "QRCodeTestForm";
            this.Text = "QRCodeTestForm";
            ((System.ComponentModel.ISupportInitialize)(this.img_QRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_QRCode;
        private System.Windows.Forms.PictureBox img_QRCode;
        private System.Windows.Forms.TextBox txt_Sign;
    }
}