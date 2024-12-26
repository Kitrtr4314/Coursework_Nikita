using System;
using System.Windows.Forms;

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
                starSystem.AddObject(newObject);
                UpdateObjectList();
            }
        }

        private void btnRemoveObject_Click(object sender, EventArgs e)
        {
            if (listBoxObjects.SelectedItem is CelestialObject selectedObject)
            {
                starSystem.RemoveObject(selectedObject);
                UpdateObjectList();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите объект для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnViewInfo_Click(object sender, EventArgs e)
        {
            if (listBoxObjects.SelectedItem is CelestialObject selectedObject)
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
            starSystem.SortByMass();
            UpdateObjectList();
        }

        private void UpdateObjectList()
        {
            listBoxObjects.Items.Clear();
            foreach (var obj in starSystem.GetObjects())
            {
                listBoxObjects.Items.Add(obj);
            }
        }
    }
}
