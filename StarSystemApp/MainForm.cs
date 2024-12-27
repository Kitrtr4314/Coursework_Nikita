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
            using (var addObjectForm = new AddObjectForm())
            {
                if (addObjectForm.ShowDialog() == DialogResult.OK)
                {
                    var newObject = addObjectForm.CreatedObject;
                    if (newObject != null)
                    {
                        starSystem.AddSpaceObject(newObject);
                        UpdateObjectList();
                        MessageBox.Show("Объект успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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
            using (var sortDialog = new SortDialog())
            {
                if (sortDialog.ShowDialog() == DialogResult.OK)
                {
                    var sortCriteria = sortDialog.SelectedSortCriteria;
                    if (sortCriteria != null)
                    {
                        starSystem.SortSpaceObjects(sortCriteria);
                        UpdateObjectList();
                        ObjectLabel.Text = "Объекты системы отсортированы.";
                    }
                }
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
                ObjectLabel.Text = $"Выбран объект: {selectedObject.GetType().Name}";
            }
            else
            {
                ObjectLabel.Text = "Выберите объект из списка.";
            }
        }
        private void btnEditObject_Click(object sender, EventArgs e)
        {
            if (ListBoxObject.SelectedItem is SpaceObject selectedObject)
            {
                using (var editObjectForm = new AddObjectForm(selectedObject))
                {
                    if (editObjectForm.ShowDialog() == DialogResult.OK)
                    {
                        UpdateObjectList(); // Обновляем список объектов после редактирования
                        MessageBox.Show("Объект успешно отредактирован!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите объект для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
