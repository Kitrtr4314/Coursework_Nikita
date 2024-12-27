using System;
using System.Windows.Forms;
using StarSystemLibrary;

namespace StarSystemApp
{
    public partial class MainForm : Form
    {
        private StarSystem starSystem;

        public MainForm()
        {
            InitializeComponent();
            starSystem = new StarSystem();
            ObjectLabel.Text = "Добро пожаловать!";
        }

        private void btnAddObject_Click(object sender, EventArgs e)
        {
            var addObjectForm = new AddObjectForm();
            if (addObjectForm.ShowDialog() == DialogResult.OK)
            {
                var newObject = addObjectForm.CreatedObject;
                if (newObject != null)
                {
                    starSystem.AddSpaceObject(newObject);
                    UpdateObjectList();
                    ObjectLabel.Text = "Объект добавлен!";
                }
                else
                {
                    MessageBox.Show("Ошибка при создании объекта.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRemoveObject_Click(object sender, EventArgs e)
        {
            if (ListBoxObject.SelectedItem is SpaceObject selectedObject)
            {
                starSystem.RemoveSpaceObject(selectedObject);
                UpdateObjectList();
                ObjectLabel.Text = "Объект удалён!";
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите объект для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnViewInfo_Click(object sender, EventArgs e)
        {
            if (ListBoxObject.SelectedItem is SpaceObject selectedObject)
            {
                MessageBox.Show(selectedObject.GetInfo(), "Информация об объекте", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите объект для просмотра.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            // Пример диалогового окна для выбора параметра сортировки
            var sortDialog = new SortDialog();
            if (sortDialog.ShowDialog() == DialogResult.OK)
            {
                switch (sortDialog.SelectedCriteria)
                {
                    case "Масса":
                        starSystem.SortSpaceObjects(obj => obj.Mass);
                        break;
                    case "Диаметр":
                        starSystem.SortSpaceObjects(obj => obj.EquatorialDiameter);
                        break;
                    case "Возраст":
                        starSystem.SortSpaceObjects(obj => obj.Age);
                        break;
                    default:
                        MessageBox.Show("Неверный критерий сортировки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                UpdateObjectList();
                ObjectLabel.Text = $"Отсортировано по {sortDialog.SelectedCriteria}!";
            }
        }

        private void UpdateObjectList()
        {
            ListBoxObject.Items.Clear();
            foreach (var obj in starSystem.GetAllSpaceObjects())
            {
                ListBoxObject.Items.Add(obj);
            }
        }

        private void ListBoxObject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxObject.SelectedItem is SpaceObject selectedObject)
            {
                ObjectLabel.Text = $"Выбран объект: {selectedObject.Name}";
            }
        }
    }
}
