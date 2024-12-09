using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static KursPojLetSonya.Avt;

namespace KursPojLetSonya
{
    public partial class MainForm : Form
    {
        private string _username;
        public MainForm(bool isGuest)
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.Resize += new EventHandler(MainForm_Resize);

            VarButton1.Click += OpenFormButton_Click;

            if (isGuest) { button1.Enabled = false; VarButton1.Enabled = false; }
        }
        public void MainForm_Resize(object sender, EventArgs e)
        {
            float label1PosFactor = 0.1f;
            float themeComboBoxNamePosFactor = 0.2f;
            float openDocsButtonPosFactor = 0.35f;
            float varGroupVar = 0.5f;
            float varButtonPosFactor = 0.65f;
            float buttn = 0.75f;
            float toAvtButtontPosFactor = 0.85f;

            int controlWidth = this.ClientSize.Width / 2;
            int controlHeight = this.ClientSize.Height / 10;
            int buttonWidth = this.ClientSize.Width / 5;
            int groupWidth = this.ClientSize.Width / 4;
            int combobox1Width = this.ClientSize.Width / 3;
            int combobox2Width = this.ClientSize.Width / 7;

            label1.Width = controlWidth;
            label1.Height = controlHeight;
            label1.Location = new Point((this.ClientSize.Width - label1.Width) / 2, (int)(this.ClientSize.Height * label1PosFactor));

            ThemeComboBox.Width = combobox1Width;
            ThemeComboBox.Height = controlHeight;
            ThemeComboBox.Location = new Point((this.ClientSize.Width - ThemeComboBox.Width) / 2, (int)(this.ClientSize.Height * themeComboBoxNamePosFactor));

            OpenDocsButton.Width = buttonWidth;
            OpenDocsButton.Height = controlHeight;
            OpenDocsButton.Location = new Point((this.ClientSize.Width - OpenDocsButton.Width) / 2, (int)(this.ClientSize.Height * openDocsButtonPosFactor));

            VarGroupBox.Width = groupWidth;
            VarGroupBox.Height = controlHeight;
            VarGroupBox.Location = new Point((this.ClientSize.Width - VarGroupBox.Width) / 2, (int)(this.ClientSize.Height * varGroupVar));

            ToAvtButton.Width = buttonWidth;
            ToAvtButton.Height = controlHeight;
            ToAvtButton.Location = new Point((this.ClientSize.Width - ToAvtButton.Width) / 2, (int)(this.ClientSize.Height * toAvtButtontPosFactor));

            button1.Width = buttonWidth;
            button1.Height = controlHeight;
            button1.Location = new Point((this.ClientSize.Width - button1.Width) / 2, (int)(this.ClientSize.Height * buttn));

            VarButton1.Width = buttonWidth;
            VarButton1.Height = controlHeight;
            VarButton1.Location = new Point((this.ClientSize.Width - ToAvtButton.Width) / 2, (int)(this.ClientSize.Height * varButtonPosFactor));
        }

        private void OpenDocsButton_Click(object sender, EventArgs e)
        {
            string selectedThemeOpenFile = null;

            if (ThemeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите тему.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            switch (ThemeComboBox.SelectedItem.ToString())
            {
                case "Основы":
                    selectedThemeOpenFile = @"C:\Users\sonya\OneDrive\Документы\CursLetSonTrigonometry\Theory\1Основы.docx";
                    break;
                case "Основные формулы":
                    selectedThemeOpenFile = @"C:\Users\sonya\OneDrive\Документы\CursLetSonTrigonometry\Theory\2ОсновныеФормулы.docx";
                    break;
                case "Простейшие уравнения":
                    selectedThemeOpenFile = @"C:\Users\sonya\OneDrive\Документы\CursLetSonTrigonometry\Theory\3ПростейшиеУравнения.docx";
                    break;
                case "Типы уравнений":
                    selectedThemeOpenFile = @"C:\Users\sonya\OneDrive\Документы\CursLetSonTrigonometry\Theory\4Уравнения.docx";
                    break;
                case "Неравенства":
                    selectedThemeOpenFile = @"C:\Users\sonya\OneDrive\Документы\CursLetSonTrigonometry\Theory\5Неравенства.docx";
                    break;
                case "Функции":
                    selectedThemeOpenFile = @"C:\Users\sonya\OneDrive\Документы\CursLetSonTrigonometry\Theory\6ТригонометрическиеФункции.docx";
                    break;
                default:
                    MessageBox.Show("Некорректный выбор темы.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            if (System.IO.File.Exists(selectedThemeOpenFile))
            {
                Process.Start(new ProcessStartInfo(selectedThemeOpenFile) { UseShellExecute = true });
            }
            else
            {
                MessageBox.Show("Файл не найден: " + selectedThemeOpenFile, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToAvtButton_Click(object sender, EventArgs e)
        {
            Avt avt = new Avt();
            avt.ShowDialog();
            this.Hide();
        }

        private void OpenFormButton_Click(object sender, EventArgs e)
        {
            ExcersiceForm exform = new ExcersiceForm(_username);
            exform.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExtiForm extform = new ExtiForm(_username);
            extform.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VariantiForm vf1 = new VariantiForm(1);
            vf1.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            VariantiForm vf1 = new VariantiForm(2);
            vf1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VariantiForm vf1 = new VariantiForm(3);
            vf1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.ShowDialog();
        }
    }
}
