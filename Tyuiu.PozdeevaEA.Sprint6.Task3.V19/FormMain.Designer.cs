using System.Windows.Forms;

namespace Tyuiu.PozdeevaEA.Sprint6.Task3.V19
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
            buttonRes_PEA = new Button();
            buttonHelp_PEA = new Button();
            groupBoxTask_PEA = new GroupBox();
            dataGridViewTask_PEA = new DataGridView();
            textBox_PEA = new TextBox();
            Column1 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            groupBoxRes_PEA = new GroupBox();
            dataGridViewRes_PEA = new DataGridView();
            groupBoxTask_PEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTask_PEA).BeginInit();
            groupBoxRes_PEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_PEA).BeginInit();
            SuspendLayout();
            // 
            // buttonRes_PEA
            // 
            buttonRes_PEA.BackColor = Color.PaleGoldenrod;
            buttonRes_PEA.BackgroundImageLayout = ImageLayout.None;
            buttonRes_PEA.FlatStyle = FlatStyle.Popup;
            buttonRes_PEA.Location = new Point(682, 394);
            buttonRes_PEA.Name = "buttonRes_PEA";
            buttonRes_PEA.Size = new Size(106, 29);
            buttonRes_PEA.TabIndex = 0;
            buttonRes_PEA.Text = "Выполнить";
            buttonRes_PEA.UseVisualStyleBackColor = false;
            buttonRes_PEA.Click += buttonRes_PEA_Click;
            // 
            // buttonHelp_PEA
            // 
            buttonHelp_PEA.Location = new Point(582, 394);
            buttonHelp_PEA.Name = "buttonHelp_PEA";
            buttonHelp_PEA.Size = new Size(94, 29);
            buttonHelp_PEA.TabIndex = 1;
            buttonHelp_PEA.Text = "Справка";
            buttonHelp_PEA.UseVisualStyleBackColor = true;
            buttonHelp_PEA.Click += buttonHelp_PEA_Click;
            // 
            // groupBoxTask_PEA
            // 
            groupBoxTask_PEA.Controls.Add(dataGridViewTask_PEA);
            groupBoxTask_PEA.Controls.Add(textBox_PEA);
            groupBoxTask_PEA.Location = new Point(12, 12);
            groupBoxTask_PEA.Name = "groupBoxTask_PEA";
            groupBoxTask_PEA.Size = new Size(439, 426);
            groupBoxTask_PEA.TabIndex = 2;
            groupBoxTask_PEA.TabStop = false;
            groupBoxTask_PEA.Text = "Условие";
            // 
            // dataGridViewTask_PEA
            // 
            dataGridViewTask_PEA.AllowUserToAddRows = false;
            dataGridViewTask_PEA.AllowUserToDeleteRows = false;
            dataGridViewTask_PEA.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewTask_PEA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTask_PEA.ColumnHeadersVisible = false;
            dataGridViewTask_PEA.Location = new Point(50, 136);
            dataGridViewTask_PEA.Name = "dataGridViewTask_PEA";
            dataGridViewTask_PEA.ReadOnly = true;
            dataGridViewTask_PEA.RowHeadersVisible = false;
            dataGridViewTask_PEA.RowHeadersWidth = 51;
            dataGridViewTask_PEA.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewTask_PEA.ScrollBars = ScrollBars.None;
            dataGridViewTask_PEA.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewTask_PEA.Size = new Size(326, 188);
            dataGridViewTask_PEA.TabIndex = 4;
            // 
            // textBox_PEA
            // 
            textBox_PEA.BackColor = SystemColors.Info;
            textBox_PEA.Location = new Point(6, 26);
            textBox_PEA.Multiline = true;
            textBox_PEA.Name = "textBox_PEA";
            textBox_PEA.Size = new Size(419, 57);
            textBox_PEA.TabIndex = 5;
            textBox_PEA.Text = "Выполнить сортировку массива по возрастанию в пятом столбце.";
            textBox_PEA.TextChanged += textBox_PEA_TextChanged;
            // 
            // Column1
            // 
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column4
            // 
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column2
            // 
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // groupBoxRes_PEA
            // 
            groupBoxRes_PEA.Controls.Add(dataGridViewRes_PEA);
            groupBoxRes_PEA.Location = new Point(457, 12);
            groupBoxRes_PEA.Name = "groupBoxRes_PEA";
            groupBoxRes_PEA.Size = new Size(331, 364);
            groupBoxRes_PEA.TabIndex = 3;
            groupBoxRes_PEA.TabStop = false;
            groupBoxRes_PEA.Text = "Результат";
            // 
            // dataGridViewRes_PEA
            // 
            dataGridViewRes_PEA.AllowUserToAddRows = false;
            dataGridViewRes_PEA.AllowUserToDeleteRows = false;
            dataGridViewRes_PEA.BackgroundColor = Color.DarkSeaGreen;
            dataGridViewRes_PEA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRes_PEA.ColumnHeadersVisible = false;
            dataGridViewRes_PEA.Location = new Point(20, 38);
            dataGridViewRes_PEA.Name = "dataGridViewRes_PEA";
            dataGridViewRes_PEA.ReadOnly = true;
            dataGridViewRes_PEA.RowHeadersVisible = false;
            dataGridViewRes_PEA.RowHeadersWidth = 51;
            dataGridViewRes_PEA.Size = new Size(287, 233);
            dataGridViewRes_PEA.TabIndex = 4;
            dataGridViewRes_PEA.CellContentClick += dataGridViewRes_PEA_CellContentClick;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxRes_PEA);
            Controls.Add(groupBoxTask_PEA);
            Controls.Add(buttonHelp_PEA);
            Controls.Add(buttonRes_PEA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 19 | Поздеева Е.А.";
            Load += FormMain_Load;
            groupBoxTask_PEA.ResumeLayout(false);
            groupBoxTask_PEA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTask_PEA).EndInit();
            groupBoxRes_PEA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_PEA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonRes_PEA;
        private Button buttonHelp_PEA;
        private GroupBox groupBoxTask_PEA;
        private GroupBox groupBoxRes_PEA;
        private DataGridView dataGridViewTask_PEA;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private TextBox textBox_PEA;
        private DataGridView dataGridViewRes_PEA;
    }
}
