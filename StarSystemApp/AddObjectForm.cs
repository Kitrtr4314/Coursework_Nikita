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
                txtPlanetName.Enabled = false;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                // Общие свойства
                var mass = float.Parse(txtMass.Text);
                var diameter = float.Parse(txtDiameter.Text);
                var age = int.Parse(txtAge.Text);

                if (rbStar.Checked)
                {
                    // Создание звезды
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
                    // Создание планеты
                    var moonCount = (int)nudMoonsCount.Value;
                    CreatedObject = new Planet
                    {
                        Mass = mass,
                        EquatorialDiameter = diameter,
                        Age = age,
                        MoonsCount = moonCount
                    };
                }
                else if (rbMoon.Checked)
                {
                    // Создание луны
                    CreatedObject = new Moon
                    {
                        Mass = mass,
                        EquatorialDiameter = diameter,
                        Age = age
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
