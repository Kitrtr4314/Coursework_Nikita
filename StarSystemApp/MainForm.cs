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
        }

        private void btnAddObject_Click(object sender, EventArgs e)
        {
            var addObjectForm = new AddObjectForm();
            if (addObjectForm.ShowDialog() == DialogResult.OK)
            {
                var newObject = addObjectForm.CreatedObject;
                starSystem.AddSpaceObject(newObject);
                UpdateObjectList();
            }
        }

        private void btnRemoveObject_Click(object sender, EventArgs e)
        {
            if (listBoxObjects.SelectedItem is SpaceObject selectedObject)
            {
                starSystem.RemoveSpaceObject(selectedObject);
                UpdateObjectList();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите объект для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnViewInfo_Click(object sender, EventArgs e)
        {
            if (listBoxObjects.SelectedItem is SpaceObject selectedObject)
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
            starSystem.SortSpaceObjects(obj => obj.Mass);
            UpdateObjectList();
        }

        private void UpdateObjectList()
        {
            listBoxObjects.Items.Clear();
            foreach (var obj in starSystem.GetAllSpaceObjects())
            {
                listBoxObjects.Items.Add(obj);
            }
        }
    }
}
