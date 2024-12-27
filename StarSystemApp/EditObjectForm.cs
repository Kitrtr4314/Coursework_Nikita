using System;
using System.Windows.Forms;
using StarSystemLibrary;

namespace StarSystemApp
{
    public partial class EditObjectForm : Form
    {
        private SpaceObject EditedObject;

        // Конструктор для передачи объекта
        public EditObjectForm(SpaceObject objectToEdit)
        {
            InitializeComponent();
            EditedObject = objectToEdit;

            // Заполняем поля данными объекта
            txtName.Text = EditedObject.Name;
            txtMass.Text = EditedObject.Mass.ToString();
            txtDiameter.Text = EditedObject.EquatorialDiameter.ToString();
            txtAge.Text = EditedObject.Age.ToString();

            // Заполняем специфичные поля
            if (EditedObject is Star star)
            {
                nudLuminosity.Value = (decimal)star.Luminosity;
                nudLuminosity.Enabled = true; // Для звезды доступно поле светимости
            }
            else if (EditedObject is Planet planet)
            {
                nudMoonsCount.Value = planet.MoonsCount;
                nudMoonsCount.Enabled = true; // Для планеты доступно поле количества лун
            }
            else if (EditedObject is Moon moon)
            {
                txtPlanetName.Text = moon.PlanetName;
                txtPlanetName.Enabled = true; // Для луны доступно поле планеты
            }

            // Блокируем или разблокируем поля в зависимости от типа объекта
            ToggleInputs();
        }

        private void ToggleInputs()
        {
            // Блокировка/разблокировка полей в зависимости от типа объекта
            nudLuminosity.Enabled = EditedObject is Star;
            nudMoonsCount.Enabled = EditedObject is Planet;
            txtPlanetName.Enabled = EditedObject is Moon;
        }

        // Обработчик для кнопки Сохранить
        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверка и сохранение общих параметров
                if (!float.TryParse(txtMass.Text, out var mass) || mass <= 0)
                {
                    MessageBox.Show("Масса должна быть числом больше 0.", "Ошибка", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                if (!float.TryParse(txtDiameter.Text, out var diameter) || diameter <= 0)
                {
                    MessageBox.Show("Диаметр должен быть числом больше 0.", "Ошибка", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtAge.Text, out var age) || age <= 0)
                {
                    MessageBox.Show("Возраст должен быть числом больше 0.", "Ошибка", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                // Обновление общих свойств
                EditedObject.UpdateProperties(mass, diameter, age);

                // Специфичные параметры для каждого типа объекта
                if (EditedObject is Star star)
                {
                    star.Luminosity = (float)nudLuminosity.Value;
                }
                else if (EditedObject is Planet planet)
                {
                    planet.MoonsCount = (int)nudMoonsCount.Value;
                }
                else if (EditedObject is Moon moon)
                {
                    moon.PlanetName = txtPlanetName.Text;
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите корректные значения во все поля.", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void txtMass_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}