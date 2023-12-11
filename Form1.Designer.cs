namespace FlowApplication
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.MinuteTextBox = new System.Windows.Forms.TextBox();
            this.SecondTextBox = new System.Windows.Forms.TextBox();
            this.Divide = new System.Windows.Forms.TextBox();
            this.PauseButton = new System.Windows.Forms.Button();
            this.CloseApplicationButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.InfoButton = new System.Windows.Forms.Button();
            this.InfoTextBox = new System.Windows.Forms.TextBox();
            this.ProgressBarTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // MinuteTextBox
            // 
            this.MinuteTextBox.BackColor = System.Drawing.Color.Tomato;
            this.MinuteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MinuteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 57F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinuteTextBox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.MinuteTextBox.Location = new System.Drawing.Point(168, 86);
            this.MinuteTextBox.MaxLength = 2;
            this.MinuteTextBox.Multiline = true;
            this.MinuteTextBox.Name = "MinuteTextBox";
            this.MinuteTextBox.ShortcutsEnabled = false;
            this.MinuteTextBox.Size = new System.Drawing.Size(112, 105);
            this.MinuteTextBox.TabIndex = 1;
            this.MinuteTextBox.TabStop = false;
            this.MinuteTextBox.Text = "25";
            // 
            // SecondTextBox
            // 
            this.SecondTextBox.BackColor = System.Drawing.Color.Tomato;
            this.SecondTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SecondTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 57F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondTextBox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.SecondTextBox.Location = new System.Drawing.Point(323, 86);
            this.SecondTextBox.MaxLength = 2;
            this.SecondTextBox.Multiline = true;
            this.SecondTextBox.Name = "SecondTextBox";
            this.SecondTextBox.ShortcutsEnabled = false;
            this.SecondTextBox.Size = new System.Drawing.Size(112, 105);
            this.SecondTextBox.TabIndex = 2;
            this.SecondTextBox.TabStop = false;
            this.SecondTextBox.Text = "00";
            // 
            // Divide
            // 
            this.Divide.BackColor = System.Drawing.Color.Tomato;
            this.Divide.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 57F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Divide.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.Divide.Location = new System.Drawing.Point(286, 77);
            this.Divide.Multiline = true;
            this.Divide.Name = "Divide";
            this.Divide.ReadOnly = true;
            this.Divide.Size = new System.Drawing.Size(31, 105);
            this.Divide.TabIndex = 3;
            this.Divide.TabStop = false;
            this.Divide.Text = ":";
            // 
            // PauseButton
            // 
            this.PauseButton.BackColor = System.Drawing.Color.Tomato;
            this.PauseButton.FlatAppearance.BorderSize = 2;
            this.PauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PauseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PauseButton.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.PauseButton.Location = new System.Drawing.Point(277, 228);
            this.PauseButton.Margin = new System.Windows.Forms.Padding(5);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(50, 50);
            this.PauseButton.TabIndex = 4;
            this.PauseButton.TabStop = false;
            this.PauseButton.Text = ">";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // CloseApplicationButton
            // 
            this.CloseApplicationButton.BackColor = System.Drawing.Color.Tomato;
            this.CloseApplicationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseApplicationButton.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.CloseApplicationButton.Location = new System.Drawing.Point(607, 2);
            this.CloseApplicationButton.Name = "CloseApplicationButton";
            this.CloseApplicationButton.Size = new System.Drawing.Size(30, 30);
            this.CloseApplicationButton.TabIndex = 5;
            this.CloseApplicationButton.TabStop = false;
            this.CloseApplicationButton.Text = "X";
            this.CloseApplicationButton.UseVisualStyleBackColor = true;
            this.CloseApplicationButton.Click += new System.EventHandler(this.CloseApplication_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.ResetButton.Location = new System.Drawing.Point(568, 2);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(30, 30);
            this.ResetButton.TabIndex = 6;
            this.ResetButton.TabStop = false;
            this.ResetButton.Text = "R";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // InfoButton
            // 
            this.InfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoButton.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.InfoButton.Location = new System.Drawing.Point(3, 2);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(30, 30);
            this.InfoButton.TabIndex = 8;
            this.InfoButton.TabStop = false;
            this.InfoButton.Text = "?";
            this.InfoButton.UseVisualStyleBackColor = true;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // InfoTextBox
            // 
            this.InfoTextBox.BackColor = System.Drawing.Color.Tomato;
            this.InfoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InfoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoTextBox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.InfoTextBox.Location = new System.Drawing.Point(39, 38);
            this.InfoTextBox.Multiline = true;
            this.InfoTextBox.Name = "InfoTextBox";
            this.InfoTextBox.ReadOnly = true;
            this.InfoTextBox.Size = new System.Drawing.Size(522, 240);
            this.InfoTextBox.TabIndex = 9;
            this.InfoTextBox.Text = resources.GetString("InfoTextBox.Text");
            this.InfoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InfoTextBox.Visible = false;
            // 
            // ProgressBarTextBox
            // 
            this.ProgressBarTextBox.BackColor = System.Drawing.Color.Tomato;
            this.ProgressBarTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProgressBarTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProgressBarTextBox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.ProgressBarTextBox.Location = new System.Drawing.Point(212, 185);
            this.ProgressBarTextBox.Multiline = true;
            this.ProgressBarTextBox.Name = "ProgressBarTextBox";
            this.ProgressBarTextBox.ReadOnly = true;
            this.ProgressBarTextBox.Size = new System.Drawing.Size(185, 25);
            this.ProgressBarTextBox.TabIndex = 10;
            this.ProgressBarTextBox.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(640, 320);
            this.Controls.Add(this.ProgressBarTextBox);
            this.Controls.Add(this.InfoTextBox);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.CloseApplicationButton);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.SecondTextBox);
            this.Controls.Add(this.MinuteTextBox);
            this.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "Flow";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.TextBox MinuteTextBox;
        private System.Windows.Forms.TextBox SecondTextBox;
        private System.Windows.Forms.TextBox Divide;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button CloseApplicationButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button InfoButton;
        private System.Windows.Forms.TextBox InfoTextBox;
        private System.Windows.Forms.TextBox ProgressBarTextBox;
    }
}

