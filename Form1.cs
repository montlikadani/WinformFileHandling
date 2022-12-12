using System;
using System.IO;
using System.Windows.Forms;

namespace FileHandling {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();

            saveFileDialog.AddExtension = true;
            saveFileDialog.CheckPathExists = true;
            saveFileDialog.Filter = "Szövegfájlok (*.txt)|*.txt|Minden fájl (*.*)|*.*";
            saveFileDialog.DefaultExt = ".txt";

            openFileDialog1.CheckFileExists = openFileDialog1.CheckPathExists = true;
            openFileDialog1.Filter = "Szövegfájlok (*.txt)|*.txt|Minden fájl (*.*)|*.*";
        }

        private void saveToFileButton_Click(object sender, EventArgs e) {
            if (saveFileDialog.ShowDialog() != DialogResult.OK) {
                return;
            }

            using (StreamWriter writer = new StreamWriter(saveFileDialog.OpenFile())) {
                writer.WriteLine($"{nevBox.Text};{datePicker.Value}");
            }

            nevBox.Text = "";
            datePicker.Value = DateTime.Now;
        }

        private void readFileButton_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() != DialogResult.OK) {
                return;
            }

            string fileName = openFileDialog1.FileName;
            string[] split = File.ReadAllText(fileName).Split(';');

            readFileRes.Text = $"Kiválasztott: {fileName}";
            nevBox.Text = split[0];

            try {
                datePicker.Value = DateTime.Parse(split[1]);
            } catch (FormatException) {
                datePicker.Value = DateTime.Now;
            }
        }
    }
}
