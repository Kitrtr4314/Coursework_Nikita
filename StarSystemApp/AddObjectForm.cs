using System;
using System.Windows.Forms;
using StarSystemLibrary;

namespace StarSystemApp
{
    public partial class AddObjectForm : Form
    {
        public SpaceObject CreatedObject { get; private set; }

        public AddObjectForm()
        {
            InitializeComponent();
            ToggleInputs();
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ToggleInputs();
        }

        private void ToggleInputs()
        {
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
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Пожалуйста, введите название объекта.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
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
                
                // Общие свойства
                string name = txtName.Text;

                if (rbStar.Checked)
                {
                    // Создание звезды
                    var luminosity = (float)nudLuminosity.Value;
                    CreatedObject = new Star
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
                    // Создание планеты
                    var moonCount = (int)nudMoonsCount.Value;
                    CreatedObject = new Planet
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
                    // Создание луны
                    var planetName = txtPlanetName.Text;
                    CreatedObject = new Moon
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
    }
}
