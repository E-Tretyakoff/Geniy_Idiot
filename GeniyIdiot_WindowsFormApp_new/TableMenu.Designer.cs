namespace GeniyIdiot_WindowsFormApp_new
{
    partial class TableMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            TextNotTablelabel1 = new Label();
            deleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(449, 370);
            dataGridView1.TabIndex = 1;
            dataGridView1.Visible = false;
            // 
            // TextNotTablelabel1
            // 
            TextNotTablelabel1.AutoSize = true;
            TextNotTablelabel1.Location = new Point(25, 9);
            TextNotTablelabel1.Name = "TextNotTablelabel1";
            TextNotTablelabel1.Size = new Size(262, 15);
            TextNotTablelabel1.TabIndex = 0;
            TextNotTablelabel1.Text = "Таблица пустая... Никто еще не проходил тест";
            TextNotTablelabel1.Visible = false;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(12, 38);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += button1_Click;
            // 
            // TableMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 449);
            Controls.Add(deleteButton);
            Controls.Add(TextNotTablelabel1);
            Controls.Add(dataGridView1);
            Name = "TableMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TableMenu";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label TextNotTablelabel1;
        private Button deleteButton;
    }
}