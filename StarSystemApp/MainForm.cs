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
                    starSystem.AddObject(newObject);
                    UpdateListBox();
                }
            }
        }

        // Обработчик события удаления объекта
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
            starSystem.SortByMass(); // Сортируем по массе
            UpdateListBox();
        }

        // Обработчик события для кнопки "Посмотреть информацию"
        private void ShowInfo_Click(object sender, EventArgs e)
        {
            if (ListBoxObject.SelectedItem is SpaceObject selectedObject)
            {
                // Отображаем полную информацию о выбранном объекте
                MessageBox.Show(selectedObject.GetInfo(), "Информация о объекте");
            }
            else
            {
                MessageBox.Show("Выберите объект для просмотра информации.", "Ошибка");
            }
        }

        // Метод обновления списка в ListBox
        private void UpdateListBox()
        {
            ListBoxObject.Items.Clear();
            foreach (var obj in starSystem.GetObjects())
            {
                // Можно отображать только имя или тип объекта, чтобы список был более удобочитаемым
                ListBoxObject.Items.Add(obj.Name); // или obj.GetType().Name если нужно имя класса
            }
        }
    }
}
