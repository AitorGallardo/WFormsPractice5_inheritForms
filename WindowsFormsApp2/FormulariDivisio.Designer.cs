namespace WindowsFormsApp2
{
    partial class FormulariDivisio
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtBxResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxValue2 = new System.Windows.Forms.TextBox();
            this.txtBxValue1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Resultat";
            // 
            // txtBxResult
            // 
            this.txtBxResult.Location = new System.Drawing.Point(351, 274);
            this.txtBxResult.Name = "txtBxResult";
            this.txtBxResult.Size = new System.Drawing.Size(100, 26);
            this.txtBxResult.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Valor 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Valor 1";
            // 
            // txtBxValue2
            // 
            this.txtBxValue2.Location = new System.Drawing.Point(351, 185);
            this.txtBxValue2.Name = "txtBxValue2";
            this.txtBxValue2.Size = new System.Drawing.Size(100, 26);
            this.txtBxValue2.TabIndex = 19;
            // 
            // txtBxValue1
            // 
            this.txtBxValue1.Location = new System.Drawing.Point(351, 99);
            this.txtBxValue1.Name = "txtBxValue1";
            this.txtBxValue1.Size = new System.Drawing.Size(100, 26);
            this.txtBxValue1.TabIndex = 18;
            // 
            // FormulariDivisio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBxResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBxValue2);
            this.Controls.Add(this.txtBxValue1);
            this.Name = "FormulariDivisio";
            this.Controls.SetChildIndex(this.operationLabel, 0);
            this.Controls.SetChildIndex(this.timeLabel, 0);
            this.Controls.SetChildIndex(this.txtBxValue1, 0);
            this.Controls.SetChildIndex(this.txtBxValue2, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtBxResult, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBxResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxValue2;
        private System.Windows.Forms.TextBox txtBxValue1;
    }
}
