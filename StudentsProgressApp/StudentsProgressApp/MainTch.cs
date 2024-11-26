using System;
using System.IO;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;


namespace StudentsProgressApp
{
    public partial class MainTch : Form
    {
        private Dictionary<string, List<int>> studentMarks = new Dictionary<string, List<int>>();
        private string userName;
        public MainTch(string userName)
        {
            InitializeComponent();
            this.userName = userName;

            StatusLbl.Text = $"Поточна дата: {DateTime.Now.ToShortDateString()} | Користувач: {userName}";
            
            listStudents.Items.AddRange(new string[]
            { });
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

        private void SaveItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (var student in listStudents.Items)
                    {
                        string studentName = student.ToString();
                        List<int> marks = studentMarks.ContainsKey(studentName) ? studentMarks[studentName] : new List<int>();
                        
                        writer.WriteLine($"Прізвище - {studentName}, оцінки - {string.Join(", ", marks)}");
                    }
                }
            }
        }

        private void OpenItem_Click(object sender, EventArgs e)
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

        private void FontItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                menuStrip1.Font = fontDialog.Font;
                statusStrip.Font = fontDialog.Font;

                label1.Font = fontDialog.Font;
                label2.Font = fontDialog.Font;
                label3.Font = fontDialog.Font;
                label4.Font = fontDialog.Font;

                txtMark.Font = fontDialog.Font;
                txtStudent.Font = fontDialog.Font;
                txtShowMark.Font = fontDialog.Font;

                btnAddMark.Font = fontDialog.Font;
                btnAddStudent.Font = fontDialog.Font;
                btnDeleteMark.Font = fontDialog.Font;
                btnDelete.Font = fontDialog.Font;
                btnSort.Font = fontDialog.Font;
                btnSumm.Font = fontDialog.Font;
                ShowMark.Font = fontDialog.Font;

                rdNum1.Font = fontDialog.Font;
                rdNum2.Font = fontDialog.Font;

                listStudents.Font = fontDialog.Font;
                listMarks.Font = fontDialog.Font;
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

        private void webItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://elearning.kubg.edu.ua");
        }

        private void CalcItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void AboutItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ім'я: Мельничук Софія Дмитрівна \nгрупа: БІКСб12340 \nспеціальність: кібербезпека 2 курс", "Інформація про автора");
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string newStudent = txtStudent.Text.Trim();

            if (!string.IsNullOrEmpty(newStudent))
            {
                bool studentExists = listStudents.Items.Cast<string>().Any(item => item.Equals(newStudent, StringComparison.OrdinalIgnoreCase));

                if (!studentExists)
                {
                    listStudents.Items.Add(newStudent);
                    txtStudent.Clear();
                }
                else
                {
                    MessageBox.Show("Цей студент уже є в списку!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Введіть прізвище студента!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string studentToDelete = txtStudent.Text.Trim();

            if (!string.IsNullOrEmpty(studentToDelete))
            {
                var studentToRemove = listStudents.Items.Cast<string>()
                    .FirstOrDefault(item => item.Equals(studentToDelete, StringComparison.OrdinalIgnoreCase));

                if (studentToRemove != null)
                {
                    listStudents.Items.Remove(studentToRemove);
                    txtStudent.Clear();
                }
                else
                {
                    MessageBox.Show("Цей студент не знайдений у списку!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Введіть прізвище студента для видалення!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddMark_Click(object sender, EventArgs e)
        {
            if (listStudents.SelectedItem != null)
            {
                string selectedStudent = listStudents.SelectedItem.ToString();

                if (int.TryParse(txtMark.Text.Trim(), out int mark) && mark >= 0 && mark <= 100)
                {
                    if (!studentMarks.ContainsKey(selectedStudent))
                    {
                        studentMarks[selectedStudent] = new List<int>();
                    }

                    studentMarks[selectedStudent].Add(mark);

                    listMarks.Items.Add(mark);

                    txtMark.Clear();
                }
                else
                {
                    MessageBox.Show("Введіть правильну оцінку (0-100)!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Оберіть студента, щоб додати оцінку!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDeleteMark_Click(object sender, EventArgs e)
        {
            if (listMarks.SelectedItem != null)
            {
                listMarks.Items.Remove(listMarks.SelectedItem);
            }
            else
            {
                MessageBox.Show("Виберіть елемент для видалення", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (listStudents.Items.Count > 0)
            {
                List<string> studentsList = new List<string>();

                foreach (var student in listStudents.Items)
                {
                    studentsList.Add(student.ToString());
                }

                studentsList.Sort();

                listStudents.Items.Clear();

                foreach (var student in studentsList)
                {
                    listStudents.Items.Add(student);
                }
            }
            else
            {
                MessageBox.Show("Список студентів порожній!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
