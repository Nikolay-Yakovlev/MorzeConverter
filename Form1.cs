using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorzeConverter
{
    public partial class Form1 : Form
    {
        private AzbukaRu azbukaRu = new AzbukaRu();
        private string wrongError = "Видимо, что-то введено не правильно.";
        public Form1()
        {
            InitializeComponent();
            checkBoxRu.Text = "Очищать текст при конвертации в морзянку";
            checkBoxMrz.Text = "Очищать код при конвертации в русский";
            clearRuBtn.Text = "Очистить";
            clearMrzBtn.Text = "Очистить";
        }

        private void ToMrz_Click(object sender, EventArgs e)
        {
            try
            {
                string ruStr = ruBox.Text.Replace("\r\n", " ");
                if (!string.IsNullOrWhiteSpace(ruStr))
                {
                    foreach (var r in ruStr)
                    {
                        mrzBox.Text += azbukaRu.letters.FirstOrDefault(l => l.Value.Equals(r.ToString().ToUpper())).Code + " ";
                    }
                }
                ClearOrNot("ru");
            }
            catch(Exception ex)
            {
                var result = MessageBox.Show(wrongError, "Ошибка!");
            }
        }

        private void ToRu_Click(object sender, EventArgs e)
        {
            try
            {
                string[] mrzCodes = mrzBox.Text
                    .Replace("\r\n", " ")
                    .Replace("  ", " SPASE")
                    .Split(' '); //костыль =)
                if (mrzCodes.Length > 0)
                {
                    foreach (var m in mrzCodes)
                    {
                        if (!m.Equals(""))
                        {
                            ruBox.Text += azbukaRu.letters.FirstOrDefault(l => l.Code.Equals(m)).Value;
                        }
                    }
                }
                ClearOrNot("mrz");
            }
            catch(Exception ex)
            {
                var result = MessageBox.Show(wrongError, "Ошибка!");
            }
        }

        private void RuCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ruBox.Text))
            {
                Clipboard.SetText(ruBox.Text);
            }
        }

        private void MrzCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(mrzBox.Text))
            {
                Clipboard.SetText(mrzBox.Text);
            }
        }

        private void ClearOrNot(string lang)
        {
            if (checkBoxRu.Checked && lang.Equals("ru"))
            {
                ruBox.Text = string.Empty;
            }
            if (checkBoxMrz.Checked && lang.Equals("mrz"))
            {
                mrzBox.Text = string.Empty;
            }
        }

        private void clearRuBtn_Click(object sender, EventArgs e)
        {
            ruBox.Text = string.Empty;
        }

        private void clearMrzBtn_Click(object sender, EventArgs e)
        {
            mrzBox.Text = string.Empty;
        }
    }
}
