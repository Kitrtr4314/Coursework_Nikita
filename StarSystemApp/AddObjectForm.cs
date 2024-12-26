using System;
using System.Windows.Forms;

namespace StarSystemApp
{
    public partial class AddObjectForm : Form
    {
        public AddObjectForm()
        {
            InitializeComponent();
        }

        private void RadioButtonMoon_CheckedChanged(object sender, EventArgs e)
        {
            // Логика для выбора "Луна"
            TxtLum.Enabled = false;
            txtMoons.Enabled = true;
            txtPlanet.Enabled = true;
        }

        private void ButtonStar_CheckedChanged(object sender, EventArgs e)
        {
            // Логика для выбора "Звезда"
            TxtLum.Enabled = true;
            txtMoons.Enabled = false;
            txtPlanet.Enabled = false;
        }

        private void RadioButtonPlanet_CheckedChanged(object sender, EventArgs e)
        {
            // Логика для выбора "Планета"
            TxtLum.Enabled = false;
            txtMoons.Enabled = true;
            txtPlanet.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Ввод массы
        }

        private void TextBoxDiametr_TextChanged(object sender, EventArgs e)
        {
            // Ввод диаметра
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Логика создания объекта
            MessageBox.Show("Объект создан");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Отмена создания
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}