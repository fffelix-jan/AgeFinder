using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeFinder
{
    public partial class MainForm : Form
    {
        private bool IDCardMode;
        public MainForm()
        {
            IDCardMode = false;
            InitializeComponent();
            IDCardTextBox.Hide();
        }

        public static bool IsValidChineseID(string id)
        {
            // Check if the ID length is 18 characters
            if (id.Length != 18)
                return false;

            // Check if all characters are digits or the last character is 'X'
            foreach (char c in id)
            {
                if (!char.IsDigit(c) && c != 'X')
                    return false;
            }

            // Extract birthdate and check its validity
            string birthdateStr = id.Substring(6, 8);
            if (!DateTime.TryParseExact(birthdateStr, "yyyyMMdd", null, System.Globalization.DateTimeStyles.None, out _))
                return false;

            // Perform calculations to validate the last digit
            int[] factors = { 7, 9, 10, 5, 8, 4, 2, 1, 6, 3, 7, 9, 10, 5, 8, 4, 2, 1 };
            int sum = 0;

            for (int i = 0; i < 17; i++)
            {
                sum += (id[i] - '0') * factors[i];
            }

            int remainder = sum % 11;
            char[] checkDigits = { '1', '0', 'X', '9', '8', '7', '6', '5', '4', '3', '2' };
            char expectedCheckDigit = checkDigits[remainder];

            return id[17] == expectedCheckDigit;
        }

        public static int CalculateAgeFromID(string id)
        {
            // Extract birthdate from the ID
            string birthdateStr = id.Substring(6, 8);
            if (!DateTime.TryParseExact(birthdateStr, "yyyyMMdd", null, System.Globalization.DateTimeStyles.None, out DateTime birthdate))
            {
                throw new ArgumentException("Invalid birthdate format in ID.");
            }

            // Calculate age based on birthdate and current date
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - birthdate.Year;

            if (birthdate > currentDate.AddYears(-age))
            {
                age--; // Adjust age if birthday hasn't occurred yet this year
            }

            return age;
        }

        private void GuessButton_Click(object sender, EventArgs e)
        {
            if (IDCardMode)
            {
                if (!IsValidChineseID(IDCardTextBox.Text))
                {
                    MessageBox.Show("您输入的居民身份证号有误。请重新输入。\r\n外国人及港澳台居民无法使用此功能。请点击\"Use Age\"", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ResultForm res = new ResultForm(CalculateAgeFromID(IDCardTextBox.Text));
                res.Show();
            }
            else
            {
                ResultForm res = new ResultForm(Convert.ToInt32(AgeSelector.Value));
                res.Show();
            }
        }

        private void ToggleModeButton_Click(object sender, EventArgs e)
        {
            if (IDCardMode)
            {
                IDCardTextBox.Hide();
                AgeSelector.Show();
                ToggleModeButton.Text = "使用居民身份证";
                IDCardMode = false;
            }
            else
            {
                IDCardTextBox.Show();
                AgeSelector.Hide();
                ToggleModeButton.Text = "Use Age";
                IDCardMode = true;
            }
        }

        private void IDCardTextBox_Enter(object sender, EventArgs e)
        {
            if (IDCardTextBox.Text == "请在此处输入居民身份证号...")
            {
                IDCardTextBox.Text = "";
            }
        }

        private void IDCardTextBox_Leave(object sender, EventArgs e)
        {
            if (IDCardTextBox.Text.Length == 0)
            {
                IDCardTextBox.Text = "请在此处输入居民身份证号...";
            }
        }
    }
}
