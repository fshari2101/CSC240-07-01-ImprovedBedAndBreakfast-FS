namespace CSC240_06_01_BedAndBreakfast_FS
{
    partial class BelleAireForm
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
            UxBelleAireDecriptionLabel = new Label();
            UxBelleAirePriceLabel = new Label();
            SuspendLayout();
            // 
            // UxBelleAireDecriptionLabel
            // 
            UxBelleAireDecriptionLabel.AutoSize = true;
            UxBelleAireDecriptionLabel.Location = new Point(129, 62);
            UxBelleAireDecriptionLabel.Name = "UxBelleAireDecriptionLabel";
            UxBelleAireDecriptionLabel.Size = new Size(256, 40);
            UxBelleAireDecriptionLabel.TabIndex = 0;
            UxBelleAireDecriptionLabel.Text = "The BelleAire suite has two bedroom,\r\ntwo baths, and a private belcony\r\n";
            // 
            // UxBelleAirePriceLabel
            // 
            UxBelleAirePriceLabel.AutoSize = true;
            UxBelleAirePriceLabel.Location = new Point(150, 142);
            UxBelleAirePriceLabel.Name = "UxBelleAirePriceLabel";
            UxBelleAirePriceLabel.Size = new Size(105, 20);
            UxBelleAirePriceLabel.TabIndex = 1;
            UxBelleAirePriceLabel.Text = "$199 per night";
            // 
            // BelleAireForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(800, 450);
            Controls.Add(UxBelleAirePriceLabel);
            Controls.Add(UxBelleAireDecriptionLabel);
            Name = "BelleAireForm";
            Text = "BelleAireForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UxBelleAireDecriptionLabel;
        private Label UxBelleAirePriceLabel;
    }
}