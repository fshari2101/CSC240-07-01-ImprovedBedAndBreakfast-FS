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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // UxBreakfastOptionLabel
            // 
            UxBreakfastOptionLabel.AutoSize = true;
            UxBreakfastOptionLabel.Font = new Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UxBreakfastOptionLabel.Location = new Point(46, 52);
            UxBreakfastOptionLabel.Name = "UxBreakfastOptionLabel";
            UxBreakfastOptionLabel.Size = new Size(367, 29);
            UxBreakfastOptionLabel.TabIndex = 0;
            UxBreakfastOptionLabel.Text = "Select your breakfast option";
            // 
            // UxContinenetalRadioButton
            // 
            UxContinenetalRadioButton.AutoSize = true;
            UxContinenetalRadioButton.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UxContinenetalRadioButton.Location = new Point(67, 106);
            UxContinenetalRadioButton.Name = "UxContinenetalRadioButton";
            UxContinenetalRadioButton.Size = new Size(153, 28);
            UxContinenetalRadioButton.TabIndex = 1;
            UxContinenetalRadioButton.TabStop = true;
            UxContinenetalRadioButton.Text = "Continental";
            UxContinenetalRadioButton.UseVisualStyleBackColor = true;
            UxContinenetalRadioButton.CheckedChanged += UxContinenetalRadioButton_CheckedChanged;
            // 
            // UxFullRadioButton
            // 
            UxFullRadioButton.AutoSize = true;
            UxFullRadioButton.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UxFullRadioButton.Location = new Point(67, 187);
            UxFullRadioButton.Name = "UxFullRadioButton";
            UxFullRadioButton.Size = new Size(72, 28);
            UxFullRadioButton.TabIndex = 2;
            UxFullRadioButton.TabStop = true;
            UxFullRadioButton.Text = "Full";
            UxFullRadioButton.UseVisualStyleBackColor = true;
            UxFullRadioButton.CheckedChanged += UxFullRadioButton_CheckedChanged;
            // 
            // UxDeluxeRadioButton
            // 
            UxDeluxeRadioButton.AutoSize = true;
            UxDeluxeRadioButton.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UxDeluxeRadioButton.Location = new Point(67, 271);
            UxDeluxeRadioButton.Name = "UxDeluxeRadioButton";
            UxDeluxeRadioButton.Size = new Size(103, 28);
            UxDeluxeRadioButton.TabIndex = 3;
            UxDeluxeRadioButton.TabStop = true;
            UxDeluxeRadioButton.Text = "Deluxe";
            UxDeluxeRadioButton.UseVisualStyleBackColor = true;
            UxDeluxeRadioButton.CheckedChanged += UxDeluxeRadioButton_CheckedChanged;
            // 
            // UxPriceLabel
            // 
            UxPriceLabel.AutoSize = true;
            UxPriceLabel.Font = new Font("Georgia", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            UxPriceLabel.Location = new Point(190, 325);
            UxPriceLabel.Name = "UxPriceLabel";
            UxPriceLabel.Size = new Size(100, 32);
            UxPriceLabel.TabIndex = 4;
            UxPriceLabel.Text = "Price:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Breakfast;
            pictureBox1.Location = new Point(387, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(319, 231);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // BreakfastOptionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
            ClientSize = new Size(757, 383);
            Controls.Add(pictureBox1);
            Controls.Add(UxPriceLabel);
            Controls.Add(UxDeluxeRadioButton);
            Controls.Add(UxFullRadioButton);
            Controls.Add(UxContinenetalRadioButton);
            Controls.Add(UxBreakfastOptionLabel);
            Name = "BreakfastOptionForm";
            Text = "BreakfastOptionForm";
            Load += BreakfastOptionForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UxBreakfastOptionLabel;
        private RadioButton UxContinenetalRadioButton;
        private RadioButton UxFullRadioButton;
        private RadioButton UxDeluxeRadioButton;
        private Label UxPriceLabel;
        private PictureBox pictureBox1;
    }
}