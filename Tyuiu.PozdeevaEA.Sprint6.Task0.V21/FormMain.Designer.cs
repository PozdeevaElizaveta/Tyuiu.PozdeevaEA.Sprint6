namespace Tyuiu.PozdeevaEA.Sprint6.Task0.V21
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
            groupBoxValue_PEA = new GroupBox();
            labelX_PEA = new Label();
            textBoxValueX_PEA = new TextBox();
            groupBoxResult_PEA = new GroupBox();
            labelResult_PEA = new Label();
            textBoxResult_PEA = new TextBox();
            pictureBoxFormula_PEA = new PictureBox();
            buttonDone_PEA = new Button();
            buttonHelp_PEA = new Button();
            groupBoxTask_PEA.SuspendLayout();
            groupBoxValue_PEA.SuspendLayout();
            groupBoxResult_PEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_PEA).BeginInit();
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
            groupBoxTask_PEA.Size = new Size(895, 184);
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
            textBoxTask_PEA.Size = new Size(517, 219);
            textBoxTask_PEA.TabIndex = 0;
            textBoxTask_PEA.Text = "Вычислить выражение по формуле:";
            textBoxTask_PEA.TextChanged += textBoxTask_PEA_TextChanged;
            // 
            // groupBoxValue_PEA
            // 
            groupBoxValue_PEA.Controls.Add(labelX_PEA);
            groupBoxValue_PEA.Controls.Add(textBoxValueX_PEA);
            groupBoxValue_PEA.Location = new Point(12, 287);
            groupBoxValue_PEA.Margin = new Padding(3, 4, 3, 4);
            groupBoxValue_PEA.Name = "groupBoxValue_PEA";
            groupBoxValue_PEA.Padding = new Padding(3, 4, 3, 4);
            groupBoxValue_PEA.Size = new Size(551, 153);
            groupBoxValue_PEA.TabIndex = 0;
            groupBoxValue_PEA.TabStop = false;
            groupBoxValue_PEA.Text = "Ввод данных";
            // 
            // labelX_PEA
            // 
            labelX_PEA.AutoSize = true;
            labelX_PEA.Location = new Point(7, 40);
            labelX_PEA.Name = "labelX_PEA";
            labelX_PEA.Size = new Size(92, 20);
            labelX_PEA.TabIndex = 4;
            labelX_PEA.Text = "Значение X:";
            // 
            // textBoxValueX_PEA
            // 
            textBoxValueX_PEA.Location = new Point(7, 64);
            textBoxValueX_PEA.Margin = new Padding(3, 4, 3, 4);
            textBoxValueX_PEA.Name = "textBoxValueX_PEA";
            textBoxValueX_PEA.Size = new Size(132, 27);
            textBoxValueX_PEA.TabIndex = 3;
            // 
            // groupBoxResult_PEA
            // 
            groupBoxResult_PEA.Controls.Add(labelResult_PEA);
            groupBoxResult_PEA.Controls.Add(textBoxResult_PEA);
            groupBoxResult_PEA.Location = new Point(573, 287);
            groupBoxResult_PEA.Margin = new Padding(3, 4, 3, 4);
            groupBoxResult_PEA.Name = "groupBoxResult_PEA";
            groupBoxResult_PEA.Padding = new Padding(3, 4, 3, 4);
            groupBoxResult_PEA.Size = new Size(329, 153);
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
            textBoxResult_PEA.Location = new Point(7, 64);
            textBoxResult_PEA.Margin = new Padding(3, 4, 3, 4);
            textBoxResult_PEA.Name = "textBoxResult_PEA";
            textBoxResult_PEA.ReadOnly = true;
            textBoxResult_PEA.Size = new Size(315, 27);
            textBoxResult_PEA.TabIndex = 3;
            // 
            // pictureBoxFormula_PEA
            // 
            pictureBoxFormula_PEA.Image = (Image)resources.GetObject("pictureBoxFormula_PEA.Image");
            pictureBoxFormula_PEA.Location = new Point(523, 29);
            pictureBoxFormula_PEA.Margin = new Padding(3, 4, 3, 4);
            pictureBoxFormula_PEA.Name = "pictureBoxFormula_PEA";
            pictureBoxFormula_PEA.Size = new Size(356, 67);
            pictureBoxFormula_PEA.TabIndex = 1;
            pictureBoxFormula_PEA.TabStop = false;
            pictureBoxFormula_PEA.Click += pictureBoxFormula_PEA_Click;
            // 
            // buttonDone_PEA
            // 
            buttonDone_PEA.Location = new Point(722, 448);
            buttonDone_PEA.Margin = new Padding(3, 4, 3, 4);
            buttonDone_PEA.Name = "buttonDone_PEA";
            buttonDone_PEA.Size = new Size(180, 35);
            buttonDone_PEA.TabIndex = 4;
            buttonDone_PEA.Text = "Выполнить";
            buttonDone_PEA.UseVisualStyleBackColor = true;
            buttonDone_PEA.Click += buttonDone_PEA_Click;
            // 
            // buttonHelp_PEA
            // 
            buttonHelp_PEA.FlatStyle = FlatStyle.Flat;
            buttonHelp_PEA.Location = new Point(681, 448);
            buttonHelp_PEA.Margin = new Padding(3, 4, 3, 4);
            buttonHelp_PEA.Name = "buttonHelp_PEA";
            buttonHelp_PEA.Size = new Size(35, 35);
            buttonHelp_PEA.TabIndex = 5;
            buttonHelp_PEA.Text = "?";
            buttonHelp_PEA.UseVisualStyleBackColor = true;
            buttonHelp_PEA.Click += buttonHelp_PEA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(buttonHelp_PEA);
            Controls.Add(buttonDone_PEA);
            Controls.Add(groupBoxResult_PEA);
            Controls.Add(groupBoxValue_PEA);
            Controls.Add(groupBoxTask_PEA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 21 | Поздеева Е.А.";
            groupBoxTask_PEA.ResumeLayout(false);
            groupBoxTask_PEA.PerformLayout();
            groupBoxValue_PEA.ResumeLayout(false);
            groupBoxValue_PEA.PerformLayout();
            groupBoxResult_PEA.ResumeLayout(false);
            groupBoxResult_PEA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_PEA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_PEA;
        private GroupBox groupBoxValue_PEA;
        private GroupBox groupBoxResult_PEA;
        private TextBox textBoxResult_PEA;
        private PictureBox pictureBoxFormula_PEA;
        private Button buttonDone_PEA;
        private TextBox textBoxValueX_PEA;
        private TextBox textBoxTask_PEA;
        private Label labelX_PEA;
        private Label labelResult_PEA;
        private Button buttonHelp_PEA;
    }
}
