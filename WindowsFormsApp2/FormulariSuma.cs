using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormulariSuma : WindowsFormsApp2.FormulariBase
    {
        public FormulariSuma()
        {
            this.operationLabel.Text = "Suma";
            InitializeComponent();
        }

        protected override void calculate()
        {
            
        }
    }
}
