using System;
using System.Windows.Forms;
using StarSystemLibrary;

namespace StarSystemApp
{
    public partial class AddObjectForm : Form
    {
        public SpaceObject CreatedObject { get; private set; }

        public AddObjectForm(SpaceObject objectToEdit = null)
        {
            InitializeComponent();
            if (objectToEdit != null)
            {
                // Заполнение полей значениями существующего объекта, если он передан для редактирования
                txtName.Text = objectToEdit.Name;
                txtMass.Text = objectToEdit.Mass.ToString();
                txtDiameter.Text = objectToEdit.EquatorialDiameter.ToString();
                txtAge.Text = objectToEdit.Age.ToString();

                if (objectToEdit is Star star)
                {
                    rbStar.Checked = true;
                    nudLuminosity.Value = (decimal)star.Luminosity;
                }
                else if (objectToEdit is Planet planet)
                {
                    rbPlanet.Checked = true;
                    nudMoonsCount.Value = planet.MoonsCount;
                }
                else if (objectToEdit is Moon moon)
                {
                    rbMoon.Checked = true;
                    txtPlanetName.Text = moon.PlanetName;
                }

                CreatedObject = objectToEdit; // Сохраняем объект для редактирования
            }
            
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
                    // Создание или обновление звезды
                    var luminosity = (float)nudLuminosity.Value;
                    if (CreatedObject is Star star)
                    {
                        star.Name = name;
                        star.Mass = mass;
                        star.EquatorialDiameter = diameter;
                        star.Age = age;
                        star.Luminosity = luminosity;
                    }
                    else
                    {
                        CreatedObject = new Star
                        {
                            Name = name,
                            Mass = mass,
                            EquatorialDiameter = diameter,
                            Age = age,
                            Luminosity = luminosity
                        };
                    }
                }
                else if (rbPlanet.Checked)
                {
                    // Создание или обновление планеты
                    var moonCount = (int)nudMoonsCount.Value;
                    if (CreatedObject is Planet planet)
                    {
                        planet.Name = name;
                        planet.Mass = mass;
                        planet.EquatorialDiameter = diameter;
                        planet.Age = age;
                        planet.MoonsCount = moonCount;
                    }
                    else
                    {
                        CreatedObject = new Planet
                        {
                            Name = name,
                            Mass = mass,
                            EquatorialDiameter = diameter,
                            Age = age,
                            MoonsCount = moonCount
                        };
                    }
                }
                else if (rbMoon.Checked)
                {
                    // Создание или обновление луны
                    var planetName = txtPlanetName.Text;
                    if (CreatedObject is Moon moon)
                    {
                        moon.Name = name;
                        moon.Mass = mass;
                        moon.EquatorialDiameter = diameter;
                        moon.Age = age;
                        moon.PlanetName = planetName;
                    }
                    else
                    {
                        CreatedObject = new Moon
                        {
                            Name = name,
                            Mass = mass,
                            EquatorialDiameter = diameter,
                            Age = age,
                            PlanetName = planetName
                        };
                    }
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
