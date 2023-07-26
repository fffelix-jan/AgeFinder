using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace AgeFinder
{
    public partial class ResultForm : Form
    {
        int ProgressCounter = 0;
        int Age;

        public ResultForm(int userAge)
        {
            InitializeComponent();
            FakeLoadTimer.Start();
            Age = userAge;
            SetRandomTextLabel();
        }

        private void SetRandomTextLabel()
        {
            Random rand = new Random();
            RandomTextLabel.Text = "";
            for (int i = 0; i < 25; ++i)
            {
                RandomTextLabel.Text += (char)rand.Next(33, 127);
            }
        }

        private void FakeLoadTimer_Tick(object sender, EventArgs e)
        {
            if (ProgressCounter >= 100)
            {
                StatusLabel.Text = "DONE! Your age is: " + Age;
                SystemSounds.Exclamation.Play();
                FakeLoadTimer.Stop();
                RandomTextLabel.Text = "";
                return;
            }
            SetRandomTextLabel();
            ProgressCounter += 10;
            ScamProgressBar.Value = ProgressCounter;
        }
    }
}
