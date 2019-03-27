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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void formularisToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "suma":
                    FormulariSuma formSuma = new FormulariSuma();
                    formSuma.Text = "Formulari Suma";
                    formSuma.ShowDialog();
                    break;
                case "resta":
                    FormulariResta formResta = new FormulariResta();
                    formResta.Text = "Formulari Resta";
                    formResta.ShowDialog();
                    break;
                case "divisio":
                    FormulariDivisio formDivisio = new FormulariDivisio();
                    formDivisio.Text = "Formulari Divisio";
                    formDivisio.ShowDialog();
                    break;
                case "factorial":
                    FormulariFactorial formFactorial = new FormulariFactorial();
                    formFactorial.Text = "Formulari Factorial";
                    formFactorial.ShowDialog();
                    break;
            }
        }
    }
}
