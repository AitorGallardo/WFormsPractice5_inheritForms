namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formularisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suma = new System.Windows.Forms.ToolStripMenuItem();
            this.resta = new System.Windows.Forms.ToolStripMenuItem();
            this.divisio = new System.Windows.Forms.ToolStripMenuItem();
            this.factorial = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formularisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formularisToolStripMenuItem
            // 
            this.formularisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suma,
            this.resta,
            this.divisio,
            this.factorial});
            this.formularisToolStripMenuItem.Name = "formularisToolStripMenuItem";
            this.formularisToolStripMenuItem.Size = new System.Drawing.Size(107, 29);
            this.formularisToolStripMenuItem.Text = "Formularis";
            this.formularisToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.formularisToolStripMenuItem_DropDownItemClicked);
            // 
            // suma
            // 
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(252, 30);
            this.suma.Text = "Suma";
            // 
            // resta
            // 
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(252, 30);
            this.resta.Text = "Resta";
            // 
            // divisio
            // 
            this.divisio.Name = "divisio";
            this.divisio.Size = new System.Drawing.Size(252, 30);
            this.divisio.Text = "Divisió";
            // 
            // factorial
            // 
            this.factorial.Name = "factorial";
            this.factorial.Size = new System.Drawing.Size(252, 30);
            this.factorial.Text = "Factorial";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formularisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suma;
        private System.Windows.Forms.ToolStripMenuItem resta;
        private System.Windows.Forms.ToolStripMenuItem divisio;
        private System.Windows.Forms.ToolStripMenuItem factorial;
    }
}

