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


        public FormulariBase()
        {
            InitializeComponent();
            
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            calculate();
            this.operationCounter++;
        }

        protected virtual void calculate()
        {
            /*
             * if(){
             *  
             * }*/

        }

        private void FormulariBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("La operació "+this.operationLabel.Text+" s'ha executat "+this.operationCounter+" vegades.");
        }
    }
}
