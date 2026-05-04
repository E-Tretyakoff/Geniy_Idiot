namespace GeniyIdiot_WindowsFormApp_new
{
    partial class MainForm
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
            nextButton = new Button();
            questionNumberlabel = new Label();
            questionTextlabel = new Label();
            userAnswertextBox = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            ShowTableToolStripMenuItem = new ToolStripMenuItem();
            RestartButton = new ToolStripMenuItem();
            ExitGameStripMenuItem = new ToolStripMenuItem();
            adminToolStripMenuItem = new ToolStripMenuItem();
            управлениеВопросамиToolStripMenuItem = new ToolStripMenuItem();
            управлениеПользователямиToolStripMenuItem = new ToolStripMenuItem();
            labelTimer = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // nextButton
            // 
            nextButton.Location = new Point(49, 145);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(100, 23);
            nextButton.TabIndex = 0;
            nextButton.Text = "Далее";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // questionNumberlabel
            // 
            questionNumberlabel.AutoSize = true;
            questionNumberlabel.Location = new Point(49, 40);
            questionNumberlabel.Name = "questionNumberlabel";
            questionNumberlabel.Size = new Size(70, 15);
            questionNumberlabel.TabIndex = 1;
            questionNumberlabel.Text = "Вопрос №1";
            // 
            // questionTextlabel
            // 
            questionTextlabel.AutoSize = true;
            questionTextlabel.Location = new Point(49, 73);
            questionTextlabel.Name = "questionTextlabel";
            questionTextlabel.Size = new Size(86, 15);
            questionTextlabel.TabIndex = 2;
            questionTextlabel.Text = "Текст вопроса";
            // 
            // userAnswertextBox
            // 
            userAnswertextBox.Location = new Point(49, 103);
            userAnswertextBox.Name = "userAnswertextBox";
            userAnswertextBox.Size = new Size(286, 23);
            userAnswertextBox.TabIndex = 3;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, adminToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(564, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ShowTableToolStripMenuItem, RestartButton, ExitGameStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // ShowTableToolStripMenuItem
            // 
            ShowTableToolStripMenuItem.Name = "ShowTableToolStripMenuItem";
            ShowTableToolStripMenuItem.Size = new Size(189, 22);
            ShowTableToolStripMenuItem.Text = "Посмотреть таблицу";
            ShowTableToolStripMenuItem.Click += ShowTableToolStripMenuItem_Click;
            // 
            // RestartButton
            // 
            RestartButton.Name = "RestartButton";
            RestartButton.Size = new Size(189, 22);
            RestartButton.Text = "Рестарт";
            RestartButton.Click += рестартToolStripMenuItem_Click;
            // 
            // ExitGameStripMenuItem
            // 
            ExitGameStripMenuItem.Name = "ExitGameStripMenuItem";
            ExitGameStripMenuItem.Size = new Size(189, 22);
            ExitGameStripMenuItem.Text = "Выйти из игры";
            ExitGameStripMenuItem.Click += выйтиИзИгрыToolStripMenuItem_Click;
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { управлениеВопросамиToolStripMenuItem, управлениеПользователямиToolStripMenuItem });
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(55, 20);
            adminToolStripMenuItem.Text = "Admin";
            // 
            // управлениеВопросамиToolStripMenuItem
            // 
            управлениеВопросамиToolStripMenuItem.Name = "управлениеВопросамиToolStripMenuItem";
            управлениеВопросамиToolStripMenuItem.Size = new Size(233, 22);
            управлениеВопросамиToolStripMenuItem.Text = "управление вопросами";
            // 
            // управлениеПользователямиToolStripMenuItem
            // 
            управлениеПользователямиToolStripMenuItem.Name = "управлениеПользователямиToolStripMenuItem";
            управлениеПользователямиToolStripMenuItem.Size = new Size(233, 22);
            управлениеПользователямиToolStripMenuItem.Text = "управление пользователями";
            // 
            // labelTimer
            // 
            labelTimer.AutoSize = true;
            labelTimer.Location = new Point(132, 40);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(17, 15);
            labelTimer.TabIndex = 5;
            labelTimer.Text = "--";
            labelTimer.TextAlign = ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 207);
            Controls.Add(labelTimer);
            Controls.Add(userAnswertextBox);
            Controls.Add(questionTextlabel);
            Controls.Add(questionNumberlabel);
            Controls.Add(nextButton);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Гений_Идиот";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button nextButton;
        private Label questionNumberlabel;
        private Label questionTextlabel;
        private TextBox userAnswertextBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem ShowTableToolStripMenuItem;
        private ToolStripMenuItem RestartButton;
        private ToolStripMenuItem ExitGameStripMenuItem;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem управлениеВопросамиToolStripMenuItem;
        private ToolStripMenuItem управлениеПользователямиToolStripMenuItem;
        private Label labelTimer;
        private System.Windows.Forms.Timer timer1;
    }
}
