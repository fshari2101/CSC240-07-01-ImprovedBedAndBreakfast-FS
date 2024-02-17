namespace CSC240_06_01_BedAndBreakfast_FS
{
    public partial class UxBaileysForm : Form
    {
        public UxBaileysForm()
        {
            InitializeComponent();
        }

        private void UxBelleAireCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (UxBelleAireCheckBox.Checked) ;

            {
                // Class Object = new Constructor();
                BelleAireForm BelleAireForm = new BelleAireForm();
                BelleAireForm.ShowDialog();
                UxBelleAireCheckBox.Checked = false;
            }
        }

        private void UxLincolnCcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (UxLincolnCcheckBox.Checked) ;
            {
                LincolnForm LincolnForm = new LincolnForm();
                LincolnForm.ShowDialog();
                UxLincolnCcheckBox.Checked = false;
            }
        }

        private void UxMealButton_Click(object sender, EventArgs e)
        {
           BreakfastOptionForm breakfastForm = new BreakfastOptionForm();
            breakfastForm.ShowDialog();
        }
    }
}
