
namespace StudentsProgressApp
{
    partial class MainTch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainTch));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ExitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зовнішнійВиглядToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CalcItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.listStudents = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMark = new System.Windows.Forms.TextBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.listMarks = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddMark = new System.Windows.Forms.Button();
            this.txtShowMark = new System.Windows.Forms.TextBox();
            this.ShowMark = new System.Windows.Forms.Button();
            this.rdNum1 = new System.Windows.Forms.RadioButton();
            this.rdNum2 = new System.Windows.Forms.RadioButton();
            this.txtStudent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnSumm = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDeleteMark = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitItem,
            this.зовнішнійВиглядToolStripMenuItem,
            this.файлToolStripMenuItem,
            this.CalcItem,
            this.AboutItem,
            this.webItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(161, 557);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ExitItem
            // 
            this.ExitItem.Name = "ExitItem";
            this.ExitItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.ExitItem.Size = new System.Drawing.Size(142, 24);
            this.ExitItem.Text = "Вихід";
            this.ExitItem.Click += new System.EventHandler(this.ExitItem_Click);
            // 
            // зовнішнійВиглядToolStripMenuItem
            // 
            this.зовнішнійВиглядToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ColorItem,
            this.FontItem});
            this.зовнішнійВиглядToolStripMenuItem.Name = "зовнішнійВиглядToolStripMenuItem";
            this.зовнішнійВиглядToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.зовнішнійВиглядToolStripMenuItem.Text = "Зовнішній вигляд";
            // 
            // ColorItem
            // 
            this.ColorItem.Name = "ColorItem";
            this.ColorItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.ColorItem.Size = new System.Drawing.Size(306, 26);
            this.ColorItem.Text = "Зміна кольору фону";
            this.ColorItem.Click += new System.EventHandler(this.ColorItem_Click);
            // 
            // FontItem
            // 
            this.FontItem.Name = "FontItem";
            this.FontItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.FontItem.Size = new System.Drawing.Size(306, 26);
            this.FontItem.Text = "Зміна шрифту";
            this.FontItem.Click += new System.EventHandler(this.FontItem_Click);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenItem,
            this.SaveItem,
            this.PrintItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // OpenItem
            // 
            this.OpenItem.Name = "OpenItem";
            this.OpenItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.OpenItem.Size = new System.Drawing.Size(275, 26);
            this.OpenItem.Text = "Відкрити файл";
            this.OpenItem.Click += new System.EventHandler(this.OpenItem_Click);
            // 
            // SaveItem
            // 
            this.SaveItem.Name = "SaveItem";
            this.SaveItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.SaveItem.Size = new System.Drawing.Size(275, 26);
            this.SaveItem.Text = "Зберігти у файл";
            this.SaveItem.Click += new System.EventHandler(this.SaveItem_Click);
            // 
            // PrintItem
            // 
            this.PrintItem.Name = "PrintItem";
            this.PrintItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.PrintItem.Size = new System.Drawing.Size(275, 26);
            this.PrintItem.Text = "Друк файлу";
            this.PrintItem.Click += new System.EventHandler(this.PrintItem_Click);
            // 
            // CalcItem
            // 
            this.CalcItem.Name = "CalcItem";
            this.CalcItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.CalcItem.Size = new System.Drawing.Size(142, 24);
            this.CalcItem.Text = "Калькулятор";
            this.CalcItem.Click += new System.EventHandler(this.CalcItem_Click);
            // 
            // AboutItem
            // 
            this.AboutItem.Name = "AboutItem";
            this.AboutItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.AboutItem.Size = new System.Drawing.Size(142, 24);
            this.AboutItem.Text = "Про автора";
            this.AboutItem.Click += new System.EventHandler(this.AboutItem_Click);
            // 
            // webItem
            // 
            this.webItem.Name = "webItem";
            this.webItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.W)));
            this.webItem.Size = new System.Drawing.Size(142, 24);
            this.webItem.Text = "Сторінка КСУБГу";
            this.webItem.Click += new System.EventHandler(this.webItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(161, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(740, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "Зміна кольору фону";
            this.toolStripButton1.Click += new System.EventHandler(this.ColorItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton2.Text = "Зміна шрифту";
            this.toolStripButton2.Click += new System.EventHandler(this.FontItem_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton3.Text = "Відкрити файл";
            this.toolStripButton3.Click += new System.EventHandler(this.OpenItem_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton4.Text = "Зберігти у файл";
            this.toolStripButton4.Click += new System.EventHandler(this.SaveItem_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton5.Text = "Друк файлу";
            this.toolStripButton5.Click += new System.EventHandler(this.PrintItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Font = new System.Drawing.Font("MingLiU-ExtB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLbl});
            this.statusStrip.Location = new System.Drawing.Point(161, 534);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(740, 23);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // StatusLbl
            // 
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(44, 17);
            this.StatusLbl.Text = "Data";
            // 
            // listStudents
            // 
            this.listStudents.Font = new System.Drawing.Font("MingLiU-ExtB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listStudents.FormattingEnabled = true;
            this.listStudents.ItemHeight = 18;
            this.listStudents.Location = new System.Drawing.Point(223, 79);
            this.listStudents.Name = "listStudents";
            this.listStudents.Size = new System.Drawing.Size(201, 436);
            this.listStudents.TabIndex = 3;
            this.listStudents.SelectedIndexChanged += new System.EventHandler(this.listStudents_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU-ExtB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Журнал прізвищ студентів";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MingLiU-ExtB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(666, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Введіть оцінку";
            // 
            // txtMark
            // 
            this.txtMark.Location = new System.Drawing.Point(668, 79);
            this.txtMark.Name = "txtMark";
            this.txtMark.Size = new System.Drawing.Size(206, 29);
            this.txtMark.TabIndex = 6;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Font = new System.Drawing.Font("MingLiU-ExtB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.Location = new System.Drawing.Point(668, 224);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(106, 46);
            this.btnAddStudent.TabIndex = 7;
            this.btnAddStudent.Text = "Додати студента";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // listMarks
            // 
            this.listMarks.Font = new System.Drawing.Font("MingLiU-ExtB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listMarks.FormattingEnabled = true;
            this.listMarks.ItemHeight = 18;
            this.listMarks.Location = new System.Drawing.Point(447, 79);
            this.listMarks.Name = "listMarks";
            this.listMarks.Size = new System.Drawing.Size(205, 436);
            this.listMarks.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MingLiU-ExtB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(443, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Журнал оцінок";
            // 
            // btnAddMark
            // 
            this.btnAddMark.Font = new System.Drawing.Font("MingLiU-ExtB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMark.Location = new System.Drawing.Point(669, 114);
            this.btnAddMark.Name = "btnAddMark";
            this.btnAddMark.Size = new System.Drawing.Size(91, 50);
            this.btnAddMark.TabIndex = 10;
            this.btnAddMark.Text = "Додати оцінку";
            this.btnAddMark.UseVisualStyleBackColor = true;
            this.btnAddMark.Click += new System.EventHandler(this.btnAddMark_Click);
            // 
            // txtShowMark
            // 
            this.txtShowMark.Font = new System.Drawing.Font("MingLiU-ExtB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShowMark.Location = new System.Drawing.Point(670, 428);
            this.txtShowMark.Name = "txtShowMark";
            this.txtShowMark.ReadOnly = true;
            this.txtShowMark.Size = new System.Drawing.Size(204, 29);
            this.txtShowMark.TabIndex = 11;
            // 
            // ShowMark
            // 
            this.ShowMark.Font = new System.Drawing.Font("MingLiU-ExtB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowMark.Location = new System.Drawing.Point(668, 319);
            this.ShowMark.Name = "ShowMark";
            this.ShowMark.Size = new System.Drawing.Size(206, 59);
            this.ShowMark.TabIndex = 12;
            this.ShowMark.Text = "Вивести середню арифметичну студента";
            this.ShowMark.UseVisualStyleBackColor = true;
            this.ShowMark.Click += new System.EventHandler(this.ShowMark_Click);
            // 
            // rdNum1
            // 
            this.rdNum1.AutoSize = true;
            this.rdNum1.Checked = true;
            this.rdNum1.Font = new System.Drawing.Font("MingLiU-ExtB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNum1.Location = new System.Drawing.Point(668, 463);
            this.rdNum1.Name = "rdNum1";
            this.rdNum1.Size = new System.Drawing.Size(109, 23);
            this.rdNum1.TabIndex = 13;
            this.rdNum1.TabStop = true;
            this.rdNum1.Text = "Ціле число";
            this.rdNum1.UseVisualStyleBackColor = true;
            // 
            // rdNum2
            // 
            this.rdNum2.AutoSize = true;
            this.rdNum2.Font = new System.Drawing.Font("MingLiU-ExtB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNum2.Location = new System.Drawing.Point(668, 492);
            this.rdNum2.Name = "rdNum2";
            this.rdNum2.Size = new System.Drawing.Size(150, 23);
            this.rdNum2.TabIndex = 14;
            this.rdNum2.Text = "Десяткове число";
            this.rdNum2.UseVisualStyleBackColor = true;
            // 
            // txtStudent
            // 
            this.txtStudent.Location = new System.Drawing.Point(668, 189);
            this.txtStudent.Name = "txtStudent";
            this.txtStudent.Size = new System.Drawing.Size(208, 29);
            this.txtStudent.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MingLiU-ExtB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(666, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Введіть прізвище";
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(670, 276);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(206, 31);
            this.btnSort.TabIndex = 17;
            this.btnSort.Text = "Сортувати";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnSumm
            // 
            this.btnSumm.Font = new System.Drawing.Font("MingLiU-ExtB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumm.Location = new System.Drawing.Point(668, 384);
            this.btnSumm.Name = "btnSumm";
            this.btnSumm.Size = new System.Drawing.Size(206, 38);
            this.btnSumm.TabIndex = 18;
            this.btnSumm.Text = "Загальна кількість балів";
            this.btnSumm.UseVisualStyleBackColor = true;
            this.btnSumm.Click += new System.EventHandler(this.btnSumm_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("MingLiU-ExtB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(780, 224);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 46);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Видалити студента";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDeleteMark
            // 
            this.btnDeleteMark.Font = new System.Drawing.Font("MingLiU-ExtB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMark.Location = new System.Drawing.Point(766, 114);
            this.btnDeleteMark.Name = "btnDeleteMark";
            this.btnDeleteMark.Size = new System.Drawing.Size(108, 50);
            this.btnDeleteMark.TabIndex = 20;
            this.btnDeleteMark.Text = "Видалити оцінку";
            this.btnDeleteMark.UseVisualStyleBackColor = true;
            this.btnDeleteMark.Click += new System.EventHandler(this.btnDeleteMark_Click);
            // 
            // MainTch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 557);
            this.Controls.Add(this.btnDeleteMark);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSumm);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.txtStudent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rdNum2);
            this.Controls.Add(this.rdNum1);
            this.Controls.Add(this.ShowMark);
            this.Controls.Add(this.txtShowMark);
            this.Controls.Add(this.btnAddMark);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listMarks);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.txtMark);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listStudents);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("MingLiU-ExtB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainTch";
            this.Text = "Успішність студентів. Мельничук";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ExitItem;
        private System.Windows.Forms.ToolStripMenuItem зовнішнійВиглядToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ColorItem;
        private System.Windows.Forms.ToolStripMenuItem FontItem;
        private System.Windows.Forms.ToolStripMenuItem AboutItem;
        private System.Windows.Forms.ToolStripMenuItem webItem;
        private System.Windows.Forms.ToolStripMenuItem CalcItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusLbl;
        private System.Windows.Forms.ListBox listStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMark;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.ListBox listMarks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddMark;
        private System.Windows.Forms.TextBox txtShowMark;
        private System.Windows.Forms.Button ShowMark;
        private System.Windows.Forms.RadioButton rdNum1;
        private System.Windows.Forms.RadioButton rdNum2;
        private System.Windows.Forms.TextBox txtStudent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenItem;
        private System.Windows.Forms.ToolStripMenuItem SaveItem;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnSumm;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ToolStripMenuItem PrintItem;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.Button btnDeleteMark;
    }
}