using System;
using System.Windows.Forms;
using StarSystemLibrary;

namespace StarSystemApp
{
    public partial class EditObjectForm : Form
    {
        private SpaceObject EditedObject;

        public EditObjectForm(SpaceObject objectToEdit)
        {
            InitializeComponent();

            if (objectToEdit == null)
            {
                MessageBox.Show("Передан null-объект в форму редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new ArgumentNullException(nameof(objectToEdit));
            }

            EditedObject = objectToEdit;

            // Заполняем поля данными объекта
            try
            {
                txtName.Text = EditedObject.Name;
                txtMass.Text = EditedObject.Mass.ToString("F2");
                txtDiameter.Text = EditedObject.EquatorialDiameter.ToString("F2");
                txtAge.Text = EditedObject.Age.ToString();

                if (EditedObject is Star star)
                {
                    nudLuminosity.Value = (decimal)star.Luminosity;
                }
                else if (EditedObject is Planet planet)
                {
                    nudMoonsCount.Value = planet.MoonsCount;
                }
                else if (EditedObject is Moon moon)
                {
                    txtPlanetName.Text = moon.PlanetName;
                }

                ToggleInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при инициализации параметров: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void ToggleInputs()
        {
            nudLuminosity.Enabled = EditedObject is Star;
            nudMoonsCount.Enabled = EditedObject is Planet;
            txtPlanetName.Enabled = EditedObject is Moon;
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверка общих параметров
                if (!float.TryParse(txtMass.Text, out var mass) || mass <= 0)
                {
                    MessageBox.Show("Масса должна быть числом больше 0.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!float.TryParse(txtDiameter.Text, out var diameter) || diameter <= 0)
                {
                    MessageBox.Show("Диаметр должен быть числом больше 0.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtAge.Text, out var age) || age <= 0)
                {
                    MessageBox.Show("Возраст должен быть числом больше 0.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении изменений: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
