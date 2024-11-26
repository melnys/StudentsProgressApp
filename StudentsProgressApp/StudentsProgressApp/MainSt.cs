using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace StudentsProgressApp
{
    public partial class MainSt : Form
    {
        private Dictionary<string, List<int>> studentMarks = new Dictionary<string, List<int>>();
        private string userName;
        public MainSt(string userName)
        {
            InitializeComponent();
            this.userName = userName;

            StatusLbl.Text = $"Поточна дата: {DateTime.Now.ToShortDateString()} | Користувач: {userName}";
        }

        private void ExitItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Ви точно хочете вийти з аккаунту?", "Увага!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (res == DialogResult.Yes)
            {
                this.Close();
                Registration registrationForm = new Registration();
                registrationForm.Show();
            }
            else if (res == DialogResult.No)
            {
                return;
            }
        }

        private void ColorItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog.Color;
            }
        }

        private void FontItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                menuStrip1.Font = fontDialog.Font;
                statusStrip.Font = fontDialog.Font;

                label1.Font = fontDialog.Font;
                label3.Font = fontDialog.Font;
                ShowMark.Font = fontDialog.Font;

                rdNum1.Font = fontDialog.Font;
                rdNum2.Font = fontDialog.Font;

                listStudents.Font = fontDialog.Font;
                listMarks.Font = fontDialog.Font;
            }
        }

        private void OpenFileItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(openFileDialog.FileName);

                listStudents.Items.Clear();
                studentMarks.Clear();
                listMarks.Items.Clear();

                foreach (string line in lines)
                {
                    var parts = line.Split(new[] { " - " }, StringSplitOptions.RemoveEmptyEntries);

                    if (parts.Length == 2)
                    {
                        string studentName = parts[0].Trim();
                        string[] marksStr = parts[1].Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        List<int> marks = marksStr.Select(m => int.Parse(m.Trim())).ToList();

                        listStudents.Items.Add(studentName);
                        studentMarks[studentName] = marks;
                    }
                }
            }
        }

        private void SaveItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    for (int i = 0; i < listStudents.Items.Count; i++)
                    {
                        string student = listStudents.Items[i].ToString();
                        string marks = string.Join(", ", listMarks.Items.Cast<string>().ToArray());
                        writer.WriteLine($"{student} - {marks}");
                    }
                }
            }
        }

        private void CalcItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void AboutItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ім'я: Мельничук Софія Дмитрівна \nгрупа: БІКСб12340 \nспеціальність: кібербезпека 2 курс", "Інформація про автора");
        }

        private void webItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://elearning.kubg.edu.ua");
        }

        private void ShowMark_Click(object sender, EventArgs e)
        {
            if (listStudents.SelectedItem != null)
            {
                txtShowMark.Clear();
                string selectedStudent = listStudents.SelectedItem.ToString();

                var marks = listMarks.Items.Cast<string>().Select(int.Parse).ToList();

                if (marks.Count > 0)
                {
                    double average = marks.Average();

                    txtShowMark.Text = rdNum1.Checked ? Math.Round(average).ToString() : average.ToString("F2");
                }
            }
        }

        private void listStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            listMarks.Items.Clear();

            if (listStudents.SelectedItem != null)
            {
                string selectedStudent = listStudents.SelectedItem.ToString();

                if (studentMarks.ContainsKey(selectedStudent))
                {
                    listMarks.Items.AddRange(studentMarks[selectedStudent].Select(m => m.ToString()).ToArray());
                }
            }
        }

        private void btnSumm_Click(object sender, EventArgs e)
        {
            if (listStudents.SelectedItem != null)
            {
                string selectedStudent = listStudents.SelectedItem.ToString();

                if (studentMarks.ContainsKey(selectedStudent))
                {
                    int sum = studentMarks[selectedStudent].Sum();

                    txtShowMark.Text = sum.ToString();
                }
                else
                {
                    MessageBox.Show("У обраного студента немає оцінок.");
                    txtShowMark.Clear();
                }
            }
            else
            {
                MessageBox.Show("Оберіть студента зі списку.");
                txtShowMark.Clear();
            }
        }

        private void PrintItem_Click(object sender, EventArgs e)
        {
            using (var printDialog = new PrintDialog())
            {
                printDialog.ShowDialog();
            }
        }

    }
}
