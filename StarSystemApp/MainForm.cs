using System;
using System.Linq;
using System.Windows.Forms;
using StarSystemLibrary;

namespace StarSystemApp
{
    public partial class MainForm : Form
    {
        private readonly StarSystem starSystem = new StarSystem();

        public MainForm()
        {
            InitializeComponent();
            UpdateListBox();
        }

        // Обработчик события добавления объекта
        private void button1_Click(object sender, EventArgs e)
        {
            var addForm = new AddObjectForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                var newObject = addForm.CreatedObject;
                if (newObject != null)
                {
                    starSystem.AddSpaceObject(newObject);
                    UpdateListBox();
                }
            }
        }

        // Обработчик события удаления объекта
        private void DeleteObject_Click(object sender, EventArgs e)
        {
            if (ListBoxObject.SelectedItem is SpaceObject selectedObject)
            {
                starSystem.RemoveSpaceObject(selectedObject);
                UpdateListBox();
            }
            else
            {
                MessageBox.Show("Выберите объект для удаления.", "Ошибка");
            }
        }

        // Обработчик события отображения информации
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxObject.SelectedItem is SpaceObject selectedObject)
            {
                ObjectLabel.Text = selectedObject.GetInfo();
            }
        }

        // Обработчик события сортировки
        private void Sort_Click(object sender, EventArgs e)
        {
            starSystem.SortSpaceObjects(); // Допустим, сортируем по массе
            UpdateListBox();
        }

        // Метод обновления списка в ListBox
        private void UpdateListBox()
        {
            ListBoxObject.Items.Clear();
            foreach (var obj in starSystem.GetAllSpaceObjects())
            {
                ListBoxObject.Items.Add(obj);
            }
        }
    }
}
