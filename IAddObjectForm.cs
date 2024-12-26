using System;
using System.Windows.Forms;
using StarSystemLibrary;

namespace Coursework_Nikita
{
    public partial class AddObjectForm : Form
    {
        private readonly StarSystem _starSystem;

        public AddObjectForm(StarSystem starSystem)
        {
            InitializeComponent();
            _starSystem = starSystem;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMass.Text) ||
                string.IsNullOrWhiteSpace(txtDiameter.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text))
            {
                MessageBox.Show("Заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!float.TryParse(txtMass.Text, out var mass) ||
                !float.TryParse(txtDiameter.Text, out var diameter) ||
                !int.TryParse(txtAge.Text, out var age))
            {
                MessageBox.Show("Некорректные значения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SpaceObject newObject;
            if (rbStar.Checked)
            {
                newObject = new Star
                {
                    Mass = mass,
                    EquatorialDiameter = diameter,
                    Age = age,
                    Luminosity = (float)nudLuminosity.Value
                };
            }
            else if (rbPlanet.Checked)
            {
                newObject = new Planet
                {
                    Mass = mass,
                    EquatorialDiameter = diameter,
                    Age = age,
                    MoonsCount = (int)nudMoonsCount.Value
                };
            }
            else if (rbMoon.Checked)
            {
                newObject = new Moon
                {
                    Mass = mass,
                    EquatorialDiameter = diameter,
                    Age = age,
                    PlanetName = txtPlanetName.Text
                };
            }
            else
            {
                MessageBox.Show("Выберите тип объекта.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _starSystem.AddSpaceObject(newObject);
            MessageBox.Show("Объект добавлен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void rbStar_CheckedChanged(object sender, EventArgs e)
        {
            nudLuminosity.Enabled = rbStar.Checked;
        }

        private void rbPlanet_CheckedChanged(object sender, EventArgs e)
        {
            nudMoonsCount.Enabled = rbPlanet.Checked;
        }

        private void rbMoon_CheckedChanged(object sender, EventArgs e)
        {
            txtPlanetName.Enabled = rbMoon.Checked;
        }
    }
}
