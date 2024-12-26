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
            UpdateControls();
        }

        // Метод обновления доступных контролов в зависимости от выбранного типа объекта
        private void UpdateControls()
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

        // Обработчик переключения радиокнопок
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }

        // Обработчик создания объекта
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                // Общие свойства
                var mass = float.Parse(txtMass.Text);
                var diameter = float.Parse(txtDiameter.Text);
                var age = int.Parse(txtAge.Text);

                if (rbStar.Checked)
                {
                    // Создание объекта типа Star
                    var luminosity = (float)nudLuminosity.Value;
                    CreatedObject = new Star
                    {
                        Mass = mass,
                        EquatorialDiameter = diameter,
                        Age = age,
                        Luminosity = luminosity
                    };
                }
                else if (rbPlanet.Checked)
                {
                    // Создание объекта типа Planet
                    var moonsCount = (int)nudMoonsCount.Value;
                    CreatedObject = new Planet
                    {
                        Mass = mass,
                        EquatorialDiameter = diameter,
                        Age = age,
                        MoonsCount = moonsCount
                    };
                }
                else if (rbMoon.Checked)
                {
                    // Создание объекта типа Moon
                    var planetName = txtPlanetName.Text;
                    CreatedObject = new Moon
                    {
                        Mass = mass,
                        EquatorialDiameter = diameter,
                        Age = age,
                        PlanetName = planetName
                    };
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка ввода данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обработчик отмены создания объекта
        private void btnCancel_Click(object sender, EventArgs e)
        {
            CreatedObject = null;
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
