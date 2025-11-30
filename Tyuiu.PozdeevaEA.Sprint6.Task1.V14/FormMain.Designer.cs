namespace Tyuiu.PozdeevaEA.Sprint6.Task1.V14
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
            labelResult_PEA = new Label();
            textBoxResult_PEA = new TextBox();
            groupBoxTask_PEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_PEA).BeginInit();
            groupBoxValue_PEA.SuspendLayout();
            groupBoxResult_PEA.SuspendLayout();
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
            groupBoxTask_PEA.Size = new Size(484, 269);
            groupBoxTask_PEA.TabIndex = 0;
            groupBoxTask_PEA.TabStop = false;
            groupBoxTask_PEA.Text = "Условие";
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
            pictureBoxFormula_PEA.Image = (Image)resources.GetObject("pictureBoxFormula_PEA.Image");
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
            groupBoxValue_PEA.Location = new Point(12, 326);
            groupBoxValue_PEA.Margin = new Padding(3, 4, 3, 4);
            groupBoxValue_PEA.Name = "groupBoxValue_PEA";
            groupBoxValue_PEA.Padding = new Padding(3, 4, 3, 4);
            groupBoxValue_PEA.Size = new Size(486, 261);
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
            buttonDone_PEA.Location = new Point(274, 197);
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
            buttonHelp_PEA.Location = new Point(215, 197);
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
            labelstart_PEA.Location = new Point(23, 78);
            labelstart_PEA.Name = "labelstart_PEA";
            labelstart_PEA.Size = new Size(143, 20);
            labelstart_PEA.TabIndex = 4;
            labelstart_PEA.Text = "Начало диапазона:";
            // 
            // labelstop_PEA
            // 
            labelstop_PEA.AutoSize = true;
            labelstop_PEA.Location = new Point(259, 78);
            labelstop_PEA.Name = "labelstop_PEA";
            labelstop_PEA.Size = new Size(135, 20);
            labelstop_PEA.TabIndex = 4;
            labelstop_PEA.Text = "Конец диапазона:";
            // 
            // textBoxValuestart_PEA
            // 
            textBoxValuestart_PEA.Location = new Point(23, 126);
            textBoxValuestart_PEA.Margin = new Padding(3, 4, 3, 4);
            textBoxValuestart_PEA.Name = "textBoxValuestart_PEA";
            textBoxValuestart_PEA.Size = new Size(132, 27);
            textBoxValuestart_PEA.TabIndex = 3;
            // 
            // textBoxValuestop_PEA
            // 
            textBoxValuestop_PEA.Location = new Point(259, 126);
            textBoxValuestop_PEA.Margin = new Padding(3, 4, 3, 4);
            textBoxValuestop_PEA.Name = "textBoxValuestop_PEA";
            textBoxValuestop_PEA.Size = new Size(132, 27);
            textBoxValuestop_PEA.TabIndex = 3;
            // 
            // groupBoxResult_PEA
            // 
            groupBoxResult_PEA.Controls.Add(labelResult_PEA);
            groupBoxResult_PEA.Controls.Add(textBoxResult_PEA);
            groupBoxResult_PEA.Location = new Point(521, 16);
            groupBoxResult_PEA.Margin = new Padding(3, 4, 3, 4);
            groupBoxResult_PEA.Name = "groupBoxResult_PEA";
            groupBoxResult_PEA.Padding = new Padding(3, 4, 3, 4);
            groupBoxResult_PEA.Size = new Size(381, 571);
            groupBoxResult_PEA.TabIndex = 0;
            groupBoxResult_PEA.TabStop = false;
            groupBoxResult_PEA.Text = "Вывод данных";
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
            // textBoxResult_PEA
            // 
            textBoxResult_PEA.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_PEA.Location = new Point(35, 78);
            textBoxResult_PEA.Margin = new Padding(3, 4, 3, 4);
            textBoxResult_PEA.Multiline = true;
            textBoxResult_PEA.Name = "textBoxResult_PEA";
            textBoxResult_PEA.ReadOnly = true;
            textBoxResult_PEA.ScrollBars = ScrollBars.Vertical;
            textBoxResult_PEA.Size = new Size(315, 464);
            textBoxResult_PEA.TabIndex = 3;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(groupBoxResult_PEA);
            Controls.Add(groupBoxValue_PEA);
            Controls.Add(groupBoxTask_PEA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 14 | Поздеева Е.А.";
            groupBoxTask_PEA.ResumeLayout(false);
            groupBoxTask_PEA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_PEA).EndInit();
            groupBoxValue_PEA.ResumeLayout(false);
            groupBoxValue_PEA.PerformLayout();
            groupBoxResult_PEA.ResumeLayout(false);
            groupBoxResult_PEA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_PEA;
        private GroupBox groupBoxValue_PEA;
        private GroupBox groupBoxResult_PEA;
        private TextBox textBoxResult_PEA;
        private PictureBox pictureBoxFormula_PEA;
        private Button buttonDone_PEA;
        private TextBox textBoxValuestart_PEA;
        private TextBox textBoxValuestop_PEA;
        private TextBox textBoxTask_PEA;
        private Label labelstart_PEA;
        private Label labelstop_PEA;
        private Label labelResult_PEA;
        private Button buttonHelp_PEA;
    }

        
    }

