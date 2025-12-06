using ScottPlot;

namespace Tyuiu.PozdeevaEA.Sprint6.Task4.V20
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxTask_PEA = new GroupBox();
            pictureBoxTask_PEA = new PictureBox();
            textBoxTask_PEA = new TextBox();
            groupBoxRes_PEA = new GroupBox();
            textBoxRes_PEA = new TextBox();
            formsPlotRes_PEA = new FormsPlot();
            groupBoxData_PEA = new GroupBox();
            labelStop_PEA = new Label();
            labelStart_PEA = new Label();
            textBoxValueStop_PEA = new TextBox();
            textBoxValueStart_PEA = new TextBox();
            buttonDo_PEA = new Button();
            buttonSave_PEA = new Button();
            buttonInfo_PEA = new Button();
            groupBoxTask_PEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_PEA).BeginInit();
            groupBoxRes_PEA.SuspendLayout();
            groupBoxData_PEA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_PEA
            // 
            groupBoxTask_PEA.Controls.Add(pictureBoxTask_PEA);
            groupBoxTask_PEA.Controls.Add(textBoxTask_PEA);
            groupBoxTask_PEA.Location = new Point(12, 12);
            groupBoxTask_PEA.Name = "groupBoxTask_PEA";
            groupBoxTask_PEA.Size = new Size(431, 158);
            groupBoxTask_PEA.TabIndex = 0;
            groupBoxTask_PEA.TabStop = false;
            groupBoxTask_PEA.Text = "Условие";
            groupBoxTask_PEA.Enter += groupBox1_Enter;
            // 
            // pictureBoxTask_PEA
            // 
            pictureBoxTask_PEA.Image = (Image)resources.GetObject("pictureBoxTask_PEA.Image");
            pictureBoxTask_PEA.Location = new Point(6, 97);
            pictureBoxTask_PEA.Name = "pictureBoxTask_PEA";
            pictureBoxTask_PEA.Size = new Size(412, 46);
            pictureBoxTask_PEA.TabIndex = 1;
            pictureBoxTask_PEA.TabStop = false;
            // 
            // textBoxTask_PEA
            // 
            textBoxTask_PEA.BackColor = SystemColors.Control;
            textBoxTask_PEA.BorderStyle = BorderStyle.None;
            textBoxTask_PEA.Location = new Point(6, 26);
            textBoxTask_PEA.Multiline = true;
            textBoxTask_PEA.Name = "textBoxTask_PEA";
            textBoxTask_PEA.ReadOnly = true;
            textBoxTask_PEA.Size = new Size(412, 65);
            textBoxTask_PEA.TabIndex = 0;
            textBoxTask_PEA.Text = "Протабулировать функцию на заданном диапазоне. Округлить до двух знаков после запятой. Построить график функции.";
            textBoxTask_PEA.TextChanged += textBox1_TextChanged;
            // 
            // groupBoxRes_PEA
            // 
            groupBoxRes_PEA.Anchor = AnchorStyles.Left;
            groupBoxRes_PEA.Controls.Add(textBoxRes_PEA);
            groupBoxRes_PEA.Controls.Add(formsPlotRes_PEA);
            groupBoxRes_PEA.Location = new Point(12, 176);
            groupBoxRes_PEA.Name = "groupBoxRes_PEA";
            groupBoxRes_PEA.Size = new Size(759, 320);
            groupBoxRes_PEA.TabIndex = 1;
            groupBoxRes_PEA.TabStop = false;
            groupBoxRes_PEA.Text = "Вывод";
            // 
            // textBoxRes_PEA
            // 
            textBoxRes_PEA.Location = new Point(6, 26);
            textBoxRes_PEA.Multiline = true;
            textBoxRes_PEA.Name = "textBoxRes_PEA";
            textBoxRes_PEA.Size = new Size(216, 287);
            textBoxRes_PEA.TabIndex = 2;
            // 
            // formsPlotRes_PEA
            // 
            formsPlotRes_PEA.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            formsPlotRes_PEA.Location = new Point(220, 12);
            formsPlotRes_PEA.Margin = new Padding(5, 4, 5, 4);
            formsPlotRes_PEA.Name = "formsPlotRes_PEA";
            formsPlotRes_PEA.Size = new Size(531, 301);
            formsPlotRes_PEA.TabIndex = 1;
            formsPlotRes_PEA.Load += formsPlotRes_PEA_Load;
            // 
            // groupBoxData_PEA
            // 
            groupBoxData_PEA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBoxData_PEA.Controls.Add(labelStop_PEA);
            groupBoxData_PEA.Controls.Add(labelStart_PEA);
            groupBoxData_PEA.Controls.Add(textBoxValueStop_PEA);
            groupBoxData_PEA.Controls.Add(textBoxValueStart_PEA);
            groupBoxData_PEA.Location = new Point(506, 12);
            groupBoxData_PEA.Name = "groupBoxData_PEA";
            groupBoxData_PEA.Size = new Size(150, 158);
            groupBoxData_PEA.TabIndex = 2;
            groupBoxData_PEA.TabStop = false;
            groupBoxData_PEA.Text = "Ввод данных";
            // 
            // labelStop_PEA
            // 
            labelStop_PEA.AutoSize = true;
            labelStop_PEA.Location = new Point(6, 97);
            labelStop_PEA.Name = "labelStop_PEA";
            labelStop_PEA.Size = new Size(94, 20);
            labelStop_PEA.TabIndex = 5;
            labelStop_PEA.Text = "Конец шага:";
            // 
            // labelStart_PEA
            // 
            labelStart_PEA.AutoSize = true;
            labelStart_PEA.Location = new Point(6, 23);
            labelStart_PEA.Name = "labelStart_PEA";
            labelStart_PEA.Size = new Size(88, 20);
            labelStart_PEA.TabIndex = 4;
            labelStart_PEA.Text = "Старт шага:";
            // 
            // textBoxValueStop_PEA
            // 
            textBoxValueStop_PEA.BorderStyle = BorderStyle.FixedSingle;
            textBoxValueStop_PEA.Location = new Point(6, 125);
            textBoxValueStop_PEA.Name = "textBoxValueStop_PEA";
            textBoxValueStop_PEA.Size = new Size(125, 27);
            textBoxValueStop_PEA.TabIndex = 2;
            textBoxValueStop_PEA.TextChanged += textBox5_TextChanged;
            // 
            // textBoxValueStart_PEA
            // 
            textBoxValueStart_PEA.BorderStyle = BorderStyle.FixedSingle;
            textBoxValueStart_PEA.Location = new Point(6, 52);
            textBoxValueStart_PEA.Name = "textBoxValueStart_PEA";
            textBoxValueStart_PEA.Size = new Size(125, 27);
            textBoxValueStart_PEA.TabIndex = 0;
            textBoxValueStart_PEA.TextChanged += textBoxValueStart_PEA_TextChanged;
            // 
            // buttonDo_PEA
            // 
            buttonDo_PEA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDo_PEA.Location = new Point(676, 56);
            buttonDo_PEA.Name = "buttonDo_PEA";
            buttonDo_PEA.Size = new Size(95, 54);
            buttonDo_PEA.TabIndex = 3;
            buttonDo_PEA.Text = "Выполнить";
            buttonDo_PEA.UseVisualStyleBackColor = true;
            buttonDo_PEA.Click += buttonDo_PEA_Click;
            // 
            // buttonSave_PEA
            // 
            buttonSave_PEA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSave_PEA.Location = new Point(677, 116);
            buttonSave_PEA.Name = "buttonSave_PEA";
            buttonSave_PEA.Size = new Size(94, 54);
            buttonSave_PEA.TabIndex = 4;
            buttonSave_PEA.Text = "Сохранить";
            buttonSave_PEA.UseVisualStyleBackColor = true;
            buttonSave_PEA.Click += buttonSave_PEA_Click;
            // 
            // buttonInfo_PEA
            // 
            buttonInfo_PEA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonInfo_PEA.Location = new Point(676, 12);
            buttonInfo_PEA.Name = "buttonInfo_PEA";
            buttonInfo_PEA.Size = new Size(94, 29);
            buttonInfo_PEA.TabIndex = 5;
            buttonInfo_PEA.Text = "Справка";
            buttonInfo_PEA.UseVisualStyleBackColor = true;
            buttonInfo_PEA.Click += buttonInfo_PEA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(782, 501);
            Controls.Add(buttonInfo_PEA);
            Controls.Add(buttonSave_PEA);
            Controls.Add(buttonDo_PEA);
            Controls.Add(groupBoxData_PEA);
            Controls.Add(groupBoxRes_PEA);
            Controls.Add(groupBoxTask_PEA);
            MinimumSize = new Size(800, 500);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 20 | Поздеева Е.А.";
            Load += FormMain_Load;
            groupBoxTask_PEA.ResumeLayout(false);
            groupBoxTask_PEA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_PEA).EndInit();
            groupBoxRes_PEA.ResumeLayout(false);
            groupBoxRes_PEA.PerformLayout();
            groupBoxData_PEA.ResumeLayout(false);
            groupBoxData_PEA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_PEA;
        private GroupBox groupBoxRes_PEA;
        private GroupBox groupBoxData_PEA;
        private PictureBox pictureBoxTask_PEA;
        private TextBox textBoxValueStart_PEA;
        private TextBox textBoxValueStop_PEA;
        private Button buttonDo_PEA;
        private Label labelStop_PEA;
        private Label labelStart_PEA;
        private Button buttonSave_PEA;
        private ScottPlot.FormsPlot formsPlotRes_PEA;
        private Button buttonInfo_PEA;
        private TextBox textBoxTask_PEA;
        private TextBox textBoxRes_PEA;
    }
}
