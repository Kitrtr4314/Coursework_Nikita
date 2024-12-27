namespace StarSystemApp
{
    partial class EditObjectForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtMass;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtDiameter;
        private System.Windows.Forms.TextBox txtPlanetName;
        private System.Windows.Forms.NumericUpDown nudLuminosity;
        private System.Windows.Forms.NumericUpDown nudMoonsCount;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rbStar;
        private System.Windows.Forms.RadioButton rbPlanet;
        private System.Windows.Forms.RadioButton rbMoon;
        private System.Windows.Forms.GroupBox groupBox1;
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbStar = new System.Windows.Forms.RadioButton();
            this.rbPlanet = new System.Windows.Forms.RadioButton();
            this.rbMoon = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtMass = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtDiameter = new System.Windows.Forms.TextBox();
            this.txtPlanetName = new System.Windows.Forms.TextBox();
            this.nudLuminosity = new System.Windows.Forms.NumericUpDown();
            this.nudMoonsCount = new System.Windows.Forms.NumericUpDown();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            // Добавьте все элементы и их обработчики, как в `AddObjectForm`
        }
    }
}
