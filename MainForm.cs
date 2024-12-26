using System;
using System.Linq;
using System.Windows.Forms;
using StarSystemLibrary;

namespace Coursework_Nikita
{
    public partial class MainForm : Form
    {
        private readonly StarSystem _starSystem;

        public MainForm()
        {
            InitializeComponent();
            _starSystem = new StarSystem();
            UpdateObjectList();
        }

        private void UpdateObjectList()
        {
            listBoxObjects.Items.Clear();
            foreach (var obj in _starSystem.GetAllSpaceObjects())
            {
                listBoxObjects.Items.Add(obj.GetType().Name + $": {obj.GetInfo()}");
            }
        }

        private void btnAddObject_Click(object sender, EventArgs e)
        {
            var addObjectForm = new AddObjectForm(_starSystem);
            addObjectForm.ShowDialog();
            UpdateObjectList();
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            if (listBoxObjects.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите объект из списка.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedObject = _starSystem.GetAllSpaceObjects()[listBoxObjects.SelectedIndex];
            MessageBox.Show(selectedObject.GetInfo(), "Информация об объекте", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDeleteObject_Click(object sender, EventArgs e)
        {
            if (listBoxObjects.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите объект из списка.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedObject = _starSystem.GetAllSpaceObjects()[listBoxObjects.SelectedIndex];
            _starSystem.RemoveSpaceObject(selectedObject);
            UpdateObjectList();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            _starSystem.SortSpaceObjects(obj => obj.Mass); // Сортировка по массе
            UpdateObjectList();
        }
    }
}
