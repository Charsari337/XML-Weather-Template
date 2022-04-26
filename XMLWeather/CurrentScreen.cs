using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            cityLabel.Text = "City: ";
            cityLabel.Text += Form1.days[0].location;

            tempLabel.Text = "Current Temperature:\n";
            tempLabel.Text += Form1.days[0].currentTemp;
            tempLabel.Text += "°";

            minLabel.Text = "Low of:\n";
            minLabel.Text += Form1.days[0].tempLow;
            minLabel.Text += "°";

            maxLabel.Text = "High of:\n";
            maxLabel.Text += Form1.days[0].tempHigh;
            maxLabel.Text += "°";

            conditionLabel.Text = Form1.days[0].condition;

            dateLabel.Text = "Date:\n";
            dateLabel.Text += Form1.days[0].date;

            pictureBox1.Image = Properties.Resources.clear;
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }
    }
}
