namespace CSC240_06_01_BedAndBreakfast_FS
{
    partial class LincolnForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LincolnForm));
            UxLincolnRoomLabel = new Label();
            UxLincolnPriceLabel = new Label();
            UxLincolnPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)UxLincolnPictureBox).BeginInit();
            SuspendLayout();
            // 
            // UxLincolnRoomLabel
            // 
            UxLincolnRoomLabel.AutoSize = true;
            UxLincolnRoomLabel.Location = new Point(91, 57);
            UxLincolnRoomLabel.Name = "UxLincolnRoomLabel";
            UxLincolnRoomLabel.Size = new Size(204, 40);
            UxLincolnRoomLabel.TabIndex = 0;
            UxLincolnRoomLabel.Text = "Return to the 1850s in this \r\nlovely room with private bath";
            // 
            // UxLincolnPriceLabel
            // 
            UxLincolnPriceLabel.AutoSize = true;
            UxLincolnPriceLabel.Location = new Point(190, 142);
            UxLincolnPriceLabel.Name = "UxLincolnPriceLabel";
            UxLincolnPriceLabel.Size = new Size(105, 20);
            UxLincolnPriceLabel.TabIndex = 1;
            UxLincolnPriceLabel.Text = "$100 per night\r\n";
            // 
            // UxLincolnPictureBox
            // 
            UxLincolnPictureBox.Image = (Image)resources.GetObject("UxLincolnPictureBox.Image");
            UxLincolnPictureBox.Location = new Point(36, 130);
            UxLincolnPictureBox.Name = "UxLincolnPictureBox";
            UxLincolnPictureBox.Size = new Size(125, 86);
            UxLincolnPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            UxLincolnPictureBox.TabIndex = 2;
            UxLincolnPictureBox.TabStop = false;
            // 
            // LincolnForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 247);
            Controls.Add(UxLincolnPictureBox);
            Controls.Add(UxLincolnPriceLabel);
            Controls.Add(UxLincolnRoomLabel);
            Name = "LincolnForm";
            Text = "Lincoln Room";
            Load += LincolnForm_Load;
            ((System.ComponentModel.ISupportInitialize)UxLincolnPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UxLincolnRoomLabel;
        private Label UxLincolnPriceLabel;
        private PictureBox UxLincolnPictureBox;
    }
}