using System;
using System.Windows.Forms;

namespace StarSystemApp
{
    public partial class AddObjectForm : Form
    {
        public AddObjectForm()
        {
            InitializeComponent();

            // Привязка событий для радиокнопок
            rbStar.CheckedChanged += RadioButton_CheckedChanged;
            rbPlanet.CheckedChanged += RadioButton_CheckedChanged;
            rbMoon.CheckedChanged += RadioButton_CheckedChanged;

            // Инициализация состояния интерфейса
            UpdateFormState();
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFormState();
        }

        private void UpdateFormState()
        {
            // Установка видимости специфичных элементов
            nudLuminosity.Visible = rbStar.Checked;
            nudMoonsCount.Visible = rbPlanet.Checked;
            txtPlanetName.Visible = rbMoon.Checked;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // Проверка заполненности обязательных полей
            if (string.IsNullOrWhiteSpace(txtMass.Text) ||
                string.IsNullOrWhiteSpace(txtDiameter.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text))
            {
                MessageBox.Show("Заполните все обязательные поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Создание объекта в зависимости от выбора пользователя
            if (rbStar.Checked)
            {
                // Логика для создания звезды
                MessageBox.Show("Звезда добавлена.");
            }
            else if (rbPlanet.Checked)
            {
                // Логика для создания планеты
                MessageBox.Show("Планета добавлена.");
            }
            else if (rbMoon.Checked)
            {
                // Логика для создания луны
                MessageBox.Show("Луна добавлена.");
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
