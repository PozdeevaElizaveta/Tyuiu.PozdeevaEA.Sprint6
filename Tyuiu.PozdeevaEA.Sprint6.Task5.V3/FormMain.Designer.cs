namespace Tyuiu.PozdeevaEA.Sprint6.Task5.V3
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
            groupBoxRes_PEA = new GroupBox();
            formsPlotRes_PEA = new ScottPlot.FormsPlot();
            dataGridViewRes_PEA = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            buttonDone_PEA = new Button();
            buttonOpen_PEA = new Button();
            buttonInfo_PEA = new Button();
            textBoxFilePath_PEA = new TextBox();
            groupBoxTask_PEA.SuspendLayout();
            groupBoxRes_PEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_PEA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_PEA
            // 
            groupBoxTask_PEA.Controls.Add(textBoxTask_PEA);
            groupBoxTask_PEA.Location = new Point(12, 12);
            groupBoxTask_PEA.Name = "groupBoxTask_PEA";
            groupBoxTask_PEA.Size = new Size(451, 92);
            groupBoxTask_PEA.TabIndex = 0;
            groupBoxTask_PEA.TabStop = false;
            groupBoxTask_PEA.Text = "Условие";
            // 
            // textBoxTask_PEA
            // 
            textBoxTask_PEA.BackColor = SystemColors.Control;
            textBoxTask_PEA.BorderStyle = BorderStyle.None;
            textBoxTask_PEA.Location = new Point(6, 26);
            textBoxTask_PEA.Multiline = true;
            textBoxTask_PEA.Name = "textBoxTask_PEA";
            textBoxTask_PEA.Size = new Size(439, 66);
            textBoxTask_PEA.TabIndex = 0;
            textBoxTask_PEA.Text = "Прочитать данные из файла InPutFileTask5V3.txt. Вывести в dataGridView. Вывести все вещественные числа.  Построить диаграмму по этим значениям. ";
            textBoxTask_PEA.TextChanged += textBoxTask_PEA_TextChanged;
            // 
            // groupBoxRes_PEA
            // 
            groupBoxRes_PEA.Anchor = AnchorStyles.None;
            groupBoxRes_PEA.Controls.Add(formsPlotRes_PEA);
            groupBoxRes_PEA.Controls.Add(dataGridViewRes_PEA);
            groupBoxRes_PEA.Location = new Point(12, 111);
            groupBoxRes_PEA.Name = "groupBoxRes_PEA";
            groupBoxRes_PEA.Size = new Size(776, 330);
            groupBoxRes_PEA.TabIndex = 1;
            groupBoxRes_PEA.TabStop = false;
            groupBoxRes_PEA.Text = "Вывод";
            // 
            // formsPlotRes_PEA
            // 
            formsPlotRes_PEA.Anchor = AnchorStyles.Right;
            formsPlotRes_PEA.AutoSize = true;
            formsPlotRes_PEA.Location = new Point(269, 27);
            formsPlotRes_PEA.Margin = new Padding(5, 4, 5, 4);
            formsPlotRes_PEA.Name = "formsPlotRes_PEA";
            formsPlotRes_PEA.Size = new Size(499, 296);
            formsPlotRes_PEA.TabIndex = 1;
            formsPlotRes_PEA.Load += formsPlotRes_PEA_Load;
            // 
            // dataGridViewRes_PEA
            // 
            dataGridViewRes_PEA.Anchor = AnchorStyles.Left;
            dataGridViewRes_PEA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRes_PEA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRes_PEA.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridViewRes_PEA.Location = new Point(6, 26);
            dataGridViewRes_PEA.Name = "dataGridViewRes_PEA";
            dataGridViewRes_PEA.ReadOnly = true;
            dataGridViewRes_PEA.RowHeadersVisible = false;
            dataGridViewRes_PEA.RowHeadersWidth = 51;
            dataGridViewRes_PEA.Size = new Size(255, 296);
            dataGridViewRes_PEA.TabIndex = 0;
            dataGridViewRes_PEA.CellContentClick += dataGridViewRes_PEA_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Y";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // buttonDone_PEA
            // 
            buttonDone_PEA.BackColor = SystemColors.ActiveCaption;
            buttonDone_PEA.FlatStyle = FlatStyle.Flat;
            buttonDone_PEA.Location = new Point(478, 22);
            buttonDone_PEA.Name = "buttonDone_PEA";
            buttonDone_PEA.Size = new Size(110, 53);
            buttonDone_PEA.TabIndex = 2;
            buttonDone_PEA.Text = "Выполнить";
            buttonDone_PEA.UseVisualStyleBackColor = false;
            buttonDone_PEA.Click += buttonDone_PEA_Click;
            // 
            // buttonOpen_PEA
            // 
            buttonOpen_PEA.BackColor = Color.DarkSeaGreen;
            buttonOpen_PEA.FlatStyle = FlatStyle.Flat;
            buttonOpen_PEA.Location = new Point(594, 22);
            buttonOpen_PEA.Name = "buttonOpen_PEA";
            buttonOpen_PEA.Size = new Size(94, 53);
            buttonOpen_PEA.TabIndex = 3;
            buttonOpen_PEA.Text = "Открыть файл";
            buttonOpen_PEA.UseVisualStyleBackColor = false;
            buttonOpen_PEA.Click += buttonOpen_PEA_Click;
            // 
            // buttonInfo_PEA
            // 
            buttonInfo_PEA.FlatStyle = FlatStyle.Flat;
            buttonInfo_PEA.Location = new Point(694, 22);
            buttonInfo_PEA.Name = "buttonInfo_PEA";
            buttonInfo_PEA.Size = new Size(94, 53);
            buttonInfo_PEA.TabIndex = 4;
            buttonInfo_PEA.Text = "Справка";
            buttonInfo_PEA.UseVisualStyleBackColor = true;
            buttonInfo_PEA.Click += buttonInfo_PEA_Click;
            // 
            // textBoxFilePath_PEA
            // 
            textBoxFilePath_PEA.Location = new Point(478, 81);
            textBoxFilePath_PEA.Name = "textBoxFilePath_PEA";
            textBoxFilePath_PEA.Size = new Size(310, 27);
            textBoxFilePath_PEA.TabIndex = 5;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 453);
            Controls.Add(textBoxFilePath_PEA);
            Controls.Add(buttonInfo_PEA);
            Controls.Add(buttonOpen_PEA);
            Controls.Add(buttonDone_PEA);
            Controls.Add(groupBoxRes_PEA);
            Controls.Add(groupBoxTask_PEA);
            MinimumSize = new Size(800, 500);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 3 | Поздеева Е.А.";
            Load += FormMain_Load;
            groupBoxTask_PEA.ResumeLayout(false);
            groupBoxTask_PEA.PerformLayout();
            groupBoxRes_PEA.ResumeLayout(false);
            groupBoxRes_PEA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_PEA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxTask_PEA;
        private GroupBox groupBoxRes_PEA;
        private TextBox textBoxTask_PEA;
        private Button buttonDone_PEA;
        private Button buttonOpen_PEA;
        private Button buttonInfo_PEA;
        private DataGridView dataGridViewRes_PEA;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private ScottPlot.FormsPlot formsPlotRes_PEA;
        private TextBox textBoxFilePath_PEA;
    }
}
