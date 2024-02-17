namespace CSC240_06_01_BedAndBreakfast_FS
{
    partial class UxBaileysForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UxWelcomeLabel = new Label();
            UxRateLabel = new Label();
            UxBelleAireCheckBox = new CheckBox();
            UxLincolnCcheckBox = new CheckBox();
            UxMealButton = new Button();
            SuspendLayout();
            // 
            // UxWelcomeLabel
            // 
            UxWelcomeLabel.AutoSize = true;
            UxWelcomeLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UxWelcomeLabel.Location = new Point(227, 93);
            UxWelcomeLabel.Name = "UxWelcomeLabel";
            UxWelcomeLabel.Size = new Size(300, 36);
            UxWelcomeLabel.TabIndex = 0;
            UxWelcomeLabel.Text = "Welcome to Bailey's";
            // 
            // UxRateLabel
            // 
            UxRateLabel.AutoSize = true;
            UxRateLabel.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UxRateLabel.Location = new Point(249, 168);
            UxRateLabel.Name = "UxRateLabel";
            UxRateLabel.Size = new Size(212, 32);
            UxRateLabel.TabIndex = 1;
            UxRateLabel.Text = "Check our rates";
            // 
            // UxBelleAireCheckBox
            // 
            UxBelleAireCheckBox.AutoSize = true;
            UxBelleAireCheckBox.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UxBelleAireCheckBox.Location = new Point(244, 234);
            UxBelleAireCheckBox.Name = "UxBelleAireCheckBox";
            UxBelleAireCheckBox.Size = new Size(217, 33);
            UxBelleAireCheckBox.TabIndex = 2;
            UxBelleAireCheckBox.Text = "Belle Aire Suite";
            UxBelleAireCheckBox.UseVisualStyleBackColor = true;
            UxBelleAireCheckBox.CheckedChanged += UxBelleAireCheckBox_CheckedChanged;
            // 
            // UxLincolnCcheckBox
            // 
            UxLincolnCcheckBox.AutoSize = true;
            UxLincolnCcheckBox.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UxLincolnCcheckBox.Location = new Point(249, 289);
            UxLincolnCcheckBox.Name = "UxLincolnCcheckBox";
            UxLincolnCcheckBox.Size = new Size(195, 33);
            UxLincolnCcheckBox.TabIndex = 3;
            UxLincolnCcheckBox.Text = "Lincoln Room";
            UxLincolnCcheckBox.UseVisualStyleBackColor = true;
            UxLincolnCcheckBox.CheckedChanged += UxLincolnCcheckBox_CheckedChanged;
            // 
            // UxMealButton
            // 
            UxMealButton.Location = new Point(244, 348);
            UxMealButton.Name = "UxMealButton";
            UxMealButton.Size = new Size(193, 29);
            UxMealButton.TabIndex = 4;
            UxMealButton.Text = "Check for meal options";
            UxMealButton.UseVisualStyleBackColor = true;
            UxMealButton.Click += UxMealButton_Click;
            // 
            // UxBaileysForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(800, 450);
            Controls.Add(UxMealButton);
            Controls.Add(UxLincolnCcheckBox);
            Controls.Add(UxBelleAireCheckBox);
            Controls.Add(UxRateLabel);
            Controls.Add(UxWelcomeLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "UxBaileysForm";
            Text = "Bailey's Bed and Breakfast";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UxWelcomeLabel;
        private Label UxRateLabel;
        private CheckBox UxBelleAireCheckBox;
        private CheckBox UxLincolnCcheckBox;
        private Button UxMealButton;
    }
}
