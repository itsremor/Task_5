using System;
using System.Linq;
using System.Windows.Forms;

namespace Task_5
{
    public partial class Form1 : Form
    {
        private string _title;
        private double? _screenDiagonal;

        public Form1()
        {
            InitializeComponent();
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            _title = titleTextBox.Text;
        }

        private void screenDiagonalTextBox_TextChanged(object sender, EventArgs e)
        {
            var screenDiagonalText = screenDiagonalTextBox.Text.Replace(
                ".", ","
            );
            if (screenDiagonalText == "")
            {
                _screenDiagonal = null;
            }
            else
            {
                try
                {
                    _screenDiagonal = double.Parse(screenDiagonalTextBox.Text);
                }
                catch (FormatException)
                {
                    _screenDiagonal = null;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            laptopListBox.Items.Add(
                _screenDiagonal is null ?
                    new Laptop(_title) :
                    new Laptop(_title, (double) _screenDiagonal)
            );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var list = laptopListBox.Items.Cast<Laptop>().OrderBy(
                item => item.ScreenDiagonal
            ).ToList();
            laptopListBox.Items.Clear();
            foreach (var listItem in list)
            {
                laptopListBox.Items.Add(listItem);
            }
        }
    }
}
