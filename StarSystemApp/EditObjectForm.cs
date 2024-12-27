using System;
using System.Windows.Forms;
using StarSystemLibrary;

namespace StarSystemApp
{
    public partial class EditObjectForm : Form
    {
        public SpaceObject EditedObject { get; private set; }

        public EditObjectForm(SpaceObject existingObject)
        {
            InitializeComponent();
            EditedObject = existingObject;
            FillFormFields();
            ToggleInputs();
        }

        private void FillFormFields()
        {
            // Заполнение полей данными существующего объекта
            txtName.Text = EditedObject.Name;
            txtMass.Text = EditedObject.Mass.ToString();
            txtDiameter.Text = EditedObject.EquatorialDiameter.ToString();
            txtAge.Text = EditedObject.Age.ToString();

            // В зависимости от типа объекта, включаем нужные поля
            if (EditedObject is Star star)
            {
                rbStar.Checked = true;
                nudLuminosity.Value = (decimal)star.Luminosity;
            }
            else if (EditedObject is Planet planet)
            {
                rbPlanet.Checked = true;
                nudMoonsCount.Value = planet.MoonsCount;
            }
            else if (EditedObject is Moon moon)
            {
                rbMoon.Checked = true;
                txtPlanetName.Text = moon.PlanetName;
            }
        }

        private void ToggleInputs()
        {
            // Блокируем или разблокируем поля в зависимости от типа объекта
            if (rbStar.Checked)
            {
                nudLuminosity.Enabled = true;
                nudMoonsCount.Enabled = false;
                txtPlanetName.Enabled = false;
            }
            else if (rbPlanet.Checked)
            {
                nudLuminosity.Enabled = false;
                nudMoonsCount.Enabled = true;
                txtPlanetName.Enabled = false;
            }
            else if (rbMoon.Checked)
            {
                nudLuminosity.Enabled = false;
                nudMoonsCount.Enabled = false;
                txtPlanetName.Enabled = true;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверка на валидность массы, диаметра и возраста
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

                string name = txtName.Text;

                if (rbStar.Checked)
                {
                    var luminosity = (float)nudLuminosity.Value;
                    EditedObject = new Star
                    {
                        Mass = mass,
                        EquatorialDiameter = diameter,
                        Age = age,
                        Luminosity = luminosity,
                        Name = name
                    };
                }
                else if (rbPlanet.Checked)
                {
                    var moonCount = (int)nudMoonsCount.Value;
                    EditedObject = new Planet
                    {
                        Mass = mass,
                        EquatorialDiameter = diameter,
                        Age = age,
                        MoonsCount = moonCount,
                        Name = name
                    };
                }
                else if (rbMoon.Checked)
                {
                    var planetName = txtPlanetName.Text;
                    EditedObject = new Moon
                    {
                        Mass = mass,
                        EquatorialDiameter = diameter,
                        Age = age,
                        PlanetName = planetName,
                        Name = name
                    };
                }
                else
                {
                    MessageBox.Show("Выберите тип объекта.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите корректные значения во все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ToggleInputs();
        }
    }
}
