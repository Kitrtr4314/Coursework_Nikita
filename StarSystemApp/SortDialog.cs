using System;
using System.Windows.Forms;
using StarSystemLibrary;

namespace StarSystemApp
{
    public partial class SortDialog : Form
    {
        public Func<SpaceObject, object> SelectedSortCriteria { get; private set; }
        public bool SortAscending { get; private set; }

        public SortDialog()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (radioMass.Checked)
            {
                SelectedSortCriteria = obj => obj.Mass;
            }
            else if (radioDiameter.Checked)
            {
                SelectedSortCriteria = obj => obj.EquatorialDiameter;
            }
            else if (radioAge.Checked)
            {
                SelectedSortCriteria = obj => obj.Age;
            }
            else
            {
                MessageBox.Show("Выберите критерий сортировки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            SortAscending = radioAscending.Checked;
            
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}