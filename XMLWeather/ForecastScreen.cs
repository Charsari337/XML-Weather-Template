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
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            date1Label.Text = Form1.days[1].date;
            date1outLabel.Text = "Low\n";
            date1outLabel.Text += Form1.days[1].tempLow;
            date1outLabel.Text += "\n\nHigh\n";
            date1outLabel.Text += Form1.days[1].tempHigh;

            date2Label.Text = Form1.days[2].date;
            date2outLabel.Text = "Low\n";
            date2outLabel.Text += Form1.days[2].tempLow;
            date2outLabel.Text += "\n\nHigh\n";
            date2outLabel.Text += Form1.days[2].tempHigh;

            date3Label.Text = Form1.days[3].date;
            date3outLabel.Text = "Low\n";
            date3outLabel.Text += Form1.days[3].tempLow;
            date3outLabel.Text += "\n\nHigh\n";
            date3outLabel.Text += Form1.days[3].tempHigh;

            date4Label.Text = Form1.days[4].date;
            date4outLabel.Text = "Low\n";
            date4outLabel.Text += Form1.days[4].tempLow;
            date4outLabel.Text += "\n\nHigh\n";
            date4outLabel.Text += Form1.days[4].tempHigh;

            date5Label.Text = Form1.days[5].date;
            date5outLabel.Text = "Low\n";
            date5outLabel.Text += Form1.days[5].tempLow;
            date5outLabel.Text += "\n\nHigh\n";
            date5outLabel.Text += Form1.days[5].tempHigh;

            date6Label.Text = Form1.days[6].date;
            date6outLabel.Text = "Low\n";
            date6outLabel.Text += Form1.days[6].tempLow;
            date6outLabel.Text += "\n\nHigh\n";
            date6outLabel.Text += Form1.days[6].tempHigh;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }
    }
}
