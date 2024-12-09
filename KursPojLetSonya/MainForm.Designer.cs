namespace KursPojLetSonya
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.ThemeComboBox = new System.Windows.Forms.ComboBox();
            this.VarButton1 = new System.Windows.Forms.Button();
            this.ToAvtButton = new System.Windows.Forms.Button();
            this.OpenDocsButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.VarGroupBox = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.VarGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(831, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выбирай тему, изучай теорию и решай задачи!";
            // 
            // ThemeComboBox
            // 
            this.ThemeComboBox.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemeComboBox.FormattingEnabled = true;
            this.ThemeComboBox.Items.AddRange(new object[] {
            "Основы",
            "Основные формулы",
            "Простейшие уравнения",
            "Типы уравнений",
            "Неравенства",
            "Функции"});
            this.ThemeComboBox.Location = new System.Drawing.Point(68, 78);
            this.ThemeComboBox.Name = "ThemeComboBox";
            this.ThemeComboBox.Size = new System.Drawing.Size(558, 43);
            this.ThemeComboBox.TabIndex = 1;
            // 
            // VarButton1
            // 
            this.VarButton1.BackColor = System.Drawing.Color.MediumPurple;
            this.VarButton1.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VarButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.VarButton1.Location = new System.Drawing.Point(547, 319);
            this.VarButton1.Name = "VarButton1";
            this.VarButton1.Size = new System.Drawing.Size(140, 80);
            this.VarButton1.TabIndex = 2;
            this.VarButton1.Text = "Перейти к тестированию";
            this.VarButton1.UseVisualStyleBackColor = false;
            // 
            // ToAvtButton
            // 
            this.ToAvtButton.BackColor = System.Drawing.Color.MediumPurple;
            this.ToAvtButton.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToAvtButton.ForeColor = System.Drawing.Color.GhostWhite;
            this.ToAvtButton.Location = new System.Drawing.Point(978, 442);
            this.ToAvtButton.Name = "ToAvtButton";
            this.ToAvtButton.Size = new System.Drawing.Size(162, 80);
            this.ToAvtButton.TabIndex = 14;
            this.ToAvtButton.Text = "Вернуться";
            this.ToAvtButton.UseVisualStyleBackColor = false;
            this.ToAvtButton.Click += new System.EventHandler(this.ToAvtButton_Click);
            // 
            // OpenDocsButton
            // 
            this.OpenDocsButton.BackColor = System.Drawing.Color.MediumPurple;
            this.OpenDocsButton.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenDocsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.OpenDocsButton.Location = new System.Drawing.Point(68, 127);
            this.OpenDocsButton.Name = "OpenDocsButton";
            this.OpenDocsButton.Size = new System.Drawing.Size(239, 40);
            this.OpenDocsButton.TabIndex = 15;
            this.OpenDocsButton.Text = "Читатать теорию";
            this.OpenDocsButton.UseVisualStyleBackColor = false;
            this.OpenDocsButton.Click += new System.EventHandler(this.OpenDocsButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumPurple;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(547, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 80);
            this.button1.TabIndex = 17;
            this.button1.Text = "Посмотреть оценки";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumPurple;
            this.button2.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(6, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 80);
            this.button2.TabIndex = 18;
            this.button2.Text = "Вариант1";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumPurple;
            this.button3.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(177, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 80);
            this.button3.TabIndex = 19;
            this.button3.Text = "Вариант2";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MediumPurple;
            this.button4.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(348, 14);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(160, 80);
            this.button4.TabIndex = 20;
            this.button4.Text = "Вариант3";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // VarGroupBox
            // 
            this.VarGroupBox.Controls.Add(this.button2);
            this.VarGroupBox.Controls.Add(this.button4);
            this.VarGroupBox.Controls.Add(this.button3);
            this.VarGroupBox.Location = new System.Drawing.Point(400, 204);
            this.VarGroupBox.Name = "VarGroupBox";
            this.VarGroupBox.Size = new System.Drawing.Size(445, 109);
            this.VarGroupBox.TabIndex = 21;
            this.VarGroupBox.TabStop = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1115, 47);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(25, 25);
            this.button5.TabIndex = 22;
            this.button5.Text = "?";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1255, 591);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.VarGroupBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.VarButton1);
            this.Controls.Add(this.OpenDocsButton);
            this.Controls.Add(this.ToAvtButton);
            this.Controls.Add(this.ThemeComboBox);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Главная";
            this.VarGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ThemeComboBox;
        private System.Windows.Forms.Button VarButton1;
        private System.Windows.Forms.Button ToAvtButton;
        private System.Windows.Forms.Button OpenDocsButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox VarGroupBox;
        private System.Windows.Forms.Button button5;
    }
}