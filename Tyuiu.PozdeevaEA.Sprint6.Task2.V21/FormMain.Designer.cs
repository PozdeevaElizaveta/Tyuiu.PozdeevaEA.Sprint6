namespace Tyuiu.PozdeevaEA.Sprint6.Task2.V21
{
    partial class FormMain
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
            groupBoxTask_PEA = new GroupBox();
            textBoxTask_PEA = new TextBox();
            pictureBoxFormula_PEA = new PictureBox();
            groupBoxValue_PEA = new GroupBox();
            buttonDone_PEA = new Button();
            buttonHelp_PEA = new Button();
            labelstart_PEA = new Label();
            labelstop_PEA = new Label();
            textBoxValuestart_PEA = new TextBox();
            textBoxValuestop_PEA = new TextBox();
            groupBoxResult_PEA = new GroupBox();
            formsPlot_PEA = new ScottPlot.FormsPlot();
            labelResult_PEA = new Label();
            dataGridView_PEA = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            groupBoxTask_PEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_PEA).BeginInit();
            groupBoxValue_PEA.SuspendLayout();
            groupBoxResult_PEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_PEA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_PEA
            // 
            groupBoxTask_PEA.Controls.Add(textBoxTask_PEA);
            groupBoxTask_PEA.Controls.Add(pictureBoxFormula_PEA);
            groupBoxTask_PEA.Location = new Point(14, 16);
            groupBoxTask_PEA.Margin = new Padding(3, 4, 3, 4);
            groupBoxTask_PEA.Name = "groupBoxTask_PEA";
            groupBoxTask_PEA.Padding = new Padding(3, 4, 3, 4);
            groupBoxTask_PEA.Size = new Size(484, 190);
            groupBoxTask_PEA.TabIndex = 0;
            groupBoxTask_PEA.TabStop = false;
            groupBoxTask_PEA.Text = "Условие";
            groupBoxTask_PEA.Enter += groupBoxTask_PEA_Enter;
            // 
            // textBoxTask_PEA
            // 
            textBoxTask_PEA.BorderStyle = BorderStyle.None;
            textBoxTask_PEA.Location = new Point(7, 29);
            textBoxTask_PEA.Margin = new Padding(3, 4, 3, 4);
            textBoxTask_PEA.Multiline = true;
            textBoxTask_PEA.Name = "textBoxTask_PEA";
            textBoxTask_PEA.ReadOnly = true;
            textBoxTask_PEA.Size = new Size(517, 36);
            textBoxTask_PEA.TabIndex = 0;
            textBoxTask_PEA.Text = "Табулирование функции:";
            textBoxTask_PEA.TextChanged += textBoxTask_PEA_TextChanged;
            // 
            // pictureBoxFormula_PEA
            // 
            pictureBoxFormula_PEA.Location = new Point(42, 93);
            pictureBoxFormula_PEA.Margin = new Padding(3, 4, 3, 4);
            pictureBoxFormula_PEA.Name = "pictureBoxFormula_PEA";
            pictureBoxFormula_PEA.Size = new Size(311, 57);
            pictureBoxFormula_PEA.TabIndex = 1;
            pictureBoxFormula_PEA.TabStop = false;
            pictureBoxFormula_PEA.Click += pictureBoxFormula_PEA_Click;
            // 
            // groupBoxValue_PEA
            // 
            groupBoxValue_PEA.Controls.Add(buttonDone_PEA);
            groupBoxValue_PEA.Controls.Add(buttonHelp_PEA);
            groupBoxValue_PEA.Controls.Add(labelstart_PEA);
            groupBoxValue_PEA.Controls.Add(labelstop_PEA);
            groupBoxValue_PEA.Controls.Add(textBoxValuestart_PEA);
            groupBoxValue_PEA.Controls.Add(textBoxValuestop_PEA);
            groupBoxValue_PEA.Location = new Point(14, 233);
            groupBoxValue_PEA.Margin = new Padding(3, 4, 3, 4);
            groupBoxValue_PEA.Name = "groupBoxValue_PEA";
            groupBoxValue_PEA.Padding = new Padding(3, 4, 3, 4);
            groupBoxValue_PEA.Size = new Size(486, 242);
            groupBoxValue_PEA.TabIndex = 0;
            groupBoxValue_PEA.TabStop = false;
            groupBoxValue_PEA.Text = "Ввод данных";
            groupBoxValue_PEA.Enter += groupBoxValue_PEA_Enter;
            // 
            // buttonDone_PEA
            // 
            buttonDone_PEA.BackColor = SystemColors.ActiveCaption;
            buttonDone_PEA.BackgroundImageLayout = ImageLayout.None;
            buttonDone_PEA.FlatAppearance.BorderColor = Color.MidnightBlue;
            buttonDone_PEA.FlatStyle = FlatStyle.Flat;
            buttonDone_PEA.ForeColor = SystemColors.ActiveCaptionText;
            buttonDone_PEA.Location = new Point(279, 158);
            buttonDone_PEA.Margin = new Padding(3, 4, 3, 4);
            buttonDone_PEA.Name = "buttonDone_PEA";
            buttonDone_PEA.Size = new Size(180, 35);
            buttonDone_PEA.TabIndex = 4;
            buttonDone_PEA.Text = "Выполнить";
            buttonDone_PEA.UseVisualStyleBackColor = false;
            buttonDone_PEA.Click += buttonDone_PEA_Click;
            // 
            // buttonHelp_PEA
            // 
            buttonHelp_PEA.FlatAppearance.BorderColor = Color.Silver;
            buttonHelp_PEA.FlatStyle = FlatStyle.Flat;
            buttonHelp_PEA.Location = new Point(224, 158);
            buttonHelp_PEA.Margin = new Padding(3, 4, 3, 4);
            buttonHelp_PEA.Name = "buttonHelp_PEA";
            buttonHelp_PEA.Size = new Size(35, 35);
            buttonHelp_PEA.TabIndex = 5;
            buttonHelp_PEA.Text = "?";
            buttonHelp_PEA.UseVisualStyleBackColor = true;
            buttonHelp_PEA.Click += buttonHelp_PEA_Click;
            // 
            // labelstart_PEA
            // 
            labelstart_PEA.AutoSize = true;
            labelstart_PEA.Location = new Point(23, 62);
            labelstart_PEA.Name = "labelstart_PEA";
            labelstart_PEA.Size = new Size(143, 20);
            labelstart_PEA.TabIndex = 4;
            labelstart_PEA.Text = "Начало диапазона:";
            // 
            // labelstop_PEA
            // 
            labelstop_PEA.AutoSize = true;
            labelstop_PEA.Location = new Point(259, 62);
            labelstop_PEA.Name = "labelstop_PEA";
            labelstop_PEA.Size = new Size(135, 20);
            labelstop_PEA.TabIndex = 4;
            labelstop_PEA.Text = "Конец диапазона:";
            // 
            // textBoxValuestart_PEA
            // 
            textBoxValuestart_PEA.Location = new Point(23, 101);
            textBoxValuestart_PEA.Margin = new Padding(3, 4, 3, 4);
            textBoxValuestart_PEA.Name = "textBoxValuestart_PEA";
            textBoxValuestart_PEA.Size = new Size(132, 27);
            textBoxValuestart_PEA.TabIndex = 3;
            // 
            // textBoxValuestop_PEA
            // 
            textBoxValuestop_PEA.Location = new Point(259, 101);
            textBoxValuestop_PEA.Margin = new Padding(3, 4, 3, 4);
            textBoxValuestop_PEA.Name = "textBoxValuestop_PEA";
            textBoxValuestop_PEA.Size = new Size(132, 27);
            textBoxValuestop_PEA.TabIndex = 3;
            textBoxValuestop_PEA.TextChanged += textBoxValuestop_PEA_TextChanged;
            // 
            // groupBoxResult_PEA
            // 
            groupBoxResult_PEA.Controls.Add(dataGridView_PEA);
            groupBoxResult_PEA.Controls.Add(formsPlot_PEA);
            groupBoxResult_PEA.Controls.Add(labelResult_PEA);
            groupBoxResult_PEA.Location = new Point(521, 16);
            groupBoxResult_PEA.Margin = new Padding(3, 4, 3, 4);
            groupBoxResult_PEA.Name = "groupBoxResult_PEA";
            groupBoxResult_PEA.Padding = new Padding(3, 4, 3, 4);
            groupBoxResult_PEA.Size = new Size(807, 459);
            groupBoxResult_PEA.TabIndex = 0;
            groupBoxResult_PEA.TabStop = false;
            groupBoxResult_PEA.Text = "Вывод данных";
            // 
            // formsPlot_PEA
            // 
            formsPlot_PEA.Location = new Point(304, 40);
            formsPlot_PEA.Margin = new Padding(5, 4, 5, 4);
            formsPlot_PEA.Name = "formsPlot_PEA";
            formsPlot_PEA.Size = new Size(495, 407);
            formsPlot_PEA.TabIndex = 6;
            formsPlot_PEA.Load += formsPlot_PEA_Load;
            // 
            // labelResult_PEA
            // 
            labelResult_PEA.AutoSize = true;
            labelResult_PEA.Location = new Point(7, 40);
            labelResult_PEA.Name = "labelResult_PEA";
            labelResult_PEA.Size = new Size(78, 20);
            labelResult_PEA.TabIndex = 5;
            labelResult_PEA.Text = "Результат:";
            // 
            // dataGridView_PEA
            // 
            dataGridView_PEA.AllowUserToDeleteRows = false;
            dataGridView_PEA.BackgroundColor = SystemColors.Control;
            dataGridView_PEA.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridView_PEA.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView_PEA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_PEA.Columns.AddRange(new DataGridViewColumn[] { X, Y });
            dataGridView_PEA.GridColor = SystemColors.GrayText;
            dataGridView_PEA.ImeMode = ImeMode.NoControl;
            dataGridView_PEA.Location = new Point(21, 75);
            dataGridView_PEA.Name = "dataGridView_PEA";
            dataGridView_PEA.ReadOnly = true;
            dataGridView_PEA.RowHeadersVisible = false;
            dataGridView_PEA.RowHeadersWidth = 51;
            dataGridView_PEA.Size = new Size(259, 372);
            dataGridView_PEA.TabIndex = 7;
            dataGridView_PEA.CellContentClick += dataGridView_PEA_CellContentClick;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.ReadOnly = true;
            X.Width = 125;
            // 
            // Y
            // 
            Y.HeaderText = "Y";
            Y.MinimumWidth = 6;
            Y.Name = "Y";
            Y.ReadOnly = true;
            Y.Width = 125;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1340, 491);
            Controls.Add(groupBoxResult_PEA);
            Controls.Add(groupBoxValue_PEA);
            Controls.Add(groupBoxTask_PEA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 21 | Поздеева Е.А.";
            Load += FormMain_Load;
            groupBoxTask_PEA.ResumeLayout(false);
            groupBoxTask_PEA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_PEA).EndInit();
            groupBoxValue_PEA.ResumeLayout(false);
            groupBoxValue_PEA.PerformLayout();
            groupBoxResult_PEA.ResumeLayout(false);
            groupBoxResult_PEA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_PEA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_PEA;
        private GroupBox groupBoxValue_PEA;
        private GroupBox groupBoxResult_PEA;
        private PictureBox pictureBoxFormula_PEA;
        private Button buttonDone_PEA;
        private TextBox textBoxValuestart_PEA;
        private TextBox textBoxValuestop_PEA;
        private TextBox textBoxTask_PEA;
        private Label labelstart_PEA;
        private Label labelstop_PEA;
        private Label labelResult_PEA;
        private Button buttonHelp_PEA;
        private ScottPlot.FormsPlot formsPlot_PEA;
        private DataGridView dataGridView_PEA;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Y;
    }
}
