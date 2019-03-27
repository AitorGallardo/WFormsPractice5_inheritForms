using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormulariFactorial : WindowsFormsApp2.FormulariBase
    {
        public FormulariFactorial()
        {
            this.operationLabel.Text = "Factorial";
            InitializeComponent();
        }

        protected override bool calculate()
        {

            string value2 = this.txtBxValue2.Text;

            if (checkIfItsInteger(value2))
            {
                int result = 1;
                int number = Convert.ToInt32(value2);

                for (int i = 1; i <= number; i++)
                {
                    result = result * i;
                }
                this.txtBxResult.Text = result.ToString();
                return true;
            }
            else
            {
                MessageBox.Show("Has de introduir un número enter per poder realitzar el seu factorial");
                return false;
            }
        }

        void factorial(int number)
        {

        }
    }
}
