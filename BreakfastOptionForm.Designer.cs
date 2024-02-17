namespace CSC240_06_01_BedAndBreakfast_FS
{
    partial class BreakfastOptionForm
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
            UxBreakfastOptionLabel = new Label();
            UxContinenetalRadioButton = new RadioButton();
            UxFullRadioButton = new RadioButton();
            UxDeluxeRadioButton = new RadioButton();
            UxPriceLabel = new Label();
            SuspendLayout();
            // 
            // UxBreakfastOptionLabel
            // 
            UxBreakfastOptionLabel.AutoSize = true;
            UxBreakfastOptionLabel.Font = new Font("Georgia", 12F);
            UxBreakfastOptionLabel.Location = new Point(130, 63);
            UxBreakfastOptionLabel.Name = "UxBreakfastOptionLabel";
            UxBreakfastOptionLabel.Size = new Size(260, 24);
            UxBreakfastOptionLabel.TabIndex = 0;
            UxBreakfastOptionLabel.Text = "Select your breakfast option";
            // 
            // UxContinenetalRadioButton
            // 
            UxContinenetalRadioButton.AutoSize = true;
            UxContinenetalRadioButton.Font = new Font("Georgia", 12F);
            UxContinenetalRadioButton.Location = new Point(148, 134);
            UxContinenetalRadioButton.Name = "UxContinenetalRadioButton";
            UxContinenetalRadioButton.Size = new Size(137, 28);
            UxContinenetalRadioButton.TabIndex = 1;
            UxContinenetalRadioButton.TabStop = true;
            UxContinenetalRadioButton.Text = "Continental";
            UxContinenetalRadioButton.UseVisualStyleBackColor = true;
            UxContinenetalRadioButton.CheckedChanged += UxContinenetalRadioButton_CheckedChanged;
            // 
            // UxFullRadioButton
            // 
            UxFullRadioButton.AutoSize = true;
            UxFullRadioButton.Font = new Font("Georgia", 12F);
            UxFullRadioButton.Location = new Point(148, 196);
            UxFullRadioButton.Name = "UxFullRadioButton";
            UxFullRadioButton.Size = new Size(67, 28);
            UxFullRadioButton.TabIndex = 2;
            UxFullRadioButton.TabStop = true;
            UxFullRadioButton.Text = "Full";
            UxFullRadioButton.UseVisualStyleBackColor = true;
            UxFullRadioButton.CheckedChanged += UxFullRadioButton_CheckedChanged;
            // 
            // UxDeluxeRadioButton
            // 
            UxDeluxeRadioButton.AutoSize = true;
            UxDeluxeRadioButton.Font = new Font("Georgia", 12F);
            UxDeluxeRadioButton.Location = new Point(148, 250);
            UxDeluxeRadioButton.Name = "UxDeluxeRadioButton";
            UxDeluxeRadioButton.Size = new Size(94, 28);
            UxDeluxeRadioButton.TabIndex = 3;
            UxDeluxeRadioButton.TabStop = true;
            UxDeluxeRadioButton.Text = "Deluxe";
            UxDeluxeRadioButton.UseVisualStyleBackColor = true;
            UxDeluxeRadioButton.CheckedChanged += UxDeluxeRadioButton_CheckedChanged;
            // 
            // UxPriceLabel
            // 
            UxPriceLabel.AutoSize = true;
            UxPriceLabel.Font = new Font("Georgia", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UxPriceLabel.Location = new Point(251, 316);
            UxPriceLabel.Name = "UxPriceLabel";
            UxPriceLabel.Size = new Size(100, 32);
            UxPriceLabel.TabIndex = 4;
            UxPriceLabel.Text = "Price:";
            // 
            // BreakfastOptionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(800, 450);
            Controls.Add(UxPriceLabel);
            Controls.Add(UxDeluxeRadioButton);
            Controls.Add(UxFullRadioButton);
            Controls.Add(UxContinenetalRadioButton);
            Controls.Add(UxBreakfastOptionLabel);
            Name = "BreakfastOptionForm";
            Text = "BreakfastOptionForm";
            Load += BreakfastOptionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UxBreakfastOptionLabel;
        private RadioButton UxContinenetalRadioButton;
        private RadioButton UxFullRadioButton;
        private RadioButton UxDeluxeRadioButton;
        private Label UxPriceLabel;
    }
}