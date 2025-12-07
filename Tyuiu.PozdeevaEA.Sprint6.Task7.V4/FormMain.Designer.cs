namespace Tyuiu.PozdeevaEA.Sprint6.Task7.V4
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
            panel1 = new Panel();
            buttonHelp_PEA = new Button();
            buttonSave_PEA = new Button();
            buttonDone_PEA = new Button();
            buttonOpenFile_PEA = new Button();
            panel2 = new Panel();
            groupBoxTask_PEA = new GroupBox();
            textBoxTask_PEA = new TextBox();
            panel3 = new Panel();
            groupBoxInput_PEA = new GroupBox();
            dataGridViewInMatrix_PEA = new DataGridView();
            panel4 = new Panel();
            groupBoxResult_PEA = new GroupBox();
            dataGridViewOutMatrix_PEA = new DataGridView();
            splitter1 = new Splitter();
            openFileDialogTask_PEA = new OpenFileDialog();
            toolTip_PEA = new ToolTip(components);
            saveFileDialogMatrix = new SaveFileDialog();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxTask_PEA.SuspendLayout();
            panel3.SuspendLayout();
            groupBoxInput_PEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInMatrix_PEA).BeginInit();
            panel4.SuspendLayout();
            groupBoxResult_PEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutMatrix_PEA).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonHelp_PEA);
            panel1.Controls.Add(buttonSave_PEA);
            panel1.Controls.Add(buttonDone_PEA);
            panel1.Controls.Add(buttonOpenFile_PEA);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5, 4, 5, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1178, 99);
            panel1.TabIndex = 0;
            // 
            // buttonHelp_PEA
            // 
            buttonHelp_PEA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_PEA.BackgroundImage = (Image)resources.GetObject("buttonHelp_PEA.BackgroundImage");
            buttonHelp_PEA.BackgroundImageLayout = ImageLayout.Stretch;
            buttonHelp_PEA.Cursor = Cursors.Hand;
            buttonHelp_PEA.Location = new Point(1074, 4);
            buttonHelp_PEA.Margin = new Padding(5, 4, 5, 4);
            buttonHelp_PEA.Name = "buttonHelp_PEA";
            buttonHelp_PEA.Size = new Size(101, 84);
            buttonHelp_PEA.TabIndex = 1;
            toolTip_PEA.SetToolTip(buttonHelp_PEA, "Сведения о программе");
            buttonHelp_PEA.UseVisualStyleBackColor = true;
            buttonHelp_PEA.Click += buttonHelp_PEA_Click;
            buttonHelp_PEA.MouseEnter += buttonHelp_PEA_MouseEnter;
            // 
            // buttonSave_PEA
            // 
            buttonSave_PEA.BackgroundImage = (Image)resources.GetObject("buttonSave_PEA.BackgroundImage");
            buttonSave_PEA.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSave_PEA.Cursor = Cursors.Hand;
            buttonSave_PEA.Enabled = false;
            buttonSave_PEA.Location = new Point(219, 4);
            buttonSave_PEA.Margin = new Padding(5, 4, 5, 4);
            buttonSave_PEA.Name = "buttonSave_PEA";
            buttonSave_PEA.Size = new Size(101, 84);
            buttonSave_PEA.TabIndex = 1;
            toolTip_PEA.SetToolTip(buttonSave_PEA, "Сохранить файл");
            buttonSave_PEA.UseVisualStyleBackColor = true;
            buttonSave_PEA.Click += buttonSave_PEA_Click;
            buttonSave_PEA.MouseEnter += buttonSave_PEA_MouseEnter;
            // 
            // buttonDone_PEA
            // 
            buttonDone_PEA.BackgroundImage = (Image)resources.GetObject("buttonDone_PEA.BackgroundImage");
            buttonDone_PEA.BackgroundImageLayout = ImageLayout.Stretch;
            buttonDone_PEA.Cursor = Cursors.Hand;
            buttonDone_PEA.Enabled = false;
            buttonDone_PEA.Location = new Point(112, 4);
            buttonDone_PEA.Margin = new Padding(5, 4, 5, 4);
            buttonDone_PEA.Name = "buttonDone_PEA";
            buttonDone_PEA.Size = new Size(101, 84);
            buttonDone_PEA.TabIndex = 1;
            toolTip_PEA.SetToolTip(buttonDone_PEA, "Во второй строке числа кратные 4 заменяет на 4\r\n");
            buttonDone_PEA.UseVisualStyleBackColor = true;
            buttonDone_PEA.Click += buttonDone_PEA_Click;
            buttonDone_PEA.MouseEnter += buttonDone_PEA_MouseEnter;
            // 
            // buttonOpenFile_PEA
            // 
            buttonOpenFile_PEA.BackgroundImage = (Image)resources.GetObject("buttonOpenFile_PEA.BackgroundImage");
            buttonOpenFile_PEA.BackgroundImageLayout = ImageLayout.Stretch;
            buttonOpenFile_PEA.Cursor = Cursors.Hand;
            buttonOpenFile_PEA.Location = new Point(5, 4);
            buttonOpenFile_PEA.Margin = new Padding(5, 4, 5, 4);
            buttonOpenFile_PEA.Name = "buttonOpenFile_PEA";
            buttonOpenFile_PEA.Size = new Size(101, 84);
            buttonOpenFile_PEA.TabIndex = 1;
            toolTip_PEA.SetToolTip(buttonOpenFile_PEA, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            buttonOpenFile_PEA.UseVisualStyleBackColor = true;
            buttonOpenFile_PEA.Click += buttonOpenFile_PEA_Click;
            buttonOpenFile_PEA.MouseEnter += buttonOpenFile_PEA_MouseEnter;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBoxTask_PEA);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 99);
            panel2.Margin = new Padding(5, 4, 5, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1178, 131);
            panel2.TabIndex = 0;
            // 
            // groupBoxTask_PEA
            // 
            groupBoxTask_PEA.Controls.Add(textBoxTask_PEA);
            groupBoxTask_PEA.Dock = DockStyle.Fill;
            groupBoxTask_PEA.Location = new Point(0, 0);
            groupBoxTask_PEA.Margin = new Padding(5, 4, 5, 4);
            groupBoxTask_PEA.Name = "groupBoxTask_PEA";
            groupBoxTask_PEA.Padding = new Padding(5, 4, 5, 4);
            groupBoxTask_PEA.Size = new Size(1178, 131);
            groupBoxTask_PEA.TabIndex = 0;
            groupBoxTask_PEA.TabStop = false;
            groupBoxTask_PEA.Text = "Условие:";
            // 
            // textBoxTask_PEA
            // 
            textBoxTask_PEA.Dock = DockStyle.Fill;
            textBoxTask_PEA.Location = new Point(5, 24);
            textBoxTask_PEA.Margin = new Padding(5, 4, 5, 4);
            textBoxTask_PEA.Multiline = true;
            textBoxTask_PEA.Name = "textBoxTask_PEA";
            textBoxTask_PEA.ReadOnly = true;
            textBoxTask_PEA.Size = new Size(1168, 103);
            textBoxTask_PEA.TabIndex = 0;
            textBoxTask_PEA.Text = resources.GetString("textBoxTask_PEA.Text");
            textBoxTask_PEA.TextChanged += textBoxTask_PEA_TextChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBoxInput_PEA);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 230);
            panel3.Margin = new Padding(5, 4, 5, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(574, 557);
            panel3.TabIndex = 0;
            // 
            // groupBoxInput_PEA
            // 
            groupBoxInput_PEA.Controls.Add(dataGridViewInMatrix_PEA);
            groupBoxInput_PEA.Dock = DockStyle.Fill;
            groupBoxInput_PEA.Location = new Point(0, 0);
            groupBoxInput_PEA.Margin = new Padding(5, 4, 5, 4);
            groupBoxInput_PEA.Name = "groupBoxInput_PEA";
            groupBoxInput_PEA.Padding = new Padding(5, 4, 5, 4);
            groupBoxInput_PEA.Size = new Size(574, 557);
            groupBoxInput_PEA.TabIndex = 0;
            groupBoxInput_PEA.TabStop = false;
            groupBoxInput_PEA.Text = "Ввод:";
            // 
            // dataGridViewInMatrix_PEA
            // 
            dataGridViewInMatrix_PEA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInMatrix_PEA.ColumnHeadersVisible = false;
            dataGridViewInMatrix_PEA.Dock = DockStyle.Fill;
            dataGridViewInMatrix_PEA.Location = new Point(5, 24);
            dataGridViewInMatrix_PEA.Margin = new Padding(5, 4, 5, 4);
            dataGridViewInMatrix_PEA.Name = "dataGridViewInMatrix_PEA";
            dataGridViewInMatrix_PEA.RowHeadersVisible = false;
            dataGridViewInMatrix_PEA.RowHeadersWidth = 51;
            dataGridViewInMatrix_PEA.Size = new Size(564, 529);
            dataGridViewInMatrix_PEA.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(groupBoxResult_PEA);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(574, 230);
            panel4.Margin = new Padding(5, 4, 5, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(604, 557);
            panel4.TabIndex = 0;
            // 
            // groupBoxResult_PEA
            // 
            groupBoxResult_PEA.Controls.Add(dataGridViewOutMatrix_PEA);
            groupBoxResult_PEA.Dock = DockStyle.Fill;
            groupBoxResult_PEA.Location = new Point(0, 0);
            groupBoxResult_PEA.Margin = new Padding(5, 4, 5, 4);
            groupBoxResult_PEA.Name = "groupBoxResult_PEA";
            groupBoxResult_PEA.Padding = new Padding(5, 4, 5, 4);
            groupBoxResult_PEA.Size = new Size(604, 557);
            groupBoxResult_PEA.TabIndex = 0;
            groupBoxResult_PEA.TabStop = false;
            groupBoxResult_PEA.Text = "Вывод:";
            // 
            // dataGridViewOutMatrix_PEA
            // 
            dataGridViewOutMatrix_PEA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutMatrix_PEA.ColumnHeadersVisible = false;
            dataGridViewOutMatrix_PEA.Dock = DockStyle.Fill;
            dataGridViewOutMatrix_PEA.Location = new Point(5, 24);
            dataGridViewOutMatrix_PEA.Margin = new Padding(5, 4, 5, 4);
            dataGridViewOutMatrix_PEA.Name = "dataGridViewOutMatrix_PEA";
            dataGridViewOutMatrix_PEA.RowHeadersVisible = false;
            dataGridViewOutMatrix_PEA.RowHeadersWidth = 51;
            dataGridViewOutMatrix_PEA.Size = new Size(594, 529);
            dataGridViewOutMatrix_PEA.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(574, 230);
            splitter1.Margin = new Padding(5, 4, 5, 4);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(5, 557);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // openFileDialogTask_PEA
            // 
            openFileDialogTask_PEA.FileName = "openFileDialog1";
            // 
            // toolTip_PEA
            // 
            toolTip_PEA.ToolTipIcon = ToolTipIcon.Info;
            toolTip_PEA.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 787);
            Controls.Add(splitter1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(5, 4, 5, 4);
            MinimumSize = new Size(1194, 823);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 4 | Поздеева Е.А.";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBoxTask_PEA.ResumeLayout(false);
            groupBoxTask_PEA.PerformLayout();
            panel3.ResumeLayout(false);
            groupBoxInput_PEA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInMatrix_PEA).EndInit();
            panel4.ResumeLayout(false);
            groupBoxResult_PEA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutMatrix_PEA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBoxTask_PEA;
        private System.Windows.Forms.TextBox textBoxTask_PEA;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBoxInput_PEA;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBoxResult_PEA;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button buttonHelp_PEA;
        private System.Windows.Forms.Button buttonDone_PEA;
        private System.Windows.Forms.Button buttonOpenFile_PEA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_PEA;
        private System.Windows.Forms.ToolTip toolTip_PEA;
        private System.Windows.Forms.Button buttonSave_PEA;
        private System.Windows.Forms.DataGridView dataGridViewInMatrix_PEA;
        private System.Windows.Forms.DataGridView dataGridViewOutMatrix_PEA;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix;
    }
}
