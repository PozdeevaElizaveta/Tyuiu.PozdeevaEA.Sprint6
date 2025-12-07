namespace Tyuiu.PozdeevaEA.Sprint6.Task6.V22
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonOpenFile_PEA = new Button();
            buttonSaveFile_PEA = new Button();
            groupBoxTask_PEA = new GroupBox();
            textBoxTask_PEA = new TextBox();
            splitter_PEA = new Splitter();
            groupBoxInput_PEA = new GroupBox();
            textBoxInput_PEA = new TextBox();
            groupBoxOutput_PEA = new GroupBox();
            textBoxResult_PEA = new TextBox();
            buttonHelp_PEA = new Button();
            openFileDialogTask_PEA = new OpenFileDialog();
            toolTipTask_PEA = new ToolTip(components);
            groupBoxTask_PEA.SuspendLayout();
            groupBoxInput_PEA.SuspendLayout();
            groupBoxOutput_PEA.SuspendLayout();
            SuspendLayout();
            // 
            // buttonOpenFile_PEA
            // 
            buttonOpenFile_PEA.BackgroundImage = (Image)resources.GetObject("buttonOpenFile_PEA.BackgroundImage");
            buttonOpenFile_PEA.BackgroundImageLayout = ImageLayout.Stretch;
            buttonOpenFile_PEA.Location = new Point(14, 16);
            buttonOpenFile_PEA.Margin = new Padding(3, 4, 3, 4);
            buttonOpenFile_PEA.Name = "buttonOpenFile_PEA";
            buttonOpenFile_PEA.Size = new Size(83, 85);
            buttonOpenFile_PEA.TabIndex = 0;
            toolTipTask_PEA.SetToolTip(buttonOpenFile_PEA, "Открыть файл.\r\nВыберете нужный файл для обработки.");
            buttonOpenFile_PEA.UseVisualStyleBackColor = true;
            buttonOpenFile_PEA.Click += buttonDone_PEA_Click;
            // 
            // buttonSaveFile_PEA
            // 
            buttonSaveFile_PEA.BackgroundImage = (Image)resources.GetObject("buttonSaveFile_PEA.BackgroundImage");
            buttonSaveFile_PEA.BackgroundImageLayout = ImageLayout.Zoom;
            buttonSaveFile_PEA.Location = new Point(104, 16);
            buttonSaveFile_PEA.Margin = new Padding(3, 4, 3, 4);
            buttonSaveFile_PEA.Name = "buttonSaveFile_PEA";
            buttonSaveFile_PEA.Size = new Size(83, 85);
            buttonSaveFile_PEA.TabIndex = 1;
            toolTipTask_PEA.SetToolTip(buttonSaveFile_PEA, "Производит поиск в файле.");
            buttonSaveFile_PEA.UseVisualStyleBackColor = true;
            buttonSaveFile_PEA.Click += buttonOpenFile_PEA_Click;
            // 
            // groupBoxTask_PEA
            // 
            groupBoxTask_PEA.Controls.Add(textBoxTask_PEA);
            groupBoxTask_PEA.Location = new Point(14, 109);
            groupBoxTask_PEA.Margin = new Padding(3, 4, 3, 4);
            groupBoxTask_PEA.Name = "groupBoxTask_PEA";
            groupBoxTask_PEA.Padding = new Padding(3, 4, 3, 4);
            groupBoxTask_PEA.Size = new Size(1029, 91);
            groupBoxTask_PEA.TabIndex = 2;
            groupBoxTask_PEA.TabStop = false;
            groupBoxTask_PEA.Text = "Условие:";
            // 
            // textBoxTask_PEA
            // 
            textBoxTask_PEA.Location = new Point(3, 25);
            textBoxTask_PEA.Margin = new Padding(3, 4, 3, 4);
            textBoxTask_PEA.Multiline = true;
            textBoxTask_PEA.Name = "textBoxTask_PEA";
            textBoxTask_PEA.ReadOnly = true;
            textBoxTask_PEA.Size = new Size(1018, 48);
            textBoxTask_PEA.TabIndex = 0;
            textBoxTask_PEA.Text = resources.GetString("textBoxTask_PEA.Text");
            // 
            // splitter_PEA
            // 
            splitter_PEA.Location = new Point(0, 0);
            splitter_PEA.Margin = new Padding(3, 4, 3, 4);
            splitter_PEA.Name = "splitter_PEA";
            splitter_PEA.Size = new Size(537, 667);
            splitter_PEA.TabIndex = 3;
            splitter_PEA.TabStop = false;
            // 
            // groupBoxInput_PEA
            // 
            groupBoxInput_PEA.Controls.Add(textBoxInput_PEA);
            groupBoxInput_PEA.Location = new Point(14, 208);
            groupBoxInput_PEA.Margin = new Padding(3, 4, 3, 4);
            groupBoxInput_PEA.Name = "groupBoxInput_PEA";
            groupBoxInput_PEA.Padding = new Padding(3, 4, 3, 4);
            groupBoxInput_PEA.Size = new Size(523, 443);
            groupBoxInput_PEA.TabIndex = 0;
            groupBoxInput_PEA.TabStop = false;
            groupBoxInput_PEA.Text = "Ввод:";
            // 
            // textBoxInput_PEA
            // 
            textBoxInput_PEA.Location = new Point(7, 27);
            textBoxInput_PEA.Margin = new Padding(3, 4, 3, 4);
            textBoxInput_PEA.Multiline = true;
            textBoxInput_PEA.Name = "textBoxInput_PEA";
            textBoxInput_PEA.ScrollBars = ScrollBars.Vertical;
            textBoxInput_PEA.Size = new Size(509, 407);
            textBoxInput_PEA.TabIndex = 5;
            // 
            // groupBoxOutput_PEA
            // 
            groupBoxOutput_PEA.Controls.Add(textBoxResult_PEA);
            groupBoxOutput_PEA.Location = new Point(544, 208);
            groupBoxOutput_PEA.Margin = new Padding(3, 4, 3, 4);
            groupBoxOutput_PEA.Name = "groupBoxOutput_PEA";
            groupBoxOutput_PEA.Padding = new Padding(3, 4, 3, 4);
            groupBoxOutput_PEA.Size = new Size(530, 443);
            groupBoxOutput_PEA.TabIndex = 0;
            groupBoxOutput_PEA.TabStop = false;
            groupBoxOutput_PEA.Text = "Вывод:";
            // 
            // textBoxResult_PEA
            // 
            textBoxResult_PEA.Location = new Point(3, 25);
            textBoxResult_PEA.Margin = new Padding(3, 4, 3, 4);
            textBoxResult_PEA.Multiline = true;
            textBoxResult_PEA.Name = "textBoxResult_PEA";
            textBoxResult_PEA.ScrollBars = ScrollBars.Vertical;
            textBoxResult_PEA.Size = new Size(509, 408);
            textBoxResult_PEA.TabIndex = 0;
            // 
            // buttonHelp_PEA
            // 
            buttonHelp_PEA.BackgroundImage = (Image)resources.GetObject("buttonHelp_PEA.BackgroundImage");
            buttonHelp_PEA.BackgroundImageLayout = ImageLayout.Stretch;
            buttonHelp_PEA.Location = new Point(959, 16);
            buttonHelp_PEA.Margin = new Padding(3, 4, 3, 4);
            buttonHelp_PEA.Name = "buttonHelp_PEA";
            buttonHelp_PEA.Size = new Size(83, 85);
            buttonHelp_PEA.TabIndex = 4;
            toolTipTask_PEA.SetToolTip(buttonHelp_PEA, "Сведения о программе.");
            buttonHelp_PEA.UseVisualStyleBackColor = true;
            buttonHelp_PEA.Click += buttonHelp_PEA_Click;
            // 
            // openFileDialogTask_PEA
            // 
            openFileDialogTask_PEA.FileName = "openFileDialog1";
            // 
            // toolTipTask_PEA
            // 
            toolTipTask_PEA.ToolTipIcon = ToolTipIcon.Info;
            toolTipTask_PEA.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 667);
            Controls.Add(buttonHelp_PEA);
            Controls.Add(groupBoxOutput_PEA);
            Controls.Add(groupBoxInput_PEA);
            Controls.Add(groupBoxTask_PEA);
            Controls.Add(buttonSaveFile_PEA);
            Controls.Add(buttonOpenFile_PEA);
            Controls.Add(splitter_PEA);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 22 | Поздеева Е.А.";
            groupBoxTask_PEA.ResumeLayout(false);
            groupBoxTask_PEA.PerformLayout();
            groupBoxInput_PEA.ResumeLayout(false);
            groupBoxInput_PEA.PerformLayout();
            groupBoxOutput_PEA.ResumeLayout(false);
            groupBoxOutput_PEA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOpenFile_PEA;
        private Button buttonSaveFile_PEA;
        private GroupBox groupBoxTask_PEA;
        private Splitter splitter_PEA;
        private GroupBox groupBoxInput_PEA;
        private GroupBox groupBoxOutput_PEA;
        private Button buttonHelp_PEA;
        private TextBox textBoxInput_PEA;
        private TextBox textBoxResult_PEA;
        private TextBox textBoxTask_PEA;
        private OpenFileDialog openFileDialogTask_PEA;
        private ToolTip toolTipTask_PEA;
    }
}
