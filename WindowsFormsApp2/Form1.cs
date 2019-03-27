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
                    {
                        FormulariSuma fSuma = new FormulariSuma();
                        fSuma.ShowDialog();
                    }
                    break;
                case "resta":
                    break;
                case "multiplicacio":
                    break;
                case "divisio":
                    break;
            }
        }
    }
}
