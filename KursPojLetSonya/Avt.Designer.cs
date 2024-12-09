namespace KursPojLetSonya
{
    partial class Avt
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
            this.label1 = new System.Windows.Forms.Label();
            this.ToMainButton = new System.Windows.Forms.Button();
            this.AvtNameTextBox = new System.Windows.Forms.TextBox();
            this.AvtPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ToMainAsGuestButton = new System.Windows.Forms.Button();
            this.ToNewAvtLinkLabel = new System.Windows.Forms.LinkLabel();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(92, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1037, 92);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добро пожаловать на обучающую платформу ИзучайКа.\r\n\r\n";
            // 
            // ToMainButton
            // 
            this.ToMainButton.BackColor = System.Drawing.Color.MediumPurple;
            this.ToMainButton.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToMainButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ToMainButton.Location = new System.Drawing.Point(348, 258);
            this.ToMainButton.Name = "ToMainButton";
            this.ToMainButton.Size = new System.Drawing.Size(149, 43);
            this.ToMainButton.TabIndex = 1;
            this.ToMainButton.Text = "Зайти";
            this.ToMainButton.UseVisualStyleBackColor = false;
            this.ToMainButton.Click += new System.EventHandler(this.ToMainButton_Click);
            // 
            // AvtNameTextBox
            // 
            this.AvtNameTextBox.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvtNameTextBox.Location = new System.Drawing.Point(269, 157);
            this.AvtNameTextBox.Name = "AvtNameTextBox";
            this.AvtNameTextBox.Size = new System.Drawing.Size(322, 39);
            this.AvtNameTextBox.TabIndex = 2;
            // 
            // AvtPasswordTextBox
            // 
            this.AvtPasswordTextBox.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvtPasswordTextBox.Location = new System.Drawing.Point(269, 197);
            this.AvtPasswordTextBox.Name = "AvtPasswordTextBox";
            this.AvtPasswordTextBox.Size = new System.Drawing.Size(322, 39);
            this.AvtPasswordTextBox.TabIndex = 3;
            // 
            // ToMainAsGuestButton
            // 
            this.ToMainAsGuestButton.BackColor = System.Drawing.Color.MediumPurple;
            this.ToMainAsGuestButton.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToMainAsGuestButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ToMainAsGuestButton.Location = new System.Drawing.Point(297, 359);
            this.ToMainAsGuestButton.Name = "ToMainAsGuestButton";
            this.ToMainAsGuestButton.Size = new System.Drawing.Size(273, 43);
            this.ToMainAsGuestButton.TabIndex = 4;
            this.ToMainAsGuestButton.Text = "Зайти как гость";
            this.ToMainAsGuestButton.UseVisualStyleBackColor = false;
            this.ToMainAsGuestButton.Click += new System.EventHandler(this.ToMainAsGuestButton_Click);
            // 
            // ToNewAvtLinkLabel
            // 
            this.ToNewAvtLinkLabel.AutoSize = true;
            this.ToNewAvtLinkLabel.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToNewAvtLinkLabel.Location = new System.Drawing.Point(335, 324);
            this.ToNewAvtLinkLabel.Name = "ToNewAvtLinkLabel";
            this.ToNewAvtLinkLabel.Size = new System.Drawing.Size(343, 36);
            this.ToNewAvtLinkLabel.TabIndex = 5;
            this.ToNewAvtLinkLabel.TabStop = true;
            this.ToNewAvtLinkLabel.Text = "Хочу зарегистрироваться";
            this.ToNewAvtLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ToNewAvtLinkLabel_LinkClicked);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Trebuchet MS", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.Location = new System.Drawing.Point(107, 112);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(138, 46);
            this.LoginLabel.TabIndex = 6;
            this.LoginLabel.Text = "Логин:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Trebuchet MS", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLabel.Location = new System.Drawing.Point(110, 133);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(161, 46);
            this.PasswordLabel.TabIndex = 7;
            this.PasswordLabel.Text = "Пароль:";
            // 
            // Avt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1224, 450);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.ToNewAvtLinkLabel);
            this.Controls.Add(this.ToMainAsGuestButton);
            this.Controls.Add(this.AvtPasswordTextBox);
            this.Controls.Add(this.AvtNameTextBox);
            this.Controls.Add(this.ToMainButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Avt";
            this.Text = "Добро пожаловать";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ToMainButton;
        private System.Windows.Forms.TextBox AvtNameTextBox;
        private System.Windows.Forms.TextBox AvtPasswordTextBox;
        private System.Windows.Forms.Button ToMainAsGuestButton;
        private System.Windows.Forms.LinkLabel ToNewAvtLinkLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PasswordLabel;
    }
}

