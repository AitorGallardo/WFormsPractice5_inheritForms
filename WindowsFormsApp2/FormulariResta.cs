using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormulariResta : WindowsFormsApp2.FormulariBase
    {
        public FormulariResta()
        {
            this.operationLabel.Text = "Resta";
            InitializeComponent();
        }

        protected override bool calculate()
        {
            string value1 = this.txtBxValue1.Text;
            string value2 = this.txtBxValue2.Text;

            if (checkIfItsDouble(value1) && checkIfItsDouble(value2))
            {
                this.txtBxResult.Text = (Convert.ToDouble(parseDot(value1)) - Convert.ToDouble(parseDot(value2))).ToString();
                return true;
            }
            else
            {
                MessageBox.Show("Has de omplir les caselles amb números per poder realitzar la operació");
                return false;
            }
        }
    }
}
