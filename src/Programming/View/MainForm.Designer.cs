namespace Programming
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            enumsSeasonHandleControl1 = new View.Controls.EnumsSeasonHandleControl();
            enumsGroupBoxEnumerations1 = new View.Controls.EnumsGroupBoxEnumerations();
            tabPage2 = new TabPage();
            classesControl1 = new View.Controls.ClassesControl();
            tabPage3 = new TabPage();
            rectanglesCollisionControl1 = new View.Panels.RectanglesCollisionControl();
            enumsGroupBoxWeekdayControl1 = new View.Controls.EnumsGroupBoxWeekdayControl();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(725, 407);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(enumsGroupBoxWeekdayControl1);
            tabPage1.Controls.Add(enumsSeasonHandleControl1);
            tabPage1.Controls.Add(enumsGroupBoxEnumerations1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(717, 374);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Enums";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // enumsSeasonHandleControl1
            // 
            enumsSeasonHandleControl1.Location = new Point(356, 213);
            enumsSeasonHandleControl1.Name = "enumsSeasonHandleControl1";
            enumsSeasonHandleControl1.Size = new Size(355, 158);
            enumsSeasonHandleControl1.TabIndex = 4;
            // 
            // enumsGroupBoxEnumerations1
            // 
            enumsGroupBoxEnumerations1.Location = new Point(0, 1);
            enumsGroupBoxEnumerations1.Name = "enumsGroupBoxEnumerations1";
            enumsGroupBoxEnumerations1.Size = new Size(717, 215);
            enumsGroupBoxEnumerations1.TabIndex = 3;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(classesControl1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(717, 374);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Classes";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // classesControl1
            // 
            classesControl1.Dock = DockStyle.Fill;
            classesControl1.Location = new Point(3, 3);
            classesControl1.Name = "classesControl1";
            classesControl1.Size = new Size(711, 368);
            classesControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(rectanglesCollisionControl1);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(717, 374);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Rectangles";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl1
            // 
            rectanglesCollisionControl1.Dock = DockStyle.Fill;
            rectanglesCollisionControl1.Location = new Point(0, 0);
            rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            rectanglesCollisionControl1.Size = new Size(717, 374);
            rectanglesCollisionControl1.TabIndex = 0;
            // 
            // enumsGroupBoxWeekdayControl1
            // 
            enumsGroupBoxWeekdayControl1.Location = new Point(0, 216);
            enumsGroupBoxWeekdayControl1.Name = "enumsGroupBoxWeekdayControl1";
            enumsGroupBoxWeekdayControl1.Size = new Size(356, 162);
            enumsGroupBoxWeekdayControl1.TabIndex = 5;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(725, 407);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private View.Panels.RectanglesCollisionControl rectanglesCollisionControl1;
        private View.Controls.ClassesControl classesControl1;
        private View.Controls.EnumsGroupBoxEnumerations enumsGroupBoxEnumerations1;
        private View.Controls.EnumsSeasonHandleControl enumsSeasonHandleControl1;
        private View.Controls.EnumsGroupBoxWeekdayControl enumsGroupBoxWeekdayControl1;
    }
}