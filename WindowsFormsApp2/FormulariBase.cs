using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormulariBase : Form
    {
        int operationCounter = 0;
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public FormulariBase()
        {
            InitializeComponent();
            this.timeLabel.Text = DateTime.Now.ToString("HH:mm:ss tt");
            timer.Interval = 1000; // specify interval time as you want
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            this.timeLabel.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (calculate())
                this.operationCounter++;
        }

        protected virtual bool calculate() => true;

        private void FormulariBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("La operació "+this.operationLabel.Text+" s'ha executat "+this.operationCounter+" vegades.");
        }

        // operations utilities
        public bool checkIfItsInteger(String number)
        {
            int integ;
            return int.TryParse(number, out integ);

        }

        public bool checkIfItsDouble(String number)
        {
            double dble;
            return double.TryParse(number, out dble);

        }

        public String parseDot(String number)
        {
            if (number.Contains("."))
            {
                return replaceDotWithComma(number);
            }
            else
            {
                return number;
            }
        }
        public String replaceDotWithComma(String number) // points are not parsed into double, thats why we need commas in order to properly convert strings to doubles
        {
            int index = number.IndexOf(".");
            char[] chars = number.ToCharArray();
            chars[index] = ',';
            return new string(chars);
        }
    }
}
