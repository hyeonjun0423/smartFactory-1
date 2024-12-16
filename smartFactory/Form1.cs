using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace smartFactory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "안녕\r\n반가워";

            double sample = 1;

            textBox1.Text = sample.ToString();




            byte My_age = 24;
            short earth_underground_depth = -12000;
            int blueWhale_day_meal = 600000000;
            float my_height = 176.5f;
            double converting_1micro_to_km = 0.000000001;
           decimal solar_energy_emitted_per_day = 1000000000000000000000000000m;
            
            textBox1.Text = My_age.GetType().ToString() + " My_age " + My_age + "\r\n";
            textBox1.Text += $"{My_age.GetType()}"+" "+ "my_age"+$"{My_age}"+"\r\n";
            textBox1.Text += earth_underground_depth.GetType().ToString() + "  earth_underground_depth " + earth_underground_depth + "\r\n";
            textBox1.Text += blueWhale_day_meal.GetType().ToString() + "  blueWhale_day_meal " + blueWhale_day_meal + "\r\n";
            textBox1.Text += my_height.GetType().ToString() + "  my_height " + my_height + "\r\n";
            textBox1.Text += converting_1micro_to_km.GetType().ToString() + "  converting_1micro_to_km " + converting_1micro_to_km + "\r\n";
            textBox1.Text += solar_energy_emitted_per_day.GetType().ToString() + " solar_energy_emitted_per_day " + solar_energy_emitted_per_day + "\r\n";


        }
    }
}
