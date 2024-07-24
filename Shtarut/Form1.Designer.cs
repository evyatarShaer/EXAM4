namespace Shtarut
{
    partial class Form1
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
            dayWeekcomboBox = new ComboBox();
            yearComboBox = new ComboBox();
            monthComboBox = new ComboBox();
            monthdayComboBox = new ComboBox();
            DayWeekLabel = new Label();
            yearLabel = new Label();
            monthLabel = new Label();
            monthDayLabel = new Label();
            resultButton = new Button();
            SuspendLayout();
            // 
            // dayWeekcomboBox
            // 
            dayWeekcomboBox.FormattingEnabled = true;
            dayWeekcomboBox.Items.AddRange(new object[] { "ראשון", "שני", "שלישי", "רביעי", "חמישי", "ששי" });
            dayWeekcomboBox.Location = new Point(614, 94);
            dayWeekcomboBox.Name = "dayWeekcomboBox";
            dayWeekcomboBox.Size = new Size(87, 28);
            dayWeekcomboBox.TabIndex = 0;
            // 
            // yearComboBox
            // 
            yearComboBox.FormattingEnabled = true;
            yearComboBox.Items.AddRange(new object[] { "תשפ\"ד", "תשפ\"ה", "תשפ\"ו", "תשפ\"ז", "תשפ\"ח", "תשפ\"ט", "תש\"צ", "תשצ\"א", "תשצ\"ג", "תשצ\"ד" });
            yearComboBox.Location = new Point(183, 94);
            yearComboBox.Name = "yearComboBox";
            yearComboBox.Size = new Size(87, 28);
            yearComboBox.TabIndex = 1;
            // 
            // monthComboBox
            // 
            monthComboBox.FormattingEnabled = true;
            monthComboBox.Items.AddRange(new object[] { "תשרי", "מרחשוון", "כסלו", "טבת", "שבט", "אדר", "אדר הראשון", "אדר השני", "ניסן", "אייר", "סיון", "תמוז", "אב", "אלול" });
            monthComboBox.Location = new Point(310, 94);
            monthComboBox.Name = "monthComboBox";
            monthComboBox.Size = new Size(87, 28);
            monthComboBox.TabIndex = 2;
            // 
            // monthdayComboBox
            // 
            monthdayComboBox.FormattingEnabled = true;
            monthdayComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30" });
            monthdayComboBox.Location = new Point(461, 94);
            monthdayComboBox.Name = "monthdayComboBox";
            monthdayComboBox.Size = new Size(87, 28);
            monthdayComboBox.TabIndex = 3;
            // 
            // DayWeekLabel
            // 
            DayWeekLabel.AutoSize = true;
            DayWeekLabel.Location = new Point(632, 58);
            DayWeekLabel.Name = "DayWeekLabel";
            DayWeekLabel.Size = new Size(88, 20);
            DayWeekLabel.TabIndex = 4;
            DayWeekLabel.Text = "היום בשבוע ";
            DayWeekLabel.Click += label1_Click;
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new Point(221, 58);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(37, 20);
            yearLabel.TabIndex = 5;
            yearLabel.Text = "שנה";
            // 
            // monthLabel
            // 
            monthLabel.AutoSize = true;
            monthLabel.Location = new Point(330, 58);
            monthLabel.Name = "monthLabel";
            monthLabel.Size = new Size(42, 20);
            monthLabel.TabIndex = 6;
            monthLabel.Text = "חודש";
            // 
            // monthDayLabel
            // 
            monthDayLabel.AutoSize = true;
            monthDayLabel.Location = new Point(486, 58);
            monthDayLabel.Name = "monthDayLabel";
            monthDayLabel.Size = new Size(83, 20);
            monthDayLabel.TabIndex = 7;
            monthDayLabel.Text = "היום בחודש";
            // 
            // resultButton
            // 
            resultButton.Location = new Point(43, 93);
            resultButton.Name = "resultButton";
            resultButton.Size = new Size(94, 29);
            resultButton.TabIndex = 8;
            resultButton.Text = "תוצאה";
            resultButton.UseVisualStyleBackColor = true;
            resultButton.Click += resultButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultButton);
            Controls.Add(monthDayLabel);
            Controls.Add(monthLabel);
            Controls.Add(yearLabel);
            Controls.Add(DayWeekLabel);
            Controls.Add(monthdayComboBox);
            Controls.Add(monthComboBox);
            Controls.Add(yearComboBox);
            Controls.Add(dayWeekcomboBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox dayWeekcomboBox;
        private ComboBox yearComboBox;
        private ComboBox monthComboBox;
        private ComboBox monthdayComboBox;
        private Label DayWeekLabel;
        private Label yearLabel;
        private Label monthLabel;
        private Label monthDayLabel;
        private Button resultButton;
    }
}
