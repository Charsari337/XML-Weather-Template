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

            tempLabel.Text += Form1.days[0].currentTemp;
            tempLabel.Text += "°\n\n";

            minLabel.Text += Form1.days[0].tempLow;
            minLabel.Text += "°\n\n";

            maxLabel.Text += Form1.days[0].tempHigh;
            maxLabel.Text += "°\n\n";

            conditionLabel.Text = Form1.days[0].condition;

            dateLabel.Text = "Date:\n";
            dateLabel.Text += Form1.days[0].date;

        //    SymbolID();

        }
        //for(int = 0, i )
        //int symbol = Convert.ToInt32(Form1.days[i].symbol);

        public void SymbolID(int symbol, int number)
        {
            if (symbol <= 232)
            {
                pictureBox1.Image = Properties.Resources.thunder_weather;
            }
            else if (symbol >= 300 || symbol <= 321)
            {
                pictureBox1.Image = Properties.Resources.dizzle_weather;
            }
            else if (symbol >= 500 || symbol <= 531)
            {
                pictureBox1.Image = Properties.Resources.rain_weather;
            }
            else if (symbol >= 600 || symbol <= 622)
            {
                pictureBox1.Image = Properties.Resources.snow_weather;
            }
            else if (symbol >= 701 || symbol <= 781)
            {
                pictureBox1.Image = Properties.Resources.fog_weather;
            }
            else if (symbol >= 801 || symbol <= 804)
            {
                pictureBox1.Image = Properties.Resources.cloudy_weather;
            }
            else if (symbol == 800)
            {
                pictureBox1.Image = Properties.Resources.clear_weather;
            }
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
