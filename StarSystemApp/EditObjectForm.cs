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
        }

        private void ToggleInputs()
        {
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

        private void txtMass_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void lblmass_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
