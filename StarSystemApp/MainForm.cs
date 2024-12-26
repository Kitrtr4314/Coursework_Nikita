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

            // Привязка обработчиков событий
            AddObject.Click += AddObject_Click;
            DeleteObject.Click += DeleteObject_Click;
            ShowInfo.Click += ShowInfo_Click;
            Sort.Click += Sort_Click;

            // Обновление списка
            UpdateListBox();
        }

        private void AddObject_Click(object sender, EventArgs e)
        {
            var addForm = new AddObjectForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                var newObject = addForm.CreatedObject;
                if (newObject != null)
                {
                    starSystem.AddObject(newObject);
                    UpdateListBox();
                }
            }
        }

        private void DeleteObject_Click(object sender, EventArgs e)
        {
            if (ListBoxObject.SelectedItem is SpaceObject selectedObject)
            {
                starSystem.RemoveObject(selectedObject);
                UpdateListBox();
            }
            else
            {
                MessageBox.Show("Выберите объект для удаления.", "Ошибка");
            }
        }

        private void ShowInfo_Click(object sender, EventArgs e)
        {
            if (ListBoxObject.SelectedItem is SpaceObject selectedObject)
            {
                ObjectLabel.Text = selectedObject.GetInfo();
            }
            else
            {
                MessageBox.Show("Выберите объект для отображения информации.", "Ошибка");
            }
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            starSystem.SortByMass(); // Допустим, сортируем по массе
            UpdateListBox();
        }

        private void UpdateListBox()
        {
            ListBoxObject.Items.Clear();
            foreach (var obj in starSystem.GetObjects())
            {
                ListBoxObject.Items.Add(obj);
            }
        }
    }
}
