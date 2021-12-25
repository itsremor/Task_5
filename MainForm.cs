using System;
using System.Windows.Forms;

namespace Task_5
{
    public partial class Form1 : Form
    {
        private string _fullName = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            _fullName = FullNameTextBox.Text;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (_fullName.Equals(""))
                return;
            NeurosurgeonsListBox.Items.Add(new Neurosurgeon(_fullName));
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            var selectedItem = NeurosurgeonsListBox.SelectedItem;
            if (!(selectedItem is null))
                NeurosurgeonsListBox.Items.Remove(selectedItem);
        }
    }
}
